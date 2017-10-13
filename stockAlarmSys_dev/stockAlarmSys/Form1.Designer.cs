namespace stockAlarmSys
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_sendMail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refreshAddrList = new System.Windows.Forms.Button();
            this.dgv_addrList = new System.Windows.Forms.DataGridView();
            this.btn_delAddress = new System.Windows.Forms.Button();
            this.btn_alterAddress = new System.Windows.Forms.Button();
            this.btn_addAddress = new System.Windows.Forms.Button();
            this.btn_startWork = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_sendTimeSpan = new System.Windows.Forms.NumericUpDown();
            this.btn_sendTest = new System.Windows.Forms.Button();
            this.tb_mailBody = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_notice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tb_senderPWD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_senderAccount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_senderServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_sendFile = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_savePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_toer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_toAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_sender = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sendAddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_checkSpan = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_setGroup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addrList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sendTimeSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_checkSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sendMail
            // 
            this.btn_sendMail.Location = new System.Drawing.Point(974, 515);
            this.btn_sendMail.Name = "btn_sendMail";
            this.btn_sendMail.Size = new System.Drawing.Size(75, 23);
            this.btn_sendMail.TabIndex = 0;
            this.btn_sendMail.Text = "sendTest";
            this.btn_sendMail.UseVisualStyleBackColor = true;
            this.btn_sendMail.Click += new System.EventHandler(this.btn_showLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_setGroup);
            this.groupBox1.Controls.Add(this.btn_refreshAddrList);
            this.groupBox1.Controls.Add(this.dgv_addrList);
            this.groupBox1.Controls.Add(this.btn_delAddress);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "地址列表";
            // 
            // btn_refreshAddrList
            // 
            this.btn_refreshAddrList.Location = new System.Drawing.Point(574, 411);
            this.btn_refreshAddrList.Name = "btn_refreshAddrList";
            this.btn_refreshAddrList.Size = new System.Drawing.Size(75, 23);
            this.btn_refreshAddrList.TabIndex = 6;
            this.btn_refreshAddrList.Text = "刷新列表";
            this.btn_refreshAddrList.UseVisualStyleBackColor = true;
            this.btn_refreshAddrList.Click += new System.EventHandler(this.btn_refreshAddrList_Click);
            // 
            // dgv_addrList
            // 
            this.dgv_addrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addrList.Location = new System.Drawing.Point(7, 21);
            this.dgv_addrList.Name = "dgv_addrList";
            this.dgv_addrList.RowTemplate.Height = 23;
            this.dgv_addrList.Size = new System.Drawing.Size(561, 501);
            this.dgv_addrList.TabIndex = 5;
            // 
            // btn_delAddress
            // 
            this.btn_delAddress.Location = new System.Drawing.Point(574, 498);
            this.btn_delAddress.Name = "btn_delAddress";
            this.btn_delAddress.Size = new System.Drawing.Size(75, 23);
            this.btn_delAddress.TabIndex = 3;
            this.btn_delAddress.Text = "删除地址";
            this.btn_delAddress.UseVisualStyleBackColor = true;
            this.btn_delAddress.Click += new System.EventHandler(this.btn_delAddress_Click);
            // 
            // btn_alterAddress
            // 
            this.btn_alterAddress.Location = new System.Drawing.Point(293, 309);
            this.btn_alterAddress.Name = "btn_alterAddress";
            this.btn_alterAddress.Size = new System.Drawing.Size(75, 23);
            this.btn_alterAddress.TabIndex = 2;
            this.btn_alterAddress.Text = "修改地址";
            this.btn_alterAddress.UseVisualStyleBackColor = true;
            this.btn_alterAddress.Click += new System.EventHandler(this.btn_alterAddress_Click);
            // 
            // btn_addAddress
            // 
            this.btn_addAddress.Location = new System.Drawing.Point(293, 286);
            this.btn_addAddress.Name = "btn_addAddress";
            this.btn_addAddress.Size = new System.Drawing.Size(75, 23);
            this.btn_addAddress.TabIndex = 4;
            this.btn_addAddress.Text = "添加地址";
            this.btn_addAddress.UseVisualStyleBackColor = true;
            this.btn_addAddress.Click += new System.EventHandler(this.btn_addAddress_Click);
            // 
            // btn_startWork
            // 
            this.btn_startWork.Location = new System.Drawing.Point(974, 488);
            this.btn_startWork.Name = "btn_startWork";
            this.btn_startWork.Size = new System.Drawing.Size(75, 23);
            this.btn_startWork.TabIndex = 2;
            this.btn_startWork.Text = "启动";
            this.btn_startWork.UseVisualStyleBackColor = true;
            this.btn_startWork.Click += new System.EventHandler(this.btn_startWork_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nud_sendTimeSpan);
            this.groupBox2.Controls.Add(this.btn_sendTest);
            this.groupBox2.Controls.Add(this.tb_mailBody);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_notice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lb_ID);
            this.groupBox2.Controls.Add(this.tb_senderPWD);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_senderAccount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_senderServer);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cb_sendFile);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tb_fileName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_savePath);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_subject);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_toer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_toAddr);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_sender);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_sendAddr);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_addAddress);
            this.groupBox2.Controls.Add(this.btn_alterAddress);
            this.groupBox2.Location = new System.Drawing.Point(675, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 470);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "内容配置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 34;
            this.label13.Text = "发送间隔(分):";
            // 
            // nud_sendTimeSpan
            // 
            this.nud_sendTimeSpan.Location = new System.Drawing.Point(266, 117);
            this.nud_sendTimeSpan.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_sendTimeSpan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_sendTimeSpan.Name = "nud_sendTimeSpan";
            this.nud_sendTimeSpan.Size = new System.Drawing.Size(63, 21);
            this.nud_sendTimeSpan.TabIndex = 33;
            this.nud_sendTimeSpan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_sendTest
            // 
            this.btn_sendTest.Location = new System.Drawing.Point(293, 255);
            this.btn_sendTest.Name = "btn_sendTest";
            this.btn_sendTest.Size = new System.Drawing.Size(75, 23);
            this.btn_sendTest.TabIndex = 32;
            this.btn_sendTest.Text = "发送测试";
            this.btn_sendTest.UseVisualStyleBackColor = true;
            this.btn_sendTest.Click += new System.EventHandler(this.btn_sendTest_Click);
            // 
            // tb_mailBody
            // 
            this.tb_mailBody.Location = new System.Drawing.Point(78, 338);
            this.tb_mailBody.Multiline = true;
            this.tb_mailBody.Name = "tb_mailBody";
            this.tb_mailBody.Size = new System.Drawing.Size(289, 126);
            this.tb_mailBody.TabIndex = 31;
            this.tb_mailBody.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 30;
            this.label12.Text = "邮件内容:";
            // 
            // tb_notice
            // 
            this.tb_notice.Location = new System.Drawing.Point(78, 306);
            this.tb_notice.Name = "tb_notice";
            this.tb_notice.Size = new System.Drawing.Size(142, 21);
            this.tb_notice.TabIndex = 29;
            this.tb_notice.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 28;
            this.label11.Text = "备注:";
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(13, 122);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(11, 12);
            this.lb_ID.TabIndex = 27;
            this.lb_ID.Text = "0";
            this.lb_ID.TextChanged += new System.EventHandler(this.lb_ID_TextChanged);
            // 
            // tb_senderPWD
            // 
            this.tb_senderPWD.Location = new System.Drawing.Point(78, 279);
            this.tb_senderPWD.Name = "tb_senderPWD";
            this.tb_senderPWD.Size = new System.Drawing.Size(142, 21);
            this.tb_senderPWD.TabIndex = 26;
            this.tb_senderPWD.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "密码:";
            // 
            // tb_senderAccount
            // 
            this.tb_senderAccount.Location = new System.Drawing.Point(78, 252);
            this.tb_senderAccount.Name = "tb_senderAccount";
            this.tb_senderAccount.Size = new System.Drawing.Size(142, 21);
            this.tb_senderAccount.TabIndex = 24;
            this.tb_senderAccount.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "发件账号:";
            // 
            // tb_senderServer
            // 
            this.tb_senderServer.Location = new System.Drawing.Point(78, 225);
            this.tb_senderServer.Name = "tb_senderServer";
            this.tb_senderServer.Size = new System.Drawing.Size(142, 21);
            this.tb_senderServer.TabIndex = 22;
            this.tb_senderServer.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "发件服务器:";
            // 
            // cb_sendFile
            // 
            this.cb_sendFile.AutoSize = true;
            this.cb_sendFile.Location = new System.Drawing.Point(78, 122);
            this.cb_sendFile.Name = "cb_sendFile";
            this.cb_sendFile.Size = new System.Drawing.Size(72, 16);
            this.cb_sendFile.TabIndex = 20;
            this.cb_sendFile.Text = "发送附件";
            this.cb_sendFile.UseVisualStyleBackColor = true;
            this.cb_sendFile.CheckedChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "选择路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_selFilePath_Click);
            // 
            // tb_fileName
            // 
            this.tb_fileName.Location = new System.Drawing.Point(78, 190);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(142, 21);
            this.tb_fileName.TabIndex = 18;
            this.tb_fileName.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "文件名:";
            // 
            // tb_savePath
            // 
            this.tb_savePath.Location = new System.Drawing.Point(96, 153);
            this.tb_savePath.Name = "tb_savePath";
            this.tb_savePath.Size = new System.Drawing.Size(200, 21);
            this.tb_savePath.TabIndex = 16;
            this.tb_savePath.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "文件存储路径:";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(78, 84);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(251, 21);
            this.tb_subject.TabIndex = 14;
            this.tb_subject.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "邮件主题:";
            // 
            // tb_toer
            // 
            this.tb_toer.Location = new System.Drawing.Point(267, 45);
            this.tb_toer.Name = "tb_toer";
            this.tb_toer.Size = new System.Drawing.Size(100, 21);
            this.tb_toer.TabIndex = 12;
            this.tb_toer.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "收件人:";
            // 
            // tb_toAddr
            // 
            this.tb_toAddr.Location = new System.Drawing.Point(78, 45);
            this.tb_toAddr.Name = "tb_toAddr";
            this.tb_toAddr.Size = new System.Drawing.Size(138, 21);
            this.tb_toAddr.TabIndex = 10;
            this.tb_toAddr.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "收件人地址:";
            // 
            // tb_sender
            // 
            this.tb_sender.Location = new System.Drawing.Point(267, 18);
            this.tb_sender.Name = "tb_sender";
            this.tb_sender.Size = new System.Drawing.Size(100, 21);
            this.tb_sender.TabIndex = 8;
            this.tb_sender.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "发件人:";
            // 
            // tb_sendAddr
            // 
            this.tb_sendAddr.Location = new System.Drawing.Point(78, 18);
            this.tb_sendAddr.Name = "tb_sendAddr";
            this.tb_sendAddr.Size = new System.Drawing.Size(139, 21);
            this.tb_sendAddr.TabIndex = 6;
            this.tb_sendAddr.TextChanged += new System.EventHandler(this.tb_modify_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "发件人地址:";
            // 
            // nud_checkSpan
            // 
            this.nud_checkSpan.Location = new System.Drawing.Point(763, 488);
            this.nud_checkSpan.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nud_checkSpan.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_checkSpan.Name = "nud_checkSpan";
            this.nud_checkSpan.Size = new System.Drawing.Size(63, 21);
            this.nud_checkSpan.TabIndex = 35;
            this.nud_checkSpan.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(674, 493);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 12);
            this.label14.TabIndex = 35;
            this.label14.Text = "检测间隔(秒):";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(674, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 12);
            this.label15.TabIndex = 36;
            this.label15.Text = "同步间隔(分):";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(763, 515);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(63, 21);
            this.numericUpDown2.TabIndex = 37;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(832, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "立即同步";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_refreshAddrList_Click);
            // 
            // btn_setGroup
            // 
            this.btn_setGroup.Location = new System.Drawing.Point(575, 365);
            this.btn_setGroup.Name = "btn_setGroup";
            this.btn_setGroup.Size = new System.Drawing.Size(75, 23);
            this.btn_setGroup.TabIndex = 7;
            this.btn_setGroup.Text = "设置分组";
            this.btn_setGroup.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(293, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "设置抄送";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 552);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nud_checkSpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_startWork);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sendMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addrList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sendTimeSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_checkSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sendMail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addAddress;
        private System.Windows.Forms.Button btn_delAddress;
        private System.Windows.Forms.Button btn_alterAddress;
        private System.Windows.Forms.Button btn_startWork;
        private System.Windows.Forms.DataGridView dgv_addrList;
        private System.Windows.Forms.Button btn_refreshAddrList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_sendFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_savePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_toer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_toAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_sender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sendAddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_senderPWD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_senderAccount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_senderServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.TextBox tb_notice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_mailBody;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_sendTest;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nud_sendTimeSpan;
        private System.Windows.Forms.NumericUpDown nud_checkSpan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_setGroup;
        private System.Windows.Forms.Button button3;
    }
}

