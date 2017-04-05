using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class AbstractVan : AbstractVehicle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        public AbstractVan(IEngine engine)
            : base (engine)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="color"></param>
        public AbstractVan(IEngine engine, VehicleColor color)
            : base(engine, color)
        {
        }
    }
}
