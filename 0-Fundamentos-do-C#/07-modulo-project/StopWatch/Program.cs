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
      Console.WriteLine("[Xs]  - Seconds => 10s = 10 seconds\n[Xm]  - Minutes => 1m = 1 minute");
      Console.WriteLine("[Xrs] - Regressive Seconds => 10rs = 10 seconds\n[Xrm] - Regressive Minutes => 10rs = 10 seconds\n [e]  - Exit");
      Console.Write("\n\nMake your choose: ");
      string formatOfTime = Console.ReadLine().ToLower();
      string lastChar = null;
      int time = 0;

      // Get the last 1 char
      if (formatOfTime.Length == 1)
      {
        lastChar = formatOfTime.Substring(0, 1);
      }
      // Get the last 2 chars, test if second to last is a number
      // string lastTwoChar = text.Substring(text.Length - 2);
      // string pLastChar = lastTwoChar[0].ToString();
      // bool test = int.TryParse(pLastChar, out _);
      // Testing the last 2 characters
      else if (int.TryParse(formatOfTime.Substring(formatOfTime.Length - 2)[0].ToString(), out _))
      {
        lastChar = formatOfTime.Substring(formatOfTime.Length - 1, 1);
        // Get the last char and all of numbers
        time = int.Parse(formatOfTime.Substring(0, formatOfTime.Length - 1));
      }

      else
      {
        // Get the last 2 characters
        lastChar = formatOfTime.Substring(formatOfTime.Length - 2);
        // Get all numbers, less letters
        time = int.Parse(formatOfTime.Substring(0, formatOfTime.Length - 2));
      }

      switch (lastChar)
      {
        case "m": Minutes(time); break;
        case "s": Seconds(time); break;
        case "e": Exit(); break;
        case "rs": RegressiveSeconds(time); break;
        case "rm": RegressiveMinutes(time); break;
        default: Error(); break;
      }
    }

    static void PreStart()
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch Running ----- \n");
      Console.Write("Ready...");
      Thread.Sleep(800);
      Console.Write("Set...");
      Thread.Sleep(800);
      Console.Write("GOOOOO!!!!!");
      Thread.Sleep(1000);
      Console.Clear();
      Console.WriteLine("----- StopWatch Running ----- \n");
    }

    static void Error()
    {
      Console.Clear();
      Console.WriteLine("The key is not found");
      Console.WriteLine("[ENTER] to return to the menu...");
      Console.ReadLine();
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

    static void End(bool regressive = false)
    {
      if (regressive)
      {
        Console.WriteLine("\n\n----- Regressive StopWatch End -----\n");
        Console.WriteLine("[ENTER] to return to the menu");
        Console.ReadLine();
        Menu();
      }
      else
      {
        Console.WriteLine("\n\n----- StopWatch End -----\n");
        Console.WriteLine("[ENTER] to return to the menu");
        Console.ReadLine();
        Menu();
      }
    }

    static void Minutes(int time)
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch in Minutes -----\n\n");
      Start(time * 60);
      End();
    }

    static void RegressiveMinutes(int time)
    {
      Console.Clear();
      Console.WriteLine("--- Regressive Stopwatch in Seconds ---");
      Start(time * 60, true);
      End(true);
    }

    static void Seconds(int time)
    {
      Console.Clear();
      Console.WriteLine("----- StopWatch in Seconds -----");
      Start(time);
      End();
    }

    static void RegressiveSeconds(int time)
    {
      Console.Clear();
      Console.WriteLine("--- Regressive Stopwatch in Seconds ---");
      Start(time, true);
      End(true);
    }


    static void Start(int time, bool regressive = false)
    {
      short currentTime = 1;
      int seconds = 1000;
      PreStart();

      if (regressive)
      {
        for (int i = 0; time >= i; time--)
        {
          Console.Clear();
          Console.WriteLine("----- Regressive StopWatch Running ----- \n\n");
          Console.WriteLine(time);
          Thread.Sleep(seconds);
        }
      }
      else
      {
        while (time >= currentTime)
        {
          Console.Clear();
          Console.WriteLine("----- StopWatch Running ----- \n");
          Console.WriteLine(currentTime);
          Thread.Sleep(seconds);
          currentTime++;
        }
      }
    }
  }
}
