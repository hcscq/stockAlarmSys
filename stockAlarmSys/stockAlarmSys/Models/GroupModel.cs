using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockAlarmSys.Models
{
    class GroupModel
    {
        public alarmAddr_realations main { get; set; }
        public List<alarmAddr_realationsD> detials { get; set; }
    }
}
