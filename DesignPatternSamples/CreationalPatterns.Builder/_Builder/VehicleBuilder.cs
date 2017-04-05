using DesignPattens.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class VehicleBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract IVehicle Vehicle
        {
            get;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BuildBody()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BuildBoot()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BuildChassis()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BuildPassengerArea()
        {
        }


        /// <summary>
        /// 
        /// </summary>
        public virtual void BuildReinforcedStorageArea()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void BuildWindows()
        {
        }
    }
}
