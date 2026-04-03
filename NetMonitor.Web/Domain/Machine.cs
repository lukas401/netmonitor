namespace NetMonitor.Web.Domain
{
    public class Machine
    {
        public int Id { get; set; }

        //puxa referencias do AD
        public string HostnameAd { get; set; } = string.Empty;
        public string IpAd { get; set; } = string.Empty;
        public string? MacAddress { get; set; }
        public string? DepartmentOu { get; set; }

        public MachineStatus status { get; set; } = MachineStatus.Unknown;
        public long? LastLatencyMS { get; set; }
        public DateTime? LastSeenOnline { get; set; }
        public DateTime? LastCheckedAt { get; set; }

        public string? LastHostnameReal { get; set; }
        public bool HasDnsConflict { get; set; }
        public string? ConflictDetail { get; set; }

        public ICollection<PingResult> PingHistory { get; set; } = [];
    }
}