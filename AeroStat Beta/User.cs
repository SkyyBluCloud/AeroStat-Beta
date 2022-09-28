namespace AeroStat_Beta
{
    public class User
    {
        public long id { get; set; }
        public long spID { get; set; }
        public string opInitials { get; set; }
        public string? username { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string fullName3616
        {
            get
            {
                var output = $"{firstName[..1]}. {lastName}/{opInitials}".ToUpper();
                return output;
            }
        }
        public string certName
        {
            get
            {
                var output = $"{firstName}.{lastName}.{username}".ToUpper();
                return output;
            }
        }
        public string? unit { get; set; }
        public long rankID { get; set; }
        public bool approved { get; set; }
        public DateTime lastLogin { get; set; }
        public string? lastSystem { get; set; }
        public long lastShift { get; set; }
        public bool onShift { get; set; }
        public bool isLoggedIn { get; set; }
        public long authLevel { get; set; }
        public bool spAccess { get; set; }
        public bool BOOT { get; set; }
        public bool RS { get; set; }
        public bool kiosk { get; set; }
    }
}
