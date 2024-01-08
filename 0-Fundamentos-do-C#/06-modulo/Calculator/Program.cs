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
                    float x1 = float.Parse(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    float x2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("The sum between: " + x1 + " + " + x2 + " = " + Sum(x1, x2));
                    break;
            }

        }
    }

}