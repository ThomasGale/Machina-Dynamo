using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.DesignScript.Runtime;
using Autodesk.DesignScript.Interfaces;
using Autodesk.DesignScript.Geometry;

using Machina;
using MAction = Machina.Action;
using MPoint = Machina.Point;
using MVector = Machina.Vector;
using MOrientation = Machina.Orientation;
using MTool = Machina.Tool;
using System.IO;


namespace MachinaDynamo
{
    //  ██████╗ ███████╗██████╗ 
    //  ██╔══██╗██╔════╝██╔══██╗
    //  ██║  ██║█████╗  ██║  ██║
    //  ██║  ██║██╔══╝  ██║  ██║
    //  ██████╔╝███████╗██████╔╝
    //  ╚═════╝ ╚══════╝╚═════╝                                                                              
    partial class Actions
    {
        /// <summary>
        /// DED process, performs a compound absolute transformation to target Plane. The device's new absolute position and orientation will be those of the Plane.
        /// </summary>
        /// <param name="plane">Target Plane to transform to</param>
        /// <param name="mode">DED motion mode (Start = 0, Mid = 1 (default), End = 2)</param>
        /// <returns name="Action">DED Action</returns>
        public static MAction DEDTo(Plane plane, int mode = 1) =>
            new ActionDED(
                (ActionDED.DEDMode)mode,
                plane.Origin.X, plane.Origin.Y, plane.Origin.Z,
                plane.XAxis.X, plane.XAxis.Y, plane.XAxis.Z, 
                plane.YAxis.X, plane.YAxis.Y, plane.YAxis.Z);

    }
}
