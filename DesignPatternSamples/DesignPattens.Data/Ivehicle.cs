﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Data
{
    /// <summary>
    /// 
    /// </summary>
    public interface IVehicle
    {
        /// <summary>
        /// 
        /// </summary>
        IEngine Engine { get; }

        /// <summary>
        /// 
        /// </summary>
        VehicleColor Color { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        void Paint(VehicleColor color);
    }
}
