using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.AbstractFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class VanFactory : AbstractVehicleFactory 
    {
        /// <summary>
        /// 
        /// </summary>
        public VanFactory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IBody CreateBody()
        {
            return new VanBody();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
