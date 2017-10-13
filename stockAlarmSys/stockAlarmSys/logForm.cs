using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace stockAlarmSys
{
    public partial class logForm : Form
    {
        public logForm(string fileName , string folderName = "Log")
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AppDomain.CurrentDomain.BaseDirectory).Append(folderName).Append("\\").Append(DateTime.Now.ToString("yyyy-MM-dd")).Append("\\");
            string file = sb.ToString();
            if (!Directory.Exists(file))
                Directory.CreateDirectory(file);
            sb.Append(fileName);
            if (!File.Exists(sb.ToString())) 
                File.Create(sb.ToString()).Close();
            //string file = sb.ToString();
            //if (!Directory.Exists(file))
            //    Directory.CreateDirectory(file);
            
            InitializeComponent();
            tb_log.Enabled = false;
            try {
                tb_log.Text = File.ReadAllText(sb.ToString());
            }
            catch (Exception e1)
            {
                MessageBox.Show("Read file failed !"+e1.Message,"提示");
                Close();
                return;
            }
            

        }
    }
}
