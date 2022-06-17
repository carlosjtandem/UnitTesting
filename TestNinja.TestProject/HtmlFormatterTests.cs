
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.TestProject
{
    [TestFixture]
    internal class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            //Specific
            //Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            Assert.That(result, Is.EqualTo("<strong>abc</strong>").IgnoreCase); // para no tomar en cuenta mayusculas


            //More general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));


        }
    }
}

