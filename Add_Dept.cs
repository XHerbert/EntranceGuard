using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Add_Dept : CCSkinMain
    {


   

        //新增/修改标志
        private bool _IsModify = false;

        //要修改的数据条目ID
        private int _ID = 0;





        public Add_Dept()
        {
            InitializeComponent();
        }

        public Add_Dept(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;

        }



        /// <summary>
        /// 保存部门信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_Dept.Text.Trim() == "")
            {
                MessageBox.Show("请输入部门名称!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txt_Dept_NO.Text.Trim() == "")
            {
                MessageBox.Show("请输入部门编号!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string sql = "select max(ai.id) from Sys_Dept_Info ai ";
                int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
                string T_Sql = string.Empty;
                if (_IsModify) T_Sql = @"update Sys_Dept_Info set Dept_NO=" + txt_Dept_NO.Text.Trim() + ",Dept_Name='" + txt_Dept.Text.Trim() + "',content='" +txt_Dept_Content.Text.Trim() + "' where id=" + _ID;
                else T_Sql = "insert into Sys_Dept_Info values(" + New_ID + "," + txt_Dept_NO.Text.Trim() + ",'" + txt_Dept.Text.Trim() + "','" + txt_Dept_Content.Text.Trim() + "')";

                if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "部门信息成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "部门信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    this.Close();
                }
                else MessageBox.Show((_IsModify ? "修改" : "新增") + "部门信息失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "部门信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "部门信息错误,异常信息为: " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// 取消部门信息修改/添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void Add_Dept_Load(object sender, EventArgs e)
        {
            this.Text = _IsModify ? "修改部门信息" : "新增部门信息";
            if (_IsModify) Init_Data(_ID);


        }



        private void Init_Data(int id)
        {
            try
            {
                string sql = "select ai.* from Sys_Dept_Info ai where  ai.id= " + id;
                DataTable dt = DataAccess.dataTable(sql);
                this.txt_Dept_NO.Text = dt.Rows[0]["Dept_NO"].ToString();
                this.txt_Dept.Text = dt.Rows[0]["Dept_Name"].ToString();
                txt_Dept_Content.Text = dt.Rows[0]["Content"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据初始化失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



       
    }
}
