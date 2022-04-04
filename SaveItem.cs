using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERSaveManager
{
    public class SaveItem
    {
        public string SteamID64 { get; set; }
        public string FileName { get; set; }
        public string InitData { get; set; }
        public List<Record> Slots { get; set; } = new List<Record>();

        public class Record
        {
            public long Timestamp { get; set; }
            public string Title { get; set; }
            public string Cover { get; set; }
            public string Data { get; set; }
            public string Hash { get; set; }
        }
    }
}
