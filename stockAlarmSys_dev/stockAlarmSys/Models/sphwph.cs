using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class sphwph
    {
        public string spid { get; set; }
        public string hw { get; set; }
        public string pihao { get; set; }
        public string baozhiqi { get; set; }
        public string dangqzht { get; set; }
        public Nullable<decimal> shl { get; set; }
        public Nullable<decimal> gebjj { get; set; }
        public string miejph { get; set; }
        public string sxrq { get; set; }
        public string yanghriqi { get; set; }
        public Nullable<decimal> xsshl { get; set; }
        public Nullable<decimal> Bkxshl { get; set; }
        public Nullable<decimal> ykpshl { get; set; }
        public Nullable<decimal> bukxshl { get; set; }
        public string jwh { get; set; }
        public Nullable<System.DateTime> lastModifyTime { get; set; }
        public Nullable<System.DateTime> uploadTime { get; set; }
    }
}
