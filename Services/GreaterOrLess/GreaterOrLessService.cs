namespace MiniChallenge2to4.Services.GreaterOrLess
{
    public class GreaterOrLessService : IGreaterOrLessService
    {


        public string Expressions(string firstNumber, string secondNumber)
        {
            int firstNum = 0;
            int secondNum = 0;

            bool realNum = int.TryParse(firstNumber, out firstNum) && int.TryParse(secondNumber, out secondNum);

            if (realNum == true)
            {
                if (firstNum > secondNum)
                {
                    return firstNumber + " is greater than " + secondNumber + "\n" + secondNumber + " is less than " + firstNumber;
                }
                else if (firstNumber == secondNumber)
                {
                    return firstNumber + " is equal to " + secondNumber + "\n" + secondNumber + " is equal to " + firstNumber;
                }
                else
                {
                    return firstNumber + " is less than " + secondNumber + "\n" + secondNumber + " is greater than " + firstNumber;
                }
            }
            else
            {
                return "Invalid input. Please enter a number.";
            }

        }
    }
}