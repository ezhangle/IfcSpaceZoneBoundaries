using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "IfcSpaceZoneBoundaries" )]
[assembly: AssemblyDescription( "Revit Add-In Description for IfcSpaceZoneBoundaries" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "IfcSpaceZoneBoundaries Revit C# .NET Add-In" )]
[assembly: AssemblyCopyright( "Copyright 2019 (C) Jeremy Tammik, Autodesk Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
//
// History:
//
//
// 2019-01-22 2019.0.0.0 initial wizard-generated add-in skeleton and project description
// 2019-01-22 2019.0.0.1 implemented external DB app, RoomZoneExporter, RoomZoneData
// 2019-01-23 2019.0.0.2 implemented top face boundary extraction
// 2019-01-23 2019.0.0.3 successful csv export
// 2019-01-24 2019.0.0.4 implemented GetTopFaceBoundaryStringAndZ and added elevation to CSV output
// 2019-01-24 2019.0.0.5 implemented JtSettings for user input
// 2019-01-24 2019.0.0.6 load and save settings on startup and shutdown
// 2019-01-25 2019.0.0.7 export bottom face boundary, not topmost
// 2019-01-25 2019.0.0.8 implemented JtLogger
// 2019-01-28 2019.0.0.9 implemented direct csv file output
// 2019-01-28 2019.0.0.10 convert all messages to log file entries
// 2019-01-28 2019.0.0.11 implemented GetLinkedInIfcDoc
// 2019-01-28 2019.0.0.12 successful test of logging and direct csv output
//
[assembly: AssemblyVersion( "2019.0.0.12" )]
[assembly: AssemblyFileVersion( "2019.0.0.12" )]
