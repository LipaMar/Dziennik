using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Grade
    {
        private string subject;
        private float grade;
        public Grade(string subject, float grade)
        {
            this.subject = subject;
            this.grade = grade;
        }
        public float getGrade() {return grade;}
        public string getSubject() {return subject;}
    }
}
