﻿using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clean
            Console.Clear();
            Menu();
        }

        static void Sum()
        {
            Console.WriteLine("---------- SUM ----------");
            Console.Write("\nEnter first number: ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            float x2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe sum between: {x1} + {x2} = {x1 + x2}");
        }

        static void Sub()
        {
            Console.WriteLine("---------- SUB ----------");
            Console.Write("\nEnter First number: ");
            float sub1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            float sub2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe sub between {sub1} - {sub2} = {sub1 - sub2}");
        }

        static void Mult()
        {
            Console.WriteLine("---------- Mult ----------");
            Console.Write("\nEnter the First number: ");
            float mult1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            float mult2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"The mult between {mult1} * {mult2} = {mult1 * mult2}");
        }

        static void Div()
        {
            Console.WriteLine("---------- Div ----------");
            Console.Write("\nEnter the First number: ");
            float div1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number: ");
            float div2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"\nThe division between {div1} / {div2} = {div1 / div2}");
        }

        static void Bye()
        {
            Console.WriteLine("Thank's for use my calculator !!!");
            Thread.Sleep(1300);
            Console.Clear();
            System.Environment.Exit(0);
        }

        static void Square()
        {
            Console.WriteLine("---------- Square ----------");
            Console.Write("\nEnter the number to see it squared: ");
            float number = float.Parse(Console.ReadLine());
            Console.WriteLine($"The number {number}² = {number * number}");
        }

        static void Cube()
        {
            Console.WriteLine("---------- Cube ----------");
            Console.Write("\nEnter the number to see it cubed: ");
            float number = float.Parse(Console.ReadLine());
            Console.WriteLine($"The number {number}³ = {number * number * number}");
        }

        static void Elevated()
        {
            Console.WriteLine("---------- Elevate ----------");
            Console.Write("\nEnter the base number: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the high number: ");
            float num2 = float.Parse(Console.ReadLine());

            float? result = 1;

            if (num2 != 1)
            {
                for (int i = 0; i < num2; i++)
                {
                    result *= num1; // Multiply (num1) 
                }
            }
            else
            {
                result = num1;
            }

            Console.WriteLine($"\nThe number {num1} ^ {num2} = {result}");
        }
        static void Menu()
        {
            while (true)
            {
                Console.WriteLine("What do you need?");
                Console.Write("\n[0]Exit\n[1]Sum\n[2]Sub\n[3]Mult\n[4]Div\n[5]Square\n[6]Cube\n[7]Elevated yourself\n\nAnswer: ");
                int answer = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (answer)
                {
                    case 0: Bye(); break;
                    case 1: Sum(); break;
                    case 2: Sub(); break;
                    case 3: Mult(); break;
                    case 4: Div(); break;
                    case 5: Square(); break;
                    case 6: Cube(); break;
                    case 7: Elevated(); break;
                    default:
                        Console.WriteLine("None of the option exist");
                        break;
                }
                Console.Write("\n\n[ENTER FOR BACK TO MENU]");
                Console.ReadLine();

                Thread.Sleep(100);
                Console.Clear();
            }
        }
    }
}