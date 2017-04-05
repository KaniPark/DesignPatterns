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
    public class BoxVan : AbstractVan
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        public BoxVan(IEngine engine)
            : base(engine)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="color"></param>
        public BoxVan(IEngine engine, VehicleColor color)
            : base(engine, color)
        {
        }
    }
}
