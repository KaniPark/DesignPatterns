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
    public class CarFactory : AbstractVehicleFactory
    {
        /// <summary>
        /// 
        /// </summary>
        public CarFactory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }
}
