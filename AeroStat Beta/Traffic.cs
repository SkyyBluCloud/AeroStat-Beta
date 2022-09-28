using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroStat_Beta
{
    public class Traffic
    {
        public enum Direction
        {
            IN,
            OUT,
            INOUT
        }
        public DateTime entryDate { get; set; }
        public Shift shift { get; set; }
        public long id { get; set; }
        public long certifierID { get; set; } = 0;
        public PPR? ppr { get; set; }
        public User user { get; set; }
        public string callsign { get; set; }
        public long number { get; set; } = 1;
        public string acType { get; set; }
        public string status { get; set; }
        public string flightRule { get; set; }
        public string depPoint { get; set; }
        public string destination { get; set; }        
        public long fpType { get; set; }
        public DateOnly dof { get; set; }
        public TimeOnly etd { get; set; }
        public TimeOnly ete { get; set; }
        public TimeOnly eta { get; set; }
        public TimeOnly atd { get; set; }
        public TimeOnly ata { get; set; }
        public string? spot { get; set; }
        public long altitude { get; set; }
        public string? tail { get; set; }
        public long rwy { get; set; }
        public string remarks { get; set; }


    }
}
