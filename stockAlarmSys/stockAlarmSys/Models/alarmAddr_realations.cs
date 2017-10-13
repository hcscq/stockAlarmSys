using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class alarmAddr_realations
    {
        public int addr_Id_Main { get; set; }
        
        public int relation_Type { get; set; }
        public Guid guid { get; set; }
        public string show_Name { get; set; }
    }
}
