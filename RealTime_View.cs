using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Demo.Controller;
using System.Diagnostics;



namespace Demo
{
    public partial class RealTime_View : CCSkinMain
    {


        #region 变量常量定义
        const int WIDTH = 100;
        const int HEIGHT = 120;
        const int MARGIN = 20;
        const int LINECOUNT = 7;
        Control[] controllerList;
        bool postBack = false;
        #endregion

        #region  构造函数

        public RealTime_View()
        {
            InitializeComponent();

            SetStyles();
        }

        #endregion  构造函数

        #region 窗体加载

        private void RealTime_View_Load(object sender, EventArgs e)
        {
            InitdrvCSS(dgv_Actions);
            InitControllers();
            InitData();
            this.timer_GetData.Enabled = true;
            this.timer_GetData.Start();
            this.timer_GetData.Tick += new EventHandler(timerSetTime_Tick);
        }

        #endregion 窗体加载

        #region 窗体关闭事件

        private void RealTime_View_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.timer_GetData.Enabled = false;

            try
            {
                string sql = "update Action_Log set Is_Readed='1'";
                DataAccess.ExecuteScalar(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion 窗体关闭事件

        #region 开门操作

        private void OpenDoor_Click(object sender, EventArgs e)
        {
            //Button btn_Open = sender as Button;//此处直接绑定按钮单击事件，只有一个按钮
            ////此处只有一个Check，不用遍历寻找
            //CheckBox cb = (CheckBox)this.Controls.Find("cb" + btn_Open.Tag, true)[0];

            //int door_Index = Convert.ToInt32(btn_Open.Tag.ToString()) % 4;//门ID
            //if (door_Index == 0) door_Index = 4;
            //int row_Index = Convert.ToInt32(btn_Open.Tag.ToString()) / 4;
            //if (Convert.ToInt32(btn_Open.Tag.ToString()) % 4 == 0)
            //    row_Index -= 1;



            int controllerId = int.Parse(controllerDrop.SelectedValue.ToString());
            int doorId = int.Parse(doorDrop.SelectedValue.ToString());
            DataTable dt = DataAccess.dataTable(string.Format("select controller_id,serialNO,bondRode from controller_info  where controller_id={0}  order by controller_id",controllerId));


            string msg = "";
            if (dt.Rows.Count >0)
            {

                //int ID = Convert.ToInt32(dt.Rows[row_Index]["controller_id"].ToString());
                int ComNO = Convert.ToInt32(dt.Rows[0]["serialNO"].ToString());
                string bondRode = dt.Rows[0]["bondRode"].ToString();


                if (openAlways.Checked)
                {
                    if (openDoor.Text == "开门")
                    {
                        //执行门常开操作
                        //if (Common.Common.RemoteOpenDoorControl(ID, ComNO, bondRode, door_Index, 0, ref msg) > 0)
                        if (Common.Common.RemoteOpenDoorControl(controllerId, ComNO, bondRode, doorId, 0, ref msg) > 0)
                        {
                            LogHelper.WriteLog("【远程开门】", "远程开门成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            MessageBox.Show("门常开操作成功 ！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            openDoor.Text = "关门";
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
                        if (Common.Common.RemoteOpenDoorControl(controllerId, ComNO, bondRode, doorId, 3, ref msg) > 0)
                        {
                            LogHelper.WriteLog("【远程关门】", "远程关门成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                            openAlways.Checked = false;
                            openDoor.Text = "开门";
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
                    if (Common.Common.RemoteOpenDoorControl(controllerId, ComNO, bondRode, doorId, 3, ref msg) > 0)
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

        #endregion 开门操作

        #region 初始化控制器 - XUHONGBO

        private void InitControllers()
        {
            DataTable dt = DataAccess.dataTable("select Controller_Name,controller_id,serialNO,bondRode from controller_info  order by controller_id");
            int count = dt.Rows.Count;   
            controllerList = new Control[count];

            for (int k = 0; k < count; k++)
            {
                string name = dt.Rows[k][0].ToString();
                int j = k % LINECOUNT;
                int i = k / LINECOUNT;
                Point location = new Point(j*(WIDTH+MARGIN)+MARGIN,i*(HEIGHT+MARGIN)+MARGIN);
                Controller.Controller controller = CreateController(name, k%2, location);
                controllerList[k]=controller;
            }
            this.groupBox1.Controls.AddRange(controllerList);

        }
        
        private Controller.Controller CreateController(string name,int status,Point location)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.ControllerName = name;
            controller.Location = location;
            if (status == 0)//关闭状态
            {
                controller.StateColor = Color.Red;
                controller.TextColor = Color.Yellow;
            }
            else//打开状态
            {
                controller.StateColor = Color.Blue;
                controller.TextColor = Color.Silver;
            }
            return controller;
        }

        private void SetStyles()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.Selectable, false);
            //this.Resize += Form1_Resize;
            //this.RenameFolder += UpdateFolder;
            //FitScreen();
        }
        
        private void InitData()
        {
            string query = "select Controller_ID,Controller_Name from Controller_Info";
            DataTable dt = DataAccess.dataTable(query);
            BindControllerData(dt, controllerDrop);
            int id = int.Parse(controllerDrop.SelectedValue.ToString());
            string queryDoor = "select ID,Door_Name from Door_Info where Controller_ID="+id;
            DataTable dtDoor = DataAccess.dataTable(queryDoor);
            BindDoorData(dtDoor,doorDrop);
            postBack = true;
            //openAlways_CheckedChanged(null,null);
            //int door = int.Parse(doorDrop.SelectedValue.ToString());
            //int controller = int.Parse(controllerDrop.SelectedValue.ToString());
            //IsAlwaysOpen(controller, door, openAlways.Checked);
        }
        
        private void BindControllerData(DataTable dt,ComboBox box)
        {
            box.DataSource = dt;
            box.DisplayMember = "Controller_Name";
            box.ValueMember = "Controller_ID";
        }
        
        private void BindDoorData(DataTable dt, ComboBox box)
        {
            //box.Items.Clear();
            box.DataSource = dt;
            box.DisplayMember = "Door_Name";
            box.ValueMember = "ID";
        }

        private void controllerDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!postBack) return;
            int id = int.Parse(controllerDrop.SelectedValue.ToString());
            string queryDoor = "select ID,Door_Name from Door_Info where Controller_ID=" + id;
            DataTable dtDoor = DataAccess.dataTable(queryDoor);
            BindDoorData(dtDoor, doorDrop);
            //MessageBox.Show(controllerDrop.SelectedValue.ToString());
            Console.WriteLine(controllerDrop.SelectedValue.ToString());
        }

        private void doorDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!postBack) return;
            int door = int.Parse(doorDrop.SelectedValue.ToString());
            int controller = int.Parse(controllerDrop.SelectedValue.ToString());
            string cmd = string.Format("select Is_AlwaysOpen from Door_Info where Controller_ID={0} and ID={1}",controller,door);
            int result=DataAccess.ExecuteScalar(cmd);
            pic_Open.Visible = (result==1);
            pic_Close.Visible = (result == 0);
            Console.WriteLine(result);
            openAlways.Checked = (result==1);
        }

        private void openAlways_CheckedChanged(object sender, EventArgs e)
        {
            int door = int.Parse(doorDrop.SelectedValue.ToString());
            int controller = int.Parse(controllerDrop.SelectedValue.ToString());
            IsAlwaysOpen(controller, door, openAlways.Checked);
            doorDrop_SelectedIndexChanged(null, null);
        }

        private void IsAlwaysOpen(int controller, int door, bool isOpen)
        {
            string sql = "update Door_Info set Is_AlwaysOpen=";
            if (isOpen)
            {
                sql += "1";
            }
            else
            {
                sql += "0";
            }
            sql += " where ID=" + door + " and Controller_ID=" + controller;
            DataAccess.excuteSql(sql);
        }


        #endregion

        #region 门群组显隐

        private void Init_DoorGroup()
        {

            DataTable dt = DataAccess.dataTable("select Controller_Name,controller_id,serialNO,bondRode from controller_info  order by controller_id");
            if (dt.Rows.Count > 8) return;
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
                    GroupBox gb = (GroupBox)this.Controls.Find("door_Group" + (i + 1).ToString(), true)[0];
                    gb.Text = group_Name;
                    gb.Visible = true;
                    if (msg.Substring(0, 2) == "失败")
                    {
                        gb.Enabled = false;
                        for (int j = 1; j <= 4; j++)
                        {

                            Button bt = (Button)this.Controls.Find("door" + (i * 4 + j).ToString(), true)[0];
                            bt.BackgroundImage = global::Demo.Properties.Resources.QQ截图20160425212322;

                            bt.Font = new Font("微软雅黑", 9, FontStyle.Bold);
                            bt.Text = group_Name + (j - 1).ToString();
                            bt.ForeColor = Color.Blue;
                        }
                    }

                }
            }


        }

        #endregion 门群组显隐

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


            //for (int i = 1; i < 9; i++)
            //{
            //    GroupBox gb = (GroupBox)this.Controls.Find("door_Group" + i, true)[0];
            //    gb.Visible = false;
            //}



            #endregion
        }

        #endregion 设置grid 样式

        #region 初始化进出资料

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

                MessageBox.Show("数据加载失败 ：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion 初始化进出资料

        #region 初始化Tag值 begin

        private void InitTag()
        {
            //try
            //{
            //    for (int i = 1; i <= 32; i++)
            //    {
            //        CheckBox cb = (CheckBox)this.Controls.Find("cb" + i, true)[0];
            //        Button btn_OpenDoor = (Button)this.Controls.Find("btn_OpenDoor" + i, true)[0];
            //        cb.Tag = i.ToString();
            //        btn_OpenDoor.Tag = i.ToString();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("初始化Tag值错误 ：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

        }

        #endregion 初始化Tag值end

        #region 定时取数据

        void timerSetTime_Tick(object sender, EventArgs e)
        {
            Init_Data();
            GetInOutData();
        }

        #endregion 定时取数据

        #region 从控制器读取进出资料

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
                                    if (Common.Common.GetOneInOut(ID, ComNO, bondRode, ref ModuleID, ref YYYY, ref MM, ref DD, ref hh, ref nn, ref ss, NO, Status, ref msg) > 0)
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
                                            id = Convert.ToInt32(Card_ID) - 1;
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
                                            place = DataAccess.dataTable("select di.door_name from door_info di,Controller_Info ci where di.Controller_ID=ci.id and  ci.Controller_ID=" + ID + "  and di.door_no=" + door_no).Rows[0][0].ToString();
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
                                            MessageBox.Show("插入进出记录失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return;
                                        }
                                        else
                                        {
                                            LogHelper.WriteLog("【新增】", "插入进出记录成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                                        }

                                        if (Common.Common.DeleteOneInOut(ID, ComNO, bondRode, ref msg) <= 0)
                                        {
                                            LogHelper.WriteLog("【删除】", "删除进出记录失败", 1, msg, Program.Login_User, DateTime.Now.ToString());
                                            MessageBox.Show("删除进出记录失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        #endregion 从控制器读取进出资料

    }
}
