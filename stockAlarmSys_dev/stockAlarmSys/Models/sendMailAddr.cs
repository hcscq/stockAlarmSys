using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class sendMailAddr
    {
        public int ID { get; set; }
        public tag_terminal from;// { get; set; }
        public List<tag_terminal> list_Toer;// { get; set; }
        public string subject { get; set; }
        public string fileBasePath { get; set; }
        public List<string> list_files { get; set; }
        public bool sendFile { get; set; }
        public string SMTPHost { get; set; }
        public string SMTPPuser { get; set; }
        public string SMTPPass { get; set; }
        public string mailBody { get; set; }
        public int sendTimeSpan { get; set; }
    }
}
