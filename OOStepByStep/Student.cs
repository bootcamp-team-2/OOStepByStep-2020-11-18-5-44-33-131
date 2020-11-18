using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string profession = "student";
        private int? classNumber;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classNumber) : base(name, age)
        {
            this.classNumber = classNumber;
        }

        public override string Introduce()
        {
            string identity = profession + (classNumber.HasValue ? $" of class {classNumber}" : string.Empty);
            return base.Introduce() + $" I am a {identity}.";
        }
    }
}
