/*--------------------------------------------------------------------------*\
::
::  Copyright © 2013-2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

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