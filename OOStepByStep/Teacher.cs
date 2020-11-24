using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string profession = "teacher";
        private int? classNumber;
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, int classNumber) : base(name, age)
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
