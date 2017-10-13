using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace stockAlarmSys
{
    public struct tag_terminal
    { 
        public string addr { get; set; }
        public string showName { get; set; }
    }
    class sendMail
    {

        private logOperate log_operate = new logOperate();
        private string logFile = "{0}_Log.txt";
        /// <summary>
        /// C#发送邮件函数
        /// </summary>
        /// <param name="from">发送者邮箱</param>
        /// <param name="fromer">发送人</param>
        /// <param name="to">接受者邮箱</param>
        /// <param name="toer">收件人</param>
        /// <param name="Subject">主题</param>
        /// <param name="Body">内容</param>
        /// <param name="file">附件</param>
        /// <param name="SMTPHost">smtp服务器</param>
        /// <param name="SMTPuser">邮箱</param>
        /// <param name="SMTPpass">密码</param>

        /// <returns></returns>
        public bool sendmail(string sfrom, string sfromer, string sto, string stoer, string sSubject, string sBody, string []sfile, string sSMTPHost, string sSMTPuser, string sSMTPpass)
        {
            #region send process
            ////设置from和to地址
            MailAddress from = new MailAddress(sfrom, sfromer);
            MailAddress to = new MailAddress(sto, stoer);
            
            ////创建一个MailMessage对象
            MailMessage oMail = new MailMessage(from, to);
            
            //// 添加附件
            if (sfile.Length> 0)
            {
                foreach(var item in sfile)
                    if (item.Trim().Length > 0)
                        oMail.Attachments.Add(new Attachment(item));
            }



            ////邮件标题
            oMail.Subject = sSubject;


            ////邮件内容
            oMail.Body = sBody;

            ////邮件格式
            oMail.IsBodyHtml = false;

            ////邮件采用的编码
            oMail.BodyEncoding = System.Text.Encoding.GetEncoding("GB2312");

            ////设置邮件的优先级为高
            oMail.Priority = MailPriority.High;

            ////发送邮件
            SmtpClient client = new SmtpClient();
            ////client.UseDefaultCredentials = false; 
            client.Host = sSMTPHost;
            client.Credentials = new NetworkCredential(sSMTPuser, sSMTPpass);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            #endregion
            try
            {
                client.Send(oMail);
                return true;
            }
            catch (Exception err)
            {
                oMail.Dispose();
                //Response.Write(err.Message.ToString());
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now).Append("|邮件发送失败!")
                    .Append("       \r\n|sendaddr:").Append(sfrom)
                    .Append("       \r\n|sendname:").Append(sfromer)
                    .Append("       \r\n|toAddr:").Append(sto)
                    .Append("       \r\n|toer:").Append(stoer)
                    .Append("       \r\n|sSubject:").Append(sSubject)
                    .Append("       \r\n|sBody:").Append(sBody)
                    .Append("       \r\n|sSMTPHost:").Append(sSMTPHost)
                    .Append("       \r\n|sSMTPuser:").Append(sSMTPuser)
                    .Append("       \r\n|sSMTPpass:").Append(sSMTPpass)
                    .Append("       \r\n|Files:")
                    ;
                foreach (var item in sfile)
                    sb.Append("\r\n").Append(item);
                log_operate.writeLog(string.Format(logFile, DateTime.Now.ToString("yyyy-MM-dd")), sb.ToString());
                return false;
                //return false;
            }
            finally
            {
                ////释放资源
                oMail.Dispose();
            }

        }

        public bool sendmail2Many(tag_terminal sfrom,  List<tag_terminal> tolist,  string sSubject, string sBody, string []sfile, string sSMTPHost, string sSMTPuser, string sSMTPpass)
        {
            ////设置from和to地址
            MailAddress from = new MailAddress(sfrom.addr, sfrom.showName);

            ////创建一个MailMessage对象
            MailMessage oMail = new MailMessage();
            oMail.From = from;
            foreach (var item in tolist)
                oMail.To.Add(new MailAddress( item.addr,item.showName));
            //// 添加附件
            if (sfile.Length>0)
            {
                foreach(var item in sfile)
                    if(item.Trim().Length>0)
                        oMail.Attachments.Add(new Attachment(item));
            }

            

            ////邮件标题
            oMail.Subject = sSubject;


            ////邮件内容
            oMail.Body = sBody;

            ////邮件格式
            oMail.IsBodyHtml = false;

            ////邮件采用的编码
            oMail.BodyEncoding = System.Text.Encoding.GetEncoding("GB2312");

            ////设置邮件的优先级为高
            oMail.Priority = MailPriority.High;

            ////发送邮件
            SmtpClient client = new SmtpClient();
            ////client.UseDefaultCredentials = false; 
            client.Host = sSMTPHost;
            client.Credentials = new NetworkCredential(sSMTPuser, sSMTPpass);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(oMail);
                return true;
            }
            catch (Exception err)
            {
                //Response.Write(err.Message.ToString());
                oMail.Dispose();
                StringBuilder sb = new StringBuilder();
                sb.Append(DateTime.Now).Append("|邮件发送失败!")
                    .Append("       \r\n|sendaddr:").Append(sfrom.addr)
                    .Append("       \r\n|sendname:").Append(sfrom.showName)
                    .Append("       \r\n|toAddr/toer:");
                foreach (var item in tolist)
                    sb.Append("     \r\n").Append(item.addr).Append("/").Append(item.showName);
                sb
                    .Append("       \r\n|sSubject:").Append(sSubject)
                    .Append("       \r\n|sBody:").Append(sBody)
                    .Append("       \r\n|sSMTPHost:").Append(sSMTPHost)
                    .Append("       \r\n|sSMTPuser:").Append(sSMTPuser)
                    .Append("       \r\n|sSMTPpass:").Append(sSMTPpass)
                    .Append("       \r\n|Files:")
                    ;
                foreach (var item in sfile)
                    sb.Append("\r\n").Append(item);
                log_operate.writeLog(string.Format(logFile, DateTime.Now.ToString("yyyy-MM-dd")), sb.ToString());
                return false;
            }
            finally
            {
                ////释放资源
                oMail.Dispose();
            }

        }


    }
}
