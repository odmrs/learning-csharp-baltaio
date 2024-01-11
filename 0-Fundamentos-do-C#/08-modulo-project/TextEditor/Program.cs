using System;
using System.IO;
using System.Threading;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string defaultPath = "/home/odmrs/learning-csharp-baltaio/0-Fundamentos-do-C#/08-modulo-project/TextEditor/Files/";
            Console.Clear();
            Console.WriteLine("---------- TextEditor ----------\n\n");
            Console.WriteLine("[1] -> Open a file\n[2] -> New file\n[0] -> Exit\n\n");
            Console.Write("Answer: ");

            try
            {
                short option = short.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0: Exit(); break;
                    case 1: OpenFile(defaultPath); break;
                    case 2: EditFile(defaultPath); break;
                    default: ErrorMessage(); break;
                }
            }
            catch (Exception)
            {
                ErrorMessage();
            }
        }

        static void ErrorMessage()
        {
            Console.Clear();
            Console.WriteLine("!!!! The option is not found !!!!\n\nAny key for back to Menu");
            Console.Read();
            Menu();
        }
        static void OpenFile(string defaultPath = "")
        {
            Console.Clear();
            Console.WriteLine("---------- OpenFile Menu ----------\n\n");
            Console.WriteLine("The default path is in the directory of this project -> /Files\n[.] for default path and type de name of file\n\n");
            Console.Write("Enter the path where you want to open this file: ");
            string path = Console.ReadLine();

            if (path == ".")
            {
                Console.Write("Enter the name of file: ");
                string nameOfFile = Console.ReadLine();
                path = defaultPath + nameOfFile;
            }

            Console.Clear();

            Console.WriteLine("---------- Your File ---------\n\n");

            // Reading the file
            using (var file = new StreamReader(path))
            {
                string textByUser = file.ReadToEnd();
                Console.WriteLine(textByUser);
            }

            Console.WriteLine("\n---------- End of your file ----------\n\n\nAny key for back to Menu");
            Console.Read();
            Menu();
        }

        static void EditFile(string defaultPath)
        {
            Console.Clear();
            Console.WriteLine("---------- Edit ----------\n");
            Console.WriteLine("Type everything you want below\n[ESC] -> To Exit\n\n--------------------------\n");

            string userText = "";

            do
            {
                userText += Console.ReadLine() + Environment.NewLine;

            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(userText, defaultPath);
        }
        static void Save(string userText, string defaultPath = "")
        {
            Console.Clear();
            Console.WriteLine("---------- SaveFile Menu ----------\n\n");
            Console.WriteLine("The default path is in the directory of this project -> /Files\n[.] for default path and type de name of file\n\n");
            Console.Write("Enter the path where you want to save this file: ");

            string path = Console.ReadLine();
            bool defaultPathUsing = false;

            // Getting the default path
            if (path == ".")
            {
                Console.Write("Name of file: ");
                path = Console.ReadLine();
                defaultPath += path;
                path = defaultPath;
                defaultPathUsing = true;
            }


            using (StreamWriter file = new StreamWriter(path))
            {
                file.Write(userText);
            }

            if (defaultPathUsing)
            {
                Console.WriteLine("\n\nSaved in Default Path!");
            }

            Console.WriteLine("File was saved sucessfully.");
            Thread.Sleep(1000);
            Menu();
        }
        static void Exit()
        {
            Console.Clear();
            Console.WriteLine("Thanks for use my TextEditor!");
            Console.WriteLine("-----------------------------");
            Thread.Sleep(1000);
            Console.Clear();
            Environment.Exit(0);
        }
    }
}