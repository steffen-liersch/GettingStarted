/*--------------------------------------------------------------------------*\
::
::  Copyright © 2020 Steffen Liersch
::  https://www.steffen-liersch.de/
::
\*--------------------------------------------------------------------------*/

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