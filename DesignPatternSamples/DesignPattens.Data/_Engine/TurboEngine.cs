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
    public class TurboEngine : AbstractEngine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        public TurboEngine(int size)
            : base(size, true)
        {
        }
    }
}
