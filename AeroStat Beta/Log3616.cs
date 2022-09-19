namespace AeroStat_Beta
{
    public class Log3616
    {
        public Log3616 (Shift _shift, User _createdBy)
        {
            shift = _shift;
            createdBy = _createdBy;
        }
        public class Entry
        {
            public Entry(string _text, User _user)
            {
                text = _text;
                user = _user;
            }
                
            public string text { get; set; }
            public DateTime time { get; set; } = DateTime.Now;
            public User user { get; set; }
            public bool archive { get; set; } = false;
            public User? archiveBy { get; set; }
            public DateTime? archiveTime { get; set; }
        }
        public long id { get; set; }
        public Shift shift { get; set; }
        public long certifierid { get; set; } = 0;
        public DateTime dateCreated { get; set; } = DateTime.Now;
        public User createdBy { get; set; }
        public bool archive { get; set; } = false;
        public string? archiveBy { get; set; }
        public DateTime? archivetime { get; set; }
        public List<Entry>? entry { get; set; }
    }
}
