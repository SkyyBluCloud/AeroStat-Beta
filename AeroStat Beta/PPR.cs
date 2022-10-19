namespace AeroStat_Beta
{
    public class PPR
    {
        public string? dvCode { get; set; } = null;
        public List<Traffic>? trafficStrips { get; set; }
        public PPRStatus status { get; set; } = PPRStatus.Approved;
        public List<PPRService>? services { get; set; }
        public enum PPRStatus
        {
            Completed,
            Approved,
            Pending,
            Cancelled
        }
        public Guid id { get; set; }
        public Guid certifierID { get; set; }
        public string? pprNumber { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime lastUpdate { get; set; }
        public string? lastUser { get; set; }
        public long spID { get; set; }
        public string Callsign { get; set; }
        public string Type { get; set; }
        public string Tail { get; set; }
        public string depPoint { get; set; }
        public DateTime arrdate { get; set; }
        public DateTime depdate { get; set; }
        public string Destination { get; set; }
        public string Spot { get; set; }
        public string Fuel { get; set; }
        public string Services { get; set; }
        public string Remarks { get; set; }
        public string crew { get; set; }
        public long paxOn { get; set; }
        public long paxOff { get; set; }
        public long cargoOn { get; set; }
        public long cargoOff { get; set; }
        public string unit { get; set; }
        public string pocName { get; set; }
        public string ctcInfo { get; set; }
        public string AMOPS { get; set; }
        public string TA { get; set; }
        public string Protocol { get; set; }
        public long approval { get; set; }
        public string MSN { get; set; }
        public bool archive { get; set; }
    }
}
