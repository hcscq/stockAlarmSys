using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class stock_alarm_GSA
    {
        public int ID { get; set; }
        public string spid { get; set; }
        public string spbh { get; set; }
        public string hw { get; set; }
        public string spmch { get; set; }
        public int alarm_type { get; set; }
        public int threshold_value { get; set; }
        public System.DateTime add_date { get; set; }
        public int stock_5DLatter { get; set; }
        public System.DateTime last_alarmDate { get; set; }
        public string notice { get; set; }
        public int alarm_state { get; set; }
        public int saledIn2Month { get; set; }
        public int saledIn1Month { get; set; }
        public System.DateTime lastCalcuDate { get; set; }
        public int alarmSpan { get; set; }
    }
}