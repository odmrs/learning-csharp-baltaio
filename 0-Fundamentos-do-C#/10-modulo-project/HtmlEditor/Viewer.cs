using System;
using System.Text.RegularExpressions;

namespace HtmlEdit
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Editor.SetBackGround();
            Console.WriteLine("Viewing mode - [ENTER] To exit");
            Console.WriteLine("========================================================\n\n");

            Replace(text);
            Console.ReadKey();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf(">") + 1,
                            (
                                words[i].LastIndexOf("<") - 1) - words[i].IndexOf('>')
                        )
                    );
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }
    }
}