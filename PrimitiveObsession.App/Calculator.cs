namespace PrimitiveObsession.App.Tests
{
    public class Calculator
    {
        private int Number1;
        private int Number2;

        public Calculator(int givenNumber1, int givenNumber2)
        {
            Number1 = givenNumber1;
            Number2 = givenNumber2;
        }

        public int Sum()
        {
            return Number1 + Number2;
        }
    }
}