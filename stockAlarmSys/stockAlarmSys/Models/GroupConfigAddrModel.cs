using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockAlarmSys.Models
{
    class GroupConfigAddrModel
    {
        public int Id { get; set; }
        public string addr { get; set; }
        public bool bol_selected{ get; set; }
        public bool bol_mainAddr { get; set; }
        public bool bol_copy { get; set; }
    }
}
