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

namespace System
{
  public delegate void Action();
  public delegate TResult Func<in T, out TResult>(T arg);
}

#endif