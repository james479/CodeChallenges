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
           long index = FibonacciDigits(10);
           Console.WriteLine($"The first term where the index is 10 digits is {index}.");
        }

        static long FibonacciDigits(int max)
        {
            long firstNumber = 0;  //index 0
            long secondNumber = 1;  //index 1

            long thirdNumber = firstNumber + secondNumber;

            int index = 1;    //represents what index we are at in the sequence

            bool tenDigits = false;

            while (!tenDigits)
            {
                index++;
                Console.WriteLine($"{index}: {thirdNumber}");  //testing to see if F12 = 144
                
                if (isTenDigits(thirdNumber, max))
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

        static bool isTenDigits(long number, int max)
        {
            string stringNumber = number.ToString();
            if (stringNumber.Length >= max)
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
