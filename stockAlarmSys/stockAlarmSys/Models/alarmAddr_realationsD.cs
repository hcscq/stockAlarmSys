using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class alarmAddr_realationsD
    {

        public int addr_Id_attached { get; set; }
        public Guid guid { get; set; }
        public bool bol_copy { get; set; }

    }
}
