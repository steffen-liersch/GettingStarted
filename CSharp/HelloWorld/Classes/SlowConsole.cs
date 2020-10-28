/*--------------------------------------------------------------------------*\
::
::  Copyright © 2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

using System;
using System.Threading;

namespace Liersch.HelloWorld
{
  static class SlowConsole
  {
    public static bool IsEnabled { get; set; }

    public static void Write(string text)
    {
      if(text==null)
        return;

      if(IsEnabled && Console.CursorLeft==0)
        Thread.Sleep(20);

      Console.Write(text);
    }
  }
}