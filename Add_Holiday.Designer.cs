namespace Demo
{
    partial class Add_Holiday
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Holiday));
            this.cb_Holiday_Type = new System.Windows.Forms.ComboBox();
            this.txt_Holiday_Content = new CCWin.SkinControl.SkinWaterTextBox();
            this.txt_Holiday = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.dtp_Begintime = new System.Windows.Forms.DateTimePicker();
            this.dtp_Endtime = new System.Windows.Forms.DateTimePicker();
            this.cb_IsCycle = new System.Windows.Forms.CheckBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Holiday_Type
            // 
            this.cb_Holiday_Type.FormattingEnabled = true;
            this.cb_Holiday_Type.Items.AddRange(new object[] {
            "假日类型1",
            "假日类型2",
            "假日类型3"});
            this.cb_Holiday_Type.Location = new System.Drawing.Point(160, 110);
            this.cb_Holiday_Type.Name = "cb_Holiday_Type";
            this.cb_Holiday_Type.Size = new System.Drawing.Size(148, 20);
            this.cb_Holiday_Type.TabIndex = 63;
            // 
            // txt_Holiday_Content
            // 
            this.txt_Holiday_Content.Location = new System.Drawing.Point(160, 340);
            this.txt_Holiday_Content.MaxLength = 255;
            this.txt_Holiday_Content.Multiline = true;
            this.txt_Holiday_Content.Name = "txt_Holiday_Content";
            this.txt_Holiday_Content.Size = new System.Drawing.Size(148, 60);
            this.txt_Holiday_Content.TabIndex = 62;
            this.txt_Holiday_Content.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Holiday_Content.WaterText = "";
            // 
            // txt_Holiday
            // 
            this.txt_Holiday.Location = new System.Drawing.Point(160, 50);
            this.txt_Holiday.Multiline = true;
            this.txt_Holiday.Name = "txt_Holiday";
            this.txt_Holiday.Size = new System.Drawing.Size(148, 26);
            this.txt_Holiday.TabIndex = 60;
            this.txt_Holiday.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Holiday.WaterText = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel4.Location = new System.Drawing.Point(20, 230);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(79, 19);
            this.skinLabel4.TabIndex = 59;
            this.skinLabel4.Text = "结束日期：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel3.Location = new System.Drawing.Point(20, 170);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(79, 19);
            this.skinLabel3.TabIndex = 58;
            this.skinLabel3.Text = "开始日期：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel2.Location = new System.Drawing.Point(20, 110);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(79, 19);
            this.skinLabel2.TabIndex = 57;
            this.skinLabel2.Text = "假日类型：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel1.Location = new System.Drawing.Point(20, 50);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(79, 19);
            this.skinLabel1.TabIndex = 56;
            this.skinLabel1.Text = "假日名称：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel5.Location = new System.Drawing.Point(20, 340);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(79, 19);
            this.skinLabel5.TabIndex = 65;
            this.skinLabel5.Text = "备　　注：";
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel6.Location = new System.Drawing.Point(20, 280);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(79, 19);
            this.skinLabel6.TabIndex = 64;
            this.skinLabel6.Text = "按年循环：";
            // 
            // dtp_Begintime
            // 
            this.dtp_Begintime.Location = new System.Drawing.Point(160, 170);
            this.dtp_Begintime.Name = "dtp_Begintime";
            this.dtp_Begintime.Size = new System.Drawing.Size(148, 21);
            this.dtp_Begintime.TabIndex = 66;
            // 
            // dtp_Endtime
            // 
            this.dtp_Endtime.Location = new System.Drawing.Point(160, 230);
            this.dtp_Endtime.Name = "dtp_Endtime";
            this.dtp_Endtime.Size = new System.Drawing.Size(148, 21);
            this.dtp_Endtime.TabIndex = 67;
            // 
            // cb_IsCycle
            // 
            this.cb_IsCycle.AutoSize = true;
            this.cb_IsCycle.Location = new System.Drawing.Point(180, 280);
            this.cb_IsCycle.Name = "cb_IsCycle";
            this.cb_IsCycle.Size = new System.Drawing.Size(54, 16);
            this.cb_IsCycle.TabIndex = 68;
            this.cb_IsCycle.Text = "是/否";
            this.cb_IsCycle.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Cancel.Location = new System.Drawing.Point(242, 441);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(66, 24);
            this.btn_Cancel.TabIndex = 70;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Save.Location = new System.Drawing.Point(114, 441);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(66, 24);
            this.btn_Save.TabIndex = 69;
            this.btn_Save.Text = "确定";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(344, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 71;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(344, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 72;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(344, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 73;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(344, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 74;
            this.label4.Text = "*";
            // 
            // Add_Holiday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.add_holiday;
            this.ClientSize = new System.Drawing.Size(444, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cb_IsCycle);
            this.Controls.Add(this.dtp_Endtime);
            this.Controls.Add(this.dtp_Begintime);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.cb_Holiday_Type);
            this.Controls.Add(this.txt_Holiday_Content);
            this.Controls.Add(this.txt_Holiday);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Holiday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增节假日信息";
            this.Load += new System.EventHandler(this.Add_Holiday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Holiday_Type;
        private CCWin.SkinControl.SkinWaterTextBox txt_Holiday_Content;
        private CCWin.SkinControl.SkinWaterTextBox txt_Holiday;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DateTimePicker dtp_Begintime;
        private System.Windows.Forms.DateTimePicker dtp_Endtime;
        private System.Windows.Forms.CheckBox cb_IsCycle;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}