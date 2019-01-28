# IfcSpaceZoneBoundaries

Revit C# .NET add-in to retrieve IFC spaces and zones and their boundaries.

Once tested and running, this add-in will be re-implemented as
a [Forge Design Automation for Revit](https://thebuildingcoder.typepad.com/blog/2018/11/forge-design-automation-for-revit-at-au-and-in-public.html) app
for use in the [final workflow](#workflow) described below.

As described
by [The Building Coder](https://thebuildingcoder.typepad.com) discussing
how to [retrieve linked `IfcZone` elements using Python](https://thebuildingcoder.typepad.com/blog/2019/01/retrieving-linked-ifczone-elements-using-python.html),
IFC rooms and zones are represented by `DirectShape` elements equipped with custom shared parameters.
These elements are generated when an IFC file is linked into a Revit project, however not when it is imported.

IfcSpaceZoneBoundaries retrieves the IFC rooms and zone elements generated by linking in an IFC file and exports a CSV file listing them, their relationships and boundaries as described below.

## Room and Zone Properties

Room properties:

- IfcExportAs = IfcSpace.INTERNAL
- IfcGUID = 2QZ$T4_uPCWPddxgtStT47
- IfcName = CHA
- IfcPresentationLayer = M-AREA-____-OTLN
- IfcPropertySetList = "Pset_SpaceCommon";"BI_Parameters";"BaseQuantities"
- IfcZone = APT0102

Zone properties:

- IfcExportAs = IfcZone
- IfcGUID = 2QZ$2QZ$T4_uPCWPddxgtStT7A
- IfcName = APT0102
- IfcPresentationLayer = 
- IfcPropertySetList = "Pset_ZoneCommon";"BI_Parameters"
- IfcZone = 

## CSV Export File Format

CSV file format:

- Space or Zone
- GUID
- Name
- Zone
- Layer
- Property set
- Elevation Z coordinate
- List of space separated boundary point XY coordinates in millimetres

CSV example for the room and zone properties listed above:

    S,2QZ$T4_uPCWPddxgtStT47,CHA,APT0102,M-AREA-____-OTLN,"Pset_SpaceCommon";"BI_Parameters";"BaseQuantities",5800,664 -3532 664 -7080 3631 -7080 3631 -6073 4161 -6073 4161 -3532
    Z,2QZ$T4_uPCWPddxgtStT7A,APT0102,,,"Pset_ZoneCommon";"BI_Parameters",5800,6874 3932 6874 4417 6374 4417 6374 5167 4499 5167 4499 3932

## <a name="workflow"></a>Sample Workflow

- The Design Automation for Revit or *DA4R* app IfcSpaceZoneBoundaries is launched with an IFC file X to process plus a command file specifying configuration settings.
- IfcSpaceZoneBoundaries creates a new blank Revit project Y.
- X is linked into Y to generate the room and zone objects.
- The resulting model is processed to obtain and export the data described above to an output CSV file Z.
- Z is available from Forge.

## <a name="todo"></a>To Do

- Implement creation of new RVT from scratch and linking in IFC file
- Convert to DA4R


## Author

Jeremy Tammik,
[The Building Coder](http://thebuildingcoder.typepad.com),
[Forge](http://forge.autodesk.com) [Platform](https://developer.autodesk.com) Development,
[ADN](http://www.autodesk.com/adn)
[Open](http://www.autodesk.com/adnopen),
[Autodesk Inc.](http://www.autodesk.com)


## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT).
Please see the [LICENSE](LICENSE) file for full details.
