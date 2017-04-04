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
    public class VanGlassware : IGlassware
    {
        /// <summary>
        /// 
        /// </summary>
        public VanGlassware()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string GlasswareParts
        {
            get
            {
                return "Van Glassware Part";
            }
        }
    }
}
