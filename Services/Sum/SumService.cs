using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge2to4.Services.Sum
{
    public class SumService : ISumService
    {


        public string Numbers(string NumberOne, string NumberTwo)
        {
            int numOne = 0;
            int numTwo = 0;
            bool num = int.TryParse(NumberOne, out numOne) && int.TryParse(NumberTwo, out numTwo);

            if (num == true)
            {
                int total = numOne + numTwo;
                return $"The sum of {numOne} and {numTwo} is {total}";
            }
            else
            {
                return "invalid input";
            }

        }
    }
}