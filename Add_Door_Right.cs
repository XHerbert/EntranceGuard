using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace Demo
{
    public partial class Add_Door_Right : CCSkinMain
    {
        private bool _IsModify = false;
        private int _ID = 0;

        public Add_Door_Right()
        {
            InitializeComponent();
        }

        public Add_Door_Right(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;

        }

        #region 设置grid 样式

        private void InitdrvCSS(DataGridView dgv)
        {
            #region DataGridVeiw Style
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 23;
            dgv.RowTemplate.ReadOnly = true;
            #endregion
        }

        #endregion 设置grid 样式

        #region 窗体加载事件

        private void Add_Door_Right_Load(object sender, EventArgs e)
        {
            Init_TimeRange();
            InitdrvCSS(dgv_Door_Info_Chose);
            InitdrvCSS(dgv_Door_Info_Wait);
            InitdrvCSS(dgv_Person_Info_Chosed);
            InitdrvCSS(dgv_Person_Info_Wait);

            if (!_IsModify)
            {
                this.cb_Door_Zone.SelectedIndex = 0;
                Init_Data();
            }
            else
            {
                bindData_ByID();
            }


        }

        #endregion 窗体加载事件


        #region 方法

        private void Init_Data()
        {
            try
            {
                string sql = @"select di.id, di.door_Name,ci.Controller_Name from door_info di,controller_info ci where di.controller_id=ci.id";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Door_Info_Wait.DataSource = dt.DefaultView;
                sql = @"select pi.id,pi.name,pi.cardid from Person_Info pi";
                dt = DataAccess.dataTable(sql);
                this.dgv_Person_Info_Wait.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {

                MessageBox.Show("数据加载失败: " + ex.Message);
            }
        }


        #endregion 方法


        #region 行选中事件

        private void dgv_Door_Info_Wait_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (dgv_Door_Info_Wait.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    dgv_Door_Info_Wait.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgv_Door_Info_Wait.Rows[e.RowIndex].Cells[0].Value = !(bool)dgv_Door_Info_Wait.Rows[e.RowIndex].Cells[0].Value;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dgv_Person_Info_Wait_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (dgv_Person_Info_Wait.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    dgv_Person_Info_Wait.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgv_Person_Info_Wait.Rows[e.RowIndex].Cells[0].Value = !(bool)dgv_Person_Info_Wait.Rows[e.RowIndex].Cells[0].Value;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dgv_Door_Info_Chose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (dgv_Door_Info_Chose.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    dgv_Door_Info_Chose.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgv_Door_Info_Chose.Rows[e.RowIndex].Cells[0].Value = !(bool)dgv_Door_Info_Chose.Rows[e.RowIndex].Cells[0].Value;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void dgv_Person_Info_Chosed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (dgv_Person_Info_Chosed.Rows[e.RowIndex].Cells[0].Value == null)
                {
                    dgv_Person_Info_Chosed.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dgv_Person_Info_Chosed.Rows[e.RowIndex].Cells[0].Value = !(bool)dgv_Person_Info_Chosed.Rows[e.RowIndex].Cells[0].Value;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        #endregion 行选中事件



        #region 按钮点击事件



        #region 全选移动数据


        private void btn_Select_AllDoor_Click(object sender, EventArgs e)
        {
            try
            {
                string Wait_Chosed_IDs = Get_Dgv_IDs(this.dgv_Door_Info_Wait, 1);
                if (Wait_Chosed_IDs == "")
                {
                    MessageBox.Show("没有要移动的数据！");
                    return;
                }

                string Chose_Chosed_IDs = Get_Dgv_IDs(this.dgv_Door_Info_Chose, 1);
                BindData(Wait_Chosed_IDs + "," + Chose_Chosed_IDs, dgv_Door_Info_Chose, dgv_Door_Info_Wait, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }


        }


        private void btn_NoSelect_AllDoors_Click(object sender, EventArgs e)
        {
            try
            {
                string Chose_Chosed_IDs = Get_Dgv_IDs(this.dgv_Door_Info_Chose, 1);
                if (Chose_Chosed_IDs == "")
                {
                    MessageBox.Show("没有要移动的数据！");
                    return;

                }
                string Wait_Chosed_IDs = Get_Dgv_IDs(this.dgv_Door_Info_Wait, 1);
                BindData(Chose_Chosed_IDs + "," + Wait_Chosed_IDs, dgv_Door_Info_Wait, dgv_Door_Info_Chose, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }
        }



        private void btn_Select_AllPersons_Click(object sender, EventArgs e)
        {
            try
            {
                string Wait_Chosed_IDs = Get_Dgv_IDs(this.dgv_Person_Info_Wait, 1);
                if (Wait_Chosed_IDs == "")
                {
                    MessageBox.Show("没有要移动的数据！");
                    return;
                }
                string Chose_Chosed_IDs = Get_Dgv_IDs(this.dgv_Person_Info_Chosed, 1);
                BindData(Wait_Chosed_IDs + "," + Chose_Chosed_IDs, dgv_Person_Info_Chosed, dgv_Person_Info_Wait, 1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }
        }
        private void btn_NoSelect_AllPersons_Click(object sender, EventArgs e)
        {
            try
            {
                string Chose_Chosed_IDs = Get_Dgv_IDs(this.dgv_Person_Info_Chosed, 1);
                if (Chose_Chosed_IDs == "")
                {
                    MessageBox.Show("没有要移动的数据！");
                    return;
                }
                string Wait_Chosed_IDs = Get_Dgv_IDs(this.dgv_Person_Info_Wait, 1);
                BindData(Chose_Chosed_IDs + "," + Wait_Chosed_IDs, dgv_Person_Info_Wait, dgv_Person_Info_Chosed, 1);
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常：" + ex.Message);
            }

        }


        #endregion 全选移动数据


        #region 左右部分移动数据

        private void btn_Select_Door_Click(object sender, EventArgs e)
        {
            string Wait_Chosed_IDs_Selected = Get_Dgv_IDs(this.dgv_Door_Info_Wait, 0);
            if (Wait_Chosed_IDs_Selected == "")
            {
                MessageBox.Show("没有要移动的数据！");
                return;
            }
            else
            {
                string Wait_Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Door_Info_Wait, 1);
                string Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Door_Info_Chose, 1);
                string Chosed_IDs = Wait_Chosed_IDs_Selected + "," + Chosed_IDs_All;
                string Wait_IDs = GetIDs(Wait_Chosed_IDs_All, Wait_Chosed_IDs_Selected);
                BindData(Wait_IDs, Chosed_IDs, dgv_Door_Info_Wait, dgv_Door_Info_Chose, 0);
            }
        }

        private void btn_NoSelect_Door_Click(object sender, EventArgs e)
        {
            string Wait_Chosed_IDs_Selected = Get_Dgv_IDs(this.dgv_Door_Info_Chose, 0);
            if (Wait_Chosed_IDs_Selected == "")
            {
                MessageBox.Show("没有要移动的数据！");
                return;
            }
            else
            {
                string Wait_Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Door_Info_Chose, 1);
                string Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Door_Info_Wait, 1);
                string Chosed_IDs = Wait_Chosed_IDs_Selected + "," + Chosed_IDs_All;
                string Wait_IDs = GetIDs(Wait_Chosed_IDs_All, Wait_Chosed_IDs_Selected);
                BindData(Wait_IDs, Chosed_IDs, dgv_Door_Info_Chose, dgv_Door_Info_Wait, 0);
            }
        }





        private void btn_Select_Person_Click(object sender, EventArgs e)
        {
            string Wait_Chosed_IDs_Selected = Get_Dgv_IDs(this.dgv_Person_Info_Wait, 0);
            if (Wait_Chosed_IDs_Selected == "")
            {
                MessageBox.Show("没有要移动的数据！");
                return;
            }
            else
            {
                string Wait_Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Person_Info_Wait, 1);
                string Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Person_Info_Chosed, 1);
                string Chosed_IDs = Wait_Chosed_IDs_Selected + "," + Chosed_IDs_All;
                string Wait_IDs = GetIDs(Wait_Chosed_IDs_All, Wait_Chosed_IDs_Selected);
                BindData(Wait_IDs, Chosed_IDs, dgv_Person_Info_Wait, dgv_Person_Info_Chosed, 1);
            }
        }

        private void btn_NoSelect_Person_Click(object sender, EventArgs e)
        {
            string Wait_Chosed_IDs_Selected = Get_Dgv_IDs(this.dgv_Person_Info_Chosed, 0);
            if (Wait_Chosed_IDs_Selected == "")
            {
                MessageBox.Show("没有要移动的数据！");
                return;
            }
            else
            {
                string Wait_Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Person_Info_Chosed, 1);
                string Chosed_IDs_All = Get_Dgv_IDs(this.dgv_Person_Info_Wait, 1);
                string Chosed_IDs = Wait_Chosed_IDs_Selected + "," + Chosed_IDs_All;
                string Wait_IDs = GetIDs(Wait_Chosed_IDs_All, Wait_Chosed_IDs_Selected);
                BindData(Wait_IDs, Chosed_IDs, dgv_Person_Info_Chosed, dgv_Person_Info_Wait, 1);
            }
        }

        #endregion 左右部分移动数据


        #endregion 按钮点击事件



        #region 方法



        private void bindData_ByID()
        {
            string sql = @"select * from Door_Right_Group_Info drgi where drgi.id=" + _ID;
            DataTable dt = DataAccess.dataTable(sql);
            if (dt.Rows.Count >= 1)
            {
                txt_Door_Right.Text = dt.Rows[0]["Group_Name"].ToString();
                cb_Door_Zone.SelectedValue = Convert.ToInt32(dt.Rows[0]["TimeZone_ID"].ToString());
                string door_ids = dt.Rows[0]["Door_IDs"].ToString();
                string person_ids = dt.Rows[0]["Person_IDs"].ToString();
                string all_door_ids = Get_All_IDs_ByTableNames("Door_Info");
                string all_person_ids = Get_All_IDs_ByTableNames("Person_Info");
                string ids_left = GetIDs(all_door_ids, door_ids);
                BindData(ids_left, door_ids, dgv_Door_Info_Wait, dgv_Door_Info_Chose, 0);
                string person_letf_ids = GetIDs(all_person_ids, person_ids);
                BindData(person_letf_ids, person_ids, dgv_Person_Info_Wait, dgv_Person_Info_Chosed, 1);
                // 
            }

        }

        private string Get_All_IDs_ByTableNames(string tableName)
        {
            string sql = "select ID from " + tableName;
            string result = "";
            DataTable dt = DataAccess.dataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result += dt.Rows[i]["ID"] + ",";
            }
            if (!string.IsNullOrEmpty(result))
               result= result.Substring(0, result.Length - 1);
            return result;
        }

        /// <summary>
        /// 获取选中行的ID
        /// </summary>
        /// <param name="dgv">要获取id的datagridview控件</param>
        /// <param name="is_SelectAll">所选中的所有id</param>
        /// <returns></returns>
        private string Get_Dgv_IDs(DataGridView dgv, int is_SelectAll)
        {

            string result = string.Empty;
            try
            {
                if (dgv.Rows.Count <= 0)
                {
                    result = "";
                }
                else
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        if (is_SelectAll == 1)
                        {
                            result += dgv.Rows[i].Cells[1].Value.ToString() + ",";
                        }
                        else
                        {
                            if (null != dgv.Rows[i].Cells[0].Value)
                            {
                                if ((bool)dgv.Rows[i].Cells[0].Value)
                                {
                                    result += dgv.Rows[i].Cells[1].Value.ToString() + ",";
                                }
                                else continue;
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {

                result = "";
            }
            if (!string.IsNullOrEmpty(result)) result = result.Substring(0, result.Length - 1);
            return result;
        }



        /// <summary>
        /// 获取选中的dgv中的名称列
        /// </summary>
        /// <param name="dgv">要提取数据的Datagridview</param>
        /// <returns></returns>
        private string Get_Dgv_Names(DataGridView dgv)
        {

            string result = string.Empty;
            try
            {
                if (dgv.Rows.Count <= 0)
                {
                    result = "";
                }
                else
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        result += dgv.Rows[i].Cells[2].Value.ToString() + ",";
                    }
                }
            }
            catch (Exception)
            {

                result = "";
            }
            if (!string.IsNullOrEmpty(result)) result = result.Substring(0, result.Length - 1);
            return result;
        }


        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="dgv_Bind"></param>
        /// <param name="dgv_Clear"></param>
        /// <param name="flag"></param>
        private void BindData(string ids, DataGridView dgv_Bind, DataGridView dgv_Clear, int flag)
        {
            try
            {
                string sql = string.Empty;
                DataTable dt = null;
                if (flag == 0)
                {
                    sql = @"select di.id, di.door_Name,ci.Controller_Name from door_info di,controller_info ci where di.controller_id=ci.id and di.id in(" + ids + ")";
                    dt = DataAccess.dataTable(sql);
                    dgv_Bind.DataSource = dt.DefaultView;
                    sql = @"select di.id, di.door_Name,ci.Controller_Name from door_info di,controller_info ci where 1=2";
                    dt = DataAccess.dataTable(sql);
                    dgv_Clear.DataSource = dt.DefaultView;
                }
                else
                {
                    sql = @"select pi.id,pi.name,pi.cardid from Person_Info pi where pi.id in (" + ids + ");";
                    dt = DataAccess.dataTable(sql);
                    dgv_Bind.DataSource = dt.DefaultView;
                    sql = @"select pi.id,pi.name,pi.cardid from Person_Info pi where 1=2";
                    dt = DataAccess.dataTable(sql);
                    dgv_Clear.DataSource = dt.DefaultView;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="ids"></param>
        /// <param name="dgv_Bind"></param>
        /// <param name="dgv_Clear"></param>
        /// <param name="flag"></param>
        private void BindData(string IDs_Left, string IDs_Right, DataGridView dgv_Letf, DataGridView dgv_Right, int flag)
        {
            try
            {
                string sql = string.Empty;
                DataTable dt = null;
                if (flag == 0)
                {
                    sql = @"select di.id, di.door_Name,ci.Controller_Name from door_info di,controller_info ci where di.controller_id=ci.id  ";
                    if (IDs_Left != "")
                        sql += " and di.id in(" + IDs_Left + ")";
                    else sql += " and 1=2 ";
                    dt = DataAccess.dataTable(sql);
                    dgv_Letf.DataSource = dt.DefaultView;
                    sql = @"select di.id, di.door_Name,ci.Controller_Name from door_info di,controller_info ci where di.controller_id=ci.id ";
                    if (IDs_Right != "")
                        sql += " and di.id in(" + IDs_Right + ")";
                    else sql += " and 1=2 ";
                    dt = DataAccess.dataTable(sql);
                    dgv_Right.DataSource = dt.DefaultView;
                }
                else
                {
                    sql = @"select pi.id,pi.name,pi.cardid from Person_Info pi where  ";
                    if (IDs_Left != "")
                        sql += " pi.id in(" + IDs_Left + ")";
                    else sql += "  1=2 ";
                    dt = DataAccess.dataTable(sql);
                    dgv_Letf.DataSource = dt.DefaultView;
                    sql = @"select pi.id,pi.name,pi.cardid from Person_Info pi where ";
                    if (IDs_Right != "")
                        sql += " pi.id in (" + IDs_Right + ")";
                    else sql += " 1=2 ";
                    dt = DataAccess.dataTable(sql);
                    dgv_Right.DataSource = dt.DefaultView;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }





        /// <summary>
        /// 把选中的列id去掉
        /// </summary>
        /// <param name="All_IDs">所用id 如：1,2,3,4,5,6</param>
        /// <param name="Sub_IDs">选中的id如： 2，4，6</param>
        /// <returns>去掉选中id后的id如：1,3</returns>
        private string GetIDs(string All_IDs, string Sub_IDs)
        {
            string result = string.Empty;
            try
            {

                string[] all_ids = All_IDs.Split(',');
                string[] sub_ids = Sub_IDs.Split(',');
                string[] sub_IDs = all_ids.Distinct().Except(sub_ids).ToArray();
                foreach (var item in sub_IDs)
                {
                    result += (item + ",");
                }
            }
            catch (Exception)
            {

                result = "";
            }
            if (result == "") return "";
            else return result.Substring(0, result.Length - 1);
        }



        private void Init_TimeRange()
        {
            try
            {
                string sql = "select id,TimeRange_Name from Door_TimeZone_Info ";
                DataTable dt = DataAccess.dataTable(sql);
                this.cb_Door_Zone.DataSource = dt.DefaultView;
                cb_Door_Zone.ValueMember = "id";
                cb_Door_Zone.DisplayMember = "TimeRange_Name";
                cb_Door_Zone.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("初始化门时间段信息失败： " + ex.Message);
            }


        }



        /// <summary>
        /// 获取所有门所属的控制器ID
        /// </summary>
        /// <param name="door_ids"></param>
        /// <returns></returns>
        private List<string> Get_Controler_IDs(string door_ids)
        {
            List<string> result = new List<string>();
            string sql = "select distinct Controller_ID from Door_Info hi where id in(" + door_ids + ")";
            DataTable dt = DataAccess.dataTable(sql);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                result.Add(dt.Rows[i][0].ToString());
            }
            return result;
        }


        #endregion 方法


        #region 关闭窗口

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 关闭窗口

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_Door_Right.Text.Trim() == "")
            {
                MessageBox.Show("请输入门权限组名称!");
                return;
            }
            if (dgv_Door_Info_Chose.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何门！");
                return;
            }
            if (dgv_Person_Info_Chosed.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何人！");
                return;
            }
            try
            {
                string door_ids = Get_Dgv_IDs(dgv_Door_Info_Chose, 1);
                List<string> T_Sqls = new List<string>();
                List<string> Controller_IDs = Get_Controler_IDs(door_ids);
                string door_Right = this.txt_Door_Right.Text.Trim();
                int door_timeZone = (int)this.cb_Door_Zone.SelectedValue;
                string person_ids = Get_Dgv_IDs(dgv_Person_Info_Chosed, 1);
                string door_names = Get_Dgv_Names(dgv_Door_Info_Chose);
                string person_names = Get_Dgv_Names(dgv_Person_Info_Chosed);
                string sql = "select max(hi.id) from Door_Right_Group_Info hi ";
                int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
                int i = 0;
                foreach (var item in Controller_IDs)
                {
                    string sql_Controller_Group = "select count(1)as counts from cotroller_group_info where Controller_id=" + item + " group by Controller_id ";

                    DataTable dt = DataAccess.dataTable(sql_Controller_Group);
                    int New_ID_Controller_Group = 0;
                    if (dt.Rows.Count<=0) New_ID_Controller_Group = 0;
                    else
                    {
                        New_ID_Controller_Group = Convert.ToInt32(dt.Rows[0]["counts"]);
                    }
                    if (New_ID_Controller_Group > 16)
                    {
                        MessageBox.Show("对不起，您所设置的控制器已超过16个权限组，详情请连接管理员!");
                        return;
                    }
                    else
                    {
                       
                        string Insert_Controller_Groupt = string.Empty;
                        if (!_IsModify)
                        {
                            string sql_Controller_Groupt = "select max(hi.id) from cotroller_group_info hi ";
                            int New_ID_Controller_Groupt = Convert.ToInt32(DataAccess.ExecuteScalar(sql_Controller_Groupt)) + 1+i;
                            i++;
                            New_ID_Controller_Group++;
                            Insert_Controller_Groupt = "insert into cotroller_group_info values(" + New_ID_Controller_Groupt + "," + item + "," + New_ID_Controller_Group + "," + door_timeZone + "," + New_ID + ",'系统自动添加')";
                            T_Sqls.Add(Insert_Controller_Groupt);
                        }
                       
                    }
                }

                string T_Sql = string.Empty;
                if (_IsModify)
                {
                    T_Sql = @"update Door_Right_Group_Info set Group_Name='" + door_Right + "',TimeZone_ID=" + door_timeZone + ",Door_IDs='" + door_ids + "',door_names='" + door_names + "',Person_IDs='" + person_ids + "',Person_Names='" + person_names + "' where id=" + _ID;
                }
                else
                {
                    T_Sql = "insert into door_right_group_info values(" + New_ID + ",'" + door_Right + "'," + door_timeZone + ",'" + door_ids + "','" + door_names + "','" + person_ids + "','" + person_names + "');";
                }
                T_Sqls.Add(T_Sql);
                if (DataAccess.excuteSqlAndReturnValues(T_Sqls) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "门权限组信息成功");
                    LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "门权限组信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());

                    this.Close();
                }

                else
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "门权限组信息失败!");

               


            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "门权限组信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "门权限组信息错误,异常信息为: !" + ex.Message);
            }
        }


    }
}
