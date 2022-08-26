using System;

namespace Encapsulation
{
    public class Student
    {

        private string nameOfStudent;

        public Student(string student)
        {
                nameOfStudent = student;
        }
        public string NameOfStudent
        {
            get { return nameOfStudent; }
            set { nameOfStudent = value; }            
        }
    }
}
