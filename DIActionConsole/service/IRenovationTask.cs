using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIActionConsole.service
{
    /// <summary>
    /// 裝修 interface
    /// </summary>
    public interface IRenovationTask
    {
        string Description { get; }
        void Execute(string taskDescription);
    }
}
