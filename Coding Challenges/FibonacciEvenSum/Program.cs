using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
           long sum = FibonacciSum(100);
           Console.WriteLine($"The Fibonacci Sum is {sum:n}");
        }



        static long FibonacciSum (int maxNumber)
        {
            long firstNumber = 1;
            long secondNumber = 2;
            long thirdNumber = firstNumber + secondNumber;

            long evenSum = 0;

            while(thirdNumber <= maxNumber)
            {
                if (isEven(thirdNumber))
                {
                    evenSum += thirdNumber;
                }
                //reassign numbers for next sequence
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = secondNumber + firstNumber;

                
            }
            return evenSum;
        }

        static bool isEven(long num)
        {
            if (num % 2 == 0)
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
