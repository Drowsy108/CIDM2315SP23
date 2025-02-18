using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;
            int largest = Q1_method(num1, num2);
            Console.WriteLine($"The largest number between {num1} and {num2} is {largest}\n");

            int N = 5;
            string shape = "left"; // Change to "right" for right-side triangle
            Q2_method(N, shape);
        }

        static int Q1_method(int a, int b)
        {
            return (a > b) ? a : b;
        }

                static void Q2_method(int N, string shape)
        {
            Console.WriteLine($"N = {N}, Shape = {shape}\n");
            
            if (shape.ToLower() == "left")
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new string('*', i));
                }
            }
            else if (shape.ToLower() == "right")
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine(new string(' ', N - i) + new string('*', i));
                }
            }
            else
            {
                Console.WriteLine("Invalid shape. Please enter 'left' or 'right'.");
            }
        }
    }
}
