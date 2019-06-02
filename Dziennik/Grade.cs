using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    /// <summary>
    /// Represents school grade. Contains informations about the subject and the value of the 
    /// </summary>
    class Grade
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
        public float getGrade() {return grade;}
        public string getSubject() {return subject;}
    }
}
