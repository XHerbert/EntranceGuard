using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Add_Operater : CCSkinMain
    {

        #region 私有变量 begin

        private bool _IsModify = false;
        private int _ID = 0;

        #endregion 私有变量 end




        public Add_Operater()
        {
            InitializeComponent();
        }


        public Add_Operater(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;

        }






        private void Add_Operater_Load(object sender, EventArgs e)
        {
            try
            {
                Init_ddlAres();
                string[] ports = SerialPort.GetPortNames();
                Array.Sort(ports);
                cb_Serialport.Items.AddRange(ports);

                this.Text = _IsModify ? "修改设备信息" : "新增设备信息";
                if (!_IsModify)
                {
                    this.cb_door_type.SelectedIndex = 0;
                    cb_Serialport.SelectedIndex = 0;
                    this.cb_bote.SelectedIndex = 2;
                }
                else
                {
                    Init_Data(_ID);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("页面加载失败：" + ex.Message);
            }

        }



        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_control_name.Text.Trim() == "")
            {
                MessageBox.Show("请输入设备名称!");
                return;
            }
            if (this.txt_cotrol_NO.Text.Trim() == "")
            {
                MessageBox.Show("请输入设备编号!");
                return;
            }


            try
            {
                if (CheckCotroller() == 1)
                {

                    int maxCount = 8;
                    int count=DataAccess.ExecuteScalar("select count(*) from Controller_Info");
                    if (count >= maxCount)
                    {
                        MessageBoxEx.Show("已经超过最大设备数！");
                        return;
                    }
                    string sql = "select max(hi.ID) from Controller_Info hi ";

                    int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;

                    string sql_door_count = "select max(hi.id) from door_info hi ";

                    int New_Door = Convert.ToInt32(DataAccess.ExecuteScalar(sql_door_count)) + 1;
                    string control_name = this.txt_control_name.Text.Trim();
                    //string control_NO = this.txt_cotrol_NO.Text.Trim();
                    string control_NO = (New_ID).ToString();
                    string seri_no = this.cb_Serialport.Text.Substring(3, this.cb_Serialport.Text.Trim().Length - 3);
                    string bondrate = this.cb_bote.Text;
                    int door_count = Count(this.cb_door_type.SelectedIndex);//选择的门类型，不同的类型门数量不同
                    int IsSync_date = cb_IsSync.Checked ? 1 : 0;
                    int area_id = Convert.ToInt32(this.cb_area.SelectedValue);
                    string adress_485 = "0";
                    string content = this.txt_Controler_Content.Text.ToString().Trim();
                    List<string> list_SQL = new List<string>();
                    string T_Sql = string.Empty;


                    //修改数据后，为什么要改变ID？？？？
                    if (_IsModify)
                    {
                        T_Sql = @"update controller_info set controller_name='" + control_name + "',door_count=" + door_count + ",communication_mode='RS485/RS232',serialNO=" + seri_no + ",area_id=" + area_id + ",rs485_adress=" + adress_485 + ",content='" + content + "',bondrode='" + bondrate + "',issync_date=" + IsSync_date + " where id=" + _ID;

                        if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("修改设备信息成功");
                            LogHelper.WriteLog("【修改】", "修改设备信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());

                            this.Close();
                        }
                        else
                            MessageBox.Show("修改设备信息成功失败!");
                    }

                    else
                    {
                        string sql_add_door = "";
                        for (int i = 0; i < door_count; i++)
                        {
                            sql_add_door = "insert into door_info values(" + New_Door + "," + New_ID + ",'" + (control_name + i.ToString()) + "'," + (i + 1) + ",1,0,0,'添加设置自动添加的门',0);";
                            list_SQL.Add(sql_add_door);
                            New_Door++;
                        }
                        T_Sql = "insert into controller_info values(" + New_ID + ",'" + control_name + "'," + control_NO + "," + door_count + ",'RS485/RS232'," + seri_no + "," + area_id + "," + adress_485 + ",'" + content + "','" + bondrate + "'," + IsSync_date + ");";
                        list_SQL.Add(T_Sql);
                        if (DataAccess.excuteSqlAndReturnValues(list_SQL) > 0)
                        {
                            this.DialogResult = DialogResult.OK;
                            MessageBox.Show("新增设备信息成功");
                            this.Close();
                        }
                        else
                            MessageBox.Show("新增设备信息成功失败!");
                    }

                }
                else
                {
                    MessageBox.Show(" 设备连接失败,无法通信不可以添加设备! ", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "设备信息错误", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "设备信息错误,异常信息为: !" + ex.Message);
            }
        }






        /// <summary>
        /// 计算2的多少次方
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int Count(int n)
        {
            int result;
            if (n == 0)
            {
                return 1;
            }
            result = 2 * Count(n - 1);
            return result;
        }


        private void Init_ddlAres()
        {
            string sql = "select ai.id,ai.area from area_info ai ";
            DataTable dt = DataAccess.dataTable(sql);
            this.cb_area.DataSource = dt.DefaultView;
            cb_area.ValueMember = "id";
            cb_area.DisplayMember = "area";

        }


        private void Init_Data(int id)
        {
            try
            {
                string sql = "SELECT HI.*,AI.AREA FROM CONTROLLER_INFO HI,AREA_INFO AI WHERE HI.AREA_ID=AI.ID AND  HI.ID= " + id;
                DataTable dt = DataAccess.dataTable(sql);
                this.txt_control_name.Text = dt.Rows[0]["Controller_Name"].ToString();
                this.txt_cotrol_NO.Text = dt.Rows[0]["Controller_ID"].ToString();
                this.cb_door_type.SelectedIndex = (Convert.ToInt32(dt.Rows[0]["Door_Count"].ToString()) / 2) - 1;
                this.cb_IsSync.Checked = dt.Rows[0]["IsSync_date"].ToString() == "1" ? true : false;
                string tt = dt.Rows[0]["area"].ToString().Trim();
                cb_area.Text = dt.Rows[0]["area"].ToString().Trim();
                cb_Serialport.SelectedIndex = Convert.ToInt32(dt.Rows[0]["SerialNO"].ToString()) - 1;
                cb_bote.Text = dt.Rows[0]["bondRode"].ToString().Trim();
                txt_Controler_Content.Text = dt.Rows[0]["Content"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据初始化失败：" + ex.Message); 
            }

        }



        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_Connect_Controller_Click(object sender, EventArgs e)
        {

            int result = CheckCotroller();
            if (result == -1)
            {
                MessageBox.Show("请输入RS485地址 ! ", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 1)
            {
                MessageBox.Show(" 设备连接成功! ", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(" 设备连接失败! ", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        private int CheckCotroller()
        {

            try
            {
                if (string.IsNullOrEmpty(txt_cotrol_NO.Text.Trim()))
                {
                    return -1;
                }
                string control_NO = this.txt_cotrol_NO.Text.Trim();
                string seri_no = this.cb_Serialport.Text.Substring(3, this.cb_Serialport.Text.Trim().Length - 3);
                string bondrate = this.cb_bote.Text;
                string msg = "";
                string time = Common.Common.GetDateTime(int.Parse(control_NO), int.Parse(seri_no), bondrate, ref msg);
                if (msg.Substring(0, 2) == "失败")
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception)
            {

                return 0;
            }

        }


    }
}
