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
    public class VanBody : IBody
    {
        public VanBody()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string BodyParts
        {
            get
            {
                return "Van Body Part";
            }
        }
    }
}
