namespace OOStepByStep
{
    using System;
    public class Person
    {
        private string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual string Introduce()
        {
            return $"My name is {this.name}. I am {this.age} years old.";
        }
    }

    public class Student : Person
    {
        private string profession = "student";
        public Student(string name, int age) : base(name, age)
        {
        }

         public override string Introduce()
        {
            return base.Introduce() + $" I am a {this.profession}.";
        }
    }
}
