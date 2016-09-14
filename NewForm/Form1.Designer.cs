namespace Demo.NewForm
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.controller11 = new Demo.Controller.Controller();
            this.controller12 = new Demo.Controller.Controller();
            this.controller13 = new Demo.Controller.Controller();
            this.controller14 = new Demo.Controller.Controller();
            this.controller15 = new Demo.Controller.Controller();
            this.controller16 = new Demo.Controller.Controller();
            this.controller17 = new Demo.Controller.Controller();
            this.controller18 = new Demo.Controller.Controller();
            this.controller19 = new Demo.Controller.Controller();
            this.controller20 = new Demo.Controller.Controller();
            this.controller5 = new Demo.Controller.Controller();
            this.controller7 = new Demo.Controller.Controller();
            this.controller8 = new Demo.Controller.Controller();
            this.controller9 = new Demo.Controller.Controller();
            this.controller10 = new Demo.Controller.Controller();
            this.controller2 = new Demo.Controller.Controller();
            this.controller6 = new Demo.Controller.Controller();
            this.controller4 = new Demo.Controller.Controller();
            this.controller3 = new Demo.Controller.Controller();
            this.controller1 = new Demo.Controller.Controller();
            this.controller21 = new Demo.Controller.Controller();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "门1",
            "门2",
            "门3"});
            this.comboBox1.Location = new System.Drawing.Point(20, 585);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 20);
            this.comboBox1.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(271, 588);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "常开";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "开门";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // controller11
            // 
            this.controller11.BackColor = System.Drawing.Color.White;
            this.controller11.ControllerName = "控制器1";
            this.controller11.Location = new System.Drawing.Point(484, 415);
            this.controller11.Margin = new System.Windows.Forms.Padding(0);
            this.controller11.Name = "controller11";
            this.controller11.Size = new System.Drawing.Size(100, 120);
            this.controller11.State = null;
            this.controller11.StateColor = System.Drawing.Color.Red;
            this.controller11.TabIndex = 22;
            this.controller11.TextColor = System.Drawing.Color.Empty;
            // 
            // controller12
            // 
            this.controller12.BackColor = System.Drawing.Color.White;
            this.controller12.ControllerName = "控制器1";
            this.controller12.Location = new System.Drawing.Point(361, 415);
            this.controller12.Margin = new System.Windows.Forms.Padding(0);
            this.controller12.Name = "controller12";
            this.controller12.Size = new System.Drawing.Size(100, 120);
            this.controller12.State = null;
            this.controller12.StateColor = System.Drawing.Color.Green;
            this.controller12.TabIndex = 21;
            this.controller12.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller13
            // 
            this.controller13.BackColor = System.Drawing.Color.White;
            this.controller13.ControllerName = "控制器1";
            this.controller13.Location = new System.Drawing.Point(249, 415);
            this.controller13.Margin = new System.Windows.Forms.Padding(0);
            this.controller13.Name = "controller13";
            this.controller13.Size = new System.Drawing.Size(100, 120);
            this.controller13.State = null;
            this.controller13.StateColor = System.Drawing.Color.Red;
            this.controller13.TabIndex = 20;
            this.controller13.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller14
            // 
            this.controller14.BackColor = System.Drawing.Color.White;
            this.controller14.ControllerName = "控制器1";
            this.controller14.Location = new System.Drawing.Point(136, 415);
            this.controller14.Margin = new System.Windows.Forms.Padding(0);
            this.controller14.Name = "controller14";
            this.controller14.Size = new System.Drawing.Size(100, 120);
            this.controller14.State = null;
            this.controller14.StateColor = System.Drawing.Color.Green;
            this.controller14.TabIndex = 19;
            this.controller14.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller15
            // 
            this.controller15.BackColor = System.Drawing.Color.White;
            this.controller15.ControllerName = "控制器1";
            this.controller15.Location = new System.Drawing.Point(20, 415);
            this.controller15.Margin = new System.Windows.Forms.Padding(0);
            this.controller15.Name = "controller15";
            this.controller15.Size = new System.Drawing.Size(100, 120);
            this.controller15.State = null;
            this.controller15.StateColor = System.Drawing.Color.Red;
            this.controller15.TabIndex = 18;
            this.controller15.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller16
            // 
            this.controller16.BackColor = System.Drawing.Color.White;
            this.controller16.ControllerName = "控制器1";
            this.controller16.Location = new System.Drawing.Point(484, 278);
            this.controller16.Margin = new System.Windows.Forms.Padding(0);
            this.controller16.Name = "controller16";
            this.controller16.Size = new System.Drawing.Size(100, 120);
            this.controller16.State = null;
            this.controller16.StateColor = System.Drawing.Color.Red;
            this.controller16.TabIndex = 17;
            this.controller16.TextColor = System.Drawing.Color.Empty;
            // 
            // controller17
            // 
            this.controller17.BackColor = System.Drawing.Color.White;
            this.controller17.ControllerName = "控制器1";
            this.controller17.Location = new System.Drawing.Point(361, 278);
            this.controller17.Margin = new System.Windows.Forms.Padding(0);
            this.controller17.Name = "controller17";
            this.controller17.Size = new System.Drawing.Size(100, 120);
            this.controller17.State = null;
            this.controller17.StateColor = System.Drawing.Color.Green;
            this.controller17.TabIndex = 16;
            this.controller17.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller18
            // 
            this.controller18.BackColor = System.Drawing.Color.White;
            this.controller18.ControllerName = "控制器1";
            this.controller18.Location = new System.Drawing.Point(249, 278);
            this.controller18.Margin = new System.Windows.Forms.Padding(0);
            this.controller18.Name = "controller18";
            this.controller18.Size = new System.Drawing.Size(100, 120);
            this.controller18.State = null;
            this.controller18.StateColor = System.Drawing.Color.Red;
            this.controller18.TabIndex = 15;
            this.controller18.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller19
            // 
            this.controller19.BackColor = System.Drawing.Color.White;
            this.controller19.ControllerName = "控制器1";
            this.controller19.Location = new System.Drawing.Point(136, 278);
            this.controller19.Margin = new System.Windows.Forms.Padding(0);
            this.controller19.Name = "controller19";
            this.controller19.Size = new System.Drawing.Size(100, 120);
            this.controller19.State = null;
            this.controller19.StateColor = System.Drawing.Color.Green;
            this.controller19.TabIndex = 14;
            this.controller19.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller20
            // 
            this.controller20.BackColor = System.Drawing.Color.White;
            this.controller20.ControllerName = "控制器1";
            this.controller20.Location = new System.Drawing.Point(20, 278);
            this.controller20.Margin = new System.Windows.Forms.Padding(0);
            this.controller20.Name = "controller20";
            this.controller20.Size = new System.Drawing.Size(100, 120);
            this.controller20.State = null;
            this.controller20.StateColor = System.Drawing.Color.Red;
            this.controller20.TabIndex = 13;
            this.controller20.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller5
            // 
            this.controller5.BackColor = System.Drawing.Color.White;
            this.controller5.ControllerName = "控制器1";
            this.controller5.Location = new System.Drawing.Point(484, 146);
            this.controller5.Margin = new System.Windows.Forms.Padding(0);
            this.controller5.Name = "controller5";
            this.controller5.Size = new System.Drawing.Size(100, 120);
            this.controller5.State = null;
            this.controller5.StateColor = System.Drawing.Color.Red;
            this.controller5.TabIndex = 12;
            this.controller5.TextColor = System.Drawing.Color.Empty;
            // 
            // controller7
            // 
            this.controller7.BackColor = System.Drawing.Color.White;
            this.controller7.ControllerName = "控制器1";
            this.controller7.Location = new System.Drawing.Point(361, 146);
            this.controller7.Margin = new System.Windows.Forms.Padding(0);
            this.controller7.Name = "controller7";
            this.controller7.Size = new System.Drawing.Size(100, 120);
            this.controller7.State = null;
            this.controller7.StateColor = System.Drawing.Color.Green;
            this.controller7.TabIndex = 11;
            this.controller7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller8
            // 
            this.controller8.BackColor = System.Drawing.Color.White;
            this.controller8.ControllerName = "控制器1";
            this.controller8.Location = new System.Drawing.Point(249, 146);
            this.controller8.Margin = new System.Windows.Forms.Padding(0);
            this.controller8.Name = "controller8";
            this.controller8.Size = new System.Drawing.Size(100, 120);
            this.controller8.State = null;
            this.controller8.StateColor = System.Drawing.Color.Red;
            this.controller8.TabIndex = 10;
            this.controller8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller9
            // 
            this.controller9.BackColor = System.Drawing.Color.White;
            this.controller9.ControllerName = "控制器1";
            this.controller9.Location = new System.Drawing.Point(136, 146);
            this.controller9.Margin = new System.Windows.Forms.Padding(0);
            this.controller9.Name = "controller9";
            this.controller9.Size = new System.Drawing.Size(100, 120);
            this.controller9.State = null;
            this.controller9.StateColor = System.Drawing.Color.Green;
            this.controller9.TabIndex = 9;
            this.controller9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller10
            // 
            this.controller10.BackColor = System.Drawing.Color.White;
            this.controller10.ControllerName = "控制器1";
            this.controller10.Location = new System.Drawing.Point(20, 146);
            this.controller10.Margin = new System.Windows.Forms.Padding(0);
            this.controller10.Name = "controller10";
            this.controller10.Size = new System.Drawing.Size(100, 120);
            this.controller10.State = null;
            this.controller10.StateColor = System.Drawing.Color.Red;
            this.controller10.TabIndex = 8;
            this.controller10.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller2
            // 
            this.controller2.BackColor = System.Drawing.Color.White;
            this.controller2.ControllerName = "控制器1";
            this.controller2.Location = new System.Drawing.Point(484, 9);
            this.controller2.Margin = new System.Windows.Forms.Padding(0);
            this.controller2.Name = "controller2";
            this.controller2.Size = new System.Drawing.Size(100, 120);
            this.controller2.State = null;
            this.controller2.StateColor = System.Drawing.Color.Red;
            this.controller2.TabIndex = 7;
            this.controller2.TextColor = System.Drawing.Color.Empty;
            // 
            // controller6
            // 
            this.controller6.BackColor = System.Drawing.Color.White;
            this.controller6.ControllerName = "控制器1";
            this.controller6.Location = new System.Drawing.Point(361, 9);
            this.controller6.Margin = new System.Windows.Forms.Padding(0);
            this.controller6.Name = "controller6";
            this.controller6.Size = new System.Drawing.Size(100, 120);
            this.controller6.State = null;
            this.controller6.StateColor = System.Drawing.Color.Green;
            this.controller6.TabIndex = 6;
            this.controller6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller4
            // 
            this.controller4.BackColor = System.Drawing.Color.White;
            this.controller4.ControllerName = "控制器1";
            this.controller4.Location = new System.Drawing.Point(249, 9);
            this.controller4.Margin = new System.Windows.Forms.Padding(0);
            this.controller4.Name = "controller4";
            this.controller4.Size = new System.Drawing.Size(100, 120);
            this.controller4.State = null;
            this.controller4.StateColor = System.Drawing.Color.Red;
            this.controller4.TabIndex = 3;
            this.controller4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller3
            // 
            this.controller3.BackColor = System.Drawing.Color.White;
            this.controller3.ControllerName = "控制器1";
            this.controller3.Location = new System.Drawing.Point(136, 9);
            this.controller3.Margin = new System.Windows.Forms.Padding(0);
            this.controller3.Name = "controller3";
            this.controller3.Size = new System.Drawing.Size(100, 120);
            this.controller3.State = null;
            this.controller3.StateColor = System.Drawing.Color.Blue;
            this.controller3.TabIndex = 2;
            this.controller3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            // 
            // controller1
            // 
            this.controller1.BackColor = System.Drawing.Color.White;
            this.controller1.ControllerName = "控制器1";
            this.controller1.Location = new System.Drawing.Point(20, 9);
            this.controller1.Margin = new System.Windows.Forms.Padding(0);
            this.controller1.Name = "controller1";
            this.controller1.Size = new System.Drawing.Size(100, 120);
            this.controller1.State = null;
            this.controller1.StateColor = System.Drawing.Color.Red;
            this.controller1.TabIndex = 0;
            this.controller1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // controller21
            // 
            this.controller21.BackColor = System.Drawing.Color.White;
            this.controller21.ControllerName = null;
            this.controller21.Location = new System.Drawing.Point(612, 9);
            this.controller21.Margin = new System.Windows.Forms.Padding(0);
            this.controller21.Name = "controller21";
            this.controller21.Size = new System.Drawing.Size(100, 120);
            this.controller21.State = null;
            this.controller21.StateColor = System.Drawing.Color.Empty;
            this.controller21.TabIndex = 26;
            this.controller21.TextColor = System.Drawing.Color.Empty;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 777);
            this.Controls.Add(this.controller21);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.controller11);
            this.Controls.Add(this.controller12);
            this.Controls.Add(this.controller13);
            this.Controls.Add(this.controller14);
            this.Controls.Add(this.controller15);
            this.Controls.Add(this.controller16);
            this.Controls.Add(this.controller17);
            this.Controls.Add(this.controller18);
            this.Controls.Add(this.controller19);
            this.Controls.Add(this.controller20);
            this.Controls.Add(this.controller5);
            this.Controls.Add(this.controller7);
            this.Controls.Add(this.controller8);
            this.Controls.Add(this.controller9);
            this.Controls.Add(this.controller10);
            this.Controls.Add(this.controller2);
            this.Controls.Add(this.controller6);
            this.Controls.Add(this.controller4);
            this.Controls.Add(this.controller3);
            this.Controls.Add(this.controller1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controller.Controller controller1;
        private Controller.Controller controller3;
        private Controller.Controller controller4;
        private Controller.Controller controller6;
        private Controller.Controller controller2;
        private Controller.Controller controller5;
        private Controller.Controller controller7;
        private Controller.Controller controller8;
        private Controller.Controller controller9;
        private Controller.Controller controller10;
        private Controller.Controller controller11;
        private Controller.Controller controller12;
        private Controller.Controller controller13;
        private Controller.Controller controller14;
        private Controller.Controller controller15;
        private Controller.Controller controller16;
        private Controller.Controller controller17;
        private Controller.Controller controller18;
        private Controller.Controller controller19;
        private Controller.Controller controller20;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private Controller.Controller controller21;
    }
}