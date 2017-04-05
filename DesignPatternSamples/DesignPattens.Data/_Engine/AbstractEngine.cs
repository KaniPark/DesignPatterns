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
    public abstract class AbstractEngine : IEngine
    {
        int     _size;
        bool    _turbo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        /// <param name="turbo"></param>
        public AbstractEngine(int size, bool turbo)
        {
            _size   = size;
            _turbo  = turbo;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual int Size { get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool Turbo { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetType().Name + " (" + _size + ") ";
        }
    }
}
