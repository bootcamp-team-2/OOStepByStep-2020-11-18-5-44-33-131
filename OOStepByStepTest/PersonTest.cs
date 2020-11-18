namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Should_Return_Message_Given_Person()
        {
            var person = new Person("Tom", 21);
            var expect = "My name is Tom. I am 21 years old.";
            var actual = person.SelfIntroduce();

            Assert.Equal(expect, actual);
        }
    }
}
