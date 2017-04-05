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
    public class StandardEngine : AbstractEngine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public StandardEngine(int size)
            : base(size, false)
        {
        }
    }
}
