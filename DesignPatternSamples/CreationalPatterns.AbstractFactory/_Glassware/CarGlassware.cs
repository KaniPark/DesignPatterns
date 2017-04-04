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
    public class CarGlassware : IGlassware
    {
        /// <summary>
        /// 
        /// </summary>
        public CarGlassware()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string GlasswareParts
        {
            get
            {
                return "Car Glassware Part";
            }
        }
    }
}
