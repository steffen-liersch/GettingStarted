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

using System.Globalization;

namespace Liersch.HelloWorld
{
  static class Extensions
  {
    public static string ToStringInvariant(this int value) { return value.ToString(CultureInfo.InvariantCulture); }
  }
}