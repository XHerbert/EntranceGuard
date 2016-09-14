namespace Demo
{
    partial class Add_Operater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Operater));
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.txt_Controler_Content = new CCWin.SkinControl.SkinWaterTextBox();
            this.cb_IsSync = new System.Windows.Forms.CheckBox();
            this.cb_door_type = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cotrol_NO = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_control_name = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.cb_Serialport = new System.Windows.Forms.ComboBox();
            this.cb_bote = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_area = new System.Windows.Forms.ComboBox();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.btn_Connect_Controller = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel8.Location = new System.Drawing.Point(490, 200);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(79, 19);
            this.skinLabel8.TabIndex = 119;
            this.skinLabel8.Text = "备　　注：";
            // 
            // txt_Controler_Content
            // 
            this.txt_Controler_Content.Location = new System.Drawing.Point(490, 270);
            this.txt_Controler_Content.MaxLength = 255;
            this.txt_Controler_Content.Multiline = true;
            this.txt_Controler_Content.Name = "txt_Controler_Content";
            this.txt_Controler_Content.Size = new System.Drawing.Size(349, 90);
            this.txt_Controler_Content.TabIndex = 118;
            this.txt_Controler_Content.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Controler_Content.WaterText = "";
            // 
            // cb_IsSync
            // 
            this.cb_IsSync.AutoSize = true;
            this.cb_IsSync.Location = new System.Drawing.Point(185, 270);
            this.cb_IsSync.Name = "cb_IsSync";
            this.cb_IsSync.Size = new System.Drawing.Size(54, 16);
            this.cb_IsSync.TabIndex = 117;
            this.cb_IsSync.Text = "是/否";
            this.cb_IsSync.UseVisualStyleBackColor = true;
            // 
            // cb_door_type
            // 
            this.cb_door_type.FormattingEnabled = true;
            this.cb_door_type.Items.AddRange(new object[] {
            "单门控制器",
            "双门控制器",
            "四门控制器",
            "八门控制器",
            "16门控制器",
            "32门控制器"});
            this.cb_door_type.Location = new System.Drawing.Point(160, 200);
            this.cb_door_type.Name = "cb_door_type";
            this.cb_door_type.Size = new System.Drawing.Size(148, 20);
            this.cb_door_type.TabIndex = 116;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Cancel.Location = new System.Drawing.Point(640, 420);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(66, 24);
            this.btn_Cancel.TabIndex = 115;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Save.Location = new System.Drawing.Point(490, 420);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(66, 24);
            this.btn_Save.TabIndex = 114;
            this.btn_Save.Text = "确定";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel7.Location = new System.Drawing.Point(490, 130);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(65, 19);
            this.skinLabel7.TabIndex = 113;
            this.skinLabel7.Text = "波特率：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel5.Location = new System.Drawing.Point(490, 60);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(65, 19);
            this.skinLabel5.TabIndex = 110;
            this.skinLabel5.Text = "串口号：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel4.Location = new System.Drawing.Point(20, 270);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(115, 19);
            this.skinLabel4.TabIndex = 108;
            this.skinLabel4.Text = "连接时同步时间 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(340, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 107;
            this.label3.Text = "*";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel3.Location = new System.Drawing.Point(20, 200);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(79, 19);
            this.skinLabel3.TabIndex = 105;
            this.skinLabel3.Text = "门禁类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(340, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 104;
            this.label2.Text = "*  范围0000~9999";
            // 
            // txt_cotrol_NO
            // 
            this.txt_cotrol_NO.Location = new System.Drawing.Point(160, 130);
            this.txt_cotrol_NO.Multiline = true;
            this.txt_cotrol_NO.Name = "txt_cotrol_NO";
            this.txt_cotrol_NO.Size = new System.Drawing.Size(148, 26);
            this.txt_cotrol_NO.TabIndex = 103;
            this.txt_cotrol_NO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_cotrol_NO.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel2.Location = new System.Drawing.Point(20, 130);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(100, 19);
            this.skinLabel2.TabIndex = 102;
            this.skinLabel2.Text = "RS485地址 ：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 101;
            this.label1.Text = "*";
            // 
            // txt_control_name
            // 
            this.txt_control_name.Location = new System.Drawing.Point(160, 60);
            this.txt_control_name.Multiline = true;
            this.txt_control_name.Name = "txt_control_name";
            this.txt_control_name.Size = new System.Drawing.Size(148, 26);
            this.txt_control_name.TabIndex = 100;
            this.txt_control_name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_control_name.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel1.Location = new System.Drawing.Point(20, 60);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(79, 19);
            this.skinLabel1.TabIndex = 99;
            this.skinLabel1.Text = "设备名称：";
            // 
            // cb_Serialport
            // 
            this.cb_Serialport.FormattingEnabled = true;
            this.cb_Serialport.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18"});
            this.cb_Serialport.Location = new System.Drawing.Point(640, 60);
            this.cb_Serialport.Name = "cb_Serialport";
            this.cb_Serialport.Size = new System.Drawing.Size(148, 20);
            this.cb_Serialport.TabIndex = 120;
            // 
            // cb_bote
            // 
            this.cb_bote.FormattingEnabled = true;
            this.cb_bote.Items.AddRange(new object[] {
            "4800,n,8,1",
            "4800,e,8,1",
            "9600,n,8,1",
            "9600,e,8,1",
            "19200,n,8,1",
            "19200,e,8,1",
            "38400,n,8,1",
            "38400,e,8,1",
            "57600,n,8,1",
            "57600,e,8,1",
            "115200,n,8,1",
            "115200,e,8,1"});
            this.cb_bote.Location = new System.Drawing.Point(640, 130);
            this.cb_bote.Name = "cb_bote";
            this.cb_bote.Size = new System.Drawing.Size(148, 20);
            this.cb_bote.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(832, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 122;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(832, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 124;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(340, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 127;
            this.label7.Text = "*";
            // 
            // cb_area
            // 
            this.cb_area.FormattingEnabled = true;
            this.cb_area.Location = new System.Drawing.Point(160, 339);
            this.cb_area.Name = "cb_area";
            this.cb_area.Size = new System.Drawing.Size(148, 20);
            this.cb_area.TabIndex = 126;
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel9.Location = new System.Drawing.Point(20, 340);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(79, 19);
            this.skinLabel9.TabIndex = 125;
            this.skinLabel9.Text = "所属区域：";
            // 
            // btn_Connect_Controller
            // 
            this.btn_Connect_Controller.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Connect_Controller.Location = new System.Drawing.Point(220, 420);
            this.btn_Connect_Controller.Name = "btn_Connect_Controller";
            this.btn_Connect_Controller.Size = new System.Drawing.Size(90, 24);
            this.btn_Connect_Controller.TabIndex = 128;
            this.btn_Connect_Controller.Text = "测试连接设备";
            this.btn_Connect_Controller.UseVisualStyleBackColor = true;
            this.btn_Connect_Controller.Click += new System.EventHandler(this.btn_Connect_Controller_Click);
            // 
            // Add_Operater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.addbackgrong;
            this.ClientSize = new System.Drawing.Size(940, 488);
            this.Controls.Add(this.btn_Connect_Controller);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_area);
            this.Controls.Add(this.skinLabel9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_bote);
            this.Controls.Add(this.cb_Serialport);
            this.Controls.Add(this.skinLabel8);
            this.Controls.Add(this.txt_Controler_Content);
            this.Controls.Add(this.cb_IsSync);
            this.Controls.Add(this.cb_door_type);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cotrol_NO);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_control_name);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Operater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加设备";
            this.Load += new System.EventHandler(this.Add_Operater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinWaterTextBox txt_Controler_Content;
        private System.Windows.Forms.CheckBox cb_IsSync;
        private System.Windows.Forms.ComboBox cb_door_type;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinWaterTextBox txt_cotrol_NO;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinWaterTextBox txt_control_name;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.ComboBox cb_Serialport;
        private System.Windows.Forms.ComboBox cb_bote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_area;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private System.Windows.Forms.Button btn_Connect_Controller;
    }
}