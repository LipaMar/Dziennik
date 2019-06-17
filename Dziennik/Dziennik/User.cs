using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    /// <summary>
    /// Represents the student's account. Contains information about the index, student's name, specialization, semester, grades and schedule
    /// </summary>
    public class User
    {
        private string Index;
        private string Name;
        private string LastName;
        private string Specialization;
        private string Semester;
        private List<Grade> Grades;
        private List<Class> Classes;
        /// <summary>
        /// Initializes the Menu Form object based on the given student's index.
        /// </summary>
        /// <param name="index">Individual student's number(index)</param>
        public User(string index)
        {
            Index = index;
            Database db = new Database();
            Grades = db.GetGrades(index);
            Classes = db.GetClasses(index);
            Name = db.GetName(index);
            LastName = db.GetLastName(index);
            Specialization = db.GetSpec(index);
            Semester = db.GetSemester(index);
            db.Close();
        }
        public List<Grade> GetGrades(){return Grades;}
        public List<Class> GetClasses() { return Classes; }
        public string GetIndex(){return Index;}
        public string GetName(){return Name;}
        public string GetLastName(){return LastName;}
        public string GetSpecialization(){return Specialization;}
        public string GetSemester(){return Semester;}
        /// <summary>
        /// Encodes the given string using SHA256 algorithm
        /// </summary>
        public static string HashString(string s)
        {
            HashAlgorithm algorithm = SHA256.Create();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in algorithm.ComputeHash(Encoding.UTF8.GetBytes(s)))
                sb.Append(b.ToString("X2"));
            return sb.ToString().ToLower();
        }
    }
}
