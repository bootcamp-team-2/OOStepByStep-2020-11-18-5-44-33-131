using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        private const string Profession = "student";

        public Student(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduce()
        {
            var result = base.SelfIntroduce();
            return result + $" I am a {Student.Profession}.";
        }
    }
}
