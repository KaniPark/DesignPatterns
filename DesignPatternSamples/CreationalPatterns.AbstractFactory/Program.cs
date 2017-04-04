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
    class Program
    {
        /// <summary>
        /// Provide an interface for creating families of related or dependent objects without specifying thier concrete classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var _carFactory = new CarFactory();

            var _carBody        = _carFactory.CreateBody();
            var _carChassis     = _carFactory.CreateChassis();
            var _carGlassware   = _carFactory.CreateGlassware();

            Console.WriteLine("CAR FACTORY");

            Console.WriteLine(_carBody.BodyParts);
            Console.WriteLine(_carChassis.ChassisParts);
            Console.WriteLine(_carGlassware.GlasswareParts);

            var _vanFactory = new VanFactory();

            var _vanBody        = _vanFactory.CreateBody();
            var _vanChassis     = _vanFactory.CreateChassis();
            var _vanGlassware   = _vanFactory.CreateGlassware();

            Console.WriteLine("VAN FACTORY");

            Console.WriteLine(_vanBody.BodyParts);
            Console.WriteLine(_vanChassis.ChassisParts);
            Console.WriteLine(_vanGlassware.GlasswareParts);

            Console.Read();
        }
    }
}
