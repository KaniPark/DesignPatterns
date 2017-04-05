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
    public class Sport : AbstractCar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        public Sport(IEngine engine)
            : base(engine)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="color"></param>
        public Sport(IEngine engine, VehicleColor color)
            : base(engine, color)
        {
        }
    }
}
