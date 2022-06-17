using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.TestProject
{
    [TestFixture]
    public class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Fundamentals.Math();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //var math = new Fundamentals.Math(); // ya no se necesita porque se lo crea en Setup
            var result = _math.Add(1, 9);
            //Assert.Equals(10, result);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            //var math = new Fundamentals.Math();
            var result = _math.Max(3, 1);
            Assert.That(result, Is.EqualTo(3));
        }
        public void Max_SecondArgumentIsGreater_ReturnFirstArgument()
        {
            //var math = new Fundamentals.Math();
            var result = _math.Max(3, 1);
            Assert.That(result, Is.EqualTo(1));
        }
        public void Max_ArgumentsAreEqual_ReturSameArgument()
        {
            var math = new Fundamentals.Math();
            var result = math.Max(2, 2);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
