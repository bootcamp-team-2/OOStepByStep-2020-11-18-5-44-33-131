using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class StudentTest
    {
        [Fact]
        public void Should_Return_Message_With_Identity_When_Introduce()
        {
            //given
            string expected = "My name is Tom. I am 18 years old. I am a student.";
            Student student = new Student("Tom", 18);

            //when
            string actual = student.Introduce();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
