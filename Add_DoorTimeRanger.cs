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
    public partial class Add_DoorTimeRanger : CCSkinMain
    {


        private bool _IsModify = false;
        private int _ID = 0;




        public Add_DoorTimeRanger()
        {
            InitializeComponent();
        }

        public Add_DoorTimeRanger(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;

        }

        private void Add_DoorTimeRanger_Load(object sender, EventArgs e)
        {
            Init_TimeZone();
            this.Text = _IsModify ? "修改门通行计划信息" : "新增门通行计划信息";
            if (_IsModify) Init_Data(_ID);
        }





        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_TimeZone.Text == "")
            {
                MessageBox.Show("请输入时间区域名称");
                return;
            }



            try
            {
                string timeZone_name = this.txt_TimeZone.Text.Trim();
                string timeZone_Content = this.txt_TimeZone_Content.Text.Trim();
                string time_Zones = "";
                string is_outs = "";
                for (int i = 1; i <= 10; i++)
                {
                    ComboBox cb1 = (ComboBox)this.Controls.Find("cb_TimeZone" + i, true)[0];
                    CheckBox cb2 = (CheckBox)this.Controls.Find("cb_IsOut" + i, true)[0];
                    time_Zones += cb1.SelectedValue.ToString() + ",";
                    is_outs += (cb2.Checked ? "1" : "0")+",";
                }
                time_Zones = time_Zones.Substring(0, time_Zones.Length - 1);
                is_outs = is_outs.Substring(0, is_outs.Length-1);
                string sql = string.Empty;
                if (_IsModify)
                {

                    sql = "update door_timezone_info set TimeRange_Name='" + timeZone_name + "',Time_ZoneIDs='" + time_Zones + "',Is_Outs='" + is_outs + "',content='" + timeZone_Content + "' where id=" + _ID;
                }

                else
                {
                    string sql_ID = "select max(ai.id) from door_timezone_info ai ";
                    int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql_ID)) + 1;
                    sql = "insert into door_timezone_info values(" + New_ID + ",'" + timeZone_name + "','" + time_Zones + "','" + is_outs + "','" + timeZone_Content + "')";
                }
                if (DataAccess.excuteSqlAndReturnValues(sql) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "门通信计划成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "门通信计划成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    this.Close();
                }
                else MessageBox.Show((_IsModify ? "修改" : "新增") + "门通信计划失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "门通信计划失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "门通信计划错误,异常信息为: " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Init_TimeZone()
        {
            DataTable dt = null;
            for (int i = 1; i <= 10; i++)
            {
                dt = DataAccess.dataTable("SELECT TIME_ZONE_NO, '时区 :'+TIME_ZONE_NO+'具体时间段编号 ：'+TIME_RANGE_NO1+' ,'+TIME_RANGE_NO2+' ,'+TIME_RANGE_NO3 AS TIME_ZONE FROM TIME_ZONE ");
                ComboBox cb = (ComboBox)this.Controls.Find("cb_TimeZone" + (i), true)[0];
                cb.DataSource = dt.DefaultView;
                cb.DisplayMember = "TIME_ZONE";
                cb.ValueMember = "TIME_ZONE_NO";
            }
        }


        private void Init_Data(int id)
        {
            string sql1 = "select dti.*  from Door_TimeZone_Info dti where dti.ID= " + id;
            DataTable dt1 = DataAccess.dataTable(sql1);
            string timezone_ids = "";
            string is_outs = "";
            if (dt1.Rows.Count > 0)
            {
                this.txt_TimeZone.Text = dt1.Rows[0]["TimeRange_Name"].ToString();
                this.txt_TimeZone_Content.Text = dt1.Rows[0]["Content"].ToString();
                timezone_ids = dt1.Rows[0]["Time_ZoneIDs"].ToString();
                is_outs = dt1.Rows[0]["Is_Outs"].ToString();
            }
            string []timezones = timezone_ids.Split(',');
            string[] outs = is_outs.Split(',');
            for (int i =1; i <= timezones.Length; i++)
            {
                 ComboBox cb = (ComboBox)this.Controls.Find("cb_TimeZone" + (i), true)[0];
                 CheckBox cb1 = (CheckBox)this.Controls.Find("cb_IsOut" + i, true)[0];
                cb.SelectedValue=timezones[i-1];
                cb1.Checked = outs[i - 1] == "1" ? true : false;
            }

        }

    }
}
