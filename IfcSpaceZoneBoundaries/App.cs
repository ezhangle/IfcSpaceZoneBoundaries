#region Namespaces
using System;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
#endregion

namespace IfcSpaceZoneBoundaries
{
  class App : IExternalDBApplication
  {
    public ExternalDBApplicationResult OnStartup( 
      ControlledApplication a )
    {
      a.ApplicationInitialized += OnApplicationInitialized;
      return ExternalDBApplicationResult.Succeeded;
    }

    private void OnApplicationInitialized( 
      object sender, 
      ApplicationInitializedEventArgs e )
    {
      throw new NotImplementedException();
    }

    public ExternalDBApplicationResult OnShutdown( 
      ControlledApplication a )
    {
      return ExternalDBApplicationResult.Succeeded;
    }
  }
}
