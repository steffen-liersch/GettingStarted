/*--------------------------------------------------------------------------*\
::
::  Copyright © 2013-2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

#if NET20 || NET30

namespace System
{
  public delegate void Action();
  public delegate TResult Func<in T, out TResult>(T arg);
}

#endif