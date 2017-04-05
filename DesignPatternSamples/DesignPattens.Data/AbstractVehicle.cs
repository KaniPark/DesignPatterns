using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Data
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractVehicle : IVehicle
    {
        IEngine         _engine;
        VehicleColor    _color;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        public AbstractVehicle(IEngine engine)
            : this(engine, VehicleColor.Unpainted)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="engine"></param>
        /// <param name="color"></param>
        public AbstractVehicle(IEngine engine, VehicleColor color)
        {
            _engine = engine;
            _color  = color;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual IEngine Engine
        {
            get
            {
                return _engine;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual VehicleColor Color
        {
            get
            {
                return _color;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public virtual void Paint(VehicleColor color)
        {
            _color = color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetType().Name + " (" + _engine + ", " + _color + ") ";
        }
    }
}
