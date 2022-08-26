using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Teachers
    {
        private string nameOfTeacher;
        private string nameOfSubject;

        public Teachers(string nameOfTeacher, string nameOfSubject)
        {
            this.nameOfTeacher = nameOfTeacher;
            this.nameOfSubject = nameOfSubject;       
        }

        public string NameOfTeacher
        {
            get { return nameOfTeacher; }
            set { nameOfTeacher = value; }
        }

        public string NameOfSubject
        {
            get { return nameOfSubject; }
            set { nameOfSubject = value; }
        }
    }
}
