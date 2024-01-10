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
      Console.WriteLine("[Xs] - Seconds => 10s = 10 seconds\n[Xm] - Minutes => 1m = 1 minute\n[e]  - Exit");
      Console.Write("\n\nMake your choose: ");
      
      string formatOfTime = Console.ReadLine().ToLower();
      char? lastChar = null;
      int time = 0;

      if (formatOfTime.Length == 1)
      {
        lastChar = char.Parse(formatOfTime.Substring(0, 1));
      }

      else
      {
        lastChar = char.Parse(formatOfTime.Substring(formatOfTime.Length - 1, 1));
        time = int.Parse(formatOfTime.Substring(0, formatOfTime.Length - 1));
      }

      switch (lastChar)
      {
        case 'm': Minutes(time); break;
        case 's': Seconds(time); break;
        case 'e': Exit(); break;
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
      Console.WriteLine("\n\n----- StopWatch End -----\n");
      Console.WriteLine("[ENTER] to return to the menu");
      Console.Read();
      Menu();
    }

    static void Minutes(int time)
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch in Minutes -----\n\n");
      Start(time * 60);
      End();
    }
    
    static void Seconds(int time)
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch in Seconds -----");
      Start(time);
      End();
    }

    static void Start(int time)
    {
      short currentTime = 0;
      while (time >= currentTime)
      { 
        int seconds = 1000;
        Console.Clear();
        Console.WriteLine("----- StopWatch Running ----- \n\n");
        Console.WriteLine(currentTime);
        Thread.Sleep(seconds);
        currentTime++;
      }
    }
  }
}
