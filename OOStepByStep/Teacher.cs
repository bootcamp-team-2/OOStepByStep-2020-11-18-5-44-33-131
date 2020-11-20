using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string name;
        private int age;
        private string className;
        public Teacher(string name, int age) : base(name, age)
        {
            this.className = className;
        }

        public Teacher(string name, int age, string className) : base(name, age)
        {
            this.className = className;
        }

        public new string Introduce()
        {
            return base.Introduce() + " I am a teacher.";
        }

        public string Introduce(string className)
        {
            return base.Introduce() + " I am a teacher. I am a student of class ." + className;
        }
    }
}
