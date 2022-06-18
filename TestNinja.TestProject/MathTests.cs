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
        [Ignore ("BEcause I wanted do!")]
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


        //***** PARAMETERS TESTS ****************//
        [Test]
        [TestCase(2,1,2)]// 2 y 1 max=2
        [TestCase(1,3,3)]// 1 y 3 max=3 
        [TestCase(1,1,1)]// 1 y 1 max=1 
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a,int b, int expectectedResult)
        {
            //var math = new Fundamentals.Math(); // ya no se necesita porque se lo crea en Setup
            var result = _math.Max(a,b);
            //Assert.Equals(10, result);
            Assert.That(result, Is.EqualTo(expectectedResult));
        }

        // **** atesting arrays and collections -- method GetOddNumbers in Math.cs

    }
}
