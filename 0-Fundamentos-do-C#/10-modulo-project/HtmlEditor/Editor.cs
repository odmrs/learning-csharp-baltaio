using System;
using System.IO;
using System.Text;
using System.Threading;

namespace HtmlEdit
{
    public static class Editor
    {
        public static void Show()
        {
            SetBackGround();
            Console.WriteLine("Editor Mode - [ESC] To exit");
            Console.WriteLine("===========================\n\n");
            Start();
        }

        public static void Start()
        {
            var userText = new StringBuilder();

            do
            {
                userText.Append(Console.ReadLine());
                userText.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            // Show the text
            Viewer.Show(userText.ToString());

            Console.WriteLine("\n-----------------------------------\n\n");
            Console.Write("Would you like to save the file? (Y/N): ");
            char saveFile = char.Parse(Console.ReadLine().ToLower());

            if (saveFile != 'y')
            {
                Console.WriteLine("Returning to the Menu...");
                Thread.Sleep(1000);
                Menu.Show();
            }
            Save(userText.ToString());
            Menu.Show();
        }

        public static void Save(string userText)
        {
            string defaultPath = "/home/odmrs/learning-csharp-baltaio/0-Fundamentos-do-C#/10-modulo-project/HtmlEditor/Files/";
            SetBackGround();
            Console.WriteLine("Save File - [.] Default Path (/Files in this project)");
            Console.WriteLine("=====================================================\n\n");

            Console.Write("Enter the path to save this file: ");
            string path = Console.ReadLine();
            string nameFile;

            if (path == ".")
            {
                Console.Write("Enter the name of file: ");
                nameFile = Console.ReadLine();

                path = defaultPath + nameFile;
            }

            using (var file = new StreamWriter(path))
            {
                file.WriteLine(userText);
            }

            Console.WriteLine("\n\nFile saved successfully");
            Thread.Sleep(1000);
        }

        public static void SetBackGround()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }
    }
}