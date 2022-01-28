using System;

namespace Task5AllocateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //           Allocate Array
            //Allocate array
            //Description
            //Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

            //Input
            //On the only line you will receive the number N
            //Output
            //Print the obtained array on the console.
            //Each number should be on a new line
            //Constraints
            //1 <= N <= 20
            //N will always be a valid integer number
            //Sample tests
            //| Input | Output | |:-----:|:------:| | 5 | 0
            //5
            //10
            //15
            //20 |

            int n;
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n <=1 || n >=20);
            
            int[] array = new int[n];
            for (int i = 0; i < n ; i++)
            {
                 array[i] = i * 5;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
