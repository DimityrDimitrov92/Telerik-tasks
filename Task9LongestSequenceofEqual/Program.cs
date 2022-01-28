using System;

namespace Task9LongestSequenceofEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Longest Sequence of Equal
            //Description
            //Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

            //Input
            //On the first line you will receive the number N
            //On the next N lines the numbers of the array will be given
            //Output
            //Print the length of the maximal sequence
            //Constraints
            //1 <= N <= 1024
            //Sample tests
            //Input
            //10
            //2
            //1
            //1
            //2
            //3
            //3
            //2
            //2
            //2
            //1
            //Output
            //3

            int count = 1, tempCount = 1;
            int length;
            do
            {
                length = int.Parse(Console.ReadLine());
            } while (1 >= length || length >= 1024);

            int[] arrayInt = new int[length];

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayInt.Length - 1; i++)
            {
                if (arrayInt[i] == arrayInt[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                }
            }
            Console.WriteLine(count);
            //for (int i = 0; i < count; i++) Console.Write($"{count}");






            //int count = 1, tempCount = 1, number = 0;

            //Console.Write("Enter array length: ");
            //int length = Int32.Parse(Console.ReadLine());
            //int[] arr = new int[length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter {0} element: ", i);
            //    arr[i] = Int32.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    if (arr[i] == arr[i + 1]) tempCount++;
            //    else tempCount = 1;

            //    if (tempCount > count)
            //    {
            //        count = tempCount;
            //        number = arr[i];
            //    }
            //}

            //for (int i = 0; i < count; i++) Console.Write("{0}, ", number);
        }
    }
    
}
