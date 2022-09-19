namespace AeroStat_Beta
{
    public class Spot : ISurface
    {
        public long id { get; set; }
        public string spotName { get; set; }
        public bool occupied { get; set; }
    }
}
