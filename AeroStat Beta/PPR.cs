﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroStat_Beta
{
    public class PPR
    {
        public enum PPRStatus
        {
            Completed,
            Approved,
            Pending,
            Cancelled
        }

        public int id { get; set; }
        public string callsign { get; set; }
        public string ppr { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime lastUpdate { get; set; } = DateTime.Now;
        public string? lastUpdateUser { get; set; }
        public string acType { get; set; }
        public string tail { get; set; }
        public string depPoint { get; set; }
        public string destination { get; set; }
        public string spot { get; set; }
        public string fuel { get; set; }
        public List<int> services { get; set; }
        public string remarks { get; set; }
        public string paxUnit { get; set; }
        public int paxOn { get; set; }
        public int paxOff { get; set; }
        public string cargoUnit { get; set; }
        public int cargoOn { get; set; }
        public int cargoOff { get; set; }
        public string pocName { get; set; }
        public string pocUnit { get; set; }
        public string pocContact { get; set; }
        public PPRStatus status { get; set; } = PPRStatus.Approved;
        public string? dvCode { get; set; } = null;
        public List<Traffic>? trafficStrips { get; set; }
    }
}
