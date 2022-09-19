namespace AeroStat_Beta
{
    public class Apron : ISurface
    {
        public long id { get; set; }
        public string rampName { get; set; }
        public string rampPrefix { get; set; }
        public long rows { get; set; }
        public bool latinRows { get; set; }
        public long spots { get; set; }
        public bool latinSpots { get; set; }
        public long MOG { get; set; }
    }
}
