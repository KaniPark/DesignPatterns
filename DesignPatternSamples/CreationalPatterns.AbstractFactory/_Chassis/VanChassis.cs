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
    public class VanChassis : IChassis
    {
        /// <summary>
        /// 
        /// </summary>
        public VanChassis()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string ChassisParts
        {
            get
            {
                return "Van Chassis Part";
            }
        }
    }
}
