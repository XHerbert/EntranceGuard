using Haley.FrameWork;
using System.Data;
namespace Demo
{
    partial class RealTime_View
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealTime_View));
            this.skinGroupBox9 = new CCWin.SkinControl.SkinGroupBox();
            this.dgv_Actions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.事件1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_GetData = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.controllerDrop = new System.Windows.Forms.ComboBox();
            this.openAlways = new System.Windows.Forms.CheckBox();
            this.openDoor = new System.Windows.Forms.Button();
            this.doorDrop = new System.Windows.Forms.ComboBox();
            this.skinGroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).BeginInit();
            this.SuspendLayout();
            // 
            // skinGroupBox9
            // 
            this.skinGroupBox9.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox9.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox9.Controls.Add(this.dgv_Actions);
            this.skinGroupBox9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinGroupBox9.Location = new System.Drawing.Point(950, 50);
            this.skinGroupBox9.Name = "skinGroupBox9";
            this.skinGroupBox9.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox9.Size = new System.Drawing.Size(848, 766);
            this.skinGroupBox9.TabIndex = 103;
            this.skinGroupBox9.TabStop = false;
            this.skinGroupBox9.Text = "实时进出";
            this.skinGroupBox9.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox9.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // dgv_Actions
            // 
            this.dgv_Actions.AllowUserToAddRows = false;
            this.dgv_Actions.AllowUserToDeleteRows = false;
            this.dgv_Actions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Actions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Actions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.事件1,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn40});
            this.dgv_Actions.Location = new System.Drawing.Point(6, 20);
            this.dgv_Actions.MultiSelect = false;
            this.dgv_Actions.Name = "dgv_Actions";
            this.dgv_Actions.ReadOnly = true;
            this.dgv_Actions.RowTemplate.Height = 23;
            this.dgv_Actions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Actions.Size = new System.Drawing.Size(836, 740);
            this.dgv_Actions.TabIndex = 104;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn39.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 80;
            // 
            // 事件1
            // 
            this.事件1.DataPropertyName = "Action";
            this.事件1.HeaderText = "事件";
            this.事件1.Name = "事件1";
            this.事件1.ReadOnly = true;
            this.事件1.Width = 180;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Date_Time";
            this.dataGridViewTextBoxColumn43.HeaderText = "刷卡日期";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 150;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Person_Name";
            this.dataGridViewTextBoxColumn42.HeaderText = "刷卡人";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 140;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "place";
            this.dataGridViewTextBoxColumn41.HeaderText = "刷卡地点";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 120;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Controller_Name";
            this.dataGridViewTextBoxColumn40.HeaderText = "控制器名称";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 120;
            // 
            // timer_GetData
            // 
            this.timer_GetData.Interval = 6000;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(23, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 621);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "控制器";
            // 
            // controllerDrop
            // 
            this.controllerDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.controllerDrop.FormattingEnabled = true;
            this.controllerDrop.Items.AddRange(new object[] {
            "-- 请选择控制器--"});
            this.controllerDrop.Location = new System.Drawing.Point(24, 674);
            this.controllerDrop.Name = "controllerDrop";
            this.controllerDrop.Size = new System.Drawing.Size(226, 20);
            this.controllerDrop.TabIndex = 112;
            this.controllerDrop.SelectedIndexChanged += new System.EventHandler(this.controllerDrop_SelectedIndexChanged);
            // 
            // openAlways
            // 
            this.openAlways.BackColor = System.Drawing.Color.Transparent;
            this.openAlways.ForeColor = System.Drawing.Color.Maroon;
            this.openAlways.Location = new System.Drawing.Point(526, 674);
            this.openAlways.Name = "openAlways";
            this.openAlways.Size = new System.Drawing.Size(86, 20);
            this.openAlways.TabIndex = 113;
            this.openAlways.Text = "常开";
            this.openAlways.UseVisualStyleBackColor = false;
            this.openAlways.CheckedChanged += new System.EventHandler(this.openAlways_CheckedChanged);
            // 
            // openDoor
            // 
            this.openDoor.ForeColor = System.Drawing.Color.Maroon;
            this.openDoor.Location = new System.Drawing.Point(656, 674);
            this.openDoor.Name = "openDoor";
            this.openDoor.Size = new System.Drawing.Size(283, 20);
            this.openDoor.TabIndex = 114;
            this.openDoor.Text = "开门";
            this.openDoor.UseVisualStyleBackColor = true;
            this.openDoor.Click += new System.EventHandler(this.OpenDoor_Click);
            // 
            // doorDrop
            // 
            this.doorDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doorDrop.FormattingEnabled = true;
            this.doorDrop.Items.AddRange(new object[] {
            "--请选择门--"});
            this.doorDrop.Location = new System.Drawing.Point(285, 674);
            this.doorDrop.Name = "doorDrop";
            this.doorDrop.Size = new System.Drawing.Size(216, 20);
            this.doorDrop.TabIndex = 115;
            this.doorDrop.SelectedIndexChanged += new System.EventHandler(this.doorDrop_SelectedIndexChanged);
            // 
            // RealTime_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 837);
            this.Controls.Add(this.doorDrop);
            this.Controls.Add(this.openDoor);
            this.Controls.Add(this.openAlways);
            this.Controls.Add(this.controllerDrop);
            this.Controls.Add(this.skinGroupBox9);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RealTime_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实时监控";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RealTime_View_FormClosing);
            this.Load += new System.EventHandler(this.RealTime_View_Load);
            this.skinGroupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinGroupBox skinGroupBox9;
        private System.Windows.Forms.DataGridView dgv_Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事件1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.Timer timer_GetData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox controllerDrop;
        private System.Windows.Forms.CheckBox openAlways;
        private System.Windows.Forms.Button openDoor;
        private System.Windows.Forms.ComboBox doorDrop;
    }
}