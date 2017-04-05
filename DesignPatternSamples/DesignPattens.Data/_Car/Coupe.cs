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
    public class Coupe : AbstractCar
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        public Coupe(IEngine engine)
            : base(engine)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="color"></param>
        public Coupe(IEngine engine, VehicleColor color)
            : base(engine, color)
        {
        }
    }
}
