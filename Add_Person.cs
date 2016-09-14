using CCWin;
using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Demo
{
    public partial class Add_Person : CCSkinMain
    {


        #region 私有变量 begin

        private bool _IsModify = false;
        private int _ID = 0;
        private string _Head_Img_Path = "";
        #endregion 私有变量 end


        #region 构造函数

        public Add_Person()
        {
            InitializeComponent();
            this.pb_Head.ImageLocation = System.IO.Directory.GetCurrentDirectory() + "\\Img\\default_head.jpg";
        }


        public Add_Person(int id)
        {
            InitializeComponent();
            this._ID = id;
            _IsModify = true;
            Init_Data(id);
        }

        #endregion 构造函数


        #region  页面加载

        private void Add_Person_Load(object sender, EventArgs e)
        {
            this.Text = _IsModify ? "修改人员日信息" : "新增人员日信息";
            if (!_IsModify)
                this.cb_Card_Type.SelectedIndex = 0;
        }

        #endregion  页面加载


        #region 保存数据

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (this.txt_username.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名称!");
                return;
            }
            if (this.txt_phone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系电话!");
                return;
            }
            if (this.txt_Email.Text.Trim() == "" && !IsEmail(txt_Email.Text.Trim()))
            {
                MessageBox.Show("请输入邮箱或邮箱格式不正确!");
                return;
            }
            if (!isNumberic(this.txt_Animal_Count.Text.Trim()))
            {
                MessageBox.Show("动物总用数量必须为数字!");
                return;
            }

            try
            {
                string sql = "select max(hi.id) from Person_Info hi ";
                int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;

                //用户名
                string user_name = this.txt_username.Text.Trim();
                //电话
                string phone = this.txt_phone.Text.Trim();
                //邮箱
                string email = this.txt_Email.Text.Trim();
                //卡号
                string cardId = this.txt_CardID.Text.Trim();

                if (this.txt_CardID.Text.Trim().Length < 10)
                {
                    MessageBox.Show("请输入正确格式的卡号！");
                }

                string card_NO = Get_Card_NOs(cardId);


                //卡片类型
                int card_Type = this.cb_Card_Type.SelectedIndex + 1;

                string pinPWD = this.txt_PINPWD.Text.Trim();

                string laboriy = this.txt_Lably.Text.ToString();
                string Mount_Guard = this.txt_shanggangzhenghao.Text.ToString().Trim();
                int Dept_Id = this.cb_Dept.SelectedIndex + 1;
                int is_apb = this.cb_IsAPB_Check.Checked == true ? 1 : 0;

              
                string Identity_NO = txt_Identity_NO.Text.Trim();
                string content = this.txt_Card_Content.Text.Trim();
                string T_Sql = string.Empty;
                if (_IsModify)
                {
                    _Head_Img_Path = _ID + ".jpg";
                    T_Sql = @"update person_info set name='" + user_name + "',phone='" + phone + "',email='" + email + "',cardid='" + cardId + "',cardno='" + card_NO + "',cardtype=" + card_Type + ",pinpwd='" + pinPWD + "',isapbcheck=" + is_apb + ",content='" + content + "',Identity_NO='" + Identity_NO + "',Img_Path='" + _Head_Img_Path + "',Laboratory='" + laboriy + "',Mount_Guard='" + Mount_Guard + "',Dept_Id=" + Dept_Id + " where id=" + _ID;
                }
                else
                {
                    _Head_Img_Path = New_ID + ".jpg";
                    T_Sql = "insert into person_info values(" + New_ID + ",'" + user_name + "','" + phone + "','" + cardId + "','" + card_NO + "'," + card_Type + ",'" + pinPWD + "'," + is_apb + ",'" + email + "','" + content + "','" + Identity_NO + "','" + _Head_Img_Path + "','" + laboriy + "','" + Mount_Guard + "'," + Dept_Id + ");";

                }
                Bitmap box1 = new Bitmap(pb_Head.Image);

                string str = System.IO.Directory.GetCurrentDirectory() + "\\Img\\" + _Head_Img_Path;
                box1.Save(str);
                if (DataAccess.excuteSqlAndReturnValues(T_Sql) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show((_IsModify ? "修改" : "新增") + "人员信息成功");
                    LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "人员信息成功", 1, "成功", Program.Login_User, DateTime.Now.ToString());
                    this.Close();
                }

                else
                {

                    MessageBox.Show((_IsModify ? "修改" : "新增") + "人员信息失败!");
                }



            }
            catch (Exception ex)
            {
                LogHelper.WriteLog("【" + (_IsModify ? "修改" : "新增") + "】", (_IsModify ? "修改" : "新增") + "人员信息失败", 0, ex.Message, Program.Login_User, DateTime.Now.ToString());
                MessageBox.Show((_IsModify ? "修改" : "新增") + "人员信息错误,异常信息为: !" + ex.Message);
            }
        }


        #endregion 保存数据


        #region 方法begion


        private string Get_Card_NOs(string card_id)
        {
            string Card_IDs = "";
            char[] temp = card_id.ToCharArray();
            bool flag = false;
            foreach (var item in temp)
            {
                if ((item != '0' || flag) && Card_IDs.Length < 7)
                {
                    flag = true;
                    Card_IDs += item;
                }
                else continue;

                if (Card_IDs.Length == 7) break;
            }
            Card_IDs = Convert.ToInt32(Card_IDs).ToString("X2");
            return Card_IDs;
        }



        private void Init_Data(int id)
        {
            try
            {
                string sql = "select hi.*,sdi.Dept_Name from person_Info hi,Sys_Dept_Info sdi where hi.Dept_Id=sdi.id and hi.id= " + id;
                DataTable dt = DataAccess.dataTable(sql);
                this.txt_username.Text = dt.Rows[0]["name"].ToString();
                this.txt_phone.Text = dt.Rows[0]["phone"].ToString();
                this.txt_Email.Text = dt.Rows[0]["email"].ToString();
                this.txt_CardID.Text = dt.Rows[0]["cardid"].ToString();
                this.cb_Card_Type.SelectedIndex = Convert.ToInt32(dt.Rows[0]["cardtype"].ToString()) - 1;
                this.txt_PINPWD.Text = dt.Rows[0]["pinpwd"].ToString();
                txt_Lably.Text = dt.Rows[0]["Laboratory"].ToString();
                this.cb_Dept.Text = dt.Rows[0]["Dept_Name"].ToString();
                txt_shanggangzhenghao.Text = dt.Rows[0]["Mount_Guard"].ToString();
                this.pb_Head.ImageLocation = System.IO.Directory.GetCurrentDirectory() + "\\Img\\" + dt.Rows[0]["Img_Path"].ToString();
                this.cb_IsAPB_Check.Checked = dt.Rows[0]["isapbcheck"].ToString() == "1" ? true : false;

                // cb_IsExport.Checked = dt.Rows[0]["Is_Export"].ToString() == "1" ? true : false;
                txt_Identity_NO.Text = dt.Rows[0]["Identity_NO"].ToString();
                this.txt_Card_Content.Text = dt.Rows[0]["Content"].ToString();
                btn_GetData_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据初始化失败：" + ex.Message); ;
            }

        }


        protected bool isNumberic(string message)
        {
            //判断是否为整数字符串
            //是的话则将其转换为数字并将其设为out类型的输出值、返回true, 否则为false
            try
            {

                Convert.ToInt32(message);
                return true;
            }
            catch
            {
                return false;
            }
        }



        #endregion 方法end

        #region 检查邮箱正确性

        public static bool IsEmail(string email)
        {
            String strExp = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex r = new Regex(strExp);
            Match m = r.Match(email);
            return m.Success;
        }

        #endregion 检查邮箱正确性

        #region 关闭页面

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion 关闭页面


        private void btn_GetData_Click(object sender, EventArgs e)
        {
            string Identity_NO = this.txt_Identity_NO.Text.ToString().Trim();
            string sql = @"select * from Test_info where Identity_NO='" + Identity_NO + "'";
            DataTable dt = DataAccess.dataTable(sql);
            if (dt.Rows.Count > 0)
            {
                string begin_Time = dt.Rows[0]["Experiment_TimeRange"].ToString().Split('-')[0];
                string end_Time = dt.Rows[0]["Experiment_TimeRange"].ToString().Split('-')[1];

                begin_Time = (begin_Time.Substring(0, 4) + "-" + begin_Time.Substring(4, 2) + "-" + begin_Time.Substring(6, 2));
                end_Time = (end_Time.Substring(0, 4) + "-" + end_Time.Substring(4, 2) + "-" + end_Time.Substring(6, 2));

                txt_IACUC_Name.Text = dt.Rows[0]["IACUC_GroupName"].ToString();
                dtp_Approval_Date.Text = dt.Rows[0]["Approval_Date"].ToString();
                dtp_begin_Date.Text = begin_Time;
                dtp_End_Date.Text = end_Time;
                txt_Topic_Name.Text = dt.Rows[0]["Topic_Name"].ToString();
                txt_PI.Text = dt.Rows[0]["PI"].ToString();
                txt_Applicant.Text = dt.Rows[0]["Applicant"].ToString();
                txt_AP.Text = dt.Rows[0]["AP"].ToString();
                txt_Animal_Species.Text = dt.Rows[0]["Animal_Species"].ToString();
                txt_Animal_Count.Text = dt.Rows[0]["Animal_Count"].ToString();
            }
            else MessageBox.Show("检索无数据!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_Chose_Img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "JPG图片|*.jpg|BMP图片|*.bmp|Gif图片|*.gif";
            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(ofdlg.FileName);
                pb_Head.Image = image;
            }
        }

    }
}
