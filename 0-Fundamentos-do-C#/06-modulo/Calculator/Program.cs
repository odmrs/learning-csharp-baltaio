using System;
using System.ComponentModel.Design;

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

        static float Sum(float x1, float x2)
        {
            return x1 + x2;
        }

        static float Sub(float x1, float x2)
        {
            return x1 - x2;
        }

        static float Mult(float x1, float x2)
        {
            return x1 * x2;
        }

        static float Div(float x1, float x2)
        {
            return x1 / x2;
        }
        static void Menu()
        {
            Console.WriteLine("What do you need?");
            Console.Write("\n[1]Sum\n[2]Sub\n[3]Mult\n[4]Div\n[5]Exit\nAnswer: ");
            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Console.WriteLine("---------- SUM ----------");
                    Console.Write("\nEnter first number: ");
                    float sum1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    float sum2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"The sum between: {sum1} + {sum2} = {Sum(sum1, sum2)}");
                    break;
                case 2:
                    Console.WriteLine("---------- SUB ----------");
                    Console.Write("\nEnter First number: ");
                    float sub1 = float.Parse(Console.ReadLine());
                    Console.Write("\nEnter the Second Number: ");
                    float sub2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"The sub between {sub1} - {sub2} = {Sub(sub1, sub2)}");
                    break;
                case 3:
                    Console.WriteLine("---------- Mult ----------");
                    Console.Write("\nEnter the First number: ");
                    float mult1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter the Second number: ");
                    float mult2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"The mult between {mult1} * {mult2} = {Mult(mult1, mult2)}");
                    break;
                case 4:
                    Console.WriteLine("---------- Div ----------");
                    Console.Write("\nEnter the First number: ");
                    float div1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter the Second Number: ");
                    float div2 = float.Parse(Console.ReadLine());
                    Console.WriteLine($"The division between {div1} / {div2} = {Div(div1, div2)}");
                    break;
            }
        }
    }
}