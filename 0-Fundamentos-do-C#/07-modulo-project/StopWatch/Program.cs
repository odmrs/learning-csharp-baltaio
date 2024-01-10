using System;
using System.Threading;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }
    
    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("---------- StopWatch ----------\n\n");
      Console.WriteLine("[s] - Seconds\n[m] - Minutes\n[e] - Exit");
      Console.Write("\n\nMake your choose: ");
      string formatOfTime = Console.ReadLine();

      switch (formatOfTime)
      {
        case "m": case "M": Minutes(); break;
        case "s": case "S": Seconds(); break;
        case "e": case "E": Exit(); break;
        default: Error(); break;
      }
    }
    
    static void Error()
    {
      Console.Clear();
      Console.WriteLine("The key is not found");
      Console.WriteLine("[ENTER] to return to the menu...");
      Console.Read();
      Menu();
    }

    static void Exit()
    {
      Console.Clear();
      Console.WriteLine("--- Thanks for use my StopWatch ---");
      Thread.Sleep(1500);
      Console.Clear();
      Environment.Exit(0);
    }

    static void End()
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch End -----\n\n");
      Console.WriteLine("[ENTER] to return to the menu");
      Console.Read();
      Menu();
    }

    static void Minutes()
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch in Minutes -----\n\n");
      Console.Write("Enter the number of minutes: ");
      int numberOfMinutes = int.Parse(Console.ReadLine());
      int time = numberOfMinutes * 60;

      Start(time);
      End();
    }
    
    static void Seconds()
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch in Seconds -----\n\n");
      Console.Write("Enter the number of seconds: ");
      int numberOfSeconds = int.Parse(Console.ReadLine());

      Start(numberOfSeconds);
      End();
    }

    static void Start(int time)
    {
      short currentTime = 0;
      while (time >= currentTime)
      { 
        Console.WriteLine("----- StopWatch Running -----");
        int seconds = 1000;
        Console.Clear();
        Console.WriteLine(currentTime);
        Thread.Sleep(seconds);
        currentTime++;
      }
    }
  }
}
