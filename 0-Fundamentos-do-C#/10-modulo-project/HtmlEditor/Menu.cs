using System;

namespace HtmlEdit
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());

            HandleMenuOption(option);
        }

        public static void DrawScreen(int x = 30, int y = 13)
        {
            HorizontalLine(x);
            VerticalLine(y, x);
            HorizontalLine(x);
        }

        public static void HorizontalLine(int horizontalLength = 30)
        {
            Console.Write("+");
            for (int lines = 0; lines <= horizontalLength; lines++)
            {
                Console.Write("-");
            }
            Console.Write("+\n");
        }

        public static void VerticalLine(int verticalLength = 10, int lengthOfHorizontalLine = 30)
        {
            for (int lines = 0; lines <= verticalLength; lines++)
            {
                Console.Write("|");
                for (int whiteSpace = 0; whiteSpace <= lengthOfHorizontalLine; whiteSpace++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("HtmlEditor");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Select an opition bellow:");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - New File");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("2 - Open File");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Exit");
            Console.SetCursorPosition(3, 11);
            Console.Write("Option: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 0: Exit(); break;
                case 1: Editor.Show(); break;
                // case 2: Open.Show(); break;
                default: Menu.Show(); break;

            }
        }

        public static void Exit()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen(40, 6);
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Exiting!!!");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==========");
            Console.SetCursorPosition(3, 5);
            Console.Write("Thank's for use my Html Editor!");
            Console.ReadLine();
        }
    }
}