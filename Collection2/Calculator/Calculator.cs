using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator<T>
    {
       
        public T Add(T num1, T num2)
        {

              dynamic number1 = num1;
            dynamic number2 = num2;
            dynamic result = number1 + number2;
            return result;
        }

        public T Subtract(T num1, T num2)
        {
            dynamic number1 = num1;
            dynamic number2 = num2;
            dynamic result = number1 - number2;
            return result;
        }

        public T Multiply(T num1, T num2)
        {
            dynamic number1 = num1;
            dynamic number2 = num2;
            dynamic result = number1 * number2;
            return result;
        }

        public T Divide(T num1, T num2)
        {
            if (Convert.ToDouble(num2) == 0)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            dynamic number1 = num1;
            dynamic number2 = num2;
            dynamic result = number1 / number2;
            return result;
        }
    }
}