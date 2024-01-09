namespace MiniChallenge2to4.Services.GreaterOrLess
{
    public class GreaterOrLessService : IGreaterOrLessService
    {


        public string Expressions(string FirstNumber, string SecondNumber)
        {
            int firstNum = 0;
            int secondNum = 0;

            bool realNum = int.TryParse(FirstNumber, out firstNum) && int.TryParse(SecondNumber, out secondNum);

            if (realNum == true)
            {
                if (firstNum > secondNum)
                {
                    return FirstNumber + " is greater than " + SecondNumber + "\n" + SecondNumber + " is less than " + FirstNumber;
                }
                else if (FirstNumber == SecondNumber)
                {
                    return FirstNumber + " is equal to " + SecondNumber + "\n" + SecondNumber + " is equal to " + FirstNumber;
                }
                else
                {
                    return FirstNumber + " is less than " + SecondNumber + "\n" + SecondNumber + " is greater than " + FirstNumber;
                }
            }
            else
            {
                return "Invalid input. Please enter a number.";
            }

        }
    }
}