using System;

namespace Task2SumTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //          Sum two numbers
            // Write a program that reads two numbers from the standard input and prints their sum.

            //Input
            //The input will consist of two lines
            //Each line will contain a number between - 1500000 and 1500000
            //Output
            //You should print a single line with the result of summing the two numbers
            //Constraints
            //The numbers will be between - 1500000 and 1500000
            //Input
            //2
            //2
            //Output
            //4
            //Input
            //- 1
            //3
            //Output
            //2
            //Input
            //- 2
            //- 5
            //Output
            //- 7


            int a = int.Parse(Console.ReadLine());
            
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
        }
    }
}
