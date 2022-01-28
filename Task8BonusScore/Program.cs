using System;

namespace Task8BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bonus Score
            //Bonus Score
            //Description
            //Write a program that applies bonus score to given score in the range[1…9] by the following rules:

            //If the score is between 1 and 3, the program multiplies it by 10.
            //If the score is between 4 and 6, the program multiplies it by 100.
            //If the score is between 7 and 9, the program multiplies it by 1000.
            //If the score is less than 0 or more than 9, the program prints "invalid score".
            //Input
            //The only input line will contain one integer number -the score
            //Output
            //Output the score with the applied bonus
            //Constraints
            //The score will always be a valid integer number
            //Sample tests
            //| Input | Output | | -----------------| -----------------| | 2 | 20 | | 4 | 400 | | 9 | 9000 | | 10 | invalid score |

              int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 9)
            {
                Console.WriteLine("Not Valid");
            }
            if (n <= 3 && n >= 1)
            {
                n *= 10;
                Console.WriteLine(n);
            }
            else if (n <=6 && n >= 4)
            {
                n *= 100;
                Console.WriteLine(n);
            }
            else if (n <= 9 && n >= 7)
            {
                n *= 1000;
                Console.WriteLine(n);
            }
        }
    }
}
