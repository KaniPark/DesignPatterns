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
    public class CarBody : IBody
    {
        /// <summary>
        /// 
        /// </summary>
        public CarBody()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public string BodyParts
        {
            get
            {
                return "Car Body Parts";
            }
        }
    }
}
