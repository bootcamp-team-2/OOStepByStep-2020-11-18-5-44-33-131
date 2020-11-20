namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void PersonTest()
        {
            var person = new Person("Tom", 21);
            var actual = person.Introduce();
            Assert.Equal("My name is Tom. I am 21 years old.", actual);
        }

        [Fact]
        public void Teacher_Test()
        {
            var teacher = new Teacher("Tom", 18);
            var actual = teacher.Introduce();
            Assert.Equal("My name is Tom. I am 18 years old. I am a teacher.", actual);
        }

        [Fact]
        public void Student_And_His_ClassTest()
        {
            var stduent = new Student("Amy", 30);
            var actual = stduent.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a student.", actual);
        }

        [Fact]
        public void Teacher_And_His_Class_Test()
        {
            var teacher = new Teacher("Tom", 18);
            var actual = teacher.Introduce();
            Assert.Equal("My name is Tom. I am 18 years old. I am a teacher.", actual);
        }

        [Fact]
        public void StudentTest()
        {
            var stduent = new Student("Amy", 30);
            var actual = stduent.Introduce();
            Assert.Equal("My name is Amy. I am 30 years old. I am a student.", actual);
        }

        [Fact]
        public void Test1()
        {
            var class1 = new Class1();
            Assert.NotNull(class1);
        }
    }
}
