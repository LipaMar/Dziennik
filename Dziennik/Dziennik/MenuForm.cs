using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dziennik
{
    public partial class MenuForm : Form
    { 
        User user;
        List<Grade> grades;
        List<Class> classes;
        int todayDay;
        int todayMonth;
        DateTime calendar;
        public enum Date
        {
            DAY,WEEK,MONTH
        }
        public MenuForm(string index)
        {
            user = new User(index);
            InitializeComponent();
            todayDay = DateTime.Today.Day;
            todayMonth = DateTime.Today.Month;
            calendar = DateTime.Today;
            calendar = calendar.AddMonths(-1);

            infoLabel.Text = String.Format("{0} {1} ({2})", user.GetName(), user.GetLastName(), user.GetIndex());
            gradesPanel.Visible = false;
            timetablePanel.Visible = false;
            initGradesTable();
        }
        private void initGradesTable()
        {
            float sum = 0;
            int nrOfSubjects = 0;
            grades = user.GetGrades();
            classes = user.GetClasses();
            foreach (Grade x in grades)
            {
                ListViewItem item = new ListViewItem();
                item.Text = x.getSubject();
                if (x.getGrade() == 0)
                    item.SubItems.Add("brak");
                else
                {
                    item.SubItems.Add(x.getGrade().ToString());
                    sum += x.getGrade();
                    nrOfSubjects++;
                }
                gradesListView.Items.Add(item);
                averageLabel.Text = String.Format("Średnia arytmetczna {0,-10:f2}", sum / nrOfSubjects);
            }
        }

        private void timetablePictureButton_Click(object sender, EventArgs e)
        {
            if (timetablePanel.Visible == false)
            {
                timetablePanel.BringToFront();
                timetablePanel.Visible = true;
                gradesPanel.Visible = false;
                gradesPanel.SendToBack();
            }
            else
            {
                timetablePanel.Visible = false;
                timetablePanel.SendToBack();
            }
        }

        private void gradesPictureButton_Click(object sender, EventArgs e)
        {
            if(gradesPanel.Visible == false)
            {
                gradesPanel.BringToFront();
                gradesPanel.Visible = true;
                timetablePanel.Visible = false;
                timetablePanel.SendToBack();
            }
            else
            {
                gradesPanel.Visible = false;
                gradesPanel.SendToBack();
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dayRadio_CheckedChanged(object sender, EventArgs e)
        {
           // calendar = DateTime.Today;
            SetTimeSpan(Date.DAY);
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
           // calendar = DateTime.Today;
            SetTimeSpan(Date.WEEK);
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
           // calendar = DateTime.Today;
            SetTimeSpan(Date.MONTH);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="today">format dd.mm.yyyy</param>
        /// <param name=""></param>
        /// <returns></returns>
        private List<Class> SetTimeSpan(Date span)
        {
            timetableListView.Items.Clear();
            int day = calendar.Day;
            int month = calendar.Month;
            String todayDayStr = AddZero(day);
            String todayMonthStr = AddZero(month) ;
            int firstDayOfWeek = (int)(calendar.Day - calendar.DayOfWeek);
            int lastDayOfWeek = (int)(calendar.Day + 6-calendar.DayOfWeek);
            List<Class> result=new List<Class>();
            for (int i = 0; i < classes.Count; i++)
            {
                int classDay = Int32.Parse(classes[i].GetDate().Substring(0,2));
                int classMonth = Int32.Parse(classes[i].GetDate().Substring(3, 2));
                if(span==Date.DAY)
                {
                    if(classMonth == month && classDay==day)
                    {
                        AddToTimeTable(classes[i]);
                    }
                }
                else if(span==Date.WEEK)
                {
                    if(classMonth==month && classDay>=firstDayOfWeek && classDay<=lastDayOfWeek)
                    {
                        AddToTimeTable(classes[i]);
                    }
                }
                else if(span==Date.MONTH)
                {
                    if (classMonth==month)
                    {
                        AddToTimeTable(classes[i]);
                    }
                }
            }

                return result;
        }
        private String AddZero(int i)
        {
            return i < 10 ? "0" + i.ToString() : i.ToString();
        }
        private String AddZero(string str)
        {
            return Int32.Parse(str) < 10 ? "0" + str.ToString() : str.ToString();
        }
        private void AddToTimeTable(Class c)
        {
            ListViewItem item = new ListViewItem();
            item.Text = c.GetDate();
            item.SubItems.Add(c.GetForm());
            item.SubItems.Add(c.GetName());
            item.SubItems.Add(c.GetTeacher());
            item.SubItems.Add(c.GetStart().ToString());
            item.SubItems.Add(c.GetEnd().ToString());
            timetableListView.Items.Add(item);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (dayRadio.Checked)
            {
                calendar=calendar.AddDays(-1);
                SetTimeSpan(Date.DAY);
            }
            else if (weekRadio.Checked)
            {
                calendar = calendar.AddDays(-7);
                SetTimeSpan(Date.WEEK);
            }
            else if (monthRadio.Checked)
            {
                calendar = calendar.AddMonths(-1);
                SetTimeSpan(Date.MONTH);
            }
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (dayRadio.Checked)
            {
                calendar = calendar.AddDays(1);
                SetTimeSpan(Date.DAY);
            }
            else if (weekRadio.Checked)
            {
                calendar = calendar.AddDays(7);
                SetTimeSpan(Date.WEEK);
            }
            else if (monthRadio.Checked)
            {
                calendar = calendar.AddMonths(1);
                SetTimeSpan(Date.MONTH);
            }
        }
    }
}
