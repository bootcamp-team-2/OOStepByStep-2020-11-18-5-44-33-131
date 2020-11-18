using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class TeacherTest
    {
        [Fact]
        public void Should_Return_Message_With_Identity_When_Introduce()
        {
            //given
            string expected = "My name is Amy. I am 30 years old. I am a teacher.";
            Teacher teacher = new Teacher("Amy", 30);

            //when
            string actual = teacher.Introduce();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
