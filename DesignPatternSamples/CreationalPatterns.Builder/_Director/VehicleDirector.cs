using DesignPattens.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VehicleDirector
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
