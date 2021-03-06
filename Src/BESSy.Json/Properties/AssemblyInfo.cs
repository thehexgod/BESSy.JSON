#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if PORTABLE40
[assembly: AssemblyTitle("Json.NET Portable .NET 4.0")]
#elif PORTABLE
[assembly: AssemblyTitle("Json.NET Portable")]
#elif NETFX_CORE
[assembly: AssemblyTitle("Json.NET WinRT")]
#elif NET20
[assembly: AssemblyTitle("Json.NET .NET 2.0")]
[assembly: AllowPartiallyTrustedCallers]
#elif NET35
[assembly: AssemblyTitle("Json.NET .NET 3.5")]
[assembly: AllowPartiallyTrustedCallers]
#elif NET40 && !MONO
[assembly: AssemblyTitle("Json.NET .NET 4.0")]
[assembly: AllowPartiallyTrustedCallers]
#elif MONO
[assembly: AssemblyTitle("Json.NET Mono")]
[assembly: AllowPartiallyTrustedCallers]
#else
[assembly: AssemblyTitle("Json.NET")]
[assembly: AllowPartiallyTrustedCallers]
#endif


[assembly: InternalsVisibleTo("BESSy.Json.Tests, PublicKey=0024000004800000140100000602000000240000525341310008000001000100550ec61287e936f496092086363c95ee8ea94a4820410ac1c7a0abbb88e3b84387f33b11787f72afbb862d3e12b3d9c5a8b0535cfcc3e38e174ec9e78b04e1ef89dcce36e18db95bf0a23aba650fe0c6af7f59ddb9480ee23c8cde4c429c698422ffe75e55498f5fbd735ad62ac85fa9b2955d801d2b83138e9681c2d654bf768d49ea66ac750d04fe5fabc3d6bfa544d8d4eb439f199d5afff15411d157b16d56e3ceb8c3fc3328ce27f04ff6dc3f12b94c704e1667abdfb0b9831be6aa462bede88d98dda005e407f50f3faebaed0373978a371f441b401d8656b014fd36ef6621df3335e8e5e576924e668c4c3df95684c6c67122a7dae6a4ad545b886ebd")]
[assembly: InternalsVisibleTo("BESSy.Json.Dynamic, PublicKey=0024000004800000940000000602000000240000525341310004000001000100cbd8d53b9d7de30f1f1278f636ec462cf9c254991291e66ebb157a885638a517887633b898ccbcf0d5c5ff7be85a6abe9e765d0ac7cd33c68dac67e7e64530e8222101109f154ab14a941c490ac155cd1d4fcba0fabb49016b4ef28593b015cab5937da31172f03f67d09edda404b88a60023f062ae71d0b2e4438b74cc11dc9")]



[assembly: AssemblyDescription("Json.NET is a popular high-performance JSON framework for .NET")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Newtonsoft")]
[assembly: AssemblyProduct("Json.NET")]
[assembly: AssemblyCopyright("Copyright � James Newton-King 2008")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

#if !(PORTABLE40 || PORTABLE)
// Setting ComVisible to false makes the types in this assembly not visible 
// to COM componenets.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM

[assembly: Guid("9ca358aa-317b-4925-8ada-4a29e943a363")]
#endif

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion("6.0.0.0")]
[assembly: AssemblyFileVersion("6.0.2.17209")]
[assembly: CLSCompliant(true)]
