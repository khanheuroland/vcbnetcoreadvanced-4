using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcbmain.Services
{
    public enum Operators
    {
        Add, Subtract, Multiply, Divide
    }
    public class NumberService
    {
        public double Calculate(Operators opt, int number1, int number2)
        {
            switch(opt)
            {
                case Operators.Add:
                    return number1 + number2;
                case Operators.Subtract:
                    return number1 - number2;
                case Operators.Multiply:
                    return number1 * number2;
                default:
                    if(number2==0) throw new DivideByZeroException();
                    return (double)number1 / (double)number2;
            }
        }
    }
}