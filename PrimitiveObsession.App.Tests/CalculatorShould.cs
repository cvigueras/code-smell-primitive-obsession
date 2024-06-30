namespace PrimitiveObsession.App.Tests
{
    public class CalculatorShould
    {
        private int givenNumber1;
        private int givenNumber2;
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            givenNumber1 = 10;
            givenNumber2 = 20;
            calculator = new Calculator(givenNumber1, givenNumber2);
        }

        [Test]
        public void SumTwoNumbersSuccessfully()
        {
            var result = calculator.Sum();

            Assert.IsTrue(result == givenNumber1 + givenNumber2);
        }

        [Test]
        public void SubstractTwoNumbersSuccessfully()
        {
            var result = calculator.Subtract();

            Assert.IsTrue(result == givenNumber1 - givenNumber2);
        }

        [Test]
        public void MultiplyTwoNumbersSuccessfully()
        {
            var result = calculator.Multiply();

            Assert.IsTrue(result == givenNumber1 * givenNumber2);
        }

        [Test]
        public void SplitTwoNumbersSuccessfully()
        {
            var result = calculator.Split();

            Assert.IsTrue(result == givenNumber1 / givenNumber2);
        }
    }
}