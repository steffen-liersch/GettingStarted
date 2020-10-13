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
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Liersch.HelloWorld
{
  static class Application
  {
    public static void Run(string[] args)
    {
      int last=Helpers.KeyWidth;
      try
      {
        SayHello(args);
      
        Helpers.KeyWidth=19;

        ShowEnvironmentInfo();
        ShowFilesAndFolders();
        ShowAssemblyInfo(typeof(Program).Assembly.ManifestModule.FullyQualifiedName);
        ShowAssemblyInfo(typeof(int).Assembly.ManifestModule.FullyQualifiedName);
      }
      finally
      {
        Helpers.KeyWidth=last;
      }
    }

    static void SayHello(string[] args)
    {
      Helpers.WriteLine("Hello World!", ConsoleColor.White);

      int c=args!=null ? args.Length : 0;
      if(c<=0)
        Helpers.WriteLine("No parameters were specified.", ConsoleColor.DarkGray);
      else
      {
        Console.WriteLine();
        Helpers.WriteHeadline("Arguments");

        Helpers.KeyWidth=c.ToStringInvariant().Length;
        for(int i = 0; i<c; i++)
          Helpers.WriteKeyValue("#"+i.ToStringInvariant(), args[i]);
      }

      Console.WriteLine();
    }

    static void ShowEnvironmentInfo()
    {
      Helpers.WriteHeadline("Environment Information");
      Helpers.WriteKeyValue("Configuration", Diagnostics.IsDebugVersion ? "Debug" : "Release");
      Helpers.WriteKeyValue("Target type", Diagnostics.TargetType);
      Helpers.WriteKeyValue("Environment version", Environment.Version.ToString());
      Helpers.WriteKeyValue("Core library file", typeof(int).Assembly.ManifestModule.FullyQualifiedName);
      Console.WriteLine();
    }

    static void ShowFilesAndFolders()
    {
      Helpers.WriteHeadline("Files and Folders");
      Helpers.WriteKeyValue("Program assembly", typeof(Program).Assembly.ManifestModule.FullyQualifiedName);
      Helpers.WriteKeyValue("Entry assembly", Assembly.GetEntryAssembly().ManifestModule.FullyQualifiedName);
      Helpers.WriteKeyValue("Calling assembly", Assembly.GetCallingAssembly().ManifestModule.FullyQualifiedName);
      Helpers.WriteKeyValue("Current directory", Directory.GetCurrentDirectory());
      Console.WriteLine();
    }

    static void ShowAssemblyInfo(string fileName)
    {
      Helpers.WriteHeadline(Path.GetFileName(fileName));

      var fvi=FileVersionInfo.GetVersionInfo(fileName);
      Helpers.WriteKeyValue("Product name", fvi.ProductName);
      Helpers.WriteKeyValue("Product version", fvi.ProductVersion);
      Helpers.WriteKeyValue("File version", fvi.FileVersion);
      Helpers.WriteKeyValue("File description", fvi.FileDescription);
      Helpers.WriteKeyValue("Company name", fvi.CompanyName);
      Helpers.WriteKeyValue("Copyright", fvi.LegalCopyright);
      Console.WriteLine();
    }
  }
}