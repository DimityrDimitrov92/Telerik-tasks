using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        //Multiplication Sign
        //Description
        //Write a program that shows the sign(+, -or 0) of the product of three real numbers, without calculating it.

        //Use a sequence of if operators.
        //Input
        //On the first three lines, you will receive the three numbers, each on a separate line
        //Output
        //Output a single line -the sign of the product of the three numbers
        //Constraints
        //The input will always consist of valid floating - point numbers
        //  Sample tests
        //  | Input | Output | | -------------------| --------------| | 2
        //5
        //2 | + | | 2
        //5
        //- 2 | - | | -0.5
        //0
        //- 2 | 0 |

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= 1 && b >= 1 && c >= 1 || a <= -1 && b <= -1 && c >= 1 || a <= -1 && b >= 1 && c <= -1 || a >= 1 && b <= -1 && c <= -1)
        {
            Console.WriteLine("+");
        }
        else if (a <= -1 && b >= 1 && c >= 1 || a >= 1 && b <= -1 && c >= 1 || a >= 1 && b >= 1 && c <= -1)
        {
            Console.WriteLine("-");
        }
        else if (a > -1 && a < 1 || b > -1 && b < 1 || c > -1 && c < 1)
        {
            Console.WriteLine(0);
        }
        else if (a <= -1 && b <=-1 && c <=-1)
        {
            Console.WriteLine("-");
        }

    }
}