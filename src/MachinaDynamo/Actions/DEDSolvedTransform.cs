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
        /// DED process, performs a compound absolute solved transformation to target Plane. The device's new absolute position and orientation will be those of the plane. The specified config will be used at this point. 
        /// </summary>
        /// <param name="plane">Target Plane to transform to</param>
        /// <param name="mode">DED motion mode (Start = 0, Mid = 1 (default), End = 2)</param>
        /// <param name="cf1"></param>
        /// <param name="cf4"></param>
        /// <param name="cf6"></param>
        /// <param name="cfx"></param>
        /// <returns name="Action">DED Action</returns>
        public static MAction DEDSolvedTransformTo(Plane plane, int mode = 1, int cf1 = 0, int cf4 = 0, int cf6 = 0, int cfx = 0) =>
            new ActionDEDSolvedTransform(
                plane.Origin.X, plane.Origin.Y, plane.Origin.Z,
                plane.XAxis.X, plane.XAxis.Y, plane.XAxis.Z, 
                plane.YAxis.X, plane.YAxis.Y, plane.YAxis.Z,
                cf1, cf4, cf6, cfx, (ActionDEDSolvedTransform.DEDMode)mode);

    }
}
