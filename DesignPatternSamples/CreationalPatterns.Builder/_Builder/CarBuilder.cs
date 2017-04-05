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
    public class CarBuilder : VehicleBuilder
    {
        AbstractCar _carInProgress;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="car"></param>
        public CarBuilder(AbstractCar car)
        {
            _carInProgress = car;
        }

        /// <summary>
        /// 
        /// </summary>
        public override IVehicle Vehicle
        {
            get
            {
                return _carInProgress;
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
        public override void BuildBoot()
        {
            base.BuildBoot();
            Console.WriteLine("BuildBoot");
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
