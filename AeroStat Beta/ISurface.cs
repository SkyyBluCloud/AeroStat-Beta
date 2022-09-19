namespace AeroStat_Beta
{
    internal interface ISurface
    {
        public enum Status
        {
            OPS_NORM,
            OPS_SUSP,
            DEG,
            LTD,
            CLSD
        }
        public enum Type
        { 
            MISC,
            RWY,
            TWY,
            APRON,
            SVCRD,
            SPOT,
            MISC_ACFT
        }
        public long id { get; set; }
        public string sfcName { get; set; }
        public ISurface.Type sfcType { get; set; }
        public ISurface.Status status { get; set; }
        public string dimUnit { get; set; }
        public string massUnit { get; set; }
        public long length { get; set; }
        public long width { get; set; }
        public long pcn { get; set; }
        public string pavementType { get; set; }
        public long maxWeight { get; set; }
        public string equipment { get; set; }
    }
}
