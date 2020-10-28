/*--------------------------------------------------------------------------*\
::
::  Copyright © 2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

using System.Globalization;

namespace Liersch.HelloWorld
{
  static class Extensions
  {
    public static string ToStringInvariant(this int value) { return value.ToString(CultureInfo.InvariantCulture); }
  }
}