using System.Reflection;

/*
 * In order to define assembly information in the code, 
 * it must be enabled in the .NET SDK project file:
 * 
 *   <Project Sdk="Microsoft.NET.Sdk">
 *     <PropertyGroup>
 *       <GenerateAssemblyInfo>false</GenerateAssemblyInfo>
 *     </PropertyGroup>
 *   </Project>
 */

[assembly: AssemblyCompany("Steffen Liersch")]
[assembly: AssemblyCopyright("© 2020 Dipl.-Ing. (BA) Steffen Liersch")]
[assembly: AssemblyFileVersion("1.0.0")]
[assembly: AssemblyInformationalVersion("1.0.0")] // See FileVersionInfo.ProductVersion
[assembly: AssemblyProduct("HelloWorld")]
[assembly: AssemblyTitle("C# Example Application")] // See FileVersionInfo.FileDescription
