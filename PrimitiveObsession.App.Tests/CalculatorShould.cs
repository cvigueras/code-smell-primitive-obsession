namespace PrimitiveObsession.App.Tests
{
    public class CalculatorShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SumTwoNumbersSuccessfully()
        {
            var givenNumber1 = 10;
            var givenNumber2 = 20;

            var calculator = new Calculator(givenNumber1, givenNumber2);

            var result = calculator.Sum();

            Assert.IsTrue(result == givenNumber1 + givenNumber2);
        }

        [Test]
        public void SubstractTwoNumbersSuccessfully()
        {
            var givenNumber1 = 10;
            var givenNumber2 = 20;

            var calculator = new Calculator(givenNumber1, givenNumber2);

            var result = calculator.Subtract();

            Assert.IsTrue(result == givenNumber1 - givenNumber2);
        }
    }
}