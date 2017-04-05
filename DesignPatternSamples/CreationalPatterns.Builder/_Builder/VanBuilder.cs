using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattens.Data;

namespace CreationalPatterns.Builder
{
    /// <summary>
    /// 
    /// </summary>
    public class VanBuilder : VehicleBuilder
    {
        AbstractVan _vanInProgress;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="van"></param>
        public VanBuilder(AbstractVan van)
        {
            _vanInProgress = van;
        }

        /// <summary>
        /// 
        /// </summary>
        public override IVehicle Vehicle
        {
            get
            {
                return _vanInProgress;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildBody()
        {
            base.BuildBody();
            Console.WriteLine("BuildBody");
        }
        
        /// <summary>
        /// 
        /// </summary>
        public override void BuildChassis()
        {
            base.BuildChassis();
            Console.WriteLine("BuildChassis");
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildPassengerArea()
        {
            base.BuildPassengerArea();
            Console.WriteLine("BuildPassengerArea");
        }

        /// <summary>
        /// 
        /// </summary>
        public override void BuildWindows()
        {
            base.BuildWindows();
            Console.WriteLine("BuildWindows");
        }
    }
}
