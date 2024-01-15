using System;
using Microsoft.VisualBasic;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5]; // start always with 0
            // var arr = new int[5] {1,2,3,4,5}; // or inicialized them with {}
            arr[0] = 44;
            // Console.WriteLine(arr.Length);

            // Percorrendo arrays

            // for (var i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }

            // For Each

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}