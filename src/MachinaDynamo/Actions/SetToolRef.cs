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
        /// Simply set the tool reference used for subsequent linear/joint motions in cartensian space
        /// </summary>
        /// <param name="toolName">The name of the referenced Tool which is already attached to the Robot flange.</param>
        /// <returns name="Action">SetToolRef Action</returns>
        public static MAction SetToolRef(string toolName)
        {
            if (toolName == "")
            {
                DynamoServices.LogWarningMessageEvents.OnLogWarningMessage("No tool name specified...");
                return null;
            }
            return new ActionSetToolRef(toolName);
        } 

    }
}
