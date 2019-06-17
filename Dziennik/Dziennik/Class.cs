using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    /// <summary>
    /// Represents lessons at school. Contains informations about the subject and the value of the 
    /// </summary>
    class Class
    {
        private string date;
        private string name;
        private string startTime;
        private string endTime;
        private string teacher;
        private string form;
        /// <summary>
        /// Initializes the class object
        /// </summary>
        /// <param name="date">Date of class in format DD.MM.YYYY</param>
        /// <param name="name">Name of the subject</param>
        /// <param name="startTime">Class start time in format HH:MM</param>
        /// <param name="endTime">Class end time in format HH:MM</param>
        /// <param name="teacher">Name and surname of the lecturer </param>
        /// <param name="form">Form of the class</param>
        public Class(string date, string name, string startTime, string endTime, string teacher, string form)
        {
            this.date = date;
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.teacher = teacher;
            this.form = form;
        }

        public string GetDate() { return date; }
        public string GetName() { return name; }
        public string GetStart() { return startTime; }
        public string GetEnd() { return endTime; }
        public string GetTeacher() { return teacher; }
        public string GetForm() { return form; }
    }
}
