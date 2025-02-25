using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestTwo = GetLargestOfTwo();
            Console.WriteLine($"Q1: The largest of the two numbers is: {largestTwo}\n");

            int largestFour = GetLargestOfFour();
            Console.WriteLine($"Q2: The largest of the four numbers is: {largestFour}\n");

            CreateAccount();
        }

        static int GetLargestOfTwo()
        {
            Console.WriteLine("Q1: Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Q1: Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            return (num1 > num2) ? num1 : num2;
        }

        static int GetLargestOfFour()
        {
            Console.WriteLine("Q2: Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Q2: Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Q2: Enter the third number:");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Q2: Enter the fourth number:");
            int num4 = int.Parse(Console.ReadLine());

            int max1 = GetLargestOfTwoHelper(num1, num2);
            int max2 = GetLargestOfTwoHelper(num3, num4);

            return GetLargestOfTwoHelper(max1, max2);
        }

        static int GetLargestOfTwoHelper(int a, int b)
        {
            return (a > b) ? a : b;
        }

        static void CreateAccount()
        {
            Console.WriteLine("Q3: Enter your desired username:");
            string username = Console.ReadLine();

            Console.WriteLine("Q3: Enter your desired password:");
            string password1 = Console.ReadLine();

            Console.WriteLine("Q3: Confirm your password:");
            string password2 = Console.ReadLine();

            Console.WriteLine("Q3: Enter your birth year:");
            int birthYear = int.Parse(Console.ReadLine());

            // Call checkAge method
            bool isOldEnough = CheckAge(birthYear);

            if (isOldEnough)
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }

        static bool CheckAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            return (age >= 18);
        }
    }
}
