using System;
using System.IO;

namespace HtmlEdit
{
    public static class Documentation
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Menu.DrawScreen(50, 15);
            WriteOptions();

            short opition = short.Parse(Console.ReadLine());

            HandleMenuOption(opition);
            Menu.Show();
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Documentation");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Select an opition bellow to see an exemple:");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - <strong> </strong>");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - <toupper> </toupper>");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(3, 11);
            Console.Write("Option: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0: Menu.Show(); break;
                case 1: Open.See(Paths(1)); break;
                case 2: Open.See(Paths(2)); break;
            }
        }

        public static string Paths(short option)
        {
            var strongExemple = "/home/odmrs/learning-csharp-baltaio/0-Fundamentos-do-C#/10-modulo-project/HtmlEditor/Exemples/strongExemple.txt";
            var toupperExemple = "/home/odmrs/learning-csharp-baltaio/0-Fundamentos-do-C#/10-modulo-project/HtmlEditor/Exemples/toupperExemple.txt";

            switch (option)
            {
                case 1: return strongExemple;
                case 2: return toupperExemple;
            }

            return "error";
        }
    }
}