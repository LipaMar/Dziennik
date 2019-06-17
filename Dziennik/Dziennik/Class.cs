using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziennik
{
    class Class
    {
        private string date;
        private string name;
        private string startTime;
        private string endTime;
        private string teacher;
        private string form;
        public Class(string d, string n, string st, string et, string t, string f)
        {
            date = d;
            name = n;
            startTime = st;
            endTime = et;
            teacher = t;
            form = f;
        }
        public string GetDate() { return date; }
        public string GetName() { return name; }
        public string GetStart() { return startTime; }
        public string GetEnd() { return endTime; }
        public string GetTeacher() { return teacher; }
        public string GetForm() { return form; }
    }
}
