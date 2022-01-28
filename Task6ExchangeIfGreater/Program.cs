using System;

namespace Task6ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exchange if Greater
            //Exchange numbers
            //Description
            //Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if the first one is greater than the second one.Use an if-statement.As a result print the values of the variables A and B, separated by a space.

            //Input
            //On the first line, you will receive the value of A
            //On the second line, you will receive the value of B
            //Output
            //On the only output line, print the values of the two variables, separated by a whitespace
            //Constraints
            //A and B will always be valid real numbers between - 100 and 100
            //Sample tests
            //| Input | Output | | -----------------| -----------------| | 5
            //3 | 3 5 | | 2
            //4 | 2 4 | | 3.3
            //3.3 | 3.3 3.3 |

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if(a > b)
            {
                a = a * b; //a=50 (5*10)      
                b = a / b; //b=5 (50/10)      
                a = a / b; //a=10 (50/5)    
                Console.WriteLine($"{a} {b}");
            }
            else
            {
                Console.WriteLine($"{a} {b}");
            }
           
        }
    }
}
