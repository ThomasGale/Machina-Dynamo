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
    //   █████╗ ████████╗████████╗ █████╗  ██████╗██╗  ██╗████████╗ ██████╗  ██████╗ ██╗     
    //  ██╔══██╗╚══██╔══╝╚══██╔══╝██╔══██╗██╔════╝██║  ██║╚══██╔══╝██╔═══██╗██╔═══██╗██║     
    //  ███████║   ██║      ██║   ███████║██║     ███████║   ██║   ██║   ██║██║   ██║██║     
    //  ██╔══██║   ██║      ██║   ██╔══██║██║     ██╔══██║   ██║   ██║   ██║██║   ██║██║     
    //  ██║  ██║   ██║      ██║   ██║  ██║╚██████╗██║  ██║   ██║   ╚██████╔╝╚██████╔╝███████╗
    //  ╚═╝  ╚═╝   ╚═╝      ╚═╝   ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝  ╚═════╝ ╚══════╝
    //                                                                           
    partial class Actions
    {
        /// <summary>
        /// Simply set the workplane reference used for subsequent linear/joint motions in cartensian space
        /// </summary>
        /// <param name="workplaneName">The name of the referenced workplane (linear/joint motions in cartensian space will be with respect to this workplane).</param>
        /// <returns name="Action">SetToolRef Action</returns>
        public static MAction SetWorkplaneRef(string workplaneName)
        {
            if (workplaneName == "")
            {
                DynamoServices.LogWarningMessageEvents.OnLogWarningMessage("No workplane name specified...");
                return null;
            }
            return new ActionSetWorkplaneRef(workplaneName);
        } 

    }
}
