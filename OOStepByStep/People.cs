using System.Linq;

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

    public class Teacher : Person
    {
        private string name;
        private int age;
        private string profession = "teacher";
        private IClass findclassNumber;
        public Teacher(string name, int age, IClass findclassNumber) : base(name, age)
        {
            this.findclassNumber = findclassNumber;
            this.name = name;
            this.age = age;
        }

        public override string Introduce()
        {
            string partOfIntroduce = string.Empty;
            if (this.findclassNumber.IsBelongToClass2(this.name))
            {
                partOfIntroduce = $" I am a {this.profession} of class 2.";
            }
            else
            {
                partOfIntroduce = $" I am a {this.profession} of other class.";
            }

            return base.Introduce() + partOfIntroduce;
        }
    }

    public class TeacherFindClass : IClass
    {
        public bool IsBelongToClass2(string name)
        {
            string[] teacherNameArray = new string[] { "Amy" };
            return teacherNameArray.Contains(name);
        }
    }

    //class StudentFindClass : IClass
    //{
    //    public string IsBelongToClass2()
    //    {

    //        return "Do nothing!";
    //    }
    //}
}
