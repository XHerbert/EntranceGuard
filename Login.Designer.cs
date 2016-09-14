namespace Demo
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_PWD = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_pwdInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_UserName
            // 
            this.txt_UserName.AcceptsTab = true;
            this.txt_UserName.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_UserName.Location = new System.Drawing.Point(305, 122);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(176, 28);
            this.txt_UserName.TabIndex = 0;
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            this.txt_UserName.MouseEnter += new System.EventHandler(this.txt_UserName_MouseEnter);
            this.txt_UserName.MouseLeave += new System.EventHandler(this.txt_UserName_MouseLeave);
            // 
            // txt_PWD
            // 
            this.txt_PWD.AcceptsTab = true;
            this.txt_PWD.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_PWD.Location = new System.Drawing.Point(305, 165);
            this.txt_PWD.Multiline = true;
            this.txt_PWD.Name = "txt_PWD";
            this.txt_PWD.PasswordChar = '*';
            this.txt_PWD.Size = new System.Drawing.Size(176, 28);
            this.txt_PWD.TabIndex = 1;
            this.txt_PWD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PWD_KeyDown);
            this.txt_PWD.MouseLeave += new System.EventHandler(this.txt_PWD_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Demo.Properties.Resources._11;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(326, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_pwdInfo
            // 
            this.txt_pwdInfo.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_pwdInfo.Location = new System.Drawing.Point(305, 165);
            this.txt_pwdInfo.Multiline = true;
            this.txt_pwdInfo.Name = "txt_pwdInfo";
            this.txt_pwdInfo.Size = new System.Drawing.Size(176, 28);
            this.txt_pwdInfo.TabIndex = 2;
            this.txt_pwdInfo.Text = "密码";
            this.txt_pwdInfo.MouseEnter += new System.EventHandler(this.txt_pwdInfo_MouseEnter);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demo.Properties.Resources.QQ截图20160403215147;
            this.ClientSize = new System.Drawing.Size(711, 430);
            this.Controls.Add(this.txt_pwdInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_PWD);
            this.Controls.Add(this.txt_UserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实验室门禁系统 v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_PWD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pwdInfo;
    }
}