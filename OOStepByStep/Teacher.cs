using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private const string Profession = "teacher";

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string SelfIntroduce()
        {
            var result = base.SelfIntroduce();
            return result + $" I am a {Teacher.Profession}.";
        }
    }
}
