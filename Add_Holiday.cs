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
    public partial class Add_Holiday : CCSkinMain
    {
        private bool _IsModify = false;
        private int _ID = 0;
        public Add_Holiday()
        {
            InitializeComponent();

        }

        public Add_Holiday(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;
        }

        #region 窗口加载事件

        private void Add_Holiday_Load(object sender, EventArgs e)
        {
            this.Text = _IsModify ? "修改节假日信息" : "新增节假日信息";
            if (!_IsModify)
            {
                this.cb_Holiday_Type.SelectedIndex = 0;
            }
            Init_Data(_ID);
        }

        #endregion 窗口加载事件

        #region 保存假日信息

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_Holiday.Text.Trim() == "")
            {
                MessageBox.Show("请输入假日名称!");
                return;
            }

            try
            {
                string sql = "select max(hi.id) from Holiday_Info hi ";
                int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
                int holiday_Type = this.cb_Holiday_Type.SelectedIndex + 1;

                string dt_begin = this.dtp_Begintime.Text.Replace('月', '-').Replace('年', '-').Replace('日', ' ').Trim();
                string dt_end = this.dtp_Endtime.Text.Replace('月', '-').Replace('年', '-').Replace('日', ' ').Trim();
                int is_cycle = this.cb_IsCycle.Checked == true ? 1 : 0;
                string content = this.txt_Holiday_Content.Text.Trim();
                string T_Sql = string.Empty;
                if (_IsModify)
                {
                    T_Sql = "update Holiday_Info set name='" + txt_Holiday.Text.Trim() + "',type=" + holiday_Type + ",begin_date='" + dt_begin + "',end_date='" + dt_end + "',is_cycle=" + is_cycle + ",content='" + content + "' where id=" + _ID;
                }
                else T_Sql = "insert into Holiday_Info values(" + New_ID + ",'" + txt_Holiday.Text.Trim() + "'," + holiday_Type + ",'" + dt_begin + "','" + dt_end + "'," + is_cycle + ",'" + content + "');";

                if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "假日信息成功");
                    LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "假日信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());

                    this.Close();
                }

                else
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "假日信息失败!");


            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "假日信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "假日信息错误,异常信息为: !" + ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion 保存假日信息

        #region 方法begion

        private void Init_Data(int id)
        {
            try
            {
                string sql = "select hi.* from Holiday_Info hi where hi.id= " + id;
                DataTable dt = DataAccess.dataTable(sql);
                this.txt_Holiday.Text = dt.Rows[0]["name"].ToString();
                this.cb_Holiday_Type.SelectedIndex = Convert.ToInt32(dt.Rows[0]["type"].ToString()) - 1;
                this.dtp_Begintime.Text = dt.Rows[0]["begin_Date"].ToString();
                this.dtp_Endtime.Text = dt.Rows[0]["end_Date"].ToString();
                this.cb_IsCycle.Checked = dt.Rows[0]["is_cycle"].ToString() == "1" ? true : false;
                this.txt_Holiday_Content.Text = dt.Rows[0]["content"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("数据加载失败 ： " + ex.Message);
            }

        }



        #endregion 方法end

    }
}
