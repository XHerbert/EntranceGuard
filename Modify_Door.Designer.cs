namespace Demo
{
    partial class Modify_Door
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modify_Door));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Is_Attendance_Record = new System.Windows.Forms.CheckBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.cb_Pass_Time = new System.Windows.Forms.ComboBox();
            this.txt_door_Content = new CCWin.SkinControl.SkinWaterTextBox();
            this.txt_Door_Name = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_door_NO = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Controller_Name = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(344, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 82;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(344, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 81;
            this.label1.Text = "*";
            // 
            // cb_Is_Attendance_Record
            // 
            this.cb_Is_Attendance_Record.AutoSize = true;
            this.cb_Is_Attendance_Record.Location = new System.Drawing.Point(180, 290);
            this.cb_Is_Attendance_Record.Name = "cb_Is_Attendance_Record";
            this.cb_Is_Attendance_Record.Size = new System.Drawing.Size(54, 16);
            this.cb_Is_Attendance_Record.TabIndex = 80;
            this.cb_Is_Attendance_Record.Text = "是/否";
            this.cb_Is_Attendance_Record.UseVisualStyleBackColor = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel5.Location = new System.Drawing.Point(20, 350);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(79, 19);
            this.skinLabel5.TabIndex = 79;
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
            this.skinLabel6.Location = new System.Drawing.Point(20, 290);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(107, 19);
            this.skinLabel6.TabIndex = 78;
            this.skinLabel6.Text = "是否为考勤门：";
            // 
            // cb_Pass_Time
            // 
            this.cb_Pass_Time.FormattingEnabled = true;
            this.cb_Pass_Time.Location = new System.Drawing.Point(160, 230);
            this.cb_Pass_Time.Name = "cb_Pass_Time";
            this.cb_Pass_Time.Size = new System.Drawing.Size(148, 20);
            this.cb_Pass_Time.TabIndex = 77;
            // 
            // txt_door_Content
            // 
            this.txt_door_Content.Location = new System.Drawing.Point(160, 350);
            this.txt_door_Content.MaxLength = 255;
            this.txt_door_Content.Multiline = true;
            this.txt_door_Content.Name = "txt_door_Content";
            this.txt_door_Content.Size = new System.Drawing.Size(148, 60);
            this.txt_door_Content.TabIndex = 76;
            this.txt_door_Content.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_door_Content.WaterText = "";
            // 
            // txt_Door_Name
            // 
            this.txt_Door_Name.Location = new System.Drawing.Point(160, 50);
            this.txt_Door_Name.Multiline = true;
            this.txt_Door_Name.Name = "txt_Door_Name";
            this.txt_Door_Name.Size = new System.Drawing.Size(148, 26);
            this.txt_Door_Name.TabIndex = 75;
            this.txt_Door_Name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Door_Name.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel2.Location = new System.Drawing.Point(20, 230);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(79, 19);
            this.skinLabel2.TabIndex = 74;
            this.skinLabel2.Text = "通行时区：";
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
            this.skinLabel1.Size = new System.Drawing.Size(65, 19);
            this.skinLabel1.TabIndex = 73;
            this.skinLabel1.Text = "门名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(344, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 85;
            this.label3.Text = "*";
            // 
            // txt_door_NO
            // 
            this.txt_door_NO.Location = new System.Drawing.Point(160, 110);
            this.txt_door_NO.Multiline = true;
            this.txt_door_NO.Name = "txt_door_NO";
            this.txt_door_NO.ReadOnly = true;
            this.txt_door_NO.Size = new System.Drawing.Size(148, 26);
            this.txt_door_NO.TabIndex = 84;
            this.txt_door_NO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_door_NO.WaterText = "";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel3.Location = new System.Drawing.Point(20, 110);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(65, 19);
            this.skinLabel3.TabIndex = 83;
            this.skinLabel3.Text = "门编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(344, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 88;
            this.label4.Text = "*";
            // 
            // txt_Controller_Name
            // 
            this.txt_Controller_Name.Location = new System.Drawing.Point(160, 170);
            this.txt_Controller_Name.Multiline = true;
            this.txt_Controller_Name.Name = "txt_Controller_Name";
            this.txt_Controller_Name.ReadOnly = true;
            this.txt_Controller_Name.Size = new System.Drawing.Size(148, 26);
            this.txt_Controller_Name.TabIndex = 87;
            this.txt_Controller_Name.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Controller_Name.WaterText = "";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel4.Location = new System.Drawing.Point(20, 170);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(79, 19);
            this.skinLabel4.TabIndex = 86;
            this.skinLabel4.Text = "所属设备：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Cancel.Location = new System.Drawing.Point(289, 436);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(66, 24);
            this.btn_Cancel.TabIndex = 90;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Save.Location = new System.Drawing.Point(160, 436);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(66, 24);
            this.btn_Save.TabIndex = 89;
            this.btn_Save.Text = "确定";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Modify_Door
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.add_holiday;
            this.ClientSize = new System.Drawing.Size(412, 485);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Controller_Name);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_door_NO);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Is_Attendance_Record);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.cb_Pass_Time);
            this.Controls.Add(this.txt_door_Content);
            this.Controls.Add(this.txt_Door_Name);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Modify_Door";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑门信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_Is_Attendance_Record;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.ComboBox cb_Pass_Time;
        private CCWin.SkinControl.SkinWaterTextBox txt_door_Content;
        private CCWin.SkinControl.SkinWaterTextBox txt_Door_Name;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinWaterTextBox txt_door_NO;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinWaterTextBox txt_Controller_Name;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
    }
}