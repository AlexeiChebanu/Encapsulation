using System;

namespace Encapsulation
{

    public class PrivateAcademy
    {
        Student student;

        Teachers teachersName;

        private string[] schedule = new string[5] { "8:00-8:45", "9:00-9:45", "10:00-10:45",
            "11:00-11:45", "12:00-12:45" };
        private int pointer;

        public PrivateAcademy( int i, Teachers teachersName,Student student)
        {
            this.student = student;
            pointer = i;
            this.teachersName = teachersName;
        }

        public void Print()
        {
                Console.WriteLine($"Name: {student.NameOfStudent}\t" +
                    $"Lesson: {schedule[pointer]}\n" +
                    $"Teacher: {teachersName.NameOfTeacher} - '{teachersName.NameOfSubject}'");
        }
    }
}