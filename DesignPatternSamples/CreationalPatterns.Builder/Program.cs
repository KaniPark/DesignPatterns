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
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            AbstractCar     _car        = new Saloon(new StandardEngine(1300));
            VehicleBuilder  _builder    = new CarBuilder(_car);
            VehicleDirector _director   = new CarDirector();
            IVehicle        _vehicle    = _director.Build(_builder);

            Console.WriteLine(_vehicle);
            Console.Read();
        }
    }
}
