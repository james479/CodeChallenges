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
            FibonacciSum(4000000);
        }

        static void FibonacciSum (int maxNumber)
        {
            int firstNumber = 1;
            int secondNumber = 2;
            int thirdNumber = firstNumber + secondNumber;
            int evenSum = 2;

            while(thirdNumber <= maxNumber)
            {
                if (thirdNumber % 2 == 0)
                {
                    evenSum += thirdNumber;
                }
                //reassign numbers for next sequence
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                thirdNumber = secondNumber + firstNumber;

                
            }
            Console.WriteLine($"The Fibonacci Sum is {evenSum:n}");
        }
    }
}
