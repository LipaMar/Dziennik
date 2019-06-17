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
    /// <summary>
    /// Represents Menu form. Displays user's personal info and two options to choose from: timetable (classes) and grades.
    /// </summary>
    public partial class MenuForm : Form
    { 
        User user;
        List<Grade> grades;
        List<Class> classes;
        DateTime calendar;
        /// <summary>
        /// Initializes the Menu Form object based on the given student's index.
        /// </summary>
        /// <param name="index">Individual student's number(index)</param>
        public MenuForm(string index)
        {
            user = new User(index);
            InitializeComponent();
            grades = user.GetGrades();
            classes = user.GetClasses();
            calendar = DateTime.Today;

            infoLabel.Text = String.Format("Dane logowania:\nStudent: {0} {1} \nKierunek: {2}\nSemestr: {3} \nNumer albumu: [{4}]", 
                                            user.GetName(), user.GetLastName(), user.GetSpecialization(), user.GetSemester(), user.GetIndex());
            gradesPanel.Visible = false;
            timetablePanel.Visible = false;
            initGradesTable();
        }
        private enum Date
        {
            DAY, WEEK, MONTH
        }

        /// <summary>
        /// Adds a list of student's grades in adequate list view and calculates the arithmetic mean of them.
        /// </summary>
        private void initGradesTable()
        {
            float sum = 0;
            int nrOfSubjects = 0; 
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
                averageLabel.Text = String.Format("Średnia arytmetczna {0,0:f2}", sum / nrOfSubjects);
            }
        }

        /// <summary>
        /// Prevents user from resizing columns widths in Timetable List View.
        /// </summary>
        private void timetableListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = timetableListView.Columns[e.ColumnIndex].Width;
        }

        /// <summary>
        /// Prevents user from resizing columns widths in Grades List View.
        /// </summary>
        private void gradesListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = gradesListView.Columns[e.ColumnIndex].Width;
        }

        /// <summary>
        /// After clicking the "Timetable" button - shows student's timetable, next click will close it.
        /// </summary>
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

        /// <summary>
        /// After clicking the "Grades" button - shows student's grades, next click will close it.
        /// </summary>
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

        /// <summary>
        /// After clicking the "Log Out" button, moves user to the login panel (by restarting the application).
        /// </summary>
        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void dayRadio_CheckedChanged(object sender, EventArgs e)
        {
            calendar = DateTime.Today;
            SetTimeSpan(Date.DAY);
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {
            calendar = DateTime.Today;
            SetTimeSpan(Date.WEEK);
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
            calendar = DateTime.Today;
            SetTimeSpan(Date.MONTH);
        }

        /// <summary>
        /// Sets the time interval displayed in the list view based on the given argument.
        /// </summary>
        /// <param name="span">Period of time (DAY, WEEK, MONTH)</param>
        private void SetTimeSpan(Date span)
        {
            timetableListView.Items.Clear();
            DateTime day = calendar;
            DateTime firstDayOfWeek = calendar.AddDays(-((int)calendar.DayOfWeek));
            DateTime lastDayOfWeek = calendar.AddDays(6 - (int)calendar.DayOfWeek);
            for (int i = 0; i < classes.Count; i++)
            {
                int classDay = Int32.Parse(classes[i].GetDate().Substring(0, 2));
                int classMonth = Int32.Parse(classes[i].GetDate().Substring(3, 2));
                int classYear = Int32.Parse(classes[i].GetDate().Substring(6, 4));
                DateTime classDate = new DateTime(classYear,classMonth,classDay);
                if (span == Date.DAY)
                {
                    if (classDate == day)
                    {
                        AddToTimeTable(classes[i]);
                    }
                }
                else if (span == Date.WEEK)
                {
                    if(firstDayOfWeek<=classDate && classDate <= lastDayOfWeek)
                    {
                        AddToTimeTable(classes[i]);
                    }
                }
                else if (span == Date.MONTH)
                {
                    if (classDate.Month == day.Month && classDate.Year == day.Year)
                    {
                        AddToTimeTable(classes[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Adds a list of student classes (form, name, teacher, start & end) to the Timetable List View.
        /// </summary>
        /// <param name="c">Class "Class" object</param>
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

        /// <summary>
        /// After clicking the "Previous" button changes currently displayed timetable to the previous time period (previous day, week, month).
        /// </summary>
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

        /// <summary>
        /// After clicking the "Next" button changes currently displayed timetable to the later time period (next day, week, month).
        /// </summary>
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
