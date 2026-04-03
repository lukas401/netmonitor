using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetMonitor.Web.Domain
{
    public class PingResult
    {
        public int ID {get; set;}
        public int MachineId {get; set;}

        public bool IsOnline {get; set;}
        public long? LatencyMs {get;set;}
        public string IpUsed {get; set;} = string.Empty;
        public string RawStatus {get; set;} = string.Empty;
        public string? HostnameReal {get; set;}
        public bool IdentityVerified {get; set;}

        public DateTime checkedAt {get; set;} = DateTime.UtcNow;
        public Machine Machine { get; set; } = null!;
    }
}