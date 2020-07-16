using NUnit.Framework;
using StringCalculator;

namespace String_Calculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public  void AcceptAStringAsInputAndReturnANumber()
        {
            int number = StringCalculatorService.Add("");
            Assert.Pass();
        }

        [Test]
        public void Stringnulla()
        {
            int number = StringCalculatorService.Add("");
            Assert.That(number, Is.EqualTo(0));
        }

        [Test]
        public void ReturnNumber()
        {
            int number = StringCalculatorService.Add("1");
            Assert.That(number, Is.EqualTo(1));
        }

        [Test]
        public void SumNumber()
        {
            int number = StringCalculatorService.Add("1,2");
            Assert.That(number, Is.EqualTo(3));
        }

        [Test]
        public void SumListNumber()
        {
            int number = StringCalculatorService.Add("1,2,10,10");
            Assert.That(number, Is.EqualTo(23));

        }

        public void acceptNl ()
        {
            int number = StringCalculatorService.Add("1\n2,3");
            Assert.That(number, Is.EqualTo(6));

        }
    }
}