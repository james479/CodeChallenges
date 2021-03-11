using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class TenDigitFibonacci
    {
        //index starts at zero
        static void Main(string[] args)
        {
           long index = FibonacciTenDigits();
            Console.WriteLine($"The first term where the index is 10 digits is {index}.");
        }

        static long FibonacciTenDigits()
        {
            long firstNumber = 0;
            long secondNumber = 1;
            long thirdNumber = firstNumber + secondNumber;
            int index = 2;    //represents what index we are at in the sequence
            bool tenDigits = false;
            while (!tenDigits)
            {
                index++;
                if (isTenDigits(thirdNumber))
                {
                    tenDigits = true;
                }
                else
                {
                    firstNumber = secondNumber;
                    secondNumber = thirdNumber;
                    thirdNumber = secondNumber + firstNumber;
                }
            }
            return index;
        }

        static bool isTenDigits(long number)
        {
            string stringNumber = number.ToString();
            if (stringNumber.Length >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
