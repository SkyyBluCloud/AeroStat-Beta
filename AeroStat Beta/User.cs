namespace AeroStat_Beta
{
    public class User
    {
        public long ID { get; set; }
        public long spID { get; set; }
        public string opInitials { get; set; }
        public string username { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string unit { get; set; }

        internal User getCurrentUser()
        {
            throw new NotImplementedException();
        }

        public long rankID { get; set; }
        public bool approved { get; set; }
        public DateTime lastLogin { get; set; }
        public string lastSystem { get; set; }
        public long lastShift { get; set; }
        public bool onShift { get; set; }
        public bool isLoggedIn { get; set; }
        public int authLevel { get; set; }
        public bool spAccess { get; set; }
        public bool BOOT { get; set; }
        public bool RS { get; set; }
        public bool kiosk { get; set; }
    }
}
