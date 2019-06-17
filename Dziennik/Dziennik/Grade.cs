using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    /// <summary>
    /// Represents school grade. Contains information about the subject name and the value of the grade.
    /// </summary>
    public class Grade
    {
        private string subject;
        private float grade;
        /// <summary>
        /// Initializes the grade object with subject and value of grade
        /// </summary>
        /// <param name="subject">The subject which it applies to</param>
        /// <param name="grade">The value of the grade</param>
        public Grade(string subject, float grade)
        {
            this.subject = subject;
            this.grade = grade;
        }
        public float getGrade() { return grade; }
        public string getSubject() { return subject; }
        /// <summary>
        /// Calculates the average of grades
        /// </summary>
        public static float avgGrade(List<Grade> grades)
        {
            float sum = 0;
            int nrOfGrades = 0;
            foreach (Grade g in grades)
            {
                sum += g.getGrade();
                if (g.getGrade() != 0)
                    nrOfGrades++;
            }
            return sum / nrOfGrades;
        }
    }
}
