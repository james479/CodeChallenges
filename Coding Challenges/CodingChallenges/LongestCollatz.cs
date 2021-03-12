using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class LongestCollatz
    {
        static void Main(string[] args)
        {
            List<int> longestChain = GetLongestChain(16);
            foreach (var item in longestChain)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> GetLongestChain(int target)
        {
            int largestNumber = 0;
            int currentNumber = 1;
        
            List<int> largestIndexes = new List<int>();

            for (int i = 1; i < target; i++)
            {
                currentNumber = GetChainNumber(i);
               
                if (largestNumber < currentNumber || largestNumber == currentNumber)
                {
                    if (largestNumber < currentNumber)
                    {
                        largestIndexes.Clear();
                        largestNumber = currentNumber;
                        largestIndexes.Add(i);
                    }
                    else
                    {
                        largestIndexes.Add(i);
                    }
                    
                }

            }

            return largestIndexes;
        }

        static int GetChainNumber(int number)
        {
            Console.Write($"{number} => ");
            int chainNumber = 0;
            bool IsOne = false;
            while (!IsOne)
            {
                chainNumber++;
                number = GetNextNumber(number);
            
                if (number == 1)
                {
                    IsOne = true;
                }
                Console.Write($"{number} => ");
            }
            Console.WriteLine("\n");
            return chainNumber;
        }

        static int GetNextNumber(int number)
        {
            int nextNum;

            if (IsEven(number))
            {
                nextNum = number / 2;
            }
            else
            {
                nextNum = 3 * number + 1;
            }

            return nextNum;
        }

        static bool IsEven(long number)
        {
            if (number % 2 == 0)
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
