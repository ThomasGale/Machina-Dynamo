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
    //  ████████╗██████╗  █████╗ ███╗   ██╗███████╗███████╗ ██████╗ ██████╗ ███╗   ███╗
    //  ╚══██╔══╝██╔══██╗██╔══██╗████╗  ██║██╔════╝██╔════╝██╔═══██╗██╔══██╗████╗ ████║
    //     ██║   ██████╔╝███████║██╔██╗ ██║███████╗█████╗  ██║   ██║██████╔╝██╔████╔██║
    //     ██║   ██╔══██╗██╔══██║██║╚██╗██║╚════██║██╔══╝  ██║   ██║██╔══██╗██║╚██╔╝██║
    //     ██║   ██║  ██║██║  ██║██║ ╚████║███████║██║     ╚██████╔╝██║  ██║██║ ╚═╝ ██║
    //     ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚══════╝╚═╝      ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝
    //                                                                                 
    partial class Actions
    {
        /// <summary>
        /// Performs a compound absolute transformation to target Plane. The device's new absolute position and orientation will be those of the Plane.
        /// </summary>
        /// <param name="plane">Target Plane to transform to</param>
        /// <param name="cf1">Config 1</param>
        /// <param name="cf4">Config 4</param>
        /// <param name="cf6">Config 6</param>
        /// <param name="cfx">Config X</param>
        /// <returns>Transform Action</returns>
        public static MAction SolvedTransformTo(Plane plane, int cf1 = 0, int cf4 = 0, int cf6 = 0, int cfx = 0) =>
            new ActionSolvedTransformation(
                plane.Origin.X, plane.Origin.Y, plane.Origin.Z,
                plane.XAxis.X, plane.XAxis.Y, plane.XAxis.Z, 
                plane.YAxis.X, plane.YAxis.Y, plane.YAxis.Z,
                cf1, cf4, cf6, cfx);

    }
}
