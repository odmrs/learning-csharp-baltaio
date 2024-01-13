using System;
using System.IO;
using System.Text;

namespace HtmlEdit
{
    public static class Open
    {
        public static void Show()
        {
            string defaultPath = "/home/odmrs/learning-csharp-baltaio/0-Fundamentos-do-C#/10-modulo-project/HtmlEditor/Files/";

            Editor.SetBackGround();
            Console.WriteLine("OpenFile - [.] Default Path (/Files in this project)");
            Console.WriteLine("========================================================\n\n");

            Console.Write("Enter the path to open this file: ");
            string path = Console.ReadLine();
            string nameFile;

            if (path == ".")
            {
                Console.Write("Enter the name of file: ");
                nameFile = Console.ReadLine();

                path = defaultPath + nameFile;
            }
            try
            {
                using (var file = new StreamReader(path))
                {
                    var userText = new StringBuilder();
                    userText.Append(file.ReadToEnd());

                    Viewer.Show(userText.ToString());
                    Menu.Show();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("This file can't be open:");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }

    }
}
