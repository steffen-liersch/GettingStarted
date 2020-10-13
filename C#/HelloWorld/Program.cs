//----------------------------------------------------------------------------
//
// Copyright © 2020 Dipl.-Ing. (BA) Steffen Liersch
// All rights reserved.
//
// Steffen Liersch
// Robert-Schumann-Straße 1
// 08289 Schneeberg
// Germany
//
// Phone: +49-3772-38 28 08
// E-Mail: S.Liersch@gmx.de
//
//----------------------------------------------------------------------------

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