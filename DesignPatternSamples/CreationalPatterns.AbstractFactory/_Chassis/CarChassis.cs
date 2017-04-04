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
    public class CarChassis : IChassis
    {
        /// <summary>
        /// 
        /// </summary>
        public CarChassis()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string ChassisParts
        {
            get
            {
                return "Car Chassis Part";
            }
        }
    }
}
