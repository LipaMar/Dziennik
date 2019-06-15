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

        public MenuForm(string index)
        {
            user = new User(index);
            InitializeComponent();
            infoLabel.Text = String.Format("{0} {1} ({2})", user.GetName(), user.GetLastName(), user.GetIndex());
            gradesPanel.Visible = false;
            timetablePanel.Visible = false;
            float sum = 0;
            int nrOfSub = 0;
            List<Grade> grades = user.GetGrades();
            List<Class> classes = user.GetClasses();
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
                    nrOfSub++;
                }
                gradesListView.Items.Add(item);
                averageLabel.Text = String.Format("Średnia arytmetczna {0,-10:f2}",sum/nrOfSub);
            }

            foreach (Class y in classes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = y.GetDate();
                item.SubItems.Add(y.GetForm());
                item.SubItems.Add(y.GetName());
                item.SubItems.Add(y.GetTeacher());
                item.SubItems.Add(y.GetStart().ToString());
                item.SubItems.Add(y.GetEnd().ToString());
                timetableListView.Items.Add(item);
            }
        }

        private void timetablePictureButton_Click(object sender, EventArgs e)
        {
            if (timetablePanel.Visible == false)
            {
                timetablePanel.Visible = true;
                timetablePanel.BringToFront();
            }
            else
            {
                timetablePanel.Visible = false;
            }
        }

        private void gradesPictureButton_Click(object sender, EventArgs e)
        {
            if(gradesPanel.Visible == false)
            {
                gradesPanel.Visible = true;
                gradesPanel.BringToFront();
            }
            else
            {
                gradesPanel.Visible = false;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
