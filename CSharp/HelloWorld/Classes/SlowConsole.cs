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