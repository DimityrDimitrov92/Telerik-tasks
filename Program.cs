using System;

namespace Telerik
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCipher();
        }
        public static void CreateCipher()
        {
            int numberOne = 0;
            int numberTwo = 0;
            int numberThree = 0;
            int threeDigit = 0;
            int cipherLastDigit = 0;
            int result = 0;
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            while (threeDigit < 5)
            {
                Console.Write("");
                int numbersOf3 = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 3; i++)
                {
                    var digit = numbersOf3 % 10;
                    numbersOf3 /= 10;
                    if (i == 3)
                    {
                        numberOne = digit;
                    }
                    else if (i == 2)
                    {
                        numberTwo = digit;
                    }
                    else
                    {
                        numberThree = digit;
                    }

                }
                result = numberOne * numberTwo * numberThree;
                cipherLastDigit = result % 10;
                if (threeDigit == 4)
                {
                    e = cipherLastDigit;
                }
                else if (threeDigit == 3)
                {
                    d = cipherLastDigit;
                }
                else if (threeDigit == 2)
                {
                    c = cipherLastDigit;
                }
                else if (threeDigit == 1)
                {
                    b = cipherLastDigit;
                }
                else
                {
                    a = cipherLastDigit;
                }
                threeDigit++;
            }
            Console.WriteLine($"{a}{b}{c}{d}{e}");
        }
    }
}

