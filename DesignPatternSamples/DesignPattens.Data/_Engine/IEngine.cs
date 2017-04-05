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
    public interface IEngine
    {
        /// <summary>
        /// 
        /// </summary>
        int Size { get; }

        /// <summary>
        /// 
        /// </summary>
        bool Turbo { get; }
    }
}
