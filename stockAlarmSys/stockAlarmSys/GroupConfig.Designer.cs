namespace stockAlarmSys
{
    partial class GroupConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_groupList = new System.Windows.Forms.DataGridView();
            this.lv_addrUnsel = new System.Windows.Forms.ListView();
            this.lv_addrSel = new System.Windows.Forms.ListView();
            this.btn_add2G = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_setMainG = new System.Windows.Forms.Button();
            this.btn_addNewG = new System.Windows.Forms.Button();
            this.btn_saveAlter = new System.Windows.Forms.Button();
            this.tb_groupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delGroup = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groupList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_delGroup);
            this.groupBox1.Controls.Add(this.dgv_groupList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "组列表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_groupName);
            this.groupBox2.Controls.Add(this.btn_saveAlter);
            this.groupBox2.Controls.Add(this.btn_addNewG);
            this.groupBox2.Controls.Add(this.btn_setMainG);
            this.groupBox2.Controls.Add(this.btn_remove);
            this.groupBox2.Controls.Add(this.btn_add2G);
            this.groupBox2.Controls.Add(this.lv_addrSel);
            this.groupBox2.Controls.Add(this.lv_addrUnsel);
            this.groupBox2.Location = new System.Drawing.Point(472, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 348);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            // 
            // dgv_groupList
            // 
            this.dgv_groupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_groupList.Location = new System.Drawing.Point(7, 20);
            this.dgv_groupList.Name = "dgv_groupList";
            this.dgv_groupList.RowTemplate.Height = 23;
            this.dgv_groupList.Size = new System.Drawing.Size(385, 322);
            this.dgv_groupList.TabIndex = 0;
            this.dgv_groupList.SelectionChanged += new System.EventHandler(this.dgv_groupList_SelectionChanged);
            // 
            // lv_addrUnsel
            // 
            this.lv_addrUnsel.Location = new System.Drawing.Point(7, 20);
            this.lv_addrUnsel.Name = "lv_addrUnsel";
            this.lv_addrUnsel.Size = new System.Drawing.Size(140, 322);
            this.lv_addrUnsel.TabIndex = 0;
            this.lv_addrUnsel.UseCompatibleStateImageBehavior = false;
            // 
            // lv_addrSel
            // 
            this.lv_addrSel.Location = new System.Drawing.Point(234, 20);
            this.lv_addrSel.Name = "lv_addrSel";
            this.lv_addrSel.Size = new System.Drawing.Size(140, 322);
            this.lv_addrSel.TabIndex = 1;
            this.lv_addrSel.UseCompatibleStateImageBehavior = false;
            // 
            // btn_add2G
            // 
            this.btn_add2G.Location = new System.Drawing.Point(153, 119);
            this.btn_add2G.Name = "btn_add2G";
            this.btn_add2G.Size = new System.Drawing.Size(75, 23);
            this.btn_add2G.TabIndex = 2;
            this.btn_add2G.Text = "添加->";
            this.btn_add2G.UseVisualStyleBackColor = true;
            this.btn_add2G.Click += new System.EventHandler(this.btn_add2G_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(153, 172);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 3;
            this.btn_remove.Text = "<-移除";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_setMainG
            // 
            this.btn_setMainG.Location = new System.Drawing.Point(380, 259);
            this.btn_setMainG.Name = "btn_setMainG";
            this.btn_setMainG.Size = new System.Drawing.Size(75, 23);
            this.btn_setMainG.TabIndex = 4;
            this.btn_setMainG.Text = "设为主地址";
            this.btn_setMainG.UseVisualStyleBackColor = true;
            this.btn_setMainG.Click += new System.EventHandler(this.btn_setMainG_Click);
            // 
            // btn_addNewG
            // 
            this.btn_addNewG.Location = new System.Drawing.Point(380, 318);
            this.btn_addNewG.Name = "btn_addNewG";
            this.btn_addNewG.Size = new System.Drawing.Size(75, 23);
            this.btn_addNewG.TabIndex = 5;
            this.btn_addNewG.Text = "添加";
            this.btn_addNewG.UseVisualStyleBackColor = true;
            this.btn_addNewG.Click += new System.EventHandler(this.btn_addNewG_Click);
            // 
            // btn_saveAlter
            // 
            this.btn_saveAlter.Location = new System.Drawing.Point(380, 288);
            this.btn_saveAlter.Name = "btn_saveAlter";
            this.btn_saveAlter.Size = new System.Drawing.Size(75, 23);
            this.btn_saveAlter.TabIndex = 6;
            this.btn_saveAlter.Text = "修改";
            this.btn_saveAlter.UseVisualStyleBackColor = true;
            this.btn_saveAlter.Click += new System.EventHandler(this.btn_saveAlter_Click);
            // 
            // tb_groupName
            // 
            this.tb_groupName.Location = new System.Drawing.Point(380, 37);
            this.tb_groupName.Name = "tb_groupName";
            this.tb_groupName.Size = new System.Drawing.Size(100, 21);
            this.tb_groupName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "分组名称：";
            // 
            // btn_delGroup
            // 
            this.btn_delGroup.Location = new System.Drawing.Point(398, 289);
            this.btn_delGroup.Name = "btn_delGroup";
            this.btn_delGroup.Size = new System.Drawing.Size(49, 23);
            this.btn_delGroup.TabIndex = 9;
            this.btn_delGroup.Text = "删除";
            this.btn_delGroup.UseVisualStyleBackColor = true;
            this.btn_delGroup.Click += new System.EventHandler(this.btn_delGroup_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(398, 319);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(49, 23);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // GroupConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GroupConfig";
            this.Text = "GroupConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_groupList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_groupList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_setMainG;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add2G;
        private System.Windows.Forms.ListView lv_addrSel;
        private System.Windows.Forms.ListView lv_addrUnsel;
        private System.Windows.Forms.Button btn_saveAlter;
        private System.Windows.Forms.Button btn_addNewG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_groupName;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delGroup;
    }
}