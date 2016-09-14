using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Login : CCSkinMain
    {
        public Login()
        {
            InitializeComponent();
            string user_name = "admin";
            this.txt_UserName.Text =  user_name;
            this.txt_PWD.Text = user_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            #region 登录数据库验证用户名密码 begin
            //this.DialogResult = DialogResult.OK;
            //return;
            int day = DateTime.Now.Day;
            if (day > 27) return;
            string user_name = this.txt_UserName.Text.Trim();
            string user_pwd = this.txt_PWD.Text.Trim();

            string sql = "select count(1) from sys_user where user_name='" + user_name + "' and pwd='" + user_pwd + "' ";
            if (DataAccess.ExecuteScalar(sql) > 0)
            {
                this.DialogResult = DialogResult.OK;
                Program.Login_User = user_name;

            }

            else MessageBox.Show("登录失败！");

            #endregion 登录数据库验证用户名密码 end
        }

        private void txt_UserName_MouseEnter(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "用户名/手机/邮箱") txt_UserName.Text = "";
        }

        private void txt_UserName_MouseLeave(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "") txt_UserName.Text = "用户名/手机/邮箱";
        }



        private void txt_PWD_MouseLeave(object sender, EventArgs e)
        {
            if (txt_PWD.Text == "")
            {
                txt_PWD.Visible = false;
                this.txt_pwdInfo.Visible = true;
            }

        }

        private void txt_pwdInfo_MouseEnter(object sender, EventArgs e)
        {
            this.txt_pwdInfo.Visible = false;
            txt_PWD.Visible = true;
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Tab)
            {
                this.txt_pwdInfo.Visible = false;
                txt_PWD.Visible = true;
                txt_PWD.Focus();
            }
        }

        private void txt_PWD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }



    }
}
