using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var date = new DateTime(); | Just inicialized but came with deafult numbers 1/1/0001 - 12:00 AM
            // var date = DateTime.Now; | busca a data da atual
            // var date = new DateTime(2024, 1, 14, 15, 25, 58);
            // To get each one of this results:
            // Console.WriteLine(date.AddDays(3));
            // Console.WriteLine(date);

            // FOrmatation

            var date = DateTime.Now;
            var formated = string.Format("{0:yyyy:MM:dd}", date);

            Console.WriteLine(formated);
        }
    }
}