using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string name;
        private int age;
        private string classNumber;
        public Student(string name, int age) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public Student(string name, int age, string classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public new string Introduce()
        {
            return base.Introduce() + " I am a student.";
        }

        public new string Introduce(string classNumber)
        {
            return base.Introduce() + " I am a student. I am a student of class" + classNumber;
        }
    }
}
