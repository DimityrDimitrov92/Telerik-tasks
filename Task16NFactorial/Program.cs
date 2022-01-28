using System;
using System.Numerics;

namespace Task16NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //N Factorial
            //Description
            //Write a method that multiplies a number represented as an array of digits by a given integer number. Write a program to calculate N!.

            //Input
            //On the first line you will receive the number N
            //Output
            //Print N!
            //Constraints
            //0 <= N <= 100
            //Sample tests
            //| Input | Output | |:-------|:-------| | 5 | 120 |

            int numbers;
            BigInteger factorial = 1;
            do
            {
                numbers = int.Parse(Console.ReadLine());
            } while (numbers <= 0 || numbers > 100);

            int[] arrayOfInt = new int[numbers];

            for (int i = 1; i <= numbers; i++)
            {
                arrayOfInt[i-1] = i;
            }
            foreach (ulong item in arrayOfInt)
            {
                factorial *= item;
            }

            Console.WriteLine(factorial);



            //long facturial = 1;

            //filter: Console.Write("");
            //long n = long.Parse(Console.ReadLine());
            //if (n <= 0 || n >=100)
            //{
            //    goto filter;
            //}
            //for (long i = 1; i <= n; i++)
            //{
            //    facturial *= i;
            //}
            //Console.WriteLine(facturial);
        }
    }
    
}
