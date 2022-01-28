using System;

namespace Task15MostFrequent
{
    class Program
    {
        static void Main(string[] args)
        {
            //Most Frequent
            //Write a program that finds the most frequent number in an array of N elements.

            //Input
            //On the first line you will receive the number N
            //On the next N lines the numbers of the array will be given
            //Output
            //Print the most frequent number and how many time it is repeated
            //Output should be REPEATING_NUMBER(REPEATED_TIMES times)
            //Constraints
            //1 <= N <= 1024
            //0 <= each number in the array <= 10000
            //There will be only one most frequent number
            //Sample tests
            //| Input | Output | |:-----:|:------:| | 13
            //4
            //1
            //1
            //4
            //2
            //3
            //4
            //4
            //1
            //2
            //4
            //9
            //3 | 4(5 times) |
            
            int numbersInArray,n;
            int counter = 1;
            int check = 0;
            int result = 0;

            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 1024);

            int[] arrayOfNumbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                do
                {
                    numbersInArray = int.Parse(Console.ReadLine());
                } while (numbersInArray <= 0 || numbersInArray >= 10000);

                arrayOfNumbers[i] = numbersInArray;
            }
            Array.Sort(arrayOfNumbers);

            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                if (arrayOfNumbers[i] == arrayOfNumbers[i + 1])
                {
                    counter++;
                    if (i == arrayOfNumbers.Length-2 && counter>check)
                    {
                        check = counter;
                        result = arrayOfNumbers[i];
                    }
                }
                else       //5,5,3,4,6,6
                {
                    if (counter > check)
                    {
                        check = counter;
                        result = arrayOfNumbers[i];
                    }
                    counter = 1;

                }
            }
            Console.WriteLine(result + " (" + check + " times)");
        }
    }
}
