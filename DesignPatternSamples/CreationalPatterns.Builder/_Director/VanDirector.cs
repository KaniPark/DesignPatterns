using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattens.Data;

namespace CreationalPatterns.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public class VanDirector : VehicleDirector
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChassis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}
