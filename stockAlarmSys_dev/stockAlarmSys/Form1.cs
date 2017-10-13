using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stockAlarmSys.Models;
using System.Reflection;
using System.Net.Mail;
using System.Data.Entity;

namespace stockAlarmSys
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer = null;
        private string fileBasPath = AppDomain.CurrentDomain.BaseDirectory ;
        private string from = "zhuye@7lk.com";
        private string fromer = "库存预警系统";
        private string to = "zhuye@7lk.com";
        private string toer = "收件人";
        private string Subject = "商品库存预警-（{0}）";
        private string fileName = "商品库存预警-({0}).xlsx";
        private string file = "C:\\Users\\39438\\Desktop\\spkfk.txt";
        private string Body = "以下是今日系统预判未来五天后可能会出现缺货的商品（共{0}个商品），请查收；\r\n并在采购人员确认后进行补货 谢谢！";
        private string SMTPHost = "smtp.exmail.qq.com";
        private string SMTPuser = "zhuye@7lk.com";
        private string SMTPpass = "Qlk123456";
        private sendMail sendM;
        private int canEditRowIndex = -1;
        private static bool bol_alarming = false;
        private logOperate log_operate = new logOperate();
        private List<alarm_mailaddr> addr_List = new List<alarm_mailaddr>();
        private bool bol_running = false;
        private string logFile = "{0}_Log.txt";
        public Form1()
        {
            InitializeComponent();
            Inital();
            //dgv_addrList.ReadOnly = true;

        }
        /// <summary>
        /// 将泛类型集合List类转换成DataTable
        /// </summary>
        /// <param name="list">泛类型集合</param>
        /// <returns></returns>
        public static DataTable ListToDataTable<T>(List<T> entitys)
        {
            //检查实体集合不能为空
            if (entitys == null || entitys.Count < 1)
            {
                throw new Exception("需转换的集合为空");
            }
            //取出第一个实体的所有Propertie
            Type entityType = entitys[0].GetType();
            PropertyInfo[] entityProperties = entityType.GetProperties();

            //生成DataTable的structure
            //生产代码中，应将生成的DataTable结构Cache起来，此处略
            DataTable dt = new DataTable();
            for (int i = 0; i < entityProperties.Length; i++)
            {
                //dt.Columns.Add(entityProperties[i].Name, entityProperties[i].PropertyType);
                dt.Columns.Add(entityProperties[i].Name);
            }
            //将所有entity添加到DataTable中
            foreach (object entity in entitys)
            {
                //检查所有的的实体都为同一类型
                if (entity.GetType() != entityType)
                {
                    throw new Exception("要转换的集合元素类型不一致");
                }
                object[] entityValues = new object[entityProperties.Length];
                for (int i = 0; i < entityProperties.Length; i++)
                {
                    entityValues[i] = entityProperties[i].GetValue(entity, null);
                }
                dt.Rows.Add(entityValues);
            }
            return dt;
        }
        private void Inital()
        {

            dgv_addrList.MultiSelect = false;                                                                                                                                                                                     
            tb_senderPWD.PasswordChar = '*';
            btn_delAddress.Enabled = false;
            btn_alterAddress.Enabled = false;
            //tb_senderPWD.UseSystemPasswordChar = true;
            timer = new System.Timers.Timer((double)nud_checkSpan.Value * 1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timerPro);
            timer.AutoReset = true;
            sendM = new sendMail();
            //timer.Start();
            dgv_addrList.RowPostPaint += new DataGridViewRowPostPaintEventHandler(dgvRowRepaint);
            canEditRowIndex = 0;
            using (ksoaContext db=new ksoaContext ())
            {
                addr_List = (List<alarm_mailaddr>)(from q in db.alarm_MailAddr where q.IsDeleted == false select q).ToList();
                dgv_addrList.DataSource = addr_List;// (from q in db.alarm_MailAddr where q.IsDeleted==false   select q).ToList();
                dgv_addrList.Columns["ID"].ReadOnly = true;
                dgv_addrList.Columns["ID"].Visible = false;
                
            }
            dgv_addrList.SelectionChanged += new EventHandler(dgv_addrList_selectChanged);
            (btn_startWork).Text = bol_running ? "暂停" : "启动";

            if (!bol_running)
            {
                timer.Stop();
                nud_checkSpan.Enabled = true;
            }
            else { timer.Start(); nud_checkSpan.Enabled = false; }
            timerPro(null,null);

        }
        private void dgv_addrList_selectChanged(object sender,EventArgs args)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                alarm_mailaddr model = addr_List.Find(q => q.ID == int.Parse(dgv.SelectedRows[0].Cells["ID"].Value.ToString()));
                GetOrSetContext(ref model, false);
                btn_delAddress.Enabled = true;
            }
            else btn_delAddress.Enabled = false;

        }
        private bool GetOrSetContext(ref alarm_mailaddr model,bool get=true)
        {
            
            if (!get && model == null)
                throw new Exception("The input model is null.");
            if (get)
            {
                model = model == null ? (new alarm_mailaddr()) : model;
                model.ID = int.Parse(lb_ID.Text);

                model.mailAddress = tb_toAddr.Text.Trim();

                model.toer = tb_toer.Text.Trim();
                model.notice = tb_notice.Text.Trim();

                model.senderAddr = tb_sendAddr.Text.Trim();

                model.senderName = tb_sender.Text.Trim();
                model.sendFile = cb_sendFile.Checked;
                model.SMTPHost = tb_senderServer.Text.Trim();
                model.SMTPPass = tb_senderPWD.Text.Trim();
                model.SMTPPuser = tb_senderAccount.Text.Trim();
                model.subject = tb_subject.Text.Trim();
                model.fileBasePath = tb_savePath.Text.Trim();
                model.mailBody = tb_mailBody.Text.Trim();
                model.sendTimeSpan = (int)nud_sendTimeSpan.Value;
                model.lastSendDate = DateTime.Now;
                if (!model.subject.Contains("{0}"))
                    model.subject += "{0}";
                if (!model.mailBody.Contains("{0}"))
                    model.subject += "预警商品共({0})个";
            }
            else
            {
                btn_alterAddress.Enabled = true;
                lb_ID.Text = model.ID.ToString();

                tb_sendAddr.Text= model.senderAddr;

                tb_notice.Text= model.notice;

                tb_toAddr.Text= model.mailAddress;

                tb_sender.Text= model.senderName;
                cb_sendFile.Checked= model.sendFile;
                tb_senderServer.Text= model.SMTPHost;
                tb_senderPWD.Text= model.SMTPPass;
                tb_senderAccount.Text= model.SMTPPuser;
                tb_subject.Text= model.subject;
                tb_savePath.Text= model.fileBasePath;
                tb_mailBody.Text= model.mailBody;
                tb_toer.Text = model.toer;
                nud_sendTimeSpan.Value = model.sendTimeSpan<= nud_sendTimeSpan.Minimum ? nud_sendTimeSpan.Minimum: model.sendTimeSpan;
            }
            return true;
        }
        private void dgvRowRepaint(object sender,DataGridViewRowPostPaintEventArgs args)
        {
            if(canEditRowIndex!= args.RowIndex)
            ((DataGridView)sender).Rows[args.RowIndex].ReadOnly = true;
            
        }
        private void timerPro(object sender,System.Timers.ElapsedEventArgs e)
        {
            if (bol_running&&!bol_alarming)
            {
                bol_alarming = true;
                string loc_file = "";
                int Dcount = 0;
                Random rand = new Random(DateTime.Now.Second);
                string loc_fileName = string.Format(fileName, DateTime.Now.ToString("yyyy-MM-dd") + DateTime.Now.Second + rand.Next());

                using (ksoaContext db=new ksoaContext ())
                {
                    //var query = (from q in db.alarm_MailAddr where q.IsDeleted==false&& DbFunctions.DiffMinutes(q.lastSendDate, DateTime.Now ) >= q.sendTimeSpan select q).ToList();
                    var query = addr_List.AsEnumerable().Where(q=>q.IsDeleted == false && DateTime.Now.AddMinutes(-q.sendTimeSpan)>q.lastSendDate).ToList();
                    sendMailAddr loc_addr =new sendMailAddr ();
                    tag_terminal loc_point;
                    if (query.Count > 0)
                    {
                        List<stock_alarm_GSA> list_goods;

                        Subject = string.Format(Subject, DateTime.Now.ToString("yyyy-MM-dd"));
                        Body = string.Format(Body, Dcount.ToString());

                        var loc_item = query.First(q => !string.IsNullOrEmpty(q.SMTPPuser) &&
                                                      !string.IsNullOrEmpty(q.mailBody) &&
                                                      !string.IsNullOrEmpty(q.senderAddr) &&
                                                      !string.IsNullOrEmpty(q.senderName) &&
                                                      !string.IsNullOrEmpty(q.SMTPHost) &&
                                                      !string.IsNullOrEmpty(q.SMTPPass) &&
                                                      !string.IsNullOrEmpty(q.subject)
                                                      );
                        checkTimes(DateTime.Now,  loc_item.fileBasePath, loc_fileName, out Dcount, out list_goods);
                        loc_file = file = loc_item.fileBasePath + loc_fileName;

                        loc_addr.mailBody = string.Format(loc_item.mailBody, Dcount.ToString());
                        loc_addr.SMTPHost = loc_item.SMTPHost;
                        loc_addr.SMTPPass = loc_item.SMTPPass;
                        loc_addr.SMTPPuser = loc_item.SMTPPuser;
                        loc_addr.subject = string.Format(loc_item.subject, DateTime.Now.ToString("yyyy-MM-dd"));
                        loc_addr.from.addr = loc_item.senderAddr;
                        loc_addr.from.showName = loc_item.senderName;
                        loc_addr.list_Toer = new List<tag_terminal>();
                        loc_addr.list_files = new List<string>();
                        loc_addr.list_files.Add(loc_file);
                        foreach (var item in query)
                        {
                            loc_point = new tag_terminal();
                            loc_point.addr = item.mailAddress;
                            loc_point.showName = item.toer;
                            loc_addr.list_Toer.Add(loc_point);
                        }
                        if (sendMail(loc_addr))
                        {
                            alarm_mailaddr loc_ma;
                            
                            foreach (var item in query)
                            {
                                loc_ma = db.alarm_MailAddr.Find(item.ID);
                                loc_ma.lastSendDate = DateTime.Now;
                            }
                            foreach (var item in list_goods)
                            {
                                db.stock_alarm_GSA.Find(item.ID).last_alarmDate = (DateTime.Now);
                            }
                            db.SaveChanges();
                            dataRefresh();
                            StringBuilder sb = new StringBuilder();
                            sb.Append(DateTime.Now).Append("|商品库存预警邮件发送成功!共(").Append(Dcount).Append(")个商品.");
                            log_operate.writeLog(string.Format(logFile, DateTime.Now.ToString("yyyy-MM-dd")), sb.ToString());
                        }
                        else
                        {
                            dataRefresh();     
                            StringBuilder sb = new StringBuilder();
                            sb.Append(DateTime.Now).Append("|商品库存预警邮件发送失败!共(").Append(Dcount).Append(")个商品.");
                            log_operate.writeLog(string.Format(logFile, DateTime.Now.ToString("yyyy-MM-dd")), sb.ToString());
                        }
                    }
                }
                bol_alarming = false;
            }
        }
        private bool checkTimes(DateTime aimTime, string fileBasePath,string fileName,out int gCount,out List<stock_alarm_GSA> goodsList )
        {
            gCount = 0;
            using (ksoaContext db = new ksoaContext())
            {
                var query = from q in db.stock_alarm_GSA where q.stock_5DLatter < q.threshold_value && q.alarm_state == 0 && DbFunctions.DiffMinutes(q.last_alarmDate, DateTime.Now) >= q.alarmSpan select q;

                var query1 = from q in query
                             where q.stock_5DLatter < q.threshold_value && q.alarm_state == 0 && DbFunctions.DiffMinutes(q.last_alarmDate, DateTime.Now) >= q.alarmSpan
                             from p in db.spkfks 
                            from r in db.huoweizls
                             where q.spid == p.spid &&r.hw==q.hw
                             select new
                            {
                                ID=q.ID,
                                商品编号=q.spbh,
                                商品名称=q.spmch,
                                货位=r.huowname,
                                一级分类=p.yjfl,
                                二级分类=p.ejfl,
                                三级分类=p.sjfl,
                                预警阈值=q.threshold_value,
                                五日后库存=q.stock_5DLatter,
                                最后统计时间=q.lastCalcuDate,
                                上次预警时间=q.last_alarmDate,
                                近两个月销量=q.saledIn2Month,
                                近一月销量=q.saledIn1Month,

                            };

                goodsList = query.ToList();
                gCount = goodsList.Count();
                if (gCount > 0)
                {
                    OpenXmlExcelOper.CreateSpreadSheet(fileBasePath + fileName, "data");
                    OpenXmlExcelOper.FillAlarmData(fileBasePath + fileName, "data", ListToDataTable(query1.ToList()));
                }
            }
            return true;
        }
        
        private void btn_startWork_Click(object sender, EventArgs e)
        {
            bol_running = !bol_running;
            ((Button)sender).Text = bol_running ? "暂停" : "启动";
            if (!bol_running)
            {
                timer.Stop();
                nud_checkSpan.Enabled = true;
            }
            else {
                nud_checkSpan.Enabled = false;
                timer.Interval = (double)nud_checkSpan.Value * 1000;
                timer.Start();
            }
        }

        private void tb_modify_TextChanged(object sender, EventArgs e)
        {
            //alarm_mailaddr model = new alarm_mailaddr();
            //GetOrSetContext(ref model);
            //if (model.Equals(addr_List.Find(q => q.ID == model.ID)))
            //    btn_alterAddress.Enabled = false;
            //else btn_alterAddress.Enabled = true;
        }
        /// <summary>
        /// 修改地址配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_alterAddress_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            alarm_mailaddr model = new alarm_mailaddr();
            GetOrSetContext(ref model);
            if (!checkAddrModel(model))
                return;
            btn.Enabled = false;
            using (ksoaContext db=new ksoaContext ())
            {                
                var query = db.alarm_MailAddr.Find(model.ID);//query.First()
                query.mailAddress = model.mailAddress;
                query.mailBody = model.mailBody;
                query.notice = model.notice;
                query.senderAddr = model.senderAddr;
                query.senderName = model.senderName;
                query.sendFile = model.sendFile;
                query.SMTPHost = model.SMTPHost;
                query.SMTPPass = model.SMTPPass;
                query.SMTPPuser = model.SMTPPuser;
                query.subject = model.subject;
                query.toer = model.toer;
                query.sendTimeSpan = model.sendTimeSpan;
                if (0 < db.SaveChanges())
                {
                    alarm_mailaddr loc_m = new alarm_mailaddr();
                    MessageBox.Show("修改成功!", "提示");

                    GetOrSetContext(ref loc_m, false);
                }
                else {
                    MessageBox.Show("修改失败!", "提示");
                    btn.Enabled = true;
                }
            }
            //btn.Enabled = true;
            dataRefresh();
        }

        private void btn_addAddress_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            alarm_mailaddr model = new alarm_mailaddr();
            GetOrSetContext(ref model);
            if (!checkAddrModel(model))
                return ;
            btn.Enabled = false;
            using (ksoaContext db = new ksoaContext())
            {
                db.alarm_MailAddr.Add(model);
                if (0 < db.SaveChanges())
                {
                    alarm_mailaddr loc_m = new alarm_mailaddr();
                    MessageBox.Show("添加成功!", "提示");
                    GetOrSetContext(ref loc_m, false);
                    dataRefresh();
                }
                else
                    MessageBox.Show("添加失败!", "提示");
            }
            btn.Enabled = true;
        }
        /// <summary>
        /// 检查alarm_mailaddr合法性、并给出提示
        /// </summary>
        /// <param name="model">待检测模型</param>
        /// <returns></returns>
        private bool checkAddrModel(alarm_mailaddr model)
        {
            if (model == null) return false;
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(model.mailAddress.Trim()))
                sb.Append("收件人地址|");
            if (string.IsNullOrEmpty(model.mailBody.Trim()))
                sb.Append("邮件内容|");
            if (string.IsNullOrEmpty(model.senderAddr.Trim()))
                sb.Append("发件人地址|");
            if (string.IsNullOrEmpty(model.senderName.Trim()))
                sb.Append("发件人名称|");
            if (string.IsNullOrEmpty(model.SMTPHost.Trim()))
                sb.Append("发件服务器|");
            if (string.IsNullOrEmpty(model.SMTPPuser.Trim()))
                sb.Append("发件账号|");
            if (string.IsNullOrEmpty(model.SMTPPass.Trim()))
                sb.Append("发件密码|");
            if (string.IsNullOrEmpty(model.subject.Trim()))
                sb.Append("邮件主题|");
            if (string.IsNullOrEmpty(model.toer.Trim()))
                sb.Append("收件人地址|");
            if (model.sendTimeSpan<=0)
                sb.Append("发送间隔|");
            if (sb.Length > 0)
            {
                MessageBox.Show(sb.Remove(sb.Length - 1, 1).Append("不能为空!").ToString(), "提示");
                return false;
            }
            return true;
        }
        private void btn_refreshAddrList_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            dataRefresh();
            btn.Enabled = true;
        }
        delegate void dosth();
        /// <summary>
        /// 刷新数据|同时更新内存中的addr_list
        /// </summary>
        private void dataRefresh()
        {
            using (ksoaContext db = new ksoaContext())
            {
                addr_List = (List<alarm_mailaddr>)(from q in db.alarm_MailAddr where q.IsDeleted == false select q).ToList();
                if (dgv_addrList.InvokeRequired)
                {
                    this.Invoke(new dosth(()=> { dgv_addrList.DataSource = addr_List; }));
                }
                else
                    dgv_addrList.DataSource = addr_List;
            }
        }
        private void btn_delAddress_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
            if (dgv_addrList.SelectedRows.Count > 0)
            {
                var model = addr_List.Find(q => q.ID == int.Parse(dgv_addrList.SelectedRows[0].Cells["ID"].Value.ToString()));
                using (ksoaContext db = new ksoaContext())
                {
                    var query = db.alarm_MailAddr.Find(model.ID);
                    query.IsDeleted = true;
                    if (0 < db.SaveChanges())
                    {
                        alarm_mailaddr loc_m = new alarm_mailaddr();
                        MessageBox.Show("删除成功!", "提示");
                        GetOrSetContext(ref loc_m, false);
                    }
                    else
                        MessageBox.Show("删除失败!", "提示");
                }
                dataRefresh();
            }
            btn.Enabled = true;
        }

        private void btn_selFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (DialogResult.OK == fbd.ShowDialog(this))
            {
                tb_savePath.Text = fbd.SelectedPath;
            }
            
            
        }

        private void lb_ID_TextChanged(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            if (int.Parse(lb.Text.Trim()) <= 0)
                btn_alterAddress.Enabled = false;
            else btn_alterAddress.Enabled = true;
        }
        private bool sendMail(alarm_mailaddr model)
        {
            if (sendM == null)
                sendM = new sendMail();
            return sendM.sendmail(model.senderAddr, model.senderName, model.mailAddress, model.toer, model.subject, model.mailBody, new string[] { model.sendFile? model.fileBasePath:"" }, model.SMTPHost, model.SMTPPuser, model.SMTPPass);

        }
        private bool sendMail(sendMailAddr model, string sfrom=null, string sfromer = null, string sSubject = null, string sBody = null, string[] sfile = null, string sSMTPHost = null, string sSMTPuser = null, string sSMTPpass = null)
        {
            if (model.list_Toer.Count <= 0)
                throw new Exception("model list have no member!");
            if (sendM == null)
                sendM = new sendMail();
            return sendM.sendmail2Many(model.from,model.list_Toer,
                string.IsNullOrEmpty(sSubject)?model.subject:sSubject,
                string.IsNullOrEmpty(sBody) ? model.mailBody:sBody,
                (sfile==null||sfile.Length<=0) ? model.list_files.ToArray():sfile,
                string.IsNullOrEmpty(sSMTPHost) ? model.SMTPHost:sSMTPHost,
                string.IsNullOrEmpty(sSMTPuser) ? model.SMTPPuser:sSMTPuser,
                string.IsNullOrEmpty(sSMTPpass) ? model.SMTPPass:sSMTPpass);
        }

        private void btn_sendTest_Click(object sender, EventArgs e)
        {
            alarm_mailaddr model = new alarm_mailaddr();
            GetOrSetContext(ref model);
            if (!checkAddrModel(model))
                return;
            model.subject = string.Format(model.subject, DateTime.Now.ToString("yyyy-MM-dd"))+"test";
            model.mailBody = string.Format(model.mailBody, "test");
            sendMail(model);
        }

        private void btn_showLog_Click(object sender, EventArgs e)
        {
            logForm lf=
            new logForm(string.Format(logFile, DateTime.Now.ToString("yyyy-MM-dd")));
            lf.ShowDialog(this);
        }
    }
}
