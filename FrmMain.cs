/********************************************************************
 * *
 * * 创建时间：2013-12-08
 * * 说明：FrmMain.cs
 * *
********************************************************************/

using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RST_ReadSDData;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Threading;

namespace Demo
{
    public partial class FrmMain : CCSkinMain
    {


        //文件夹
        int FileCount = 0;
        //文件
        int Document = 0;
        /*----------声明委托----------*/
        //显示状态
        private delegate void ShwStatusInfoCallBack(string str);
        private ShwStatusInfoCallBack shwStatusInfoCallBack;

        //显示进度
        private delegate void ShwProgressProcCallBack(int progress);
        private ShwProgressProcCallBack shwProgressProcCallBack;


        //异步调用(与要调用的方法具有相同签名)
        private delegate void ReceiveMessageDelegate(out string receiveMessage);
        private delegate void SendMessageDelegate(string sendMessage);


        //显示状态
        private void ShwStatusInfo(string str)
        {
            toolStripStatusInfo.Text = str;
        }

        //显示进度
        private void shwProgressProc(int progress)
        {
            toolStripProgressProc.Value = progress;
        }



        /*- - - - - - -  - - - -定义回调函数 - - - - - - - - - - */
        //接受请求
        private void AcceptClientConnect()
        {
            statusStripInfo.Invoke(shwStatusInfoCallBack, "程序初始化中. . .");
            //间歇延时
            DateTime nowtime = DateTime.Now;
            while (nowtime.AddSeconds(1) > DateTime.Now) { }
            int i = 2;
            while (i < 100)
            {
                statusStripInfo.Invoke(shwProgressProcCallBack, i);
                i++;
                Thread.Sleep(1);
            }
            statusStripInfo.Invoke(shwStatusInfoCallBack, "等待操作");
        }

        public FrmMain()
        {

            /*---------------定义委托---------------------*/
            //显示状态
            shwStatusInfoCallBack = new ShwStatusInfoCallBack(ShwStatusInfo);
            //显示进度
            shwProgressProcCallBack = new ShwProgressProcCallBack(shwProgressProc);
            //toolStripProgressProc.Minimum = 0;


            InitializeComponent();
            txt_Person_Search.Text = "请输入查询条件进行数据检索";
            txt_Operater_Search.Text = "请输入查询条件进行数据检索";
            txt_Area_Serach.Text = "请输入查询条件进行数据检索";
            txt_search_holiday.Text = "请输入查询条件进行数据检索";
            txt_search_doorInfo.Text = "请输入查询条件进行数据检索";
            txt_Search_DoorRange.Text = "请输入查询条件进行数据检索";
            txt_Log.Text = "请输入查询条件进行数据检索";
            txt_Door_Right.Text = "请输入查询条件进行数据检索";
            txt_Today_Actions.Text = "请输入查询条件进行数据检索";
            txt_Exception.Text = "请输入查询条件进行数据检索";
            txt_Dept.Text = "请输入查询条件进行数据检索";
            txt_Animal_Search.Text = "请输入查询条件进行数据检索";
            InitdrvCSS(dgv_Person_Data);
            InitdrvCSS(dgv_Animal);
            InitdrvCSS(dgv_Operater_Data);
            InitdrvCSS(dgv_Area_Data);
            InitdrvCSS(dgv_holiday);
            InitdrvCSS(dgv_door_info);
            InitdrvCSS(dgv_Door_Range_Data);
            InitdrvCSS(dgv_Log);
            InitdrvCSS(dgv_Today_Actions);
            InitdrvCSS(this.dgv_Door_Right);
            InitdrvCSS(dgv_Exception);
            InitdrvCSS(dgv_Dept);
            InitdrvCSS(dgv_Actions);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btn_search_Click(null, null);
            skinTabControl1.SelectedIndex = 6;
            //timer_GetData.Enabled = true;
            //timer_GetData.Tick += new EventHandler(timerSetTime_Tick);  重要 记得取消注释
        }




        private void InitdrvCSS(DataGridView dgv)
        {
    
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.ForeColor= Color.Black;

            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDark;

            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 23;
            dgv.RowTemplate.ReadOnly = true;

        }



        private void skinWaterTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Person_Search.Text == "") txt_Person_Search.Text = "请输入查询条件进行数据检索";
        }

        private void skinWaterTextBox1_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Person_Search.Text == "请输入查询条件进行数据检索") txt_Person_Search.Text = "";
        }

        private void txt_Operater_Search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Operater_Search.Text == "请输入查询条件进行数据检索") txt_Operater_Search.Text = "";
        }

        private void txt_Operater_Search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Operater_Search.Text == "") txt_Operater_Search.Text = "请输入查询条件进行数据检索";
        }

        private void txt_Area_Serach_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Area_Serach.Text == "请输入查询条件进行数据检索") txt_Area_Serach.Text = "";
        }

        private void txt_Area_Serach_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Area_Serach.Text == "") txt_Area_Serach.Text = "请输入查询条件进行数据检索";
        }

        private void txt_search_holiday_MouseEnter(object sender, EventArgs e)
        {
            if (txt_search_holiday.Text == "请输入查询条件进行数据检索") txt_search_holiday.Text = "";
        }

        private void txt_search_holiday_MouseLeave(object sender, EventArgs e)
        {
            if (txt_search_holiday.Text == "") txt_search_holiday.Text = "请输入查询条件进行数据检索";
        }

        private void txt_search_doorInfo_MouseEnter(object sender, EventArgs e)
        {
            if (txt_search_doorInfo.Text == "请输入查询条件进行数据检索") txt_search_doorInfo.Text = "";
        }

        private void txt_search_doorInfo_MouseLeave(object sender, EventArgs e)
        {
            if (txt_search_doorInfo.Text == "") txt_search_doorInfo.Text = "请输入查询条件进行数据检索";
        }

        private void txt_Search_DoorRange_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Search_DoorRange.Text == "请输入查询条件进行数据检索") txt_Search_DoorRange.Text = "";
        }
        private void txt_Search_DoorRange_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Search_DoorRange.Text == "") txt_Search_DoorRange.Text = "请输入查询条件进行数据检索";
        }

        private void txt_Log_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Log.Text == "请输入查询条件进行数据检索") txt_Log.Text = "";
        }

        private void txt_Log_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Log.Text == "") txt_Log.Text = "请输入查询条件进行数据检索";
        }

        private void txt_Door_Right_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Door_Right.Text == "请输入查询条件进行数据检索") txt_Door_Right.Text = "";
        }
        private void txt_Door_Right_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Door_Right.Text == "") txt_Door_Right.Text = "请输入查询条件进行数据检索";
        }
        private void txt_Today_Actions_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Today_Actions.Text == "请输入查询条件进行数据检索") txt_Today_Actions.Text = "";
        }

        private void txt_Today_Actions_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Today_Actions.Text == "") txt_Today_Actions.Text = "请输入查询条件进行数据检索";
        }


        private void txt_Exception_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Exception.Text == "请输入查询条件进行数据检索") txt_Exception.Text = "";
        }

        private void txt_Exception_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Exception.Text == "") txt_Exception.Text = "请输入查询条件进行数据检索";
        }

        private void txt_Dept_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Dept.Text == "请输入查询条件进行数据检索") txt_Dept.Text = "";
        }

        private void txt_Dept_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Dept.Text == "") txt_Dept.Text = "请输入查询条件进行数据检索";
        }

        private void txt_Animal_Search_MouseEnter(object sender, EventArgs e)
        {
            if (txt_Animal_Search.Text == "请输入查询条件进行数据检索") txt_Animal_Search.Text = "";
        }

        private void txt_Animal_Search_MouseLeave(object sender, EventArgs e)
        {
            if (txt_Animal_Search.Text == "") txt_Animal_Search.Text = "请输入查询条件进行数据检索";
        }


        /// <summary>
        /// 查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                //Switch(pi.isapbcheck='1','是',pi.isapbcheck ='0','否') AS isapbcheck  ,pi.email,pi.Identity_NO,ti.IACUC_GroupName,ti.approval_date,ti.experiment_timerange,ti.topic_name,pi,ti.applicant,ti.ap,ti.animal_species,ti.animal_count,pi.content from person_info pi ,Test_Info ti where pi.Identity_NO=ti.Identity_NO ";
                //string sql = @"select pi.id ,pi.name,pi.phone,pi.cardid,pi.cardtype,pi.pinpwd,
                //               Switch(pi.isapbcheck='1','是',pi.isapbcheck ='0','否') AS isapbcheck  ,
                //                pi.email,pi.Identity_NO,ti.IACUC_GroupName,ti.approval_date,ti.experiment_timerange,ti.topic_name,pi,ti.applicant,ti.ap,ti.animal_species,ti.animal_count,pi.content from person_info pi ,Test_Info ti   where pi.Identity_NO=ti.Identity_NO";


                string sql = @"select person_info.id ,person_info.name,person_info.phone,person_info.cardid,person_info.cardtype,      
                                Switch(person_info.isapbcheck='1','是',person_info.isapbcheck ='0','否') AS isapbcheck  ,
                                person_info.email,
                                person_info.Identity_NO,
                                Test_Info.IACUC_GroupName,
                                Test_Info.approval_date,
                                Test_Info.experiment_timerange,
                                Test_Info.topic_name,
                                Test_Info.applicant,
                                Test_Info.ap,
                                Test_Info.animal_species,
                                Test_Info.animal_count,
                                person_info.content from person_info left join Test_Info on person_info.Identity_NO=Test_Info.Identity_NO";



                string search_text = this.txt_Person_Search.Text.Trim();
                if (search_text != "" && search_text != "请输入查询条件进行数据检索")
                    sql += " where (person_info.name like '*" + search_text + "*' or person_info.phone like '*" + search_text + "*' or person_info.email like '*" + search_text + "*' or person_info.cardid like '*" + search_text + "*' or person_info.content like '*" + search_text + "*')";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Person_Data.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据获取失败 : " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }


        /// <summary>
        /// 添加人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Add_Person add_Person = new Add_Person();
            add_Person.ShowDialog();  // 显示窗体
            if (add_Person.DialogResult == DialogResult.OK)
            {
                btn_search_Click(null, null);
            }
        }

        /// <summary>
        /// 修改人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdatePerson_Click(object sender, EventArgs e)
        {
            if (dgv_Person_Data.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Person_Data.CurrentCell.RowIndex;
                string id = dgv_Person_Data.Rows[rowIndex].Cells[0].Value.ToString();
                Add_Person add_person = new Add_Person(Convert.ToInt32(id));
                add_person.ShowDialog();
                if (add_person.DialogResult == DialogResult.OK)
                {
                    btn_search_Click(null, null);
                }
            }
        }
        /// <summary>
        /// 删除人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DelPerson_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Person_Data.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_Person_Data.CurrentCell.RowIndex;
                        string id = dgv_Person_Data.Rows[rowIndex].Cells[2].Value.ToString();
                        //string id = dgv_Person_Data.Rows[rowIndex].Cells[2].Value.ToString();//正解
                        string T_Sql = "delete from Person_Info where id=" + id;

                        if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                        {

                            LogHelper.WriteLog("【删除】", "删除人员信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除人员信息成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_search_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除人员段信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除人员信息失败!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除人员信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除人员息异常!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 导入人员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_InportPerson_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();//打开文件对话框。   
            openFile.Filter = ("Excel 文件(*.xls)|*.xls");//后缀名。   
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string excelPath = openFile.FileName;
                byte[] fileBytes = File.ReadAllBytes(excelPath);
                if (ExcelRender.HasData(new MemoryStream(fileBytes)))
                {
                    if (ExcelRender.RenderToDb(new MemoryStream(fileBytes), null, null))
                    {
                        LogHelper.WriteLog("【导入】", "导入试验成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                        MessageBox.Show("导入试验成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LogHelper.WriteLog("【导入】", "导入试验失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                        MessageBox.Show("导入试验失败!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }





        }


        /// <summary>
        /// 设备查询事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_searchOperater_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                string sql = "select ci.id,ci.controller_name,ci.controller_id,ci.door_count,ai.area,ci.communication_mode,ci.serialno,ci.RS485_Adress,ci.bondrode,ci.content from Controller_info ci ,area_info ai where ci.area_id=ai.id";
                string txt_Operater = this.txt_Operater_Search.Text.Trim();
                if (txt_Operater != "" && txt_Operater != "请输入查询条件进行数据检索")
                    sql += " and ( ci.controller_name like '%" + txt_Operater + "%' or ci.controller_id like '%" + txt_Operater + "%' or ci.communication_mode like '%" + txt_Operater + "%' or ci.serialno like '%" + txt_Operater + "%' or ci.bondrode like '%" + txt_Operater + "%' or ai.area like '%" + txt_Operater + "%')";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Operater_Data.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("设备数据查询失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }

        /// <summary>
        /// 添加设备信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddOperater_Click(object sender, EventArgs e)
        {
            Add_Operater add_operater = new Add_Operater();
            add_operater.ShowDialog();
            if (add_operater.DialogResult == DialogResult.OK)
            {
                btn_searchOperater_Click(null, null);
            }
        }

        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_UpdateOperater_Click(object sender, EventArgs e)
        {
            if (dgv_Operater_Data.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Operater_Data.CurrentCell.RowIndex;
                string id = dgv_Operater_Data.Rows[rowIndex].Cells[0].Value.ToString();
                Add_Operater add_operater = new Add_Operater(Convert.ToInt32(id));
                add_operater.ShowDialog();
                if (add_operater.DialogResult == DialogResult.OK)
                {
                    btn_searchOperater_Click(null, null);
                }

            }

        }

        /// <summary>
        /// 删除设备信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_DelOperater_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Operater_Data.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_Operater_Data.CurrentCell.RowIndex;
                        string id = dgv_Operater_Data.Rows[rowIndex].Cells[0].Value.ToString();
                        List<string> T_Sqls = new List<string>();
                        T_Sqls.Add("delete from door_info where Controller_ID=" + id);
                        T_Sqls.Add("delete from Controller_Info where id=" + id);


                        if (DataAccess.excuteSqlAndReturnValues(T_Sqls) > 0)
                        {

                            LogHelper.WriteLog("【删除】", "删除设置信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除设置信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_searchOperater_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除设置段信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除设置信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除设置信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除设置信息异常:" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// 区域搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_serach_area_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                string sql = "select a.id, a.area_id,a.area,a.content,b.area as Father_Name from area_info as a,area_info as b where a.father_id=b.id";
                string area_search = this.txt_Area_Serach.Text.Trim();
                if (area_search != "" && area_search != "请输入查询条件进行数据检索")
                    sql += " and ( a.area_id like '%" + area_search + "%' or a.area like '%" + area_search + "%')";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Area_Data.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据查询失败 :  " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }

        /// <summary>
        /// 区域添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Area_Click(object sender, EventArgs e)
        {
            Add_Area add_area = new Add_Area();
            add_area.ShowDialog();
            if (add_area.DialogResult == DialogResult.OK)
            {
                btn_serach_area_Click(null, null);
            }
        }

        /// <summary>
        /// 区域修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Update_Area_Click(object sender, EventArgs e)
        {
            if (dgv_Area_Data.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Area_Data.CurrentCell.RowIndex;
                string id = dgv_Area_Data.Rows[rowIndex].Cells[0].Value.ToString();
                Add_Area add_area = new Add_Area(Convert.ToInt32(id));
                add_area.ShowDialog();
                if (add_area.DialogResult == DialogResult.OK)
                {
                    btn_serach_area_Click(null, null);
                }
            }
        }


        /// <summary>
        /// 删除区域事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Del_Area_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Area_Data.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_Area_Data.CurrentCell.RowIndex;
                        string id = dgv_Area_Data.Rows[rowIndex].Cells[0].Value.ToString();
                        string T_Sql = "delete from area_info where id=" + id;

                        if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                        {


                            LogHelper.WriteLog("【删除】", "删除区域信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除区域信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_serach_area_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除区域段信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除区域信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除区域信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除区域信息异常:" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_search_holiday_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                string sql = @"select hi.id,hi.name,ht.holiday_name,hi.begin_date,hi.end_date,
Switch(is_cycle=1,'是',is_cycle =0,'否') AS is_cycle,hi.content 
from holiday_info hi,holiday_type ht 
where  hi.type=ht.id";
                string search_holiday = this.txt_search_holiday.Text.Trim();
                if (search_holiday != "" && search_holiday != "请输入查询条件进行数据检索")
                    sql += " and ( hi.name like '%" + search_holiday + "%' or ht.holiday_name like '%" + search_holiday + "%' or hi.begin_date like '%" + search_holiday + "%' or hi.end_date like '%" + search_holiday + "%')";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_holiday.DataSource = dt.DefaultView;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }

        private void btn_add_holiday_Click(object sender, EventArgs e)
        {
            Add_Holiday add_holiday = new Add_Holiday();
            add_holiday.ShowDialog();
            if (add_holiday.DialogResult == DialogResult.OK)
            {
                btn_search_holiday_Click(null, null);
            }
        }

        private void btn_update_holiday_Click(object sender, EventArgs e)
        {
            if (dgv_holiday.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_holiday.CurrentCell.RowIndex;
                string id = dgv_holiday.Rows[rowIndex].Cells[0].Value.ToString();
                Add_Holiday add_holiday = new Add_Holiday(Convert.ToInt32(id));
                add_holiday.ShowDialog();
                if (add_holiday.DialogResult == DialogResult.OK)
                {
                    btn_search_holiday_Click(null, null);
                }
            }
        }

        private void btn_del_holiday_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_holiday.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_holiday.CurrentCell.RowIndex;
                        string id = dgv_holiday.Rows[rowIndex].Cells[0].Value.ToString();
                        string T_Sql = "delete from Holiday_Info where id=" + id;

                        if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                        {
                            LogHelper.WriteLog("【删除】", "删除假日信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除假日信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_search_holiday_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除假日信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除假日信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除假日信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除假日信息异常:" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void skinButton1_Click(object sender, EventArgs e)
        {

            if (dgv_holiday.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info ");
                string msg = "";
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int ID = Convert.ToInt32(dt.Rows[i]["controller_id"].ToString());
                        int ComNO = Convert.ToInt32(dt.Rows[i]["serialNO"].ToString());
                        string bondRode = dt.Rows[i]["bondRode"].ToString();
                        int rowIndex = dgv_holiday.CurrentCell.RowIndex;
                        string type = dgv_holiday.Rows[rowIndex].Cells[2].Value.ToString().Substring(4, 1);
                        string begin_time = dgv_holiday.Rows[rowIndex].Cells[3].Value.ToString();
                        string end_time = dgv_holiday.Rows[rowIndex].Cells[4].Value.ToString();
                        int begin_MM = Convert.ToInt32(begin_time.Split('-')[1]);
                        char[] Days = new char[] { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
                        int begin = Convert.ToInt32(begin_time.Split('-')[2]);//5.1
                        int end = Convert.ToInt32(end_time.Split('-')[2]);//5.3
                        for (int index = begin; index <= end; index++)
                        {
                            Days[index - 1] = Convert.ToChar(type);

                        }
                        string days = new string(Days);
                        if (Common.Common.SetHolidayTable(ID, ComNO, bondRode, begin_MM, days, ref msg) == 1)
                        {
                            msg = i.ToString();
                        }

                    }
                    if (msg != dt.Rows.Count.ToString())
                    {
                        MessageBox.Show("更新控制器假日信息失败 !", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("更新控制器假日信息成功 !", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }



        }

        private void btn_search_door_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                string sql = @"select di.id,ci.Controller_Name,di.door_name,di.door_no,
Switch(Is_Attendance_Record=1,'是',Is_Attendance_Record =0,'否') AS Is_Attendance_Record,di.content
from door_info di,controller_info ci 
where di.Controller_ID=ci.id ";

                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_door_info.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取门信息失败 : " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }

        private void btn_Update_door_Click(object sender, EventArgs e)
        {
            if (dgv_door_info.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_door_info.CurrentCell.RowIndex;
                string id = dgv_door_info.Rows[rowIndex].Cells[0].Value.ToString();
                Modify_Door add_holiday = new Modify_Door(Convert.ToInt32(id));
                add_holiday.ShowDialog();
                if (add_holiday.DialogResult == DialogResult.OK)
                {
                    btn_search_door_Click(null, null);
                }
            }
        }




        /// <summary>
        /// 查询时间段信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Door_Range_Search_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                string sql = @"select ID,TimeRange_Name,Content from Door_TimeZone_Info";
                string Search_DoorRange = this.txt_Search_DoorRange.Text.Trim();
                if (Search_DoorRange != "" && Search_DoorRange != "请输入查询条件进行数据检索")
                    sql += " where  TimeRange_Name like '%" + Search_DoorRange + "%' or content like '%" + Search_DoorRange + "%'";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Door_Range_Data.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取门时间段信息失败 : " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }


        private void btn_Add_DoorRange_Click(object sender, EventArgs e)
        {
            try
            {
                Add_DoorTimeRanger add_door_timeRanger = new Add_DoorTimeRanger();
                add_door_timeRanger.ShowDialog();
                if (add_door_timeRanger.DialogResult == DialogResult.OK)
                {
                    btn_Door_Range_Search_Click(null, null);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btn_Update_DoorRange_Click(object sender, EventArgs e)
        {
            if (dgv_Door_Range_Data.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Door_Range_Data.CurrentCell.RowIndex;
                string id = dgv_Door_Range_Data.Rows[rowIndex].Cells[0].Value.ToString();
                Add_DoorTimeRanger add_door_timeRanger = new Add_DoorTimeRanger(Convert.ToInt32(id));
                add_door_timeRanger.ShowDialog();
                if (add_door_timeRanger.DialogResult == DialogResult.OK)
                {
                    btn_Door_Range_Search_Click(null, null);
                }
            }
        }

        private void btn_Del_DoorRange_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Door_Range_Data.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_Door_Range_Data.CurrentCell.RowIndex;
                        string id = dgv_Door_Range_Data.Rows[rowIndex].Cells[0].Value.ToString();
                        string T_Sql = "delete from Door_TimeZone_Info where id=" + id;
                        if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                        {
                            LogHelper.WriteLog("【删除】", "删除时间段信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除时间段信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Door_Range_Search_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除时间段信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除时间段信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除时间段信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除时间段信息失败: " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        /// <summary>
        /// 保存时间段信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "操作进行中,请稍后 . . . ");
                int index_Process = 2;
                while (index_Process < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
                List<string> list_TSql = new List<string>();
                string sql = string.Empty;
                for (int i = 0; i < 30; i++)
                {
                    string id = (i + 2).ToString();
                    string index = (i + 1).ToString();
                    string begin_time = ((DateTimePicker)this.Controls.Find("dtp_Begin_Time" + index, true)[0]).Text;
                    string end_Time = ((DateTimePicker)this.Controls.Find("dtp_End_Time" + index, true)[0]).Text;
                    sql = "update time_range set begin_time='" + begin_time + "',end_time='" + end_Time + "'  where id=" + id + " and Timer_NO='" + ((i + 1) > 9 ? (i + 1).ToString() : ("0" + (i + 1).ToString())) + "'";

                    list_TSql.Add(sql);
                }
                if (DataAccess.excuteSqlAndReturnValues(list_TSql) > 0)
                {
                    DataTable dt = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info ");
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            int ID = Convert.ToInt32(dt.Rows[i]["controller_id"].ToString());
                            int ComNO = Convert.ToInt32(dt.Rows[i]["serialNO"].ToString());
                            string bondRode = dt.Rows[i]["bondRode"].ToString();
                            Save_TimeRange(ID, ComNO, bondRode);
                        }
                    }
                    LogHelper.WriteLog("【更新】", "更新时间段信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    MessageBox.Show("更新时间段信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    LogHelper.WriteLog("【更新】", "更新时间段信息失败", 1, "失败", Program.Login_User, DateTime.Now.ToString());
                    MessageBox.Show("更新时间段信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("更新时间段信息失败: " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "操作完成!");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }


        private void btn_Search_Dept_Info_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                string sql = "select * from Sys_Dept_Info sdi where 1=1 ";
                string txt_Operater = this.txt_Dept.Text.Trim();
                if (txt_Operater != "" && txt_Operater != "请输入查询条件进行数据检索")
                    sql += " and ( sdi.Dept_NO like '%" + txt_Operater + "%' or sdi.Dept_Name like '%" + txt_Operater + "%' or sdi.Content like '%" + txt_Operater + "%')";
                sql += " order by id";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Dept.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("设备数据查询失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }



        private void btn_Add_Dept_Click(object sender, EventArgs e)
        {
            Add_Dept add_dept = new Add_Dept();
            add_dept.ShowDialog();
            if (add_dept.DialogResult == DialogResult.OK)
            {
                btn_Search_Dept_Info_Click(null, null);
            }
        }



        private void btn_Modify_Dept_Click(object sender, EventArgs e)
        {
            if (dgv_Dept.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Dept.CurrentCell.RowIndex;
                string id = dgv_Dept.Rows[rowIndex].Cells[0].Value.ToString();
                Add_Dept add_dept = new Add_Dept(Convert.ToInt32(id));
                add_dept.ShowDialog();
                if (add_dept.DialogResult == DialogResult.OK)
                {
                    btn_Search_Dept_Info_Click(null, null);
                }
            }
        }

        private void btn_Del_Dept_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据删除中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                if (dgv_Dept.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_Dept.CurrentCell.RowIndex;
                        string id = dgv_Dept.Rows[rowIndex].Cells[0].Value.ToString();
                        string T_Sql = "delete from Sys_Dept_Info where id=" + id;

                        if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                        {


                            LogHelper.WriteLog("【删除】", "删除部门信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除部门信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Search_Dept_Info_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除部门信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除部门信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除部门信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除部门信息异常:" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "删除操作完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }





        private void skinTabControl3_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tb_Exception_Action)
            {
                btn_Search_ExceptionData_Click(null, null);
            }
            if (e.TabPage == tb_Today_Action)
            {
                btn_Today_Actions_Click(null, null);
            }
        }


        private void skinTabControl1_Selected(object sender, TabControlEventArgs e)
        {

            if (e.TabPage == tabPageEx2)
            {
                this.timer_GetData.Enabled = false;
                btn_serach_area_Click(null, null);
            }
            if (e.TabPage == tabPageEx3)
            {
                this.timer_GetData.Enabled = false;
                Init_TimeInfo();
            }
            if (e.TabPage == tabPageEx4)
            {
                this.timer_GetData.Enabled = false;
                btn_Log_Click(null, null);
            }
            if (e.TabPage == tabPage2)
            {
                this.timer_GetData.Enabled = true;
                this.timer_GetData.Tick += new EventHandler(timerSetTime_Tick);
                this.timer_GetData.Start();

                Init_DoorGroup();
                RealTime_View rv = new RealTime_View();
                rv.ShowDialog();
            }
            //考勤
            if (e.TabPage == tabPageEx6)
            {
                this.timer_GetData.Enabled = false;
                Init_KaoQinData();
            }
            //报表事件
            if (e.TabPage == tabPageEx5)
            {
                this.timer_GetData.Enabled = false;
                btn_Today_Actions_Click(null, null);
            }

            //报表事件
            if (e.TabPage == tabPage4)
            {
                btn_Animal_Search_Click(null, null);
            }
        }

        

        private void skinTabControl5_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tp_doorRange)
            {
                btn_Door_Range_Search_Click(null, null);
            }
            if (e.TabPage == tp_doorHoliday)
            {
                btn_search_holiday_Click(null, null);
            }
            if (e.TabPage == tp_doorInfo)
            {
                btn_search_door_Click(null, null);
            }
            if (e.TabPage == tp_door_Right)
            {
                btn_Door_Right_Search_Click(null, null);
            }
            if (e.TabPage == tp_TimeInfo)
            {
                Init_TimeInfo();
            }
            if (e.TabPage == tb_TimeRange)
            {
                Init_TimeRange();
            }
        }



        private void skinTabControl4_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tp_Area)
            {
                btn_serach_area_Click(null, null);
            }
            if (e.TabPage == tp_Cotroller)
            {
                btn_searchOperater_Click(null, null);
            }
        }



        private void skinTabControl7_Selected(object sender, TabControlEventArgs e)
        {
            //部门选择事件
            if (e.TabPage == tp_Dept)
            {
                btn_Search_Dept_Info_Click(null, null);
            }
            //考勤选择事件
            if (e.TabPage == tp_KaoQin)
            {
                Init_KaoQinData();
            }
            //权限选择事件
            if (e.TabPage == tp_Right)
            {
            }
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                string sql = @"select sl.id,sl.OperateType,sl.OperateContent,
Switch(Is_succeed=1,'成功',Is_succeed =0,'失败') AS Is_succeed ,sl.Fail_renson,sl.Operater,sl.Operate_Date
from sys_log sl";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Log.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("获取门信息失败 : " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }

        private void btn_Door_Right_Search_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                string sql = @"select drgi.id, drgi.group_name,dti.TimeRange_Name,drgi.door_names,drgi.Person_Names from Door_Right_Group_Info drgi ,Door_TimeZone_Info dti
where drgi.TimeZone_ID=dti.id";
                string Search_txt = txt_Door_Right.Text.Trim();
                if (Search_txt != "" && Search_txt != "请输入查询条件进行数据检索")
                    sql += " and (drgi.id like '%" + Search_txt + "%' or drgi.group_name like '%" + Search_txt + "%' or dti.TimeRange_Name like '%" + Search_txt + "%' or drgi.door_names like '%" + Search_txt + "%' or drgi.Person_Names like '" + Search_txt + "')";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Door_Right.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据加载失败 : " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }


        private void btn_Add_Door_Right_Click(object sender, EventArgs e)
        {
            Add_Door_Right add_door_right = new Add_Door_Right();
            add_door_right.ShowDialog();
            if (add_door_right.DialogResult == DialogResult.OK)
            {
                btn_Door_Right_Search_Click(null, null);
            }
        }

        private void btn_Update_Door_Right_Click(object sender, EventArgs e)
        {
            if (dgv_Door_Right.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Door_Right.CurrentCell.RowIndex;
                string id = dgv_Door_Right.Rows[rowIndex].Cells[0].Value.ToString();
                Add_Door_Right add_door_right = new Add_Door_Right(Convert.ToInt32(id));
                add_door_right.ShowDialog();
                if (add_door_right.DialogResult == DialogResult.OK)
                {
                    btn_Door_Right_Search_Click(null, null);
                }
            }
        }


        private void btn_Del_Door_Right_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Door_Right.Rows.Count <= 0)
                {
                    MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("确定要删除？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int rowIndex = dgv_Door_Right.CurrentCell.RowIndex;
                        string id = dgv_Door_Right.Rows[rowIndex].Cells[0].Value.ToString();

                        string sql_getInfo = @"SELECT CI.CONTROLLER_ID ,DRGI.PERSON_IDS
FROM DOOR_RIGHT_GROUP_INFO DRGI,COTROLLER_GROUP_INFO CGI,CONTROLLER_INFO CI
WHERE DRGI.ID=" + id + " AND DRGI.ID=CGI.RIGHT_GROUP_ID AND CGI.CONTROLLER_ID=CI.ID";
                        DataTable dt_DelInfo = DataAccess.dataTable(sql_getInfo);
                        string controller_ID = dt_DelInfo.Rows[0]["CONTROLLER_ID"].ToString();
                        string person_ID = dt_DelInfo.Rows[0]["PERSON_IDS"].ToString();
                        string[] Person_Ids = person_ID.Split(',');
                        DataTable dt_Controller = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info where Controller_ID=" + controller_ID);
                        int ID = Convert.ToInt32(dt_Controller.Rows[0]["controller_id"].ToString());
                        int ComNO = Convert.ToInt32(dt_Controller.Rows[0]["serialNO"].ToString());
                        string bondRode = dt_Controller.Rows[0]["bondRode"].ToString();
                        foreach (var item in Person_Ids)
                        {
                            string msg = "";
                            if (Common.Common.DeleteCardData(ID, ComNO, bondRode, int.Parse(item) + 1, ref msg) < 0)
                            {
                                MessageBox.Show("删除门权限组失败!" , "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LogHelper.WriteLog("【删除】", "删除门权限组失败", 1, "失败", Program.Login_User, DateTime.Now.ToString());
                                return;
                            }
                        }
                        string T_Sql = "DELETE FROM DOOR_RIGHT_GROUP_INFO WHERE ID=" + id;
                        string sql_Group = "DELETE FROM COTROLLER_GROUP_INFO WHERE RIGHT_GROUP_ID=" + id;
                        List<string> T_Sqls = new List<string>();
                        T_Sqls.Add(T_Sql);
                        T_Sqls.Add(sql_Group);
                        if (DataAccess.excuteSqlAndReturnValues(T_Sqls) > 0)
                        {
                            LogHelper.WriteLog("【删除】", "删除门权限组信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除门权限组信息成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Door_Right_Search_Click(null, null);
                        }
                        else
                        {
                            LogHelper.WriteLog("【删除】", "删除门权限组信息失败", 0, "未异常错误信息", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("删除门权限组信息失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【删除】", "删除门权限组信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("删除门权限组信息异常:" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_Send_Data_DoorGroup_Click(object sender, EventArgs e)
        {
            if (dgv_Door_Right.Rows.Count <= 0)
            {
                MessageBox.Show("未选择任何行！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int rowIndex = dgv_Door_Right.CurrentCell.RowIndex;
                string id = dgv_Door_Right.Rows[rowIndex].Cells[0].Value.ToString();
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据中同步中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                SetWeekTimeZone(Convert.ToInt32(id));
            }
        }


        /// <summary>
        /// 设定周计划
        /// </summary>
        /// <param name="right_ID">权限组ID</param>
        /// <returns></returns>
        private int SetWeekTimeZone(int right_ID)
        {
            int result = 0;
            try
            {

                string sql = @"select * from cotroller_group_info where right_group_id=" + right_ID;
                DataTable dt = DataAccess.dataTable(sql);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //控制器流水编号
                        string controller_id = dt.Rows[i]["Controller_id"].ToString();

                        //在控制器中的 组编号
                        int Group_NO = Convert.ToInt32(dt.Rows[i]["Controller_Group"].ToString());

                        //通行计划流水ID
                        string Right_ID = dt.Rows[i]["Pass_TimeZone_ID"].ToString();

                        //权限组流水ID
                        string Right_Group_ID = dt.Rows[i]["Right_Group_ID"].ToString();

                        string sql_door_Ids = @"select Door_IDs from Door_Right_Group_Info where id=" + Right_Group_ID;

                        string door_IDs = DataAccess.dataTable(sql_door_Ids).Rows[0][0].ToString();

                        DataTable dt_TimeZone = DataAccess.dataTable("select Time_ZoneIDs,Is_Outs  from Door_TimeZone_Info where id=" + Right_ID);

                        string Week_TZ = dt_TimeZone.Rows[0][0].ToString().Replace(",", "").Substring(0, 14);
                        string Week_Out = dt_TimeZone.Rows[0][1].ToString().Replace(",", "").Substring(0, 7);

                        string Holiday_TZ = dt_TimeZone.Rows[0][0].ToString().Replace(",", "").Substring(14, 6) + "000000000000000000000000000000000000000000";
                        string Holiday_Out = dt_TimeZone.Rows[0][1].ToString().Replace(",", "").Substring(7, 3) + "000000000000000000000";

                        DataTable dt_Controller = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info where id=" + controller_id);
                        int ID = Convert.ToInt32(dt_Controller.Rows[0]["controller_id"].ToString());
                        int ComNO = Convert.ToInt32(dt_Controller.Rows[0]["serialNO"].ToString());
                        string bondRode = dt_Controller.Rows[0]["bondRode"].ToString();
                        string msg = "";
                        DataTable dt_Door_IDs = DataAccess.dataTable("select Door_NO from Door_Info where Controller_ID=" + controller_id + " and id in(" + door_IDs + ")");
                        string one = "00";
                        string two = "00";
                        string three = "00";
                        string four = "00";
                        if (dt_Door_IDs.Rows.Count > 0)
                        {
                            for (int index_Door_ID = 0; index_Door_ID < dt_Door_IDs.Rows.Count; index_Door_ID++)
                            {
                                if (dt_Door_IDs.Rows[index_Door_ID][0].ToString() == "1") one = "11";
                                if (dt_Door_IDs.Rows[index_Door_ID][0].ToString() == "2") two = "11";
                                if (dt_Door_IDs.Rows[index_Door_ID][0].ToString() == "3") three = "11";
                                if (dt_Door_IDs.Rows[index_Door_ID][0].ToString() == "4") four = "11";
                            }
                        }
                        string result_door_id1 = one + two;
                        string result_door_id2 = three + four;
                        string Reader = string.Format("{0:x}", Convert.ToInt32(result_door_id1, 2)) + string.Format("{0:x}", Convert.ToInt32(result_door_id2, 2));
                        if (Common.Common.SetApplicationSet(ID, ComNO, bondRode, Group_NO, Reader, "0", "60606060", "60606060", ref msg) < 0)
                        {
                            MessageBox.Show("同步周通行计划失败 ：" + msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogHelper.WriteLog("【同步控制器数据】", "同步周通行计划失败", 1, msg, Program.Login_User, DateTime.Now.ToString());
                            return 0;
                        }
                        if (Common.Common.SetWeekTimeZone(ID, ComNO, bondRode, Group_NO, Week_TZ, Week_Out, ref msg) < 0)
                        {
                            MessageBox.Show("同步周通行计划失败 ：" + msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogHelper.WriteLog("【同步控制器数据】", "同步周通行计划失败", 1, msg, Program.Login_User, DateTime.Now.ToString());
                            return 0;
                        }
                        if (Common.Common.SetHolidayTimeZone(ID, ComNO, bondRode, Group_NO, Holiday_TZ, Holiday_Out, ref msg) < 0)
                        {
                            MessageBox.Show("同步周通行计划失败 ：" + msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LogHelper.WriteLog("【同步控制器数据】", "同步假日通行计划失败", 1, msg, Program.Login_User, DateTime.Now.ToString());
                            return 0;
                        }
                        DataTable dt_Person_IDs = DataAccess.dataTable("select Person_IDs from Door_Right_Group_Info where id=" + Right_Group_ID);
                        string person_IDs = dt_Person_IDs.Rows[0][0].ToString();
                        DataTable dt_Person = DataAccess.dataTable("select * from Person_Info where id in(" + person_IDs + ")");
                        if (dt_Person.Rows.Count > 0)
                        {
                            for (int index_Person = 0; index_Person < dt_Person.Rows.Count; index_Person++)
                            {
                                int CardNo = Convert.ToInt32(dt_Person.Rows[index_Person]["ID"].ToString());
                                string cards = "0000000000000000";
                                string CardID = dt_Person.Rows[index_Person]["CardNO"].ToString();
                                CardID = cards.Substring(0, 16 - CardID.Length) + CardID;
                                int App = Group_NO;
                                int Type = Convert.ToInt32(dt_Person.Rows[index_Person]["CardType"].ToString());
                                string Pin = "XXXX";
                                string APB = "0";
                                if (Common.Common.SetCardData(ID, ComNO, bondRode, CardNo + 1, CardID, App, Type, Pin, APB, ref msg) < 0)
                                {
                                    MessageBox.Show("添加人员到控制器失败 ：" + msg, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LogHelper.WriteLog("【同步控制器数据】", "添加人员到控制器失败", 1, msg, Program.Login_User, DateTime.Now.ToString());
                                    return 0;
                                }
                            }

                        }

                        MessageBox.Show("同步控制器数据成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LogHelper.WriteLog("【同步控制器数据】", "同步周通行计划成功", 1, msg, Program.Login_User, DateTime.Now.ToString());


                    }
                }


                result = 1;
            }
            catch (Exception)
            {

                result = 0;
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据同步完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

            return result;
        }


        private void Init_TimeInfo()
        {
            try
            {
                string sql = "select tr.begin_time,tr.end_time from Time_Range tr order by id ";
                DataTable dt = DataAccess.dataTable(sql);
                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < 30; i++)
                    {
                        DateTimePicker dtp_begin = (DateTimePicker)this.Controls.Find("dtp_Begin_Time" + (i + 1), true)[0];
                        DateTimePicker dtp_end = (DateTimePicker)this.Controls.Find("dtp_End_Time" + (i + 1), true)[0];
                        dtp_begin.Text = "2016-4-8 " + dt.Rows[i + 1]["begin_time"].ToString();
                        dtp_end.Text = "2016-4-8 " + dt.Rows[i + 1]["end_time"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("异常" + ex.Message);
            }

        }

        private void Save_TimeRange(int id, int com_NO, string bondRode)
        {
            try
            {
                string msg = "";
                DataTable dt = DataAccess.dataTable("select begin_time,end_time from time_range order by id");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 1; i < 31; i++)
                    {
                        int HH = Convert.ToInt32(dt.Rows[i]["begin_time"].ToString().Substring(0, 2));
                        int MM = Convert.ToInt32(dt.Rows[i]["begin_time"].ToString().Substring(3, 2));
                        int hh = Convert.ToInt32(dt.Rows[i]["end_time"].ToString().Substring(0, 2));
                        int mm = Convert.ToInt32(dt.Rows[i]["end_time"].ToString().Substring(3, 2));
                        Common.Common.SetOneTimer(id, com_NO, bondRode, i, HH, MM, hh, mm, ref msg);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_Save1_Click(object sender, EventArgs e)
        {
            try
            {

                statusStripInfo.Invoke(shwStatusInfoCallBack, "操作进行中,请稍后 . . . ");
                int index_Process = 2;
                while (index_Process < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
                List<string> list_sql = new List<string>();
                for (int index_TB = 0; index_TB < 6; index_TB++)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        string time_zone = i > 9 ? i.ToString() : ("0" + i.ToString());

                        ComboBox cb1 = (ComboBox)this.Controls.Find("cb_TimeZone" + (index_TB * 30 + i), true)[0];
                        ComboBox cb2 = (ComboBox)this.Controls.Find("cb_TimeZone" + (index_TB * 30 + i + 10), true)[0];
                        ComboBox cb3 = (ComboBox)this.Controls.Find("cb_TimeZone" + (index_TB * 30 + i + 20), true)[0];
                        string time_Range1 = Convert.ToInt32(cb1.SelectedValue.ToString()) > 9 ? cb1.SelectedValue.ToString() : "0" + Convert.ToInt32(cb1.SelectedValue.ToString());
                        string time_Range2 = Convert.ToInt32(cb2.SelectedValue.ToString()) > 9 ? cb2.SelectedValue.ToString() : "0" + Convert.ToInt32(cb2.SelectedValue.ToString());
                        string time_Range3 = Convert.ToInt32(cb3.SelectedValue.ToString()) > 9 ? cb3.SelectedValue.ToString() : "0" + Convert.ToInt32(cb3.SelectedValue.ToString());
                        string sql = "update Time_Zone  set Time_Range_NO1='" + time_Range1 + "',Time_Range_NO2='" + time_Range2 + "',Time_Range_NO3='" + time_Range3 + "'  where id=" + ((index_TB * 10) + i).ToString();
                        list_sql.Add(sql);
                    }
                }

                if (DataAccess.excuteSqlAndReturnValues(list_sql) > 0)
                {
                    DataTable dt = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info ");
                    if (dt.Rows.Count > 0)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            int ID = Convert.ToInt32(dt.Rows[i]["controller_id"].ToString());
                            int ComNO = Convert.ToInt32(dt.Rows[i]["serialNO"].ToString());
                            string bondRode = dt.Rows[i]["bondRode"].ToString();
                            string msg = "";
                            Save_TimeZone(ID, ComNO, bondRode, ref msg);
                        }
                    }
                    LogHelper.WriteLog("【更新】", "更新时区段信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    MessageBox.Show("保存时区信息成功 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("保存时区信息失败 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存时区信息异常  ： " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "操作完成!");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }

        /// <summary>
        /// 初始化时区信息下拉列表
        /// </summary>
        private void Init_TimeRange()
        {
            try
            {

                DataTable dt = null;
                for (int i = 1; i <= 180; i++)
                {
                    dt = DataAccess.dataTable("select ID, '时间段'+Timer_NO+':'+begin_time+'至'+end_time as time_Range from time_range ");
                    ComboBox cb = (ComboBox)this.Controls.Find("cb_TimeZone" + (i), true)[0];
                    cb.DataSource = dt.DefaultView;
                    cb.DisplayMember = "time_Range";
                    cb.ValueMember = "ID";
                }

                dt = DataAccess.dataTable("select Time_Zone_NO,Time_Range_NO1,Time_Range_NO2,Time_Range_NO3 from time_zone ");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int time_range1 = Convert.ToInt32(dt.Rows[i]["Time_Range_NO1"].ToString());
                        int time_range2 = Convert.ToInt32(dt.Rows[i]["Time_Range_NO2"].ToString());
                        int time_range3 = Convert.ToInt32(dt.Rows[i]["Time_Range_NO3"].ToString());
                        ComboBox cb1 = (ComboBox)this.Controls.Find("cb_TimeZone" + ((i / 10) * 30 + (i % 10) + 1), true)[0];
                        ComboBox cb2 = (ComboBox)this.Controls.Find("cb_TimeZone" + ((i / 10) * 30 + (i % 10) + 11), true)[0];
                        ComboBox cb3 = (ComboBox)this.Controls.Find("cb_TimeZone" + ((i / 10) * 30 + (i % 10) + 21), true)[0];
                        cb1.SelectedValue = time_range1;
                        cb2.SelectedValue = time_range2;
                        cb3.SelectedValue = time_range3;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常  ： " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private int Save_TimeZone(int id, int com_NO, string bondRode, ref string msg)
        {
            try
            {
                DataTable dt = DataAccess.dataTable("select Time_Zone_NO,Time_Range_NO1,Time_Range_NO2,Time_Range_NO3 from time_zone order by id");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 1; i < 60; i++)
                    {
                        int Time_Zone_NO = Convert.ToInt32(dt.Rows[i]["Time_Zone_NO"].ToString());
                        int Time_Range_NO1 = Convert.ToInt32(dt.Rows[i]["Time_Range_NO1"].ToString());
                        int Time_Range_NO2 = Convert.ToInt32(dt.Rows[i]["Time_Range_NO2"].ToString());
                        int Time_Range_NO3 = Convert.ToInt32(dt.Rows[i]["Time_Range_NO3"].ToString());
                        if (Common.Common.SetOneTimeZone(id, com_NO, bondRode, Time_Zone_NO, Time_Range_NO1, Time_Range_NO2, Time_Range_NO3, ref msg) == 1)
                        {
                            msg = i.ToString();
                        }
                    }
                }
                if (msg == "60")
                    return 1;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return 0;
            }
        }

        /// <summary>
        /// 进出记录查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Today_Actions_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                string sql = @"SELECT AL.ID,CI.CONTROLLER_NAME,AL.PLACE,AL.PERSON_NAME,AL.DATE_TIME,AL.ACTION FROM ACTION_LOG AL,CONTROLLER_INFO CI WHERE AL.CONTROLLER_ID=CI.CONTROLLER_ID AND AL.TYPE='1'";
                string search_txt = txt_Today_Actions.Text.ToString().Trim();
                if (!string.IsNullOrEmpty(search_txt) && search_txt != "请输入查询条件进行数据检索")
                {
                    sql += " and  (al.id like '%" + search_txt + "%' or ci.Controller_Name like '%" + search_txt + "%' or al.place like '%" + search_txt + "%' or al.person_name like '%" + search_txt + "%' or al.date_time like '%" + search_txt + "%' or al.Action like '%" + search_txt + "%')";
                }


                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Today_Actions.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {

                MessageBox.Show("加载进出记录失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }

        }

        /// <summary>
        /// 异常事件查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Search_ExceptionData_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }
                string sql = @"SELECT AL.ID,CI.CONTROLLER_NAME,AL.PLACE,AL.PERSON_NAME,AL.DATE_TIME,AL.ACTION FROM ACTION_LOG AL,CONTROLLER_INFO CI WHERE AL.CONTROLLER_ID=CI.CONTROLLER_ID AND AL.TYPE='0'";
                string search_txt = txt_Exception.Text.ToString().Trim();
                if (!string.IsNullOrEmpty(search_txt) && search_txt != "请输入查询条件进行数据检索")
                {
                    sql += " and  (al.id like '%" + search_txt + "%' or ci.Controller_Name like '%" + search_txt + "%' or al.place like '%" + search_txt + "%' or al.person_name like '%" + search_txt + "%' or al.date_time like '%" + search_txt + "%' or al.Action like '%" + search_txt + "%')";
                }

                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Exception.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {

                MessageBox.Show("加载进出记录失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }

        private void Init_KaoQinData()
        {
            try
            {
                string sql = @"select * from Check_Work_Attendance_Info";
                DataTable dt = DataAccess.dataTable(sql);
                string num1 = dt.Rows[0][1].ToString();
                string num2 = dt.Rows[0][2].ToString();
                for (int i = 1; i <= 7; i++)
                {
                    NumericUpDown nud = (NumericUpDown)this.Controls.Find("nud" + (i), true)[0];
                    nud.Value = Convert.ToDecimal(dt.Rows[0][i].ToString());
                }
                txt_Mail.Text = dt.Rows[0]["Send_Users"].ToString();
                dtp_begin.Text = dt.Rows[0]["begin_time"].ToString();
                dtp_End.Text = dt.Rows[0]["end_time"].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("数据加载异常 :" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Save_KaoQin_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据保存中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                string num1 = this.nud1.Value.ToString();
                string num2 = this.nud2.Value.ToString();
                string num3 = this.nud3.Value.ToString();
                string num4 = this.nud4.Value.ToString();
                string num5 = this.nud5.Value.ToString();
                string num6 = this.nud6.Value.ToString();
                string num7 = this.nud7.Value.ToString();
                string mail = this.txt_Mail.Text.Trim();
                string begin_time = this.dtp_begin.Text.Trim();
                string end_time = this.dtp_End.Text.Trim();
                if (!IsEmail(mail))
                {
                    MessageBox.Show("邮箱输入格式错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string sql = @"update Check_Work_Attendance_Info  set  Advance_MM='" + num1 + "',Delay_MM='" + num2 + "',Late_MM='" + num3 + "',Leave_Early_MM='" + num4 + "',Late_Invalid='" + num5 +
                    "',Leave_Early_Invalid='" + num6 + "',[day]='" + num7 + "',Send_Users='" + mail + "',begin_time='" + begin_time + "',end_time='" + end_time + "'  where ID=1";
                if (DataAccess.excuteSqlAndReturnValues(sql) > 0)
                {
                    LogHelper.WriteLog("【更新】", "考勤设置数据保存成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    MessageBox.Show("数据保存成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    LogHelper.WriteLog("【更新】", "考勤设置数据保存失败", 1, "失败", Program.Login_User, DateTime.Now.ToString());
                    MessageBox.Show("数据保存失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【更新】", "考勤设置数据更新异常：" + ex.Message, 1, "失败", Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("数据保存异常 ：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据保存完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }


        }

        public static bool IsEmail(string email)
        {
            String strExp = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex r = new Regex(strExp);
            Match m = r.Match(email);
            return m.Success;
        }

        private void btn_Test_SendMail_Click(object sender, EventArgs e)
        {
            try
            {
                string mT = this.txt_Mail.Text.Trim();
                if (!IsEmail(mT))
                {
                    MessageBox.Show("邮箱输入格式错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MailMessage mail = new MailMessage();
                string mF = "entranceguard@126.com";
                MailAddress from = new MailAddress(mF, "聚友科技客户服务部", System.Text.Encoding.GetEncoding("GB2312"));
                mail.From = from;
                MailAddress to = new MailAddress(mT);
                mail.To.Add(to);
                mail.Subject = "考勤单";
                mail.Body = "邮件发送测试";
                string picPath = Environment.CurrentDirectory + "\\考勤表.xls";
                mail.Attachments.Add(new Attachment(picPath));
                mail.IsBodyHtml = true;
                mail.BodyEncoding = System.Text.Encoding.GetEncoding("GB2312");
                mail.Priority = MailPriority.Normal;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.126.com";
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("entranceguard@126.com", "a123456a");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                LogHelper.WriteLog("【测试邮件发送】", "测试邮件发送成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("测试邮件发送成功!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【测试邮件发送】", "测试邮件发送异常 ：" + ex.Message, 1, "失败", Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show("测试邮发送失败 ：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SendEmail(object sender, EventArgs e)
        {
            string day = string.Empty;
            string mT = string.Empty;
            bool is_Sended = false;
            string date = DateTime.Now.ToShortDateString();
            DataTable dt = DataAccess.dataTable("select [day],Send_Users from Check_Work_Attendance_Info");
            if (dt.Rows.Count > 0)
            {
                day = dt.Rows[0][0].ToString();
                mT = dt.Rows[0][1].ToString();
                dt = DataAccess.dataTable("select top 1 Send_Date from [Send_Mail_Log] order by [Id] desc ");
                string now_Date = dt.Rows[0][0].ToString();

                if (day == DateTime.Now.Day.ToString() && now_Date != DateTime.Now.ToShortDateString())
                {
                    is_Sended = true;
                }
                if (!IsEmail(mT))
                {
                    LogHelper.WriteLog("【邮件发送】", "邮件发送失败：邮箱格式错误！", 1, "失败", Program.Login_User, DateTime.Now.ToString());

                    return;
                }
            }
            try
            {
                if (is_Sended)
                {
                    MailMessage mail = new MailMessage();
                    string mF = "entranceguard@126.com";
                    MailAddress from = new MailAddress(mF, "聚友科技客户服务部", System.Text.Encoding.GetEncoding("GB2312"));
                    mail.From = from;
                    MailAddress to = new MailAddress(mT);
                    mail.To.Add(to);
                    mail.Subject = "考勤单";
                    mail.Body = "邮件发送测试";
                    string picPath = Environment.CurrentDirectory + "\\考勤表.xls";
                    mail.Attachments.Add(new Attachment(picPath));
                    mail.IsBodyHtml = true;
                    mail.BodyEncoding = System.Text.Encoding.GetEncoding("GB2312");
                    mail.Priority = MailPriority.Normal;
                    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.126.com";
                    client.UseDefaultCredentials = false;
                    client.Credentials = new System.Net.NetworkCredential("entranceguard@126.com", "a123456a");
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mail);
                    string sql_Mail_Log = "insert into Send_Mail_Log values ('" + mT + "','" + date + "','1','系统定时发送邮件')";
                    DataAccess.excuteSqlAndReturnValues(sql_Mail_Log);
                    LogHelper.WriteLog("【邮件发送】", "邮件发送成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                }

            }
            catch (Exception ex)
            {
                string sql_Mail_Log = "insert into Send_Mail_Log values ('" + mT + "','" + date + "','0','系统定时发送邮件')";
                DataAccess.excuteSqlAndReturnValues(sql_Mail_Log);
                LogHelper.WriteLog("【邮件发送】", "邮件发送异常 ：" + ex.Message, 1, "失败", Program.Login_User, DateTime.Now.ToString());

            }
        }


        void timerSetTime_Tick(object sender, EventArgs e)
        {
            Init_Data();
            GetInOutData();
        }


        private void Init_Data()
        {

            try
            {
                string sql = @"select al.id,ci.Controller_Name,al.place,al.Person_name,al.date_time,al.Action from Action_Log al,Controller_info ci where al.Controller_id=ci.Controller_ID  and al.Is_Readed='0'  order by al.id desc";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Actions.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【数据加载】", "数据加载失败 ：" + ex.Message, 1, "失败", Program.Login_User, DateTime.Now.ToString());
                // MessageBox.Show("数据加载失败 ：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void GetInOutData()
        {
            try
            {
                DataTable dt = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info ");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int ID = Convert.ToInt32(dt.Rows[i]["controller_id"].ToString());
                        int ComNO = Convert.ToInt32(dt.Rows[i]["serialNO"].ToString());
                        string bondRode = dt.Rows[i]["bondRode"].ToString();
                        string msg = "";
                        int NNNN = 0;
                        if (Common.Common.GetInOutRecordCount(ID, ComNO, bondRode, ref NNNN, ref msg) > 0)
                        {
                            if (NNNN > 0)
                            {
                                for (int index = 0; index < NNNN; index++)
                                {
                                    int ModuleID = 0, YYYY = 0, MM = 0, DD = 0, hh = 0, nn = 0, ss = 0;
                                    byte[] NO = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                                    byte[] Status = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00 };
                                    if (Common.Common.GetOneInOut(ID, ComNO, bondRode, ref  ModuleID, ref  YYYY, ref  MM, ref  DD, ref  hh, ref  nn, ref  ss, NO, Status, ref  msg) > 0)
                                    {
                                        string Date_Time = YYYY + "-" + MM + "-" + DD + " " + hh + ":" + nn + ":" + ss;
                                        string Card_ID = "";
                                        foreach (byte b in NO)
                                        {
                                            Card_ID += ((char)b).ToString();
                                        }
                                        int id = 0;
                                        string Person_name = "";
                                        if (Card_ID.Contains("X"))
                                        {

                                        }
                                        else
                                        {
                                            id = Convert.ToInt32(Card_ID);
                                            if (id != 0)
                                            {
                                                Person_name = DataAccess.dataTable("select Name from Person_Info where id=" + id).Rows[0][0].ToString();
                                            }
                                        }
                                        string place = "";
                                        string Status_Value = "";
                                        string door_no = "";
                                        string type = "0";
                                        if (ModuleID % 2 == 0) door_no = (ModuleID / 2).ToString();
                                        else door_no = (ModuleID / 2 + 1).ToString();

                                        foreach (var item in Status)
                                        {
                                            Status_Value += ((char)item).ToString();
                                        }
                                        if (ModuleID != 0)
                                        {
                                            place = DataAccess.dataTable("select door_name from door_info where Controller_id=" + ID + " and door_no=" + door_no).Rows[0][0].ToString();
                                        }
                                        switch (Status_Value)
                                        {
                                            case "A0001":
                                                Status_Value = "进入检查正确";
                                                type = "1";
                                                break;
                                            case "A0002":
                                                Status_Value = "外出检查正确";
                                                type = "1";
                                                break;
                                            case "B001":
                                                Status_Value = "卡片暂停使用";
                                                break;
                                            case "B0002":
                                                Status_Value = "無效卡片";
                                                break;
                                            case "B0003":
                                                Status_Value = "無效門區";
                                                break;
                                            case "B0004":
                                                Status_Value = "無效通行時區";
                                                break;
                                            case "B005":
                                                Status_Value = "重覆進入";
                                                break;
                                            case "B0006":
                                                Status_Value = "重覆外出";
                                                break;
                                            case "B0007":
                                                Status_Value = "無效密碼輸入";
                                                break;
                                            case "C0001":
                                            case "C0011":
                                                Status_Value = "防盜警報";
                                                break;
                                            case "C0002":
                                            case "C0012":
                                                Status_Value = "緊急求救警報";
                                                break;
                                            case "C0003":
                                            case "C0013":
                                                Status_Value = "火災警報";
                                                break;
                                            case "C0004":
                                            case "C0014":
                                                Status_Value = "瓦斯外洩警報";
                                                break;
                                            case "C0005":
                                            case "C0015":
                                                Status_Value = "故障警報";
                                                break;
                                            case "C0006":
                                            case "C0016":
                                                Status_Value = "強行進入警報";
                                                break;
                                            case "C0007":
                                            case "C0017":
                                                Status_Value = "解除警報";
                                                break;
                                            case "D0001":
                                                Status_Value = "主卡登入";
                                                type = "1";
                                                break;
                                            case "D0002":
                                                Status_Value = "工程師卡登入";
                                                type = "1";
                                                break;
                                            case "D0003":
                                                Status_Value = " 操作員卡登入";
                                                type = "1";
                                                break;
                                            default:
                                                break;
                                        }
                                        string sql = "select max(hi.id) from Action_log hi ";
                                        int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
                                        sql = @"insert into Action_log values(" + New_ID + "," + ID + "," + id + ",'" + Date_Time + "'," + ModuleID + ",'" + Person_name + "','" + place + "','" + Status_Value + "','" + type + "','0')";
                                        if (DataAccess.ExecuteScalar(sql) < 0)
                                        {
                                            LogHelper.WriteLog("【新增】", "插入进出记录失败", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                                            return;
                                        }
                                        else
                                        {
                                            LogHelper.WriteLog("【新增】", "插入进出记录成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                                        }

                                        if (Common.Common.DeleteOneInOut(ID, ComNO, bondRode, ref msg) <= 0)
                                        {
                                            LogHelper.WriteLog("【删除】", "删除进出记录失败", 1, msg, Program.Login_User, DateTime.Now.ToString());
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【异常】", "从控制器导出进出记录失败 ：" + ex.Message, 1, "失败", Program.Login_User, DateTime.Now.ToString());
            }


        }
 

        private void Init_DoorGroup()
        {

            DataTable dt = DataAccess.dataTable("select Controller_Name,controller_id,serialNO,bondRode from controller_info  order by controller_id");
            //int c = dt.Rows.Count;
            for (int i = 1; i < 9; i++)
            {
                GroupBox gb = (GroupBox)this.Controls.Find("door_Group" + i, true)[0];
                gb.Visible = false;
            }



            string msg = "";
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int ID = Convert.ToInt32(dt.Rows[i]["controller_id"].ToString());
                    int ComNO = Convert.ToInt32(dt.Rows[i]["serialNO"].ToString());
                    string bondRode = dt.Rows[i]["bondRode"].ToString();
                    string group_Name = dt.Rows[i]["Controller_Name"].ToString();
                    string time = Common.Common.GetDateTime(ID, ComNO, bondRode, ref msg);
                    DataTable doorTable = DataAccess.dataTable("select * from Door_Info where Controller_ID=" + ID);


                    GroupBox gb = (GroupBox)this.Controls.Find("door_Group" + (i + 1).ToString(), true)[0];
                    gb.Text = group_Name;
                    gb.Visible = true;


                    //gb.Enabled = false;
                    for (int j = 1; j <= doorTable.Rows.Count; j++)
                    {
                        //if (msg.Substring(0, 2) == "失败")
                        //{
                        //    Button bt = (Button)this.Controls.Find("door" + (i * 4 + j).ToString(), true)[0];
                        //    bt.BackgroundImage = global::Demo.Properties.Resources.QQ截图20160425212322;
                        //    bt.Enabled = false;
                        //}
                        //else
                        //{
                        //    Button bt = (Button)this.Controls.Find("door" + (i * 4 + j).ToString(), true)[0];
                        //    bt.BackgroundImage = global::Demo.Properties.Resources.use;
                        //    bt.Enabled = true;

                        //}

                        Button bt = (Button)this.Controls.Find("door" + (i * 4 + j).ToString(), true)[0];
                        Button bto = (Button)this.Controls.Find("btn_OpenDoor" + (i * 4 + j).ToString(), true)[0];
                        CheckBox cb=(CheckBox)this.Controls.Find("cb" + (i * 4 + j).ToString(), true)[0];
                        bt.BackgroundImage = global::Demo.Properties.Resources.use;
                        bt.Enabled = true;
                        bto.Enabled = true;
                        cb.Enabled = true;
                        bt.Visible = true;
                        bto.Visible = true;
                        cb.Visible = true;

                    }
                }
            }


        }


        private void btn_OpenDoor1_Click(object sender, EventArgs e)
        {
            Button btn_Open = sender as Button;

            CheckBox cb = (CheckBox)this.Controls.Find("cb" + btn_Open.Tag, true)[0];

            int door_Index = Convert.ToInt32(btn_Open.Tag.ToString()) % 4;
            if (door_Index == 0) door_Index = 4;
            int row_Index = Convert.ToInt32(btn_Open.Tag.ToString()) / 4;

            DataTable dt = DataAccess.dataTable("select controller_id,serialNO,bondRode from controller_info  order by controller_id");


            string msg = "";
            if (dt.Rows.Count >= row_Index)
            {

                int ID = Convert.ToInt32(dt.Rows[row_Index]["controller_id"].ToString());
                int ComNO = Convert.ToInt32(dt.Rows[row_Index]["serialNO"].ToString());
                string bondRode = dt.Rows[row_Index]["bondRode"].ToString();


                if (cb.Checked)
                {
                    if (btn_Open.Text == "开门")
                    {
                        //执行门常开操作
                        if (Common.Common.RemoteOpenDoorControl(ID, ComNO, bondRode, door_Index, 0, ref msg) > 0)
                        {
                            LogHelper.WriteLog("【远程开门】", "远程开门成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("门常开操作成功 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Open.Text = "关门";
                        }
                        else
                        {
                            LogHelper.WriteLog("【远程开门】", "远程开门失败", 1, "失败：" + msg, Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("远程开门失败 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {

                        //执行开启当前门操作
                        if (Common.Common.RemoteOpenDoorControl(ID, ComNO, bondRode, door_Index, 3, ref msg) > 0)
                        {
                            LogHelper.WriteLog("【远程关门】", "远程关门成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            cb.Checked = false;
                            btn_Open.Text = "开门";
                            MessageBox.Show("远程关门操作成功 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            LogHelper.WriteLog("【远程关门】", "远程关门失败", 1, "失败：" + msg, Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("远程关门失败 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }
                else
                {
                    //执行开启当前门操作
                    if (Common.Common.RemoteOpenDoorControl(ID, ComNO, bondRode, door_Index, 3, ref msg) > 0)
                    {
                        LogHelper.WriteLog("【远程开门】", "远程开门成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                        MessageBox.Show("远程开门操作成功 3秒后自动关门 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        LogHelper.WriteLog("【远程开门】", "远程开门失败", 1, "失败：" + msg, Program.Login_User, DateTime.Now.ToString());
                        MessageBox.Show("远程开门失败 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }




        }

     

        private void btn_Watch_Full_Click(object sender, EventArgs e)
        {
            RealTime_View rv = new RealTime_View();
            rv.ShowDialog();
        }

    

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = sender as ToolStripMenuItem;
            this.Opacity = Double.Parse(tsm.Tag.ToString());
        }



        private void btn_Animal_Search_Click(object sender, EventArgs e)
        {
            try
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询中 . . . ");
                int i = 2;
                while (i < 50)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, i);
                    i++;
                    Thread.Sleep(2);
                }

                string sql = @"select eri.id,eri.NAME,eri.ID_Card_Number,eri.PI,eri.Effective_Time,eri.Animal_Species,eri.Animal_Count,eri.Laboratory from Experiment_Register_Info eri where 1=1 ";
                string Search_txt = txt_Animal_Search.Text.Trim();
                if (Search_txt != "" && Search_txt != "请输入查询条件进行数据检索")
                    sql += " and (eri.id like '%" + Search_txt + "%' or eri.NAME like '%" + Search_txt + "%' or eri.ID_Card_Number like '%" + Search_txt + "%' or eri.Effective_Time like '%" + Search_txt + "%' or eri.Animal_Species like '" + Search_txt + "')";
                DataTable dt = DataAccess.dataTable(sql);
                this.dgv_Animal.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据加载失败 : " + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                statusStripInfo.Invoke(shwStatusInfoCallBack, "数据查询完成");
                int index_Process = 50;
                while (index_Process < 100)
                {
                    statusStripInfo.Invoke(shwProgressProcCallBack, index_Process);
                    index_Process++;
                    Thread.Sleep(2);
                }
            }
        }

       
    }

}
