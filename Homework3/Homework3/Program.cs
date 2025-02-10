using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            //prime numbet check 😊
            Console.Write("Enter a number (N) to check if it is prime: ");
            int N = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (N <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < N; i++)
                {
                    if (N % i == 0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
                Console.WriteLine($"{N} is prime");
            else
                Console.WriteLine($"{N} is non-prime");

            Console.WriteLine();

            // Square pattern i think ❤️
            Console.Write("Enter a number (N) for the square pattern: ");
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* "); 
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // square patterns 💀
            Console.Write("Enter a number (N) for the pattern with conditions: ");
            int patternSize = int.Parse(Console.ReadLine());

            for (int i = 0; i < patternSize; i++)
            {
                for (int j = 0; j < patternSize; j++) 
                {
                    if (i == 0 || i == patternSize - 1 || j == 0 || j == patternSize - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine(); 
            }

            Console.WriteLine();

            //bonues pattern☠️
            Console.Write("Enter a number (N) for the bonus pattern: ");
            int bonusSize = int.Parse(Console.ReadLine());

            for (int i = 0; i < bonusSize; i++)
            {
                for (int j = 0; j < bonusSize; j++)
                {
                    if (i == j || i + j == bonusSize - 1) 
                        Console.Write("* ");
                    else
                        Console.Write("  "); // Print spaces
                }
                Console.WriteLine(); 
            }
        }
    }
}
