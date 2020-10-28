/*--------------------------------------------------------------------------*\
::
::  Copyright © 2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

using System;

namespace Liersch.HelloWorld
{
  static class Helpers
  {
    public static int KeyWidth { get; set; } = Console.WindowWidth/2;

    public static void WriteKeyValue(string key, string value)
    {
      ConsoleColor last=Console.ForegroundColor;
      bool hasBlackBG=Console.BackgroundColor==ConsoleColor.Black;

      int i=key.Length;
      int diff=KeyWidth-i;
      if(diff>0)
        key+=new string(' ', diff);
      key+=": ";

      if(hasBlackBG)
        Console.ForegroundColor=ConsoleColor.Gray;
      Print(key);

      int rem=Console.WindowWidth-1-key.Length;
      diff=value.Length-rem;
      if(diff>0)
        value="..."+value.Substring(diff+3);

      if(hasBlackBG)
        Console.ForegroundColor=ConsoleColor.White;
      PrintLine(value);

      Console.ForegroundColor=last;
    }


    public static void WriteHeadline(string headline)
    {
      ConsoleColor last=Console.ForegroundColor;

      bool hasBlackBG=Console.BackgroundColor==ConsoleColor.Black;
      if(hasBlackBG)
        Console.ForegroundColor=ConsoleColor.White;

      PrintLine(headline);
      PrintLine(new string('-', headline.Length));

      Console.ForegroundColor=last;
    }

    public static void WriteLine(string text, ConsoleColor color) { Write(text+Environment.NewLine, color); }

    public static void Write(string text, ConsoleColor color)
    {
      ConsoleColor last=Console.ForegroundColor;

      bool hasBlackBG=Console.BackgroundColor==ConsoleColor.Black;
      if(hasBlackBG)
        Console.ForegroundColor=color;

      Print(text);

      Console.ForegroundColor=last;
    }


    public static void WaitForAnyKey()
    {
      int x=Console.CursorLeft;
      int y=Console.CursorTop;

      RunAction("[Press any key!] ", () => Console.ReadKey(true));

      Console.CursorLeft=x;
      Console.CursorTop=y;
    }

    public static void RunAction(string message, Action action)
    {
      int x=Console.CursorLeft;
      Write(message, ConsoleColor.Yellow);

      try
      {
        action();
      }
      catch
      {
        PrintLine();
        throw;
      }

      Console.CursorLeft=x;
      Print(new string(' ', message.Length));
      Console.CursorLeft=x;
    }


    static void PrintLine(string text = null) { Print(text+Environment.NewLine); }

    static void Print(string text) { SlowConsole.Write(text); }
  }
}