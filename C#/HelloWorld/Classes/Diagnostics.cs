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

namespace Liersch.HelloWorld
{
  static class Diagnostics
  {
    public static readonly bool IsDebugVersion=
#if DEBUG
      true
#else
      false
#endif
    ;

    // https://docs.microsoft.com/de-de/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-if
    public const string TargetType=
#if NETCOREAPP
      ".NET Core"
#elif NETSTANDARD
      ".NET Standard"
#elif NETFRAMEWORK
      ".NET Framework"
#endif
    ;
  }
}