using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class alarm_mailaddr
    {
        public int ID { get; set; }
        public string mailAddress { get; set; }
        public string notice { get; set; }
        public string senderAddr { get; set; }
        public string senderName { get; set; }
        public string subject { get; set; }
        public string fileBasePath { get; set; }
        public bool sendFile { get; set; }
        public string SMTPHost { get; set; }
        public string SMTPPuser { get; set; }
        public string SMTPPass { get; set; }
        public string mailBody { get; set; }
        public string toer { get; set; }
        public bool IsDeleted { get; set; }
        public int sendTimeSpan { get; set; }
        public System.DateTime lastSendDate { get; set; }
    }
}
