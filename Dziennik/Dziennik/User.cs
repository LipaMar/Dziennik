using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class User
    {
        private string Index;
        private string Name;
        private string LastName;
        private string Specialization;
        private string Semester;
        private List<Grade> Grades;
        private List<Class> Classes;

        public User(string index)
        {
            Index = index;
            Database db = new Database();
            Grades = db.Grades(index);
            Classes = db.Classes(index);
            Name = db.Name(index);
            LastName = db.LastName(index);
            Specialization = db.Spec(index);
            Semester = db.Semester(index);
            db.Close();
        }
        public List<Grade> GetGrades(){return Grades;}
        public List<Class> GetClasses() { return Classes; }
        public string GetIndex(){return Index;}
        public string GetName(){return Name;}
        public string GetLastName(){return LastName;}
        public string GetSpecialization(){return Specialization;}
        public string GetSemester(){return Semester;}
    }
}
