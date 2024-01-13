using System;
using System.Reflection.Metadata.Ecma335;
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
            var toupper = new Regex(@"<\s*toupper[^>]*>(.*?)<\s*/\s*toupper>");

            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(ReturningOnlyWord(words, i));
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else if (toupper.IsMatch(words[i]))
                {
                    Console.Write(ReturningOnlyWord(words, i).ToUpper());
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

        public static string ReturningOnlyWord(string[] words, int index)
        {
            string justWord =
                        words[index].Substring(
                            words[index].IndexOf(">") + 1,
                            (
                                words[index].LastIndexOf("<") - 1) - words[index].IndexOf('>')
                        );

            return justWord;
        }
    }
}