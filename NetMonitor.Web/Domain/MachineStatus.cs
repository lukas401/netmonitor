using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMonitor.Web.Domain
{
    public enum MachineStatus
    {
        Unknown = 0,
        Online = 1,
        Offline = 2,
        conflict = 3
    }
}