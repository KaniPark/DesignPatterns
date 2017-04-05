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
    public class Saloon : AbstractCar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        public Saloon(IEngine engine)
            : base(engine)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="color"></param>
        public Saloon(IEngine engine, VehicleColor color)
            : base(engine, color)
        {
        }
    }
}
