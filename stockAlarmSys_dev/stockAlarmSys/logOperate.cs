using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace stockAlarmSys
{
    class logOperate
    {
        public void writeLog( string fileName,string msg,string folderName="Log")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AppDomain.CurrentDomain.BaseDirectory).Append(folderName).Append("\\").Append(DateTime.Now.ToString("yyyy-MM-dd")).Append("\\");
            string file = sb.ToString();
            if (!Directory.Exists(file))
                Directory.CreateDirectory(file);
            sb.Append(fileName);
            if (!File.Exists(sb.ToString()))
                File.Create(sb.ToString());
            
            StreamWriter sw = File.AppendText(sb.ToString());
            sw.WriteLine(msg);
            
            sw.Close();
            return;
        }
    }
}
