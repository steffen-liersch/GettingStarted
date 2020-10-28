/*--------------------------------------------------------------------------*\
::
::  Copyright © 2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

using System;
using System.Linq;

namespace Liersch.HelloWorld
{
  static class Program
  {
    static void Main(string[] args)
    {
      try
      {
        SlowConsole.IsEnabled=!args.Any(x => x=="-f" || x=="--fast");
        Application.Run(args);
      }
      catch(Exception e)
      {
        Helpers.WriteLine(e.ToString(), ConsoleColor.Red);
      }

      if(Array.IndexOf(args, "--nowait")<0)
        Helpers.WaitForAnyKey();
    }
  }
}