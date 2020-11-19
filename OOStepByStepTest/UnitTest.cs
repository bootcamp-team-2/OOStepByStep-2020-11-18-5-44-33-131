using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Person_should_introduce_with_name_and_age()
        {
            // given
            string name = "Tom";
            int age = 21;
            var person = new Person(name, age);
            string expect = "My name is Tom. I am 21 years old.";
            // when
            string actual = person.Introduce();
            //then

            Assert.Equal(expect, actual);
        }
    }

    public class StudentTest
    {
        [Fact]
        public void Student_should_introduce_with_name_and_age()
        {
            // given
            string name = "Tom";
            int age = 18;
            var student = new Student(name, age);
            string expect = "My name is Tom. I am 18 years old. I am a student.";
            //A student can introduce him/herself like this: My name is Tom. I am 18 years old. I am a student.
            // when
            string actual = student.Introduce();
            //then

            Assert.Equal(expect, actual);
        }
    }

    public class TeacherTest
    {
        [Fact]
        public void Student_should_introduce_with_name_and_age()
        {
            // given
            string name = "Amy";
            int age = 30;
            var teacher = new Teacher(name, age);
            string expect = "My name is Amy. I am 30 years old. I am a teacher.";
            //A student can introduce him/herself like this: My name is Tom. I am 18 years old. I am a student.
            // when
            string actual = teacher.Introduce();
            //then

            Assert.Equal(expect, actual);
        }
    }
}
