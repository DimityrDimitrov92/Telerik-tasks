using System;

namespace Task3LongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //          Long Sequence
            //Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …

            //You might need to learn how to use loops in Java(search in Internet).
            //Input
            //There is no input for this task.
            //Output
            //Output the first 1000 members of the sequence, each on a separate line.
            //2
            //- 3
            //4
            //- 5
            //6...

            for (int i = 2; i < 1003; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }
        }
    }
}
