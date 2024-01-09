using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallenge2to4.Services.GreaterOrLess
{
    public interface IGreaterOrLessService
    {
        public string Expressions(string firstNumber, string secondNumber);
    }
}