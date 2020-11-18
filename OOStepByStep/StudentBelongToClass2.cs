using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class StudentBelongToClass2 : Person, IClass
    {
        private const string Profession = "student";

        public StudentBelongToClass2(string name, int age) : base(name, age)
        {
        }

        public string GetClass()
        {
            return " of class 2.";
        }

        public override string SelfIntroduce()
        {
            var result = base.SelfIntroduce();
            result += $" I am a {StudentBelongToClass2.Profession}.";
            return result.Substring(0, result.Length - 1) + GetClass();
        }
    }
}