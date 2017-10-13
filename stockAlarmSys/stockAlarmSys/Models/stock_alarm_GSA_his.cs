using System;
using System.Collections.Generic;

namespace stockAlarmSys.Models
{
    public partial class stock_alarm_GSA_his
    {
        //public  stock_alarm_GSA_his(stock_alarm_GSA model)
        //{
        //    ID = model.ID;
        //}
        public int IDS { get; set; }
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
        public int saledIn1Month { get; set; }
        public int saledIn7Days { get; set; }
        public System.DateTime lastCalcuDate { get; set; }
        public int alarmSpan { get; set; }
        public int amount_static { get; set; }
        public int ordering_cycle { get; set; }
        public int delivery_cycle { get; set; }
        public int restock_count { get; set; }
        public int safty_days { get; set; }
        public int stock_transit { get; set; }
    }
}
