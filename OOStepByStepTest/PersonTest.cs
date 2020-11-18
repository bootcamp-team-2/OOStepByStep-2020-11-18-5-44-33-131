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

        [Fact]
        public void Should_Return_Message_Given_Student()
        {
            var student = new Student("Tom", 18);
            var expect = "My name is Tom. I am 18 years old. I am a student.";
            var actual = student.SelfIntroduce();

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Return_Message_Given_Teacher()
        {
            var teacher = new Teacher("Amy", 30);
            var expect = "My name is Amy. I am 30 years old. I am a teacher.";
            var actual = teacher.SelfIntroduce();

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Return_Message_Given_StudentBelongToClass2()
        {
            var student = new StudentBelongToClass2("Tom", 18);
            var expect = "My name is Tom. I am 18 years old. I am a student of class 2.";
            var actual = student.SelfIntroduce();

            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Return_Message_Given_TeacherBelongToClass2()
        {
            var teacher = new TeacherBelongToClass2("Amy", 30);
            var expect = "My name is Amy. I am 30 years old. I am a teacher of class 2.";
            var actual = teacher.SelfIntroduce();

            Assert.Equal(expect, actual);
        }
    }
}
