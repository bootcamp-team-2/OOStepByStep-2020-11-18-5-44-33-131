using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using OOStepByStep;

namespace OOStepByStepTest
{
    public class PersonTest
    {
        [Fact]
        public void Should_Return_Message_With_Name_And_Age_When_Introduce()
        {
            //given
            string expected = "My name is Tom. I am 21 years old.";
            Person person = new Person("Tom", 21);

            //when
            string actual = person.Introduce();

            //then
            Assert.Equal(expected, actual);
        }
    }
}
