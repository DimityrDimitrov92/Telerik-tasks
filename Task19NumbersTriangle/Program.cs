using System;

namespace Task19NumbersTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers Triangle
            //You are given the number N.

            //Based on it, print triangles as follows:

            //Example: N = 3

            //1
            //1 2
            //1 2 3
            //1 2
            //3
            //Example: N = 5

            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5
            //1 2 3 4
            //1 2 3
            //1 2
            //1
            //Input
            //Read from the standard input

            //From the first line of the input, read the number N
            //Output
            //Print to the standard output

            //Print the triangle on 2 * N - 1 lines
            //  Sample tests
            //  Input
            //3
            //Output
            //1
            //1 2
            //1 2 3
            //1 2
            //3
            //Input
            //5
            //Output
            //1
            //1 2
            //1 2 3
            //1 2 3 4
            //1 2 3 4 5
            //1 2 3 4
            //1 2 3
            //1 2
            //1


            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
              
                for (int col = 1; col <= i; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }
            for (int i = n-1; i >= 1; i--) 
            {
                
                for (int col = 1; col <= i; col++)
                {
                    Console.Write(col + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
