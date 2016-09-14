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
    public partial class Modify_Door : CCSkinMain
    {
        private int _ID = 0;

        public Modify_Door()
        {
            InitializeComponent();
        }

        public Modify_Door(int id)
        {
            InitializeComponent();
            this._ID = id;
            Init_PassTimer();
            Init_Data(id);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_Door_Name.Text.Trim() == "")
            {
                MessageBox.Show("请输入门名称!");
            }
           

            string door_name = this.txt_Door_Name.Text.Trim();

            string pass_id = this.cb_Pass_Time.SelectedValue.ToString();

            string Is_Attendance_Record = this.cb_Is_Attendance_Record.Checked ? "1" : "0";
            string[] T_Sqls = new string[] { "",""};
            T_Sqls[0]="update door_info set Is_Attendance_Record=0 where 1=1 ;";
            T_Sqls[1]="update door_info set Door_Name='" + door_name + "',Pass_time_id=" + pass_id + ",Is_Attendance_Record=" + Is_Attendance_Record + " where id=" + _ID;
          



                if (DataAccess.excuteSqlAndReturnValues(T_Sqls) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("修改门信息成功");
                    this.Close();

                }
                else
                    MessageBox.Show("修改门信息失败!");
           
           
        }

        #region 方法begion

        private void Init_Data(int id)
        {
            string sql = "select di.*,ci.Controller_Name from Door_Info di,Controller_Info ci where di.Controller_ID=ci.id and  di.id= " + id;
            DataTable dt = DataAccess.dataTable(sql);
            this.txt_Door_Name.Text = dt.Rows[0]["Door_Name"].ToString();
            this.txt_door_NO.Text = dt.Rows[0]["Door_NO"].ToString();
            this.txt_Controller_Name.Text = dt.Rows[0]["Controller_Name"].ToString();
            this.cb_Pass_Time.SelectedValue = Convert.ToInt32(dt.Rows[0]["Pass_time_id"].ToString());
            this.cb_Is_Attendance_Record.Checked = dt.Rows[0]["Is_Attendance_Record"].ToString() == "1" ? true : false;
            this.txt_door_Content.Text = dt.Rows[0]["Content"].ToString();
        }

        private void Init_PassTimer()
        {
            string sql = "select pti.id,pti.TimeRange_Name from Door_TimeZone_Info pti ";
            DataTable dt = DataAccess.dataTable(sql);
            this.cb_Pass_Time.DataSource = dt.DefaultView;
            cb_Pass_Time.ValueMember = "id";
            cb_Pass_Time.DisplayMember = "TimeRange_Name";

        }



        #endregion 方法end

    }
}
