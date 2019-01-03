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
        /// Set the Parmaters for a DED process
        /// </summary>
        /// <param name="travelSpeed">DED process travel speed override (mm/s)</param>
        /// <param name="materialFlow">DED process material flow rate (mm/s)</param>
        /// <returns name="Action">DED ParametesTo Action</returns>
        public static MAction DEDParametersTo(double travelSpeed = 8, double materialFlow = 11) =>
            new ActionDEDParmaters(travelSpeed, materialFlow);

    }
}
