using System;

namespace Task17NotDivisableNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not Divisable Number
            //Description
            //Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

            //Input
            //Will always consists of one valid integer number - the number N.
            //Output
            //Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7, separated by a whitespace.
            //Constraints
            //1 < N < 1500
            //Sample tests
            //| Input | Output | | ----------------| ----------------| | 10 | 1 2 4 5 8 10 | | 3 | 1 2 |

            int input = 1;

            do
            {
                input = int.Parse(Console.ReadLine());
            } while (input < 1 || input > 1500);

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }
}
