//----------------------------------------------------------------------------
//
// Copyright © 2013-2020 Dipl.-Ing. (BA) Steffen Liersch
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

#if NET20 || NET30

using System.Collections.Generic;

namespace System.Linq
{
  static class Enumerable
  {
    public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
    {
      if(source==null)
        throw new ArgumentNullException(nameof(source));

      if(predicate==null)
        throw new ArgumentNullException(nameof(predicate));

      foreach(TSource item in source)
        if(predicate(item))
          return true;

      return false;
    }
  }
}

#endif