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
    public partial class Add_Area : CCSkinMain
    {

  

        //新增/修改标志
        private bool _IsModify = false;

        //要修改的数据条目ID
        private int _ID = 0;




        public Add_Area()
        {
            InitializeComponent();
        }

        public Add_Area(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;

        }






        private void Add_Area_Load(object sender, EventArgs e)
        {
            Init_ddlAres();
            this.Text = _IsModify ? "修改区域信息" : "新增区域信息";
            if (!_IsModify)
            {
                this.cb_Areas.SelectedIndex = 0;
            }
            else
            {
                Init_Data(_ID);
            }
        }




        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_Area.Text.Trim() == "")
            {
                MessageBox.Show("请输入区域名称!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (this.txt_Area_NO.Text.Trim() == "")
            {
                MessageBox.Show("请输入区域编号!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string sql = "select max(ai.id) from area_info ai ";
                int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
                string T_Sql = string.Empty;
                if (_IsModify) T_Sql = @"update area_info set area_id=" + txt_Area_NO.Text.Trim() + ",area='" + txt_Area.Text.Trim() + "',content='" + txt_Area_Content.Text.Trim() + "',father_id=" + cb_Areas.SelectedValue + " where id=" + _ID;
                else T_Sql = "insert into area_info values(" + New_ID + "," + txt_Area_NO.Text.Trim() + ",'" + txt_Area.Text.Trim() + "','" + txt_Area_Content.Text.Trim() + "'," + this.cb_Areas.SelectedValue + ")";

                if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "区域信息成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "区域信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    this.Close();
                }
                else MessageBox.Show((_IsModify ? "修改" : "新增") + "区域信息失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "区域信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "区域信息错误,异常信息为: " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        private void Init_ddlAres()
        {
            string sql = "select ai.id,ai.area from area_info ai ";
            DataTable dt = DataAccess.dataTable(sql);
            this.cb_Areas.DataSource = dt.DefaultView;
            cb_Areas.ValueMember = "id";
            cb_Areas.DisplayMember = "area";

        }


        private void Init_Data(int id)
        {
            try
            {
                string sql = "select ai.* from area_info ai where  ai.id= " + id;
                DataTable dt = DataAccess.dataTable(sql);
                this.txt_Area.Text = dt.Rows[0]["area"].ToString();
                this.txt_Area_NO.Text = dt.Rows[0]["area_id"].ToString();
                this.cb_Areas.SelectedValue = Convert.ToInt32(dt.Rows[0]["father_id"].ToString());
                txt_Area_Content.Text = dt.Rows[0]["Content"].ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据初始化失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        public int InsertOrModify_Experiment_Register_Info(string flag, string id,
       string ID_Card_Number, string NAME, string PI, string Effective_Time,
       string Animal_Species, string Animal_Count, string Laboratory, string Destination,
       string Enter_Time, string Enter_Note_Taker, string Out_Time, string Out_Note_Taker,
       string Return_Time, string Is_Died, string Weight, string Back_Count, string Back_Home, ref string message)
        {

            int result = 0;
            string sql = string.Empty;
            try
            {
                if (flag == "1")
                {
                    string T_Sql_ID = "select max(ai.id) from Experiment_Register_Info ai ";
                    int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(T_Sql_ID)) + 1;
                    sql = "insert into Experiment_Register_Info values(" + New_ID + ",'" + ID_Card_Number + "','" + NAME + "','" + PI + "','" + Effective_Time + "','"
                        + Animal_Species + "','" + Animal_Count + "','" + Laboratory + "','" + Destination + "','" + Enter_Time + "','" + Enter_Note_Taker + "','" + Out_Time + "','"
                        + Out_Note_Taker + "','" + Return_Time + "','" + Is_Died + "','" + Weight + "','" + Back_Count + "','" + Back_Home + "')";
                }
                else
                {
                    sql = @"update Experiment_Register_Info set ID_Card_Number='" + ID_Card_Number + "',[NAME]='" + NAME + "',PI='" + PI + "',Effective_Time='" + Effective_Time + "',Animal_Species='" + Animal_Species
                        + "',Animal_Count='" + Animal_Count + "',Laboratory='" + Laboratory + "',Destination='" + Destination + "',Enter_Time='" + Enter_Time + "',Enter_Note_Taker='" + Enter_Note_Taker + "',Out_Time='" + Out_Time
                        + "',Out_Note_Taker='" + Out_Note_Taker + "',Return_Time='" + Return_Time + "',Is_Died='" + Is_Died + "',Weight='" + Weight + "',Back_Count='" + Back_Count + "',Back_Home='" + Back_Home + "' where id=" + id;
                }

                if (DataAccess.excuteSqlAndReturnValues(sql) > 0)
                {
                    result = 1;
                    message = "插入借出小动物信息成功";
                }
                else
                {
                    result = 0;
                    message = "插入借出小动物信息失败";
                }

            }

            catch (Exception ex)
            {
                message = ex.Message;
                result = 0;
            }


            return result;
        }




        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
