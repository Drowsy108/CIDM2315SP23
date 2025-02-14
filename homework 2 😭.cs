﻿using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1
            Console.Write("Enter a letter grade (A, B, C, D, F): ");
            char grade = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("GPA Points: 4");
                    break;
                case 'B':
                    Console.WriteLine("GPA Points: 3");
                    break;
                case 'C':
                    Console.WriteLine("GPA Points: 2");
                    break;
                case 'D':
                    Console.WriteLine("GPA Points: 1");
                    break;
                case 'F':
                    Console.WriteLine("GPA Points: 0");
                    break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }

            // Code for Q2
            Console.Write("\nEnter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            
            int smallest;
            if (num1 <= num2 && num1 <= num3)
                smallest = num1;
            else if (num2 <= num1 && num2 <= num3)
                smallest = num2;
            else
                smallest = num3; // ima bit to lazy to grab the extra points at this moment im so sorry 😭
            
            Console.WriteLine("The smallest number is: " + smallest);
        }
    }
}
