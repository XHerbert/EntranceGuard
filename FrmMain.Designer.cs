/********************************************************************
 * *
 * * 使本项目源码或本项目生成的DLL前请仔细阅读以下协议内容，如果你同意以下协议才能使用本项目所有的功能，
 * * 否则如果你违反了以下协议，有可能陷入法律纠纷和赔偿，作者保留追究法律责任的权利。
 * *
 * * 1、你可以在开发的软件产品中使用和修改本项目的源码和DLL，但是请保留所有相关的版权信息。
 * * 2、不能将本项目源码与作者的其他项目整合作为一个单独的软件售卖给他人使用。
 * * 3、不能传播本项目的源码和DLL，包括上传到网上、拷贝给他人等方式。
 * * 4、以上协议暂时定制，由于还不完善，作者保留以后修改协议的权利。
 * *
 * * Copyright (C) 2013-? cskin Corporation All rights reserved.
 * * 网站：CSkin界面库 http://www.cskin.net
 * * 作者： 乔克斯 QQ：345015918 .Net项目技术组群：306485590
 * * 请保留以上版权信息，否则作者将保留追究法律责任。
 * *
 * * 创建时间：2013-12-08
 * * 说明：FrmMain.Designer.cs
 * *
********************************************************************/

namespace Demo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            CCWin.SkinControl.Animation animation2 = new CCWin.SkinControl.Animation();
            CCWin.SkinControl.Animation animation3 = new CCWin.SkinControl.Animation();
            CCWin.SkinControl.Animation animation4 = new CCWin.SkinControl.Animation();
            CCWin.SkinControl.Animation animation5 = new CCWin.SkinControl.Animation();
            CCWin.SkinControl.Animation animation6 = new CCWin.SkinControl.Animation();
            CCWin.SkinControl.Animation animation7 = new CCWin.SkinControl.Animation();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            CCWin.CmSysButton cmSysButton2 = new CCWin.CmSysButton();
            CCWin.CmSysButton cmSysButton3 = new CCWin.CmSysButton();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageEx6 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl7 = new CCWin.SkinControl.SkinTabControl();
            this.tp_Right = new System.Windows.Forms.TabPage();
            this.tp_Dept = new CCWin.SkinControl.SkinTabPage();
            this.btn_Search_Dept_Info = new CCWin.SkinControl.SkinButton();
            this.dgv_Dept = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Del_Dept = new CCWin.SkinControl.SkinButton();
            this.btn_Modify_Dept = new CCWin.SkinControl.SkinButton();
            this.btn_Add_Dept = new CCWin.SkinControl.SkinButton();
            this.txt_Dept = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel142 = new CCWin.SkinControl.SkinLabel();
            this.tp_KaoQin = new CCWin.SkinControl.SkinTabPage();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.skinLabel140 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel141 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel139 = new CCWin.SkinControl.SkinLabel();
            this.nud7 = new System.Windows.Forms.NumericUpDown();
            this.skinLabel138 = new CCWin.SkinControl.SkinLabel();
            this.nud6 = new System.Windows.Forms.NumericUpDown();
            this.nud5 = new System.Windows.Forms.NumericUpDown();
            this.nud4 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.txt_Mail = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_Test_SendMail = new System.Windows.Forms.Button();
            this.btn_Save_KaoQin = new System.Windows.Forms.Button();
            this.skinLabel124 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel125 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel126 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel128 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel129 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel130 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel131 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel132 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel133 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel134 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel135 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel136 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel137 = new CCWin.SkinControl.SkinLabel();
            this.tabPageEx5 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl3 = new CCWin.SkinControl.SkinTabControl();
            this.tb_Today_Action = new CCWin.SkinControl.SkinTabPage();
            this.dgv_Today_Actions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.事件1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Today_Actions = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_Today_Actions = new CCWin.SkinControl.SkinButton();
            this.skinLabel123 = new CCWin.SkinControl.SkinLabel();
            this.tb_Exception_Action = new CCWin.SkinControl.SkinTabPage();
            this.dgv_Exception = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.事件 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Exception = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_Search_ExceptionData = new CCWin.SkinControl.SkinButton();
            this.skinLabel127 = new CCWin.SkinControl.SkinLabel();
            this.tabPageEx4 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl2 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.dgv_Log = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Log = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_Log = new CCWin.SkinControl.SkinButton();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.tabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.tabPageEx3 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl5 = new CCWin.SkinControl.SkinTabControl();
            this.tp_TimeInfo = new CCWin.SkinControl.SkinTabPage();
            this.btn_Save = new CCWin.SkinControl.SkinButton();
            this.dtp_End_Time30 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time30 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time29 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time29 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time28 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time28 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time27 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time27 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time26 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time26 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel23 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel24 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel25 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel26 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel28 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time25 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time25 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel29 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time24 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time24 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel30 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time23 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time23 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel31 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time22 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time22 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel32 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time21 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time21 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel33 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time20 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time20 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel34 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time19 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time19 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel35 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time18 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time18 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel36 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time17 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time17 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel37 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time16 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time16 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel38 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time15 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time15 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time14 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time14 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time13 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time13 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time12 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time12 = new System.Windows.Forms.DateTimePicker();
            this.dtp_End_Time11 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time11 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel18 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel19 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel20 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel21 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel22 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time10 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time10 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time9 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time9 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time8 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time8 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time7 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time7 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time6 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time6 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time5 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time5 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel13 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time4 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time4 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel14 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time3 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time3 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel15 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time2 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel16 = new CCWin.SkinControl.SkinLabel();
            this.dtp_End_Time1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_Begin_Time1 = new System.Windows.Forms.DateTimePicker();
            this.skinLabel17 = new CCWin.SkinControl.SkinLabel();
            this.tb_TimeRange = new System.Windows.Forms.TabPage();
            this.skinTabControl6 = new CCWin.SkinControl.SkinTabControl();
            this.timezone1 = new System.Windows.Forms.TabPage();
            this.skinLabel42 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel39 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel40 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel41 = new CCWin.SkinControl.SkinLabel();
            this.cb_TimeZone30 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone29 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone28 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone27 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone26 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone25 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone24 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone23 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone22 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone21 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone20 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone19 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone18 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone17 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone16 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone15 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone14 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone13 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone12 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone11 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone10 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone9 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone8 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone7 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone6 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone5 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone4 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone3 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone2 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone1 = new System.Windows.Forms.ComboBox();
            this.skinLabel44 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel45 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel46 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel47 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel48 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel49 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel50 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel51 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel52 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel53 = new CCWin.SkinControl.SkinLabel();
            this.timezone2 = new System.Windows.Forms.TabPage();
            this.skinLabel43 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel54 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel55 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel56 = new CCWin.SkinControl.SkinLabel();
            this.cb_TimeZone60 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone59 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone58 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone57 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone56 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone55 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone54 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone53 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone52 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone51 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone50 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone49 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone48 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone47 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone46 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone45 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone44 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone43 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone42 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone41 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone40 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone39 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone38 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone37 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone36 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone35 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone34 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone33 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone32 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone31 = new System.Windows.Forms.ComboBox();
            this.skinLabel57 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel58 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel59 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel60 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel61 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel62 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel63 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel64 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel65 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel66 = new CCWin.SkinControl.SkinLabel();
            this.timezone3 = new System.Windows.Forms.TabPage();
            this.skinLabel67 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel68 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel69 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel70 = new CCWin.SkinControl.SkinLabel();
            this.cb_TimeZone90 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone89 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone88 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone87 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone86 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone85 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone84 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone83 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone82 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone81 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone80 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone79 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone78 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone77 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone76 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone75 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone74 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone73 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone72 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone71 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone70 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone69 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone68 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone67 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone66 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone65 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone64 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone63 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone62 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone61 = new System.Windows.Forms.ComboBox();
            this.skinLabel71 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel72 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel73 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel74 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel75 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel76 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel77 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel78 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel79 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel80 = new CCWin.SkinControl.SkinLabel();
            this.timezone4 = new System.Windows.Forms.TabPage();
            this.skinLabel81 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel82 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel83 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel84 = new CCWin.SkinControl.SkinLabel();
            this.cb_TimeZone120 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone119 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone118 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone117 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone116 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone115 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone114 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone113 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone112 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone111 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone110 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone109 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone108 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone107 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone106 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone105 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone104 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone103 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone102 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone101 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone100 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone99 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone98 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone97 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone96 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone95 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone94 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone93 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone92 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone91 = new System.Windows.Forms.ComboBox();
            this.skinLabel85 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel86 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel87 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel88 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel89 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel90 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel91 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel92 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel93 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel94 = new CCWin.SkinControl.SkinLabel();
            this.timezone5 = new System.Windows.Forms.TabPage();
            this.skinLabel95 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel96 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel97 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel98 = new CCWin.SkinControl.SkinLabel();
            this.cb_TimeZone150 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone149 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone148 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone147 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone146 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone145 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone144 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone143 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone142 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone141 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone140 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone139 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone138 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone137 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone136 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone135 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone134 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone133 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone132 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone131 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone130 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone129 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone128 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone127 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone126 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone125 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone124 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone123 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone122 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone121 = new System.Windows.Forms.ComboBox();
            this.skinLabel99 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel100 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel101 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel102 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel103 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel104 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel105 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel106 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel107 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel108 = new CCWin.SkinControl.SkinLabel();
            this.timezone6 = new System.Windows.Forms.TabPage();
            this.skinLabel109 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel110 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel111 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel112 = new CCWin.SkinControl.SkinLabel();
            this.cb_TimeZone180 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone179 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone178 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone177 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone176 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone175 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone174 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone173 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone172 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone171 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone170 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone169 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone168 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone167 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone166 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone165 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone164 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone163 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone162 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone161 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone160 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone159 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone158 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone157 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone156 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone155 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone154 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone153 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone152 = new System.Windows.Forms.ComboBox();
            this.cb_TimeZone151 = new System.Windows.Forms.ComboBox();
            this.skinLabel113 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel114 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel115 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel116 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel117 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel118 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel119 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel120 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel121 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel122 = new CCWin.SkinControl.SkinLabel();
            this.btn_Save1 = new CCWin.SkinControl.SkinButton();
            this.tp_doorRange = new CCWin.SkinControl.SkinTabPage();
            this.dgv_Door_Range_Data = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Del_DoorRange = new CCWin.SkinControl.SkinButton();
            this.btn_Update_DoorRange = new CCWin.SkinControl.SkinButton();
            this.btn_Add_DoorRange = new CCWin.SkinControl.SkinButton();
            this.txt_Search_DoorRange = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_Door_Range_Search = new CCWin.SkinControl.SkinButton();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.tp_doorHoliday = new CCWin.SkinControl.SkinTabPage();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.dgv_holiday = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结束日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del_holiday = new CCWin.SkinControl.SkinButton();
            this.btn_update_holiday = new CCWin.SkinControl.SkinButton();
            this.btn_add_holiday = new CCWin.SkinControl.SkinButton();
            this.txt_search_holiday = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_search_holiday = new CCWin.SkinControl.SkinButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.tp_doorInfo = new CCWin.SkinControl.SkinTabPage();
            this.dgv_door_info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Update_door = new CCWin.SkinControl.SkinButton();
            this.txt_search_doorInfo = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_search_door = new CCWin.SkinControl.SkinButton();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.tp_door_Right = new CCWin.SkinControl.SkinTabPage();
            this.btn_Send_Data_DoorGroup = new CCWin.SkinControl.SkinButton();
            this.dgv_Door_Right = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.门禁时间段 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.人员组合 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Del_Door_Right = new CCWin.SkinControl.SkinButton();
            this.btn_Update_Door_Right = new CCWin.SkinControl.SkinButton();
            this.btn_Add_Door_Right = new CCWin.SkinControl.SkinButton();
            this.txt_Door_Right = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_Door_Right_Search = new CCWin.SkinControl.SkinButton();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tabPageEx2 = new CCWin.SkinControl.SkinTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.skinTabControl4 = new CCWin.SkinControl.SkinTabControl();
            this.tp_Area = new CCWin.SkinControl.SkinTabPage();
            this.btn_serach_area = new CCWin.SkinControl.SkinButton();
            this.dgv_Area_Data = new System.Windows.Forms.DataGridView();
            this.流水编号1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Del_Area = new CCWin.SkinControl.SkinButton();
            this.btn_Update_Area = new CCWin.SkinControl.SkinButton();
            this.btn_Add_Area = new CCWin.SkinControl.SkinButton();
            this.txt_Area_Serach = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.tp_Cotroller = new CCWin.SkinControl.SkinTabPage();
            this.dgv_Operater_Data = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.波特率 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_DelOperater = new CCWin.SkinControl.SkinButton();
            this.btn_UpdateOperater = new CCWin.SkinControl.SkinButton();
            this.btn_AddOperater = new CCWin.SkinControl.SkinButton();
            this.txt_Operater_Search = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_searchOperater = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPageEx1 = new CCWin.SkinControl.SkinTabPage();
            this.dgv_Person_Data = new System.Windows.Forms.DataGridView();
            this.流水编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.联系方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.邮箱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡片编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡片类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.卡片密码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否APB检验 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IACUC审阅小组 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.批准日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.起止日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.课题名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.申请人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.动物种属 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.动物总用量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ExportPerson = new CCWin.SkinControl.SkinButton();
            this.btn_InportPerson = new CCWin.SkinControl.SkinButton();
            this.btn_DelPerson = new CCWin.SkinControl.SkinButton();
            this.btn_UpdatePerson = new CCWin.SkinControl.SkinButton();
            this.btn_AddPerson = new CCWin.SkinControl.SkinButton();
            this.txt_Person_Search = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_searchPerson = new CCWin.SkinControl.SkinButton();
            this.skinLabel27 = new CCWin.SkinControl.SkinLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Watch_Full = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox9 = new CCWin.SkinControl.SkinGroupBox();
            this.dgv_Actions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.door_Group8 = new CCWin.SkinControl.SkinGroupBox();
            this.cb32 = new CCWin.SkinControl.SkinCheckBox();
            this.door32 = new System.Windows.Forms.Button();
            this.btn_OpenDoor32 = new System.Windows.Forms.Button();
            this.cb31 = new CCWin.SkinControl.SkinCheckBox();
            this.door31 = new System.Windows.Forms.Button();
            this.btn_OpenDoor31 = new System.Windows.Forms.Button();
            this.cb30 = new CCWin.SkinControl.SkinCheckBox();
            this.door30 = new System.Windows.Forms.Button();
            this.btn_OpenDoor30 = new System.Windows.Forms.Button();
            this.cb29 = new CCWin.SkinControl.SkinCheckBox();
            this.door29 = new System.Windows.Forms.Button();
            this.btn_OpenDoor29 = new System.Windows.Forms.Button();
            this.door_Group7 = new CCWin.SkinControl.SkinGroupBox();
            this.cb28 = new CCWin.SkinControl.SkinCheckBox();
            this.door28 = new System.Windows.Forms.Button();
            this.btn_OpenDoor28 = new System.Windows.Forms.Button();
            this.cb27 = new CCWin.SkinControl.SkinCheckBox();
            this.door27 = new System.Windows.Forms.Button();
            this.btn_OpenDoor27 = new System.Windows.Forms.Button();
            this.cb26 = new CCWin.SkinControl.SkinCheckBox();
            this.door26 = new System.Windows.Forms.Button();
            this.btn_OpenDoor26 = new System.Windows.Forms.Button();
            this.cb25 = new CCWin.SkinControl.SkinCheckBox();
            this.door25 = new System.Windows.Forms.Button();
            this.btn_OpenDoor25 = new System.Windows.Forms.Button();
            this.door_Group6 = new CCWin.SkinControl.SkinGroupBox();
            this.cb24 = new CCWin.SkinControl.SkinCheckBox();
            this.door24 = new System.Windows.Forms.Button();
            this.btn_OpenDoor24 = new System.Windows.Forms.Button();
            this.cb23 = new CCWin.SkinControl.SkinCheckBox();
            this.door23 = new System.Windows.Forms.Button();
            this.btn_OpenDoor23 = new System.Windows.Forms.Button();
            this.cb22 = new CCWin.SkinControl.SkinCheckBox();
            this.door22 = new System.Windows.Forms.Button();
            this.btn_OpenDoor22 = new System.Windows.Forms.Button();
            this.cb21 = new CCWin.SkinControl.SkinCheckBox();
            this.door21 = new System.Windows.Forms.Button();
            this.btn_OpenDoor21 = new System.Windows.Forms.Button();
            this.door_Group5 = new CCWin.SkinControl.SkinGroupBox();
            this.cb20 = new CCWin.SkinControl.SkinCheckBox();
            this.door20 = new System.Windows.Forms.Button();
            this.btn_OpenDoor20 = new System.Windows.Forms.Button();
            this.cb19 = new CCWin.SkinControl.SkinCheckBox();
            this.door19 = new System.Windows.Forms.Button();
            this.btn_OpenDoor19 = new System.Windows.Forms.Button();
            this.cb18 = new CCWin.SkinControl.SkinCheckBox();
            this.door18 = new System.Windows.Forms.Button();
            this.btn_OpenDoor18 = new System.Windows.Forms.Button();
            this.cb17 = new CCWin.SkinControl.SkinCheckBox();
            this.door17 = new System.Windows.Forms.Button();
            this.btn_OpenDoor17 = new System.Windows.Forms.Button();
            this.door_Group4 = new CCWin.SkinControl.SkinGroupBox();
            this.cb16 = new CCWin.SkinControl.SkinCheckBox();
            this.door16 = new System.Windows.Forms.Button();
            this.btn_OpenDoor16 = new System.Windows.Forms.Button();
            this.cb15 = new CCWin.SkinControl.SkinCheckBox();
            this.door15 = new System.Windows.Forms.Button();
            this.btn_OpenDoor15 = new System.Windows.Forms.Button();
            this.cb14 = new CCWin.SkinControl.SkinCheckBox();
            this.door14 = new System.Windows.Forms.Button();
            this.btn_OpenDoor14 = new System.Windows.Forms.Button();
            this.cb13 = new CCWin.SkinControl.SkinCheckBox();
            this.door13 = new System.Windows.Forms.Button();
            this.btn_OpenDoor13 = new System.Windows.Forms.Button();
            this.door_Group3 = new CCWin.SkinControl.SkinGroupBox();
            this.cb12 = new CCWin.SkinControl.SkinCheckBox();
            this.door12 = new System.Windows.Forms.Button();
            this.btn_OpenDoor12 = new System.Windows.Forms.Button();
            this.cb11 = new CCWin.SkinControl.SkinCheckBox();
            this.door11 = new System.Windows.Forms.Button();
            this.btn_OpenDoor11 = new System.Windows.Forms.Button();
            this.cb10 = new CCWin.SkinControl.SkinCheckBox();
            this.door10 = new System.Windows.Forms.Button();
            this.btn_OpenDoor10 = new System.Windows.Forms.Button();
            this.cb9 = new CCWin.SkinControl.SkinCheckBox();
            this.door9 = new System.Windows.Forms.Button();
            this.btn_OpenDoor9 = new System.Windows.Forms.Button();
            this.door_Group2 = new CCWin.SkinControl.SkinGroupBox();
            this.cb8 = new CCWin.SkinControl.SkinCheckBox();
            this.door8 = new System.Windows.Forms.Button();
            this.btn_OpenDoor8 = new System.Windows.Forms.Button();
            this.cb7 = new CCWin.SkinControl.SkinCheckBox();
            this.door7 = new System.Windows.Forms.Button();
            this.btn_OpenDoor7 = new System.Windows.Forms.Button();
            this.cb6 = new CCWin.SkinControl.SkinCheckBox();
            this.door6 = new System.Windows.Forms.Button();
            this.btn_OpenDoor6 = new System.Windows.Forms.Button();
            this.cb5 = new CCWin.SkinControl.SkinCheckBox();
            this.door5 = new System.Windows.Forms.Button();
            this.btn_OpenDoor5 = new System.Windows.Forms.Button();
            this.door_Group1 = new CCWin.SkinControl.SkinGroupBox();
            this.cb4 = new CCWin.SkinControl.SkinCheckBox();
            this.door4 = new System.Windows.Forms.Button();
            this.btn_OpenDoor4 = new System.Windows.Forms.Button();
            this.cb3 = new CCWin.SkinControl.SkinCheckBox();
            this.door3 = new System.Windows.Forms.Button();
            this.btn_OpenDoor3 = new System.Windows.Forms.Button();
            this.cb2 = new CCWin.SkinControl.SkinCheckBox();
            this.door2 = new System.Windows.Forms.Button();
            this.btn_OpenDoor2 = new System.Windows.Forms.Button();
            this.cb1 = new CCWin.SkinControl.SkinCheckBox();
            this.door1 = new System.Windows.Forms.Button();
            this.btn_OpenDoor1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Animal_Search = new CCWin.SkinControl.SkinButton();
            this.dgv_Animal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Animal_Search = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel143 = new CCWin.SkinControl.SkinLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer_GetData = new System.Windows.Forms.Timer(this.components);
            this.statusStripInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressProc = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.不透明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageEx6.SuspendLayout();
            this.skinTabControl7.SuspendLayout();
            this.tp_Dept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dept)).BeginInit();
            this.tp_KaoQin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            this.tabPageEx5.SuspendLayout();
            this.skinTabControl3.SuspendLayout();
            this.tb_Today_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Today_Actions)).BeginInit();
            this.tb_Exception_Action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exception)).BeginInit();
            this.tabPageEx4.SuspendLayout();
            this.skinTabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).BeginInit();
            this.tabPageEx3.SuspendLayout();
            this.skinTabControl5.SuspendLayout();
            this.tp_TimeInfo.SuspendLayout();
            this.tb_TimeRange.SuspendLayout();
            this.skinTabControl6.SuspendLayout();
            this.timezone1.SuspendLayout();
            this.timezone2.SuspendLayout();
            this.timezone3.SuspendLayout();
            this.timezone4.SuspendLayout();
            this.timezone5.SuspendLayout();
            this.timezone6.SuspendLayout();
            this.tp_doorRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Door_Range_Data)).BeginInit();
            this.tp_doorHoliday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_holiday)).BeginInit();
            this.tp_doorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_door_info)).BeginInit();
            this.tp_door_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Door_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPageEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.skinTabControl4.SuspendLayout();
            this.tp_Area.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area_Data)).BeginInit();
            this.tp_Cotroller.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Operater_Data)).BeginInit();
            this.skinTabControl1.SuspendLayout();
            this.tabPageEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person_Data)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.skinGroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).BeginInit();
            this.door_Group8.SuspendLayout();
            this.door_Group7.SuspendLayout();
            this.door_Group6.SuspendLayout();
            this.door_Group5.SuspendLayout();
            this.door_Group4.SuspendLayout();
            this.door_Group3.SuspendLayout();
            this.door_Group2.SuspendLayout();
            this.door_Group1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Animal)).BeginInit();
            this.statusStripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "hover_360MobileMgr1.png");
            this.imageList.Images.SetKeyName(1, "ico_AdvTools.png");
            this.imageList.Images.SetKeyName(2, "ico_diannaomenzhen.png");
            this.imageList.Images.SetKeyName(3, "ico_dsmain.png");
            this.imageList.Images.SetKeyName(4, "ico_Examine.png");
            this.imageList.Images.SetKeyName(5, "ico_expert.png");
            this.imageList.Images.SetKeyName(6, "ico_rescue.png");
            this.imageList.Images.SetKeyName(7, "ico_softmgr.png");
            this.imageList.Images.SetKeyName(8, "ico_SpeedupOpt.png");
            this.imageList.Images.SetKeyName(9, "ico_SysRepair.png");
            this.imageList.Images.SetKeyName(10, "ico_TraceCleaner.png");
            this.imageList.Images.SetKeyName(11, "ico_VulRepair.png");
            // 
            // tabPageEx6
            // 
            this.tabPageEx6.BackColor = System.Drawing.Color.White;
            this.tabPageEx6.Controls.Add(this.skinTabControl7);
            this.tabPageEx6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageEx6.ForeColor = System.Drawing.Color.White;
            this.tabPageEx6.ImageIndex = 9;
            this.tabPageEx6.Location = new System.Drawing.Point(0, 75);
            this.tabPageEx6.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageEx6.Name = "tabPageEx6";
            this.tabPageEx6.Size = new System.Drawing.Size(1024, 665);
            this.tabPageEx6.TabIndex = 5;
            this.tabPageEx6.Text = "系统设置";
            // 
            // skinTabControl7
            // 
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.skinTabControl7.Animation = animation1;
            this.skinTabControl7.AnimationStart = false;
            this.skinTabControl7.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.BackgroundImage")));
            this.skinTabControl7.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl7.Controls.Add(this.tp_Right);
            this.skinTabControl7.Controls.Add(this.tp_Dept);
            this.skinTabControl7.Controls.Add(this.tp_KaoQin);
            this.skinTabControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl7.ItemSize = new System.Drawing.Size(109, 30);
            this.skinTabControl7.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl7.Name = "skinTabControl7";
            this.skinTabControl7.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageArrowDown")));
            this.skinTabControl7.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageArrowHover")));
            this.skinTabControl7.PageBackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinTabControl7.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageCloseHover")));
            this.skinTabControl7.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageCloseNormal")));
            this.skinTabControl7.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageDown")));
            this.skinTabControl7.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageHover")));
            this.skinTabControl7.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl7.PageNorml = ((System.Drawing.Image)(resources.GetObject("skinTabControl7.PageNorml")));
            this.skinTabControl7.PagePalace = true;
            this.skinTabControl7.SelectedIndex = 0;
            this.skinTabControl7.Size = new System.Drawing.Size(1024, 665);
            this.skinTabControl7.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl7.TabIndex = 10;
            this.skinTabControl7.Selected += new System.Windows.Forms.TabControlEventHandler(this.skinTabControl7_Selected);
            // 
            // tp_Right
            // 
            this.tp_Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_Right.Location = new System.Drawing.Point(0, 30);
            this.tp_Right.Name = "tp_Right";
            this.tp_Right.Size = new System.Drawing.Size(1024, 635);
            this.tp_Right.TabIndex = 2;
            this.tp_Right.Text = "权限管理";
            this.tp_Right.UseVisualStyleBackColor = true;
            // 
            // tp_Dept
            // 
            this.tp_Dept.BackColor = System.Drawing.Color.White;
            this.tp_Dept.Controls.Add(this.btn_Search_Dept_Info);
            this.tp_Dept.Controls.Add(this.dgv_Dept);
            this.tp_Dept.Controls.Add(this.btn_Del_Dept);
            this.tp_Dept.Controls.Add(this.btn_Modify_Dept);
            this.tp_Dept.Controls.Add(this.btn_Add_Dept);
            this.tp_Dept.Controls.Add(this.txt_Dept);
            this.tp_Dept.Controls.Add(this.skinLabel142);
            this.tp_Dept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_Dept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_Dept.Location = new System.Drawing.Point(0, 30);
            this.tp_Dept.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Dept.Name = "tp_Dept";
            this.tp_Dept.Size = new System.Drawing.Size(1024, 635);
            this.tp_Dept.TabIndex = 1;
            this.tp_Dept.Text = "部门设置";
            // 
            // btn_Search_Dept_Info
            // 
            this.btn_Search_Dept_Info.BackColor = System.Drawing.Color.White;
            this.btn_Search_Dept_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search_Dept_Info.BackgroundImage")));
            this.btn_Search_Dept_Info.BaseColor = System.Drawing.Color.White;
            this.btn_Search_Dept_Info.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Search_Dept_Info.DownBack = null;
            this.btn_Search_Dept_Info.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Search_Dept_Info.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_Dept_Info.Location = new System.Drawing.Point(829, -7);
            this.btn_Search_Dept_Info.MouseBack = null;
            this.btn_Search_Dept_Info.Name = "btn_Search_Dept_Info";
            this.btn_Search_Dept_Info.NormlBack = null;
            this.btn_Search_Dept_Info.Size = new System.Drawing.Size(83, 46);
            this.btn_Search_Dept_Info.TabIndex = 42;
            this.btn_Search_Dept_Info.Text = "查询";
            this.btn_Search_Dept_Info.UseVisualStyleBackColor = false;
            this.btn_Search_Dept_Info.Click += new System.EventHandler(this.btn_Search_Dept_Info_Click);
            // 
            // dgv_Dept
            // 
            this.dgv_Dept.AllowUserToAddRows = false;
            this.dgv_Dept.AllowUserToDeleteRows = false;
            this.dgv_Dept.AllowUserToOrderColumns = true;
            this.dgv_Dept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Dept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn54});
            this.dgv_Dept.Location = new System.Drawing.Point(6, 43);
            this.dgv_Dept.MultiSelect = false;
            this.dgv_Dept.Name = "dgv_Dept";
            this.dgv_Dept.ReadOnly = true;
            this.dgv_Dept.RowTemplate.Height = 23;
            this.dgv_Dept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Dept.Size = new System.Drawing.Size(1007, 532);
            this.dgv_Dept.TabIndex = 49;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn50.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.DataPropertyName = "Dept_NO";
            this.dataGridViewTextBoxColumn51.HeaderText = "部门编号";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 150;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.DataPropertyName = "Dept_Name";
            this.dataGridViewTextBoxColumn52.HeaderText = "部门名称";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Width = 200;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn54.HeaderText = "备注";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Width = 400;
            // 
            // btn_Del_Dept
            // 
            this.btn_Del_Dept.BackColor = System.Drawing.Color.White;
            this.btn_Del_Dept.BaseColor = System.Drawing.Color.White;
            this.btn_Del_Dept.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Del_Dept.DownBack = null;
            this.btn_Del_Dept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Del_Dept.ForeColor = System.Drawing.Color.Black;
            this.btn_Del_Dept.Location = new System.Drawing.Point(691, 579);
            this.btn_Del_Dept.MouseBack = null;
            this.btn_Del_Dept.Name = "btn_Del_Dept";
            this.btn_Del_Dept.NormlBack = null;
            this.btn_Del_Dept.Size = new System.Drawing.Size(83, 35);
            this.btn_Del_Dept.TabIndex = 46;
            this.btn_Del_Dept.Text = "删除";
            this.btn_Del_Dept.UseVisualStyleBackColor = false;
            this.btn_Del_Dept.Click += new System.EventHandler(this.btn_Del_Dept_Click);
            // 
            // btn_Modify_Dept
            // 
            this.btn_Modify_Dept.BackColor = System.Drawing.Color.White;
            this.btn_Modify_Dept.BaseColor = System.Drawing.Color.White;
            this.btn_Modify_Dept.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Modify_Dept.DownBack = null;
            this.btn_Modify_Dept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Modify_Dept.ForeColor = System.Drawing.Color.Black;
            this.btn_Modify_Dept.Location = new System.Drawing.Point(581, 579);
            this.btn_Modify_Dept.MouseBack = null;
            this.btn_Modify_Dept.Name = "btn_Modify_Dept";
            this.btn_Modify_Dept.NormlBack = null;
            this.btn_Modify_Dept.Size = new System.Drawing.Size(83, 35);
            this.btn_Modify_Dept.TabIndex = 45;
            this.btn_Modify_Dept.Text = "修改";
            this.btn_Modify_Dept.UseVisualStyleBackColor = false;
            this.btn_Modify_Dept.Click += new System.EventHandler(this.btn_Modify_Dept_Click);
            // 
            // btn_Add_Dept
            // 
            this.btn_Add_Dept.BackColor = System.Drawing.Color.White;
            this.btn_Add_Dept.BaseColor = System.Drawing.Color.White;
            this.btn_Add_Dept.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Add_Dept.DownBack = null;
            this.btn_Add_Dept.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add_Dept.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Dept.Location = new System.Drawing.Point(451, 579);
            this.btn_Add_Dept.MouseBack = null;
            this.btn_Add_Dept.Name = "btn_Add_Dept";
            this.btn_Add_Dept.NormlBack = null;
            this.btn_Add_Dept.Size = new System.Drawing.Size(83, 35);
            this.btn_Add_Dept.TabIndex = 44;
            this.btn_Add_Dept.Text = "增加";
            this.btn_Add_Dept.UseVisualStyleBackColor = false;
            this.btn_Add_Dept.Click += new System.EventHandler(this.btn_Add_Dept_Click);
            // 
            // txt_Dept
            // 
            this.txt_Dept.Location = new System.Drawing.Point(103, 6);
            this.txt_Dept.Multiline = true;
            this.txt_Dept.Name = "txt_Dept";
            this.txt_Dept.Size = new System.Drawing.Size(618, 29);
            this.txt_Dept.TabIndex = 43;
            this.txt_Dept.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Dept.WaterText = "";
            this.txt_Dept.MouseEnter += new System.EventHandler(this.txt_Dept_MouseEnter);
            this.txt_Dept.MouseLeave += new System.EventHandler(this.txt_Dept_MouseLeave);
            // 
            // skinLabel142
            // 
            this.skinLabel142.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel142.AutoSize = true;
            this.skinLabel142.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel142.BorderColor = System.Drawing.Color.White;
            this.skinLabel142.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel142.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel142.Location = new System.Drawing.Point(18, 6);
            this.skinLabel142.Name = "skinLabel142";
            this.skinLabel142.Size = new System.Drawing.Size(79, 19);
            this.skinLabel142.TabIndex = 41;
            this.skinLabel142.Text = "搜索条件：";
            // 
            // tp_KaoQin
            // 
            this.tp_KaoQin.BackColor = System.Drawing.Color.White;
            this.tp_KaoQin.Controls.Add(this.dtp_End);
            this.tp_KaoQin.Controls.Add(this.dtp_begin);
            this.tp_KaoQin.Controls.Add(this.skinLabel140);
            this.tp_KaoQin.Controls.Add(this.skinLabel141);
            this.tp_KaoQin.Controls.Add(this.skinLabel139);
            this.tp_KaoQin.Controls.Add(this.nud7);
            this.tp_KaoQin.Controls.Add(this.skinLabel138);
            this.tp_KaoQin.Controls.Add(this.nud6);
            this.tp_KaoQin.Controls.Add(this.nud5);
            this.tp_KaoQin.Controls.Add(this.nud4);
            this.tp_KaoQin.Controls.Add(this.nud3);
            this.tp_KaoQin.Controls.Add(this.nud2);
            this.tp_KaoQin.Controls.Add(this.nud1);
            this.tp_KaoQin.Controls.Add(this.txt_Mail);
            this.tp_KaoQin.Controls.Add(this.btn_Test_SendMail);
            this.tp_KaoQin.Controls.Add(this.btn_Save_KaoQin);
            this.tp_KaoQin.Controls.Add(this.skinLabel124);
            this.tp_KaoQin.Controls.Add(this.skinLabel125);
            this.tp_KaoQin.Controls.Add(this.skinLabel126);
            this.tp_KaoQin.Controls.Add(this.skinLabel128);
            this.tp_KaoQin.Controls.Add(this.skinLabel129);
            this.tp_KaoQin.Controls.Add(this.skinLabel130);
            this.tp_KaoQin.Controls.Add(this.skinLabel131);
            this.tp_KaoQin.Controls.Add(this.skinLabel132);
            this.tp_KaoQin.Controls.Add(this.skinLabel133);
            this.tp_KaoQin.Controls.Add(this.skinLabel134);
            this.tp_KaoQin.Controls.Add(this.skinLabel135);
            this.tp_KaoQin.Controls.Add(this.skinLabel136);
            this.tp_KaoQin.Controls.Add(this.skinLabel137);
            this.tp_KaoQin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_KaoQin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_KaoQin.Location = new System.Drawing.Point(0, 30);
            this.tp_KaoQin.Margin = new System.Windows.Forms.Padding(0);
            this.tp_KaoQin.Name = "tp_KaoQin";
            this.tp_KaoQin.Size = new System.Drawing.Size(1024, 635);
            this.tp_KaoQin.TabIndex = 0;
            this.tp_KaoQin.Text = "考勤设置";
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "HH:mm";
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(598, 20);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.ShowUpDown = true;
            this.dtp_End.Size = new System.Drawing.Size(120, 23);
            this.dtp_End.TabIndex = 240;
            this.dtp_End.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_begin
            // 
            this.dtp_begin.CustomFormat = "HH:mm";
            this.dtp_begin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_begin.Location = new System.Drawing.Point(170, 20);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.ShowUpDown = true;
            this.dtp_begin.Size = new System.Drawing.Size(120, 23);
            this.dtp_begin.TabIndex = 239;
            this.dtp_begin.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel140
            // 
            this.skinLabel140.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel140.AutoSize = true;
            this.skinLabel140.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel140.BorderColor = System.Drawing.Color.White;
            this.skinLabel140.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel140.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel140.Location = new System.Drawing.Point(468, 20);
            this.skinLabel140.Name = "skinLabel140";
            this.skinLabel140.Size = new System.Drawing.Size(101, 19);
            this.skinLabel140.TabIndex = 238;
            this.skinLabel140.Text = "下班打卡时间 :";
            // 
            // skinLabel141
            // 
            this.skinLabel141.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel141.AutoSize = true;
            this.skinLabel141.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel141.BorderColor = System.Drawing.Color.White;
            this.skinLabel141.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel141.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel141.Location = new System.Drawing.Point(30, 20);
            this.skinLabel141.Name = "skinLabel141";
            this.skinLabel141.Size = new System.Drawing.Size(107, 19);
            this.skinLabel141.TabIndex = 237;
            this.skinLabel141.Text = "上班打卡时间：";
            // 
            // skinLabel139
            // 
            this.skinLabel139.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel139.AutoSize = true;
            this.skinLabel139.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel139.BorderColor = System.Drawing.Color.White;
            this.skinLabel139.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel139.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel139.Location = new System.Drawing.Point(260, 420);
            this.skinLabel139.Name = "skinLabel139";
            this.skinLabel139.Size = new System.Drawing.Size(79, 19);
            this.skinLabel139.TabIndex = 236;
            this.skinLabel139.Text = "号发送邮件";
            // 
            // nud7
            // 
            this.nud7.Location = new System.Drawing.Point(170, 420);
            this.nud7.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nud7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud7.Name = "nud7";
            this.nud7.Size = new System.Drawing.Size(50, 23);
            this.nud7.TabIndex = 235;
            this.nud7.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // skinLabel138
            // 
            this.skinLabel138.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel138.AutoSize = true;
            this.skinLabel138.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel138.BorderColor = System.Drawing.Color.White;
            this.skinLabel138.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel138.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel138.Location = new System.Drawing.Point(30, 420);
            this.skinLabel138.Name = "skinLabel138";
            this.skinLabel138.Size = new System.Drawing.Size(51, 19);
            this.skinLabel138.TabIndex = 234;
            this.skinLabel138.Text = "第月第";
            // 
            // nud6
            // 
            this.nud6.Location = new System.Drawing.Point(598, 320);
            this.nud6.Name = "nud6";
            this.nud6.Size = new System.Drawing.Size(50, 23);
            this.nud6.TabIndex = 233;
            // 
            // nud5
            // 
            this.nud5.Location = new System.Drawing.Point(170, 320);
            this.nud5.Name = "nud5";
            this.nud5.Size = new System.Drawing.Size(50, 23);
            this.nud5.TabIndex = 232;
            // 
            // nud4
            // 
            this.nud4.Location = new System.Drawing.Point(598, 220);
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(50, 23);
            this.nud4.TabIndex = 231;
            // 
            // nud3
            // 
            this.nud3.Location = new System.Drawing.Point(170, 220);
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(50, 23);
            this.nud3.TabIndex = 230;
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(598, 120);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(50, 23);
            this.nud2.TabIndex = 229;
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(170, 120);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(50, 23);
            this.nud1.TabIndex = 228;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(202, 520);
            this.txt_Mail.Multiline = true;
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(468, 26);
            this.txt_Mail.TabIndex = 227;
            this.txt_Mail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Mail.WaterText = "";
            // 
            // btn_Test_SendMail
            // 
            this.btn_Test_SendMail.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Test_SendMail.Location = new System.Drawing.Point(334, 575);
            this.btn_Test_SendMail.Name = "btn_Test_SendMail";
            this.btn_Test_SendMail.Size = new System.Drawing.Size(97, 24);
            this.btn_Test_SendMail.TabIndex = 226;
            this.btn_Test_SendMail.Text = "测试邮件发送";
            this.btn_Test_SendMail.UseVisualStyleBackColor = true;
            this.btn_Test_SendMail.Click += new System.EventHandler(this.btn_Test_SendMail_Click);
            // 
            // btn_Save_KaoQin
            // 
            this.btn_Save_KaoQin.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_Save_KaoQin.Location = new System.Drawing.Point(636, 575);
            this.btn_Save_KaoQin.Name = "btn_Save_KaoQin";
            this.btn_Save_KaoQin.Size = new System.Drawing.Size(113, 24);
            this.btn_Save_KaoQin.TabIndex = 225;
            this.btn_Save_KaoQin.Text = "保存到数据库";
            this.btn_Save_KaoQin.UseVisualStyleBackColor = true;
            this.btn_Save_KaoQin.Click += new System.EventHandler(this.btn_Save_KaoQin_Click);
            // 
            // skinLabel124
            // 
            this.skinLabel124.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel124.AutoSize = true;
            this.skinLabel124.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel124.BorderColor = System.Drawing.Color.White;
            this.skinLabel124.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel124.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel124.Location = new System.Drawing.Point(30, 520);
            this.skinLabel124.Name = "skinLabel124";
            this.skinLabel124.Size = new System.Drawing.Size(93, 19);
            this.skinLabel124.TabIndex = 224;
            this.skinLabel124.Text = "收件人邮箱：";
            // 
            // skinLabel125
            // 
            this.skinLabel125.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel125.AutoSize = true;
            this.skinLabel125.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel125.BorderColor = System.Drawing.Color.White;
            this.skinLabel125.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel125.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel125.Location = new System.Drawing.Point(704, 120);
            this.skinLabel125.Name = "skinLabel125";
            this.skinLabel125.Size = new System.Drawing.Size(101, 19);
            this.skinLabel125.TabIndex = 223;
            this.skinLabel125.Text = "分　　　  　钟";
            // 
            // skinLabel126
            // 
            this.skinLabel126.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel126.AutoSize = true;
            this.skinLabel126.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel126.BorderColor = System.Drawing.Color.White;
            this.skinLabel126.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel126.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel126.Location = new System.Drawing.Point(30, 220);
            this.skinLabel126.Name = "skinLabel126";
            this.skinLabel126.Size = new System.Drawing.Size(93, 19);
            this.skinLabel126.TabIndex = 222;
            this.skinLabel126.Text = "迟到时间在：";
            // 
            // skinLabel128
            // 
            this.skinLabel128.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel128.AutoSize = true;
            this.skinLabel128.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel128.BorderColor = System.Drawing.Color.White;
            this.skinLabel128.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel128.Location = new System.Drawing.Point(260, 220);
            this.skinLabel128.Name = "skinLabel128";
            this.skinLabel128.Size = new System.Drawing.Size(79, 19);
            this.skinLabel128.TabIndex = 221;
            this.skinLabel128.Text = "分钟内不计";
            // 
            // skinLabel129
            // 
            this.skinLabel129.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel129.AutoSize = true;
            this.skinLabel129.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel129.BorderColor = System.Drawing.Color.White;
            this.skinLabel129.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel129.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel129.Location = new System.Drawing.Point(468, 220);
            this.skinLabel129.Name = "skinLabel129";
            this.skinLabel129.Size = new System.Drawing.Size(93, 19);
            this.skinLabel129.TabIndex = 220;
            this.skinLabel129.Text = "早退时间在：";
            // 
            // skinLabel130
            // 
            this.skinLabel130.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel130.AutoSize = true;
            this.skinLabel130.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel130.BorderColor = System.Drawing.Color.White;
            this.skinLabel130.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel130.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel130.Location = new System.Drawing.Point(695, 220);
            this.skinLabel130.Name = "skinLabel130";
            this.skinLabel130.Size = new System.Drawing.Size(83, 19);
            this.skinLabel130.TabIndex = 219;
            this.skinLabel130.Text = " 分钟内不计";
            // 
            // skinLabel131
            // 
            this.skinLabel131.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel131.AutoSize = true;
            this.skinLabel131.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel131.BorderColor = System.Drawing.Color.White;
            this.skinLabel131.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel131.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel131.Location = new System.Drawing.Point(30, 320);
            this.skinLabel131.Name = "skinLabel131";
            this.skinLabel131.Size = new System.Drawing.Size(79, 19);
            this.skinLabel131.TabIndex = 218;
            this.skinLabel131.Text = "迟到超过：";
            // 
            // skinLabel132
            // 
            this.skinLabel132.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel132.AutoSize = true;
            this.skinLabel132.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel132.BorderColor = System.Drawing.Color.White;
            this.skinLabel132.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel132.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel132.Location = new System.Drawing.Point(260, 320);
            this.skinLabel132.Name = "skinLabel132";
            this.skinLabel132.Size = new System.Drawing.Size(111, 19);
            this.skinLabel132.TabIndex = 217;
            this.skinLabel132.Text = " 分钟不计入考勤";
            // 
            // skinLabel133
            // 
            this.skinLabel133.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel133.AutoSize = true;
            this.skinLabel133.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel133.BorderColor = System.Drawing.Color.White;
            this.skinLabel133.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel133.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel133.Location = new System.Drawing.Point(468, 320);
            this.skinLabel133.Name = "skinLabel133";
            this.skinLabel133.Size = new System.Drawing.Size(65, 19);
            this.skinLabel133.TabIndex = 216;
            this.skinLabel133.Text = "早退超过";
            // 
            // skinLabel134
            // 
            this.skinLabel134.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel134.AutoSize = true;
            this.skinLabel134.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel134.BorderColor = System.Drawing.Color.White;
            this.skinLabel134.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel134.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel134.Location = new System.Drawing.Point(682, 317);
            this.skinLabel134.Name = "skinLabel134";
            this.skinLabel134.Size = new System.Drawing.Size(111, 19);
            this.skinLabel134.TabIndex = 215;
            this.skinLabel134.Text = " 分钟不计入考勤";
            // 
            // skinLabel135
            // 
            this.skinLabel135.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel135.AutoSize = true;
            this.skinLabel135.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel135.BorderColor = System.Drawing.Color.White;
            this.skinLabel135.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel135.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel135.Location = new System.Drawing.Point(468, 120);
            this.skinLabel135.Name = "skinLabel135";
            this.skinLabel135.Size = new System.Drawing.Size(101, 19);
            this.skinLabel135.TabIndex = 214;
            this.skinLabel135.Text = "下班允许推迟 :";
            // 
            // skinLabel136
            // 
            this.skinLabel136.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel136.AutoSize = true;
            this.skinLabel136.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel136.BorderColor = System.Drawing.Color.White;
            this.skinLabel136.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel136.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel136.Location = new System.Drawing.Point(260, 120);
            this.skinLabel136.Name = "skinLabel136";
            this.skinLabel136.Size = new System.Drawing.Size(107, 19);
            this.skinLabel136.TabIndex = 213;
            this.skinLabel136.Text = "分　　　　　钟";
            // 
            // skinLabel137
            // 
            this.skinLabel137.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel137.AutoSize = true;
            this.skinLabel137.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel137.BorderColor = System.Drawing.Color.White;
            this.skinLabel137.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel137.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel137.Location = new System.Drawing.Point(30, 120);
            this.skinLabel137.Name = "skinLabel137";
            this.skinLabel137.Size = new System.Drawing.Size(107, 19);
            this.skinLabel137.TabIndex = 212;
            this.skinLabel137.Text = "上班允许提前：";
            // 
            // tabPageEx5
            // 
            this.tabPageEx5.BackColor = System.Drawing.Color.White;
            this.tabPageEx5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageEx5.Controls.Add(this.skinTabControl3);
            this.tabPageEx5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageEx5.ForeColor = System.Drawing.Color.White;
            this.tabPageEx5.ImageIndex = 0;
            this.tabPageEx5.Location = new System.Drawing.Point(0, 75);
            this.tabPageEx5.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageEx5.Name = "tabPageEx5";
            this.tabPageEx5.Size = new System.Drawing.Size(1024, 665);
            this.tabPageEx5.TabIndex = 4;
            this.tabPageEx5.Text = "报表统计";
            // 
            // skinTabControl3
            // 
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.skinTabControl3.Animation = animation2;
            this.skinTabControl3.AnimationStart = false;
            this.skinTabControl3.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.BackgroundImage")));
            this.skinTabControl3.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl3.Controls.Add(this.tb_Today_Action);
            this.skinTabControl3.Controls.Add(this.tb_Exception_Action);
            this.skinTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl3.ImgTxtSpace = 0;
            this.skinTabControl3.ItemSize = new System.Drawing.Size(109, 30);
            this.skinTabControl3.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl3.Name = "skinTabControl3";
            this.skinTabControl3.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageArrowDown")));
            this.skinTabControl3.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageArrowHover")));
            this.skinTabControl3.PageBackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinTabControl3.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageCloseHover")));
            this.skinTabControl3.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageCloseNormal")));
            this.skinTabControl3.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageDown")));
            this.skinTabControl3.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageHover")));
            this.skinTabControl3.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl3.PageNorml = ((System.Drawing.Image)(resources.GetObject("skinTabControl3.PageNorml")));
            this.skinTabControl3.PagePalace = true;
            this.skinTabControl3.SelectedIndex = 0;
            this.skinTabControl3.Size = new System.Drawing.Size(1024, 665);
            this.skinTabControl3.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl3.TabIndex = 1;
            this.skinTabControl3.Selected += new System.Windows.Forms.TabControlEventHandler(this.skinTabControl3_Selected);
            // 
            // tb_Today_Action
            // 
            this.tb_Today_Action.BackColor = System.Drawing.Color.White;
            this.tb_Today_Action.Controls.Add(this.dgv_Today_Actions);
            this.tb_Today_Action.Controls.Add(this.txt_Today_Actions);
            this.tb_Today_Action.Controls.Add(this.btn_Today_Actions);
            this.tb_Today_Action.Controls.Add(this.skinLabel123);
            this.tb_Today_Action.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_Today_Action.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_Today_Action.Location = new System.Drawing.Point(0, 30);
            this.tb_Today_Action.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Today_Action.Name = "tb_Today_Action";
            this.tb_Today_Action.Size = new System.Drawing.Size(1024, 635);
            this.tb_Today_Action.TabIndex = 0;
            this.tb_Today_Action.Text = "门禁进出事件";
            // 
            // dgv_Today_Actions
            // 
            this.dgv_Today_Actions.AllowUserToAddRows = false;
            this.dgv_Today_Actions.AllowUserToDeleteRows = false;
            this.dgv_Today_Actions.AllowUserToOrderColumns = true;
            this.dgv_Today_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Today_Actions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.事件1});
            this.dgv_Today_Actions.Location = new System.Drawing.Point(8, 52);
            this.dgv_Today_Actions.MultiSelect = false;
            this.dgv_Today_Actions.Name = "dgv_Today_Actions";
            this.dgv_Today_Actions.ReadOnly = true;
            this.dgv_Today_Actions.RowTemplate.Height = 23;
            this.dgv_Today_Actions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Today_Actions.Size = new System.Drawing.Size(1007, 580);
            this.dgv_Today_Actions.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn39.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.DataPropertyName = "Controller_Name";
            this.dataGridViewTextBoxColumn40.HeaderText = "控制器名称";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 120;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.DataPropertyName = "place";
            this.dataGridViewTextBoxColumn41.HeaderText = "刷卡地点";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 120;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.DataPropertyName = "Person_Name";
            this.dataGridViewTextBoxColumn42.HeaderText = "刷卡人";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 120;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.DataPropertyName = "Date_Time";
            this.dataGridViewTextBoxColumn43.HeaderText = "刷卡日期";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 120;
            // 
            // 事件1
            // 
            this.事件1.DataPropertyName = "Action";
            this.事件1.HeaderText = "事件";
            this.事件1.Name = "事件1";
            this.事件1.ReadOnly = true;
            // 
            // txt_Today_Actions
            // 
            this.txt_Today_Actions.Location = new System.Drawing.Point(105, 15);
            this.txt_Today_Actions.Multiline = true;
            this.txt_Today_Actions.Name = "txt_Today_Actions";
            this.txt_Today_Actions.Size = new System.Drawing.Size(618, 29);
            this.txt_Today_Actions.TabIndex = 50;
            this.txt_Today_Actions.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Today_Actions.WaterText = "";
            this.txt_Today_Actions.MouseEnter += new System.EventHandler(this.txt_Today_Actions_MouseEnter);
            this.txt_Today_Actions.MouseLeave += new System.EventHandler(this.txt_Today_Actions_MouseLeave);
            // 
            // btn_Today_Actions
            // 
            this.btn_Today_Actions.BackColor = System.Drawing.Color.White;
            this.btn_Today_Actions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Today_Actions.BackgroundImage")));
            this.btn_Today_Actions.BaseColor = System.Drawing.Color.White;
            this.btn_Today_Actions.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Today_Actions.DownBack = null;
            this.btn_Today_Actions.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Today_Actions.ForeColor = System.Drawing.Color.Black;
            this.btn_Today_Actions.Location = new System.Drawing.Point(749, 8);
            this.btn_Today_Actions.MouseBack = null;
            this.btn_Today_Actions.Name = "btn_Today_Actions";
            this.btn_Today_Actions.NormlBack = null;
            this.btn_Today_Actions.Size = new System.Drawing.Size(83, 38);
            this.btn_Today_Actions.TabIndex = 49;
            this.btn_Today_Actions.Text = "查询";
            this.btn_Today_Actions.UseVisualStyleBackColor = false;
            this.btn_Today_Actions.Click += new System.EventHandler(this.btn_Today_Actions_Click);
            // 
            // skinLabel123
            // 
            this.skinLabel123.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel123.AutoSize = true;
            this.skinLabel123.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel123.BorderColor = System.Drawing.Color.White;
            this.skinLabel123.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel123.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel123.Location = new System.Drawing.Point(20, 15);
            this.skinLabel123.Name = "skinLabel123";
            this.skinLabel123.Size = new System.Drawing.Size(79, 19);
            this.skinLabel123.TabIndex = 48;
            this.skinLabel123.Text = "搜索条件：";
            // 
            // tb_Exception_Action
            // 
            this.tb_Exception_Action.BackColor = System.Drawing.Color.White;
            this.tb_Exception_Action.Controls.Add(this.dgv_Exception);
            this.tb_Exception_Action.Controls.Add(this.txt_Exception);
            this.tb_Exception_Action.Controls.Add(this.btn_Search_ExceptionData);
            this.tb_Exception_Action.Controls.Add(this.skinLabel127);
            this.tb_Exception_Action.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tb_Exception_Action.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_Exception_Action.Location = new System.Drawing.Point(0, 30);
            this.tb_Exception_Action.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Exception_Action.Name = "tb_Exception_Action";
            this.tb_Exception_Action.Size = new System.Drawing.Size(200, 0);
            this.tb_Exception_Action.TabIndex = 4;
            this.tb_Exception_Action.Text = "门禁异常事件";
            // 
            // dgv_Exception
            // 
            this.dgv_Exception.AllowUserToAddRows = false;
            this.dgv_Exception.AllowUserToDeleteRows = false;
            this.dgv_Exception.AllowUserToOrderColumns = true;
            this.dgv_Exception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Exception.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn59,
            this.事件,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63});
            this.dgv_Exception.Location = new System.Drawing.Point(8, 52);
            this.dgv_Exception.MultiSelect = false;
            this.dgv_Exception.Name = "dgv_Exception";
            this.dgv_Exception.ReadOnly = true;
            this.dgv_Exception.RowTemplate.Height = 23;
            this.dgv_Exception.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Exception.Size = new System.Drawing.Size(1007, 580);
            this.dgv_Exception.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn59.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            // 
            // 事件
            // 
            this.事件.DataPropertyName = "Action";
            this.事件.HeaderText = "事件";
            this.事件.Name = "事件";
            this.事件.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.DataPropertyName = "Controller_Name";
            this.dataGridViewTextBoxColumn60.HeaderText = "控制器名称";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Width = 120;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.DataPropertyName = "place";
            this.dataGridViewTextBoxColumn61.HeaderText = "刷卡地点";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 120;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.DataPropertyName = "Person_Name";
            this.dataGridViewTextBoxColumn62.HeaderText = "刷卡人";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Width = 120;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.DataPropertyName = "date_time";
            this.dataGridViewTextBoxColumn63.HeaderText = "刷卡日期";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Width = 120;
            // 
            // txt_Exception
            // 
            this.txt_Exception.Location = new System.Drawing.Point(105, 15);
            this.txt_Exception.Multiline = true;
            this.txt_Exception.Name = "txt_Exception";
            this.txt_Exception.Size = new System.Drawing.Size(618, 29);
            this.txt_Exception.TabIndex = 55;
            this.txt_Exception.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Exception.WaterText = "";
            this.txt_Exception.MouseEnter += new System.EventHandler(this.txt_Exception_MouseEnter);
            this.txt_Exception.MouseLeave += new System.EventHandler(this.txt_Exception_MouseLeave);
            // 
            // btn_Search_ExceptionData
            // 
            this.btn_Search_ExceptionData.BackColor = System.Drawing.Color.White;
            this.btn_Search_ExceptionData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search_ExceptionData.BackgroundImage")));
            this.btn_Search_ExceptionData.BaseColor = System.Drawing.Color.White;
            this.btn_Search_ExceptionData.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Search_ExceptionData.DownBack = null;
            this.btn_Search_ExceptionData.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Search_ExceptionData.ForeColor = System.Drawing.Color.Black;
            this.btn_Search_ExceptionData.Location = new System.Drawing.Point(749, 8);
            this.btn_Search_ExceptionData.MouseBack = null;
            this.btn_Search_ExceptionData.Name = "btn_Search_ExceptionData";
            this.btn_Search_ExceptionData.NormlBack = null;
            this.btn_Search_ExceptionData.Size = new System.Drawing.Size(83, 38);
            this.btn_Search_ExceptionData.TabIndex = 54;
            this.btn_Search_ExceptionData.Text = "查询";
            this.btn_Search_ExceptionData.UseVisualStyleBackColor = false;
            this.btn_Search_ExceptionData.Click += new System.EventHandler(this.btn_Search_ExceptionData_Click);
            // 
            // skinLabel127
            // 
            this.skinLabel127.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel127.AutoSize = true;
            this.skinLabel127.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel127.BorderColor = System.Drawing.Color.White;
            this.skinLabel127.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel127.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel127.Location = new System.Drawing.Point(20, 15);
            this.skinLabel127.Name = "skinLabel127";
            this.skinLabel127.Size = new System.Drawing.Size(79, 19);
            this.skinLabel127.TabIndex = 53;
            this.skinLabel127.Text = "搜索条件：";
            // 
            // tabPageEx4
            // 
            this.tabPageEx4.BackColor = System.Drawing.Color.White;
            this.tabPageEx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageEx4.Controls.Add(this.skinTabControl2);
            this.tabPageEx4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageEx4.ForeColor = System.Drawing.Color.White;
            this.tabPageEx4.ImageIndex = 5;
            this.tabPageEx4.Location = new System.Drawing.Point(0, 75);
            this.tabPageEx4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageEx4.Name = "tabPageEx4";
            this.tabPageEx4.Size = new System.Drawing.Size(1024, 665);
            this.tabPageEx4.TabIndex = 3;
            this.tabPageEx4.Text = "操作日志";
            // 
            // skinTabControl2
            // 
            animation3.AnimateOnlyDifferences = false;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.skinTabControl2.Animation = animation3;
            this.skinTabControl2.AnimationStart = false;
            this.skinTabControl2.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.BackgroundImage")));
            this.skinTabControl2.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl2.Controls.Add(this.tabPage1);
            this.skinTabControl2.Controls.Add(this.tabPage3);
            this.skinTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl2.ItemSize = new System.Drawing.Size(109, 30);
            this.skinTabControl2.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl2.Name = "skinTabControl2";
            this.skinTabControl2.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageArrowDown")));
            this.skinTabControl2.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageArrowHover")));
            this.skinTabControl2.PageBackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinTabControl2.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageCloseHover")));
            this.skinTabControl2.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageCloseNormal")));
            this.skinTabControl2.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageDown")));
            this.skinTabControl2.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageHover")));
            this.skinTabControl2.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl2.PageNorml = ((System.Drawing.Image)(resources.GetObject("skinTabControl2.PageNorml")));
            this.skinTabControl2.PagePalace = true;
            this.skinTabControl2.SelectedIndex = 0;
            this.skinTabControl2.Size = new System.Drawing.Size(1024, 665);
            this.skinTabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgv_Log);
            this.tabPage1.Controls.Add(this.txt_Log);
            this.tabPage1.Controls.Add(this.btn_Log);
            this.tabPage1.Controls.Add(this.skinLabel6);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tabPage1.Location = new System.Drawing.Point(0, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1024, 635);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人事操作日志";
            // 
            // dgv_Log
            // 
            this.dgv_Log.AllowUserToAddRows = false;
            this.dgv_Log.AllowUserToDeleteRows = false;
            this.dgv_Log.AllowUserToOrderColumns = true;
            this.dgv_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.dgv_Log.Location = new System.Drawing.Point(6, 56);
            this.dgv_Log.MultiSelect = false;
            this.dgv_Log.Name = "dgv_Log";
            this.dgv_Log.ReadOnly = true;
            this.dgv_Log.RowTemplate.Height = 23;
            this.dgv_Log.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Log.Size = new System.Drawing.Size(1007, 563);
            this.dgv_Log.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn31.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "OperateType";
            this.dataGridViewTextBoxColumn32.HeaderText = "操作类型";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 120;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "OperateContent";
            this.dataGridViewTextBoxColumn33.HeaderText = "操作详情";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 120;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Is_succeed";
            this.dataGridViewTextBoxColumn34.HeaderText = "是否成功";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 120;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.DataPropertyName = "Fail_renson";
            this.dataGridViewTextBoxColumn36.HeaderText = "失败原因";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Width = 120;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.DataPropertyName = "Operater";
            this.dataGridViewTextBoxColumn37.HeaderText = "操作者";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Width = 120;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.DataPropertyName = "Operate_Date";
            this.dataGridViewTextBoxColumn38.HeaderText = "操作时间";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Width = 120;
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(103, 19);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(618, 29);
            this.txt_Log.TabIndex = 50;
            this.txt_Log.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Log.WaterText = "";
            this.txt_Log.MouseEnter += new System.EventHandler(this.txt_Log_MouseEnter);
            this.txt_Log.MouseLeave += new System.EventHandler(this.txt_Log_MouseLeave);
            // 
            // btn_Log
            // 
            this.btn_Log.BackColor = System.Drawing.Color.White;
            this.btn_Log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Log.BackgroundImage")));
            this.btn_Log.BaseColor = System.Drawing.Color.White;
            this.btn_Log.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Log.DownBack = null;
            this.btn_Log.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Log.ForeColor = System.Drawing.Color.Black;
            this.btn_Log.Location = new System.Drawing.Point(747, 12);
            this.btn_Log.MouseBack = null;
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.NormlBack = null;
            this.btn_Log.Size = new System.Drawing.Size(83, 46);
            this.btn_Log.TabIndex = 49;
            this.btn_Log.Text = "查询";
            this.btn_Log.UseVisualStyleBackColor = false;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel6.Location = new System.Drawing.Point(18, 19);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(79, 19);
            this.skinLabel6.TabIndex = 48;
            this.skinLabel6.Text = "搜索条件：";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tabPage3.Location = new System.Drawing.Point(0, 30);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 0);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "考勤发送日志";
            // 
            // tabPageEx3
            // 
            this.tabPageEx3.BackColor = System.Drawing.Color.White;
            this.tabPageEx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageEx3.Controls.Add(this.skinTabControl5);
            this.tabPageEx3.Controls.Add(this.pictureBox6);
            this.tabPageEx3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.tabPageEx3.ForeColor = System.Drawing.Color.White;
            this.tabPageEx3.ImageIndex = 6;
            this.tabPageEx3.Location = new System.Drawing.Point(0, 75);
            this.tabPageEx3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageEx3.Name = "tabPageEx3";
            this.tabPageEx3.Size = new System.Drawing.Size(1024, 665);
            this.tabPageEx3.TabIndex = 2;
            this.tabPageEx3.Text = "门禁设置";
            // 
            // skinTabControl5
            // 
            animation4.AnimateOnlyDifferences = false;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.skinTabControl5.Animation = animation4;
            this.skinTabControl5.AnimationStart = false;
            this.skinTabControl5.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.BackgroundImage")));
            this.skinTabControl5.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl5.Controls.Add(this.tp_TimeInfo);
            this.skinTabControl5.Controls.Add(this.tb_TimeRange);
            this.skinTabControl5.Controls.Add(this.tp_doorRange);
            this.skinTabControl5.Controls.Add(this.tp_doorHoliday);
            this.skinTabControl5.Controls.Add(this.tp_doorInfo);
            this.skinTabControl5.Controls.Add(this.tp_door_Right);
            this.skinTabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl5.ImgTxtSpace = 0;
            this.skinTabControl5.ItemSize = new System.Drawing.Size(109, 30);
            this.skinTabControl5.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl5.Name = "skinTabControl5";
            this.skinTabControl5.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageArrowDown")));
            this.skinTabControl5.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageArrowHover")));
            this.skinTabControl5.PageBackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinTabControl5.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageCloseHover")));
            this.skinTabControl5.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageCloseNormal")));
            this.skinTabControl5.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageDown")));
            this.skinTabControl5.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageHover")));
            this.skinTabControl5.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl5.PageNorml = ((System.Drawing.Image)(resources.GetObject("skinTabControl5.PageNorml")));
            this.skinTabControl5.PagePalace = true;
            this.skinTabControl5.SelectedIndex = 0;
            this.skinTabControl5.Size = new System.Drawing.Size(1024, 665);
            this.skinTabControl5.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl5.TabIndex = 7;
            this.skinTabControl5.Selected += new System.Windows.Forms.TabControlEventHandler(this.skinTabControl5_Selected);
            // 
            // tp_TimeInfo
            // 
            this.tp_TimeInfo.BackColor = System.Drawing.Color.White;
            this.tp_TimeInfo.Controls.Add(this.btn_Save);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time30);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time30);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time29);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time29);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time28);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time28);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time27);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time27);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time26);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time26);
            this.tp_TimeInfo.Controls.Add(this.skinLabel23);
            this.tp_TimeInfo.Controls.Add(this.skinLabel24);
            this.tp_TimeInfo.Controls.Add(this.skinLabel25);
            this.tp_TimeInfo.Controls.Add(this.skinLabel26);
            this.tp_TimeInfo.Controls.Add(this.skinLabel28);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time25);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time25);
            this.tp_TimeInfo.Controls.Add(this.skinLabel29);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time24);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time24);
            this.tp_TimeInfo.Controls.Add(this.skinLabel30);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time23);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time23);
            this.tp_TimeInfo.Controls.Add(this.skinLabel31);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time22);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time22);
            this.tp_TimeInfo.Controls.Add(this.skinLabel32);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time21);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time21);
            this.tp_TimeInfo.Controls.Add(this.skinLabel33);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time20);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time20);
            this.tp_TimeInfo.Controls.Add(this.skinLabel34);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time19);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time19);
            this.tp_TimeInfo.Controls.Add(this.skinLabel35);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time18);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time18);
            this.tp_TimeInfo.Controls.Add(this.skinLabel36);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time17);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time17);
            this.tp_TimeInfo.Controls.Add(this.skinLabel37);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time16);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time16);
            this.tp_TimeInfo.Controls.Add(this.skinLabel38);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time15);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time15);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time14);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time14);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time13);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time13);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time12);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time12);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time11);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time11);
            this.tp_TimeInfo.Controls.Add(this.skinLabel18);
            this.tp_TimeInfo.Controls.Add(this.skinLabel19);
            this.tp_TimeInfo.Controls.Add(this.skinLabel20);
            this.tp_TimeInfo.Controls.Add(this.skinLabel21);
            this.tp_TimeInfo.Controls.Add(this.skinLabel22);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time10);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time10);
            this.tp_TimeInfo.Controls.Add(this.skinLabel10);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time9);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time9);
            this.tp_TimeInfo.Controls.Add(this.skinLabel11);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time8);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time8);
            this.tp_TimeInfo.Controls.Add(this.skinLabel12);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time7);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time7);
            this.tp_TimeInfo.Controls.Add(this.skinLabel9);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time6);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time6);
            this.tp_TimeInfo.Controls.Add(this.skinLabel8);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time5);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time5);
            this.tp_TimeInfo.Controls.Add(this.skinLabel13);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time4);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time4);
            this.tp_TimeInfo.Controls.Add(this.skinLabel14);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time3);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time3);
            this.tp_TimeInfo.Controls.Add(this.skinLabel15);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time2);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time2);
            this.tp_TimeInfo.Controls.Add(this.skinLabel16);
            this.tp_TimeInfo.Controls.Add(this.dtp_End_Time1);
            this.tp_TimeInfo.Controls.Add(this.dtp_Begin_Time1);
            this.tp_TimeInfo.Controls.Add(this.skinLabel17);
            this.tp_TimeInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tp_TimeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_TimeInfo.Location = new System.Drawing.Point(0, 30);
            this.tp_TimeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tp_TimeInfo.Name = "tp_TimeInfo";
            this.tp_TimeInfo.Size = new System.Drawing.Size(1024, 635);
            this.tp_TimeInfo.TabIndex = 4;
            this.tp_TimeInfo.Text = "时间段设置";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.BaseColor = System.Drawing.Color.White;
            this.btn_Save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Save.DownBack = null;
            this.btn_Save.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(916, 500);
            this.btn_Save.MouseBack = null;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NormlBack = null;
            this.btn_Save.Size = new System.Drawing.Size(105, 31);
            this.btn_Save.TabIndex = 297;
            this.btn_Save.Text = "保存并同步";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_End_Time30
            // 
            this.dtp_End_Time30.CustomFormat = "HH:mm";
            this.dtp_End_Time30.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time30.Location = new System.Drawing.Point(777, 580);
            this.dtp_End_Time30.Name = "dtp_End_Time30";
            this.dtp_End_Time30.ShowUpDown = true;
            this.dtp_End_Time30.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time30.TabIndex = 296;
            this.dtp_End_Time30.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time30
            // 
            this.dtp_Begin_Time30.CustomFormat = "HH:mm";
            this.dtp_Begin_Time30.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time30.Location = new System.Drawing.Point(577, 580);
            this.dtp_Begin_Time30.Name = "dtp_Begin_Time30";
            this.dtp_Begin_Time30.ShowUpDown = true;
            this.dtp_Begin_Time30.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time30.TabIndex = 295;
            this.dtp_Begin_Time30.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time29
            // 
            this.dtp_End_Time29.CustomFormat = "HH:mm";
            this.dtp_End_Time29.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time29.Location = new System.Drawing.Point(777, 540);
            this.dtp_End_Time29.Name = "dtp_End_Time29";
            this.dtp_End_Time29.ShowUpDown = true;
            this.dtp_End_Time29.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time29.TabIndex = 294;
            this.dtp_End_Time29.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time29
            // 
            this.dtp_Begin_Time29.CustomFormat = "HH:mm";
            this.dtp_Begin_Time29.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time29.Location = new System.Drawing.Point(577, 540);
            this.dtp_Begin_Time29.Name = "dtp_Begin_Time29";
            this.dtp_Begin_Time29.ShowUpDown = true;
            this.dtp_Begin_Time29.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time29.TabIndex = 293;
            this.dtp_Begin_Time29.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time28
            // 
            this.dtp_End_Time28.CustomFormat = "HH:mm";
            this.dtp_End_Time28.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time28.Location = new System.Drawing.Point(777, 500);
            this.dtp_End_Time28.Name = "dtp_End_Time28";
            this.dtp_End_Time28.ShowUpDown = true;
            this.dtp_End_Time28.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time28.TabIndex = 292;
            this.dtp_End_Time28.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time28
            // 
            this.dtp_Begin_Time28.CustomFormat = "HH:mm";
            this.dtp_Begin_Time28.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time28.Location = new System.Drawing.Point(577, 500);
            this.dtp_Begin_Time28.Name = "dtp_Begin_Time28";
            this.dtp_Begin_Time28.ShowUpDown = true;
            this.dtp_Begin_Time28.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time28.TabIndex = 291;
            this.dtp_Begin_Time28.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time27
            // 
            this.dtp_End_Time27.CustomFormat = "HH:mm";
            this.dtp_End_Time27.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time27.Location = new System.Drawing.Point(777, 460);
            this.dtp_End_Time27.Name = "dtp_End_Time27";
            this.dtp_End_Time27.ShowUpDown = true;
            this.dtp_End_Time27.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time27.TabIndex = 290;
            this.dtp_End_Time27.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time27
            // 
            this.dtp_Begin_Time27.CustomFormat = "HH:mm";
            this.dtp_Begin_Time27.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time27.Location = new System.Drawing.Point(577, 460);
            this.dtp_Begin_Time27.Name = "dtp_Begin_Time27";
            this.dtp_Begin_Time27.ShowUpDown = true;
            this.dtp_Begin_Time27.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time27.TabIndex = 289;
            this.dtp_Begin_Time27.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time26
            // 
            this.dtp_End_Time26.CustomFormat = "HH:mm";
            this.dtp_End_Time26.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time26.Location = new System.Drawing.Point(777, 420);
            this.dtp_End_Time26.Name = "dtp_End_Time26";
            this.dtp_End_Time26.ShowUpDown = true;
            this.dtp_End_Time26.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time26.TabIndex = 288;
            this.dtp_End_Time26.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time26
            // 
            this.dtp_Begin_Time26.CustomFormat = "HH:mm";
            this.dtp_Begin_Time26.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time26.Location = new System.Drawing.Point(577, 420);
            this.dtp_Begin_Time26.Name = "dtp_Begin_Time26";
            this.dtp_Begin_Time26.ShowUpDown = true;
            this.dtp_Begin_Time26.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time26.TabIndex = 287;
            this.dtp_Begin_Time26.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel23
            // 
            this.skinLabel23.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel23.AutoSize = true;
            this.skinLabel23.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel23.BorderColor = System.Drawing.Color.White;
            this.skinLabel23.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel23.Location = new System.Drawing.Point(497, 580);
            this.skinLabel23.Name = "skinLabel23";
            this.skinLabel23.Size = new System.Drawing.Size(69, 19);
            this.skinLabel23.TabIndex = 286;
            this.skinLabel23.Text = "时段30：";
            // 
            // skinLabel24
            // 
            this.skinLabel24.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel24.AutoSize = true;
            this.skinLabel24.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel24.BorderColor = System.Drawing.Color.White;
            this.skinLabel24.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel24.Location = new System.Drawing.Point(497, 540);
            this.skinLabel24.Name = "skinLabel24";
            this.skinLabel24.Size = new System.Drawing.Size(69, 19);
            this.skinLabel24.TabIndex = 285;
            this.skinLabel24.Text = "时段29：";
            // 
            // skinLabel25
            // 
            this.skinLabel25.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel25.AutoSize = true;
            this.skinLabel25.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel25.BorderColor = System.Drawing.Color.White;
            this.skinLabel25.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel25.Location = new System.Drawing.Point(497, 500);
            this.skinLabel25.Name = "skinLabel25";
            this.skinLabel25.Size = new System.Drawing.Size(69, 19);
            this.skinLabel25.TabIndex = 284;
            this.skinLabel25.Text = "时段28：";
            // 
            // skinLabel26
            // 
            this.skinLabel26.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel26.AutoSize = true;
            this.skinLabel26.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel26.BorderColor = System.Drawing.Color.White;
            this.skinLabel26.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel26.Location = new System.Drawing.Point(497, 460);
            this.skinLabel26.Name = "skinLabel26";
            this.skinLabel26.Size = new System.Drawing.Size(69, 19);
            this.skinLabel26.TabIndex = 283;
            this.skinLabel26.Text = "时段27：";
            // 
            // skinLabel28
            // 
            this.skinLabel28.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel28.AutoSize = true;
            this.skinLabel28.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel28.BorderColor = System.Drawing.Color.White;
            this.skinLabel28.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel28.Location = new System.Drawing.Point(497, 420);
            this.skinLabel28.Name = "skinLabel28";
            this.skinLabel28.Size = new System.Drawing.Size(69, 19);
            this.skinLabel28.TabIndex = 282;
            this.skinLabel28.Text = "时段26：";
            // 
            // dtp_End_Time25
            // 
            this.dtp_End_Time25.CustomFormat = "HH:mm";
            this.dtp_End_Time25.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time25.Location = new System.Drawing.Point(777, 380);
            this.dtp_End_Time25.Name = "dtp_End_Time25";
            this.dtp_End_Time25.ShowUpDown = true;
            this.dtp_End_Time25.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time25.TabIndex = 281;
            this.dtp_End_Time25.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time25
            // 
            this.dtp_Begin_Time25.CustomFormat = "HH:mm";
            this.dtp_Begin_Time25.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time25.Location = new System.Drawing.Point(577, 380);
            this.dtp_Begin_Time25.Name = "dtp_Begin_Time25";
            this.dtp_Begin_Time25.ShowUpDown = true;
            this.dtp_Begin_Time25.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time25.TabIndex = 280;
            this.dtp_Begin_Time25.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel29
            // 
            this.skinLabel29.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel29.AutoSize = true;
            this.skinLabel29.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel29.BorderColor = System.Drawing.Color.White;
            this.skinLabel29.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel29.Location = new System.Drawing.Point(497, 380);
            this.skinLabel29.Name = "skinLabel29";
            this.skinLabel29.Size = new System.Drawing.Size(69, 19);
            this.skinLabel29.TabIndex = 279;
            this.skinLabel29.Text = "时段25：";
            // 
            // dtp_End_Time24
            // 
            this.dtp_End_Time24.CustomFormat = "HH:mm";
            this.dtp_End_Time24.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time24.Location = new System.Drawing.Point(777, 340);
            this.dtp_End_Time24.Name = "dtp_End_Time24";
            this.dtp_End_Time24.ShowUpDown = true;
            this.dtp_End_Time24.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time24.TabIndex = 278;
            this.dtp_End_Time24.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time24
            // 
            this.dtp_Begin_Time24.CustomFormat = "HH:mm";
            this.dtp_Begin_Time24.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time24.Location = new System.Drawing.Point(577, 340);
            this.dtp_Begin_Time24.Name = "dtp_Begin_Time24";
            this.dtp_Begin_Time24.ShowUpDown = true;
            this.dtp_Begin_Time24.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time24.TabIndex = 277;
            this.dtp_Begin_Time24.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel30
            // 
            this.skinLabel30.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel30.AutoSize = true;
            this.skinLabel30.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel30.BorderColor = System.Drawing.Color.White;
            this.skinLabel30.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel30.Location = new System.Drawing.Point(497, 340);
            this.skinLabel30.Name = "skinLabel30";
            this.skinLabel30.Size = new System.Drawing.Size(69, 19);
            this.skinLabel30.TabIndex = 276;
            this.skinLabel30.Text = "时段24：";
            // 
            // dtp_End_Time23
            // 
            this.dtp_End_Time23.CustomFormat = "HH:mm";
            this.dtp_End_Time23.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time23.Location = new System.Drawing.Point(777, 300);
            this.dtp_End_Time23.Name = "dtp_End_Time23";
            this.dtp_End_Time23.ShowUpDown = true;
            this.dtp_End_Time23.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time23.TabIndex = 275;
            this.dtp_End_Time23.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time23
            // 
            this.dtp_Begin_Time23.CustomFormat = "HH:mm";
            this.dtp_Begin_Time23.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time23.Location = new System.Drawing.Point(577, 300);
            this.dtp_Begin_Time23.Name = "dtp_Begin_Time23";
            this.dtp_Begin_Time23.ShowUpDown = true;
            this.dtp_Begin_Time23.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time23.TabIndex = 274;
            this.dtp_Begin_Time23.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel31
            // 
            this.skinLabel31.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel31.AutoSize = true;
            this.skinLabel31.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel31.BorderColor = System.Drawing.Color.White;
            this.skinLabel31.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel31.Location = new System.Drawing.Point(497, 300);
            this.skinLabel31.Name = "skinLabel31";
            this.skinLabel31.Size = new System.Drawing.Size(69, 19);
            this.skinLabel31.TabIndex = 273;
            this.skinLabel31.Text = "时段23：";
            // 
            // dtp_End_Time22
            // 
            this.dtp_End_Time22.CustomFormat = "HH:mm";
            this.dtp_End_Time22.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time22.Location = new System.Drawing.Point(777, 260);
            this.dtp_End_Time22.Name = "dtp_End_Time22";
            this.dtp_End_Time22.ShowUpDown = true;
            this.dtp_End_Time22.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time22.TabIndex = 272;
            this.dtp_End_Time22.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time22
            // 
            this.dtp_Begin_Time22.CustomFormat = "HH:mm";
            this.dtp_Begin_Time22.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time22.Location = new System.Drawing.Point(577, 260);
            this.dtp_Begin_Time22.Name = "dtp_Begin_Time22";
            this.dtp_Begin_Time22.ShowUpDown = true;
            this.dtp_Begin_Time22.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time22.TabIndex = 271;
            this.dtp_Begin_Time22.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel32
            // 
            this.skinLabel32.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel32.AutoSize = true;
            this.skinLabel32.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel32.BorderColor = System.Drawing.Color.White;
            this.skinLabel32.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel32.Location = new System.Drawing.Point(497, 260);
            this.skinLabel32.Name = "skinLabel32";
            this.skinLabel32.Size = new System.Drawing.Size(69, 19);
            this.skinLabel32.TabIndex = 270;
            this.skinLabel32.Text = "时段22：";
            // 
            // dtp_End_Time21
            // 
            this.dtp_End_Time21.CustomFormat = "HH:mm";
            this.dtp_End_Time21.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time21.Location = new System.Drawing.Point(777, 220);
            this.dtp_End_Time21.Name = "dtp_End_Time21";
            this.dtp_End_Time21.ShowUpDown = true;
            this.dtp_End_Time21.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time21.TabIndex = 269;
            this.dtp_End_Time21.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time21
            // 
            this.dtp_Begin_Time21.CustomFormat = "HH:mm";
            this.dtp_Begin_Time21.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time21.Location = new System.Drawing.Point(577, 220);
            this.dtp_Begin_Time21.Name = "dtp_Begin_Time21";
            this.dtp_Begin_Time21.ShowUpDown = true;
            this.dtp_Begin_Time21.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time21.TabIndex = 268;
            this.dtp_Begin_Time21.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel33
            // 
            this.skinLabel33.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel33.AutoSize = true;
            this.skinLabel33.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel33.BorderColor = System.Drawing.Color.White;
            this.skinLabel33.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel33.Location = new System.Drawing.Point(497, 220);
            this.skinLabel33.Name = "skinLabel33";
            this.skinLabel33.Size = new System.Drawing.Size(69, 19);
            this.skinLabel33.TabIndex = 267;
            this.skinLabel33.Text = "时段21：";
            // 
            // dtp_End_Time20
            // 
            this.dtp_End_Time20.CustomFormat = "HH:mm";
            this.dtp_End_Time20.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time20.Location = new System.Drawing.Point(777, 180);
            this.dtp_End_Time20.Name = "dtp_End_Time20";
            this.dtp_End_Time20.ShowUpDown = true;
            this.dtp_End_Time20.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time20.TabIndex = 266;
            this.dtp_End_Time20.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time20
            // 
            this.dtp_Begin_Time20.CustomFormat = "HH:mm";
            this.dtp_Begin_Time20.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time20.Location = new System.Drawing.Point(577, 180);
            this.dtp_Begin_Time20.Name = "dtp_Begin_Time20";
            this.dtp_Begin_Time20.ShowUpDown = true;
            this.dtp_Begin_Time20.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time20.TabIndex = 265;
            this.dtp_Begin_Time20.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel34
            // 
            this.skinLabel34.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel34.AutoSize = true;
            this.skinLabel34.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel34.BorderColor = System.Drawing.Color.White;
            this.skinLabel34.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel34.Location = new System.Drawing.Point(497, 180);
            this.skinLabel34.Name = "skinLabel34";
            this.skinLabel34.Size = new System.Drawing.Size(69, 19);
            this.skinLabel34.TabIndex = 264;
            this.skinLabel34.Text = "时段20：";
            // 
            // dtp_End_Time19
            // 
            this.dtp_End_Time19.CustomFormat = "HH:mm";
            this.dtp_End_Time19.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time19.Location = new System.Drawing.Point(777, 140);
            this.dtp_End_Time19.Name = "dtp_End_Time19";
            this.dtp_End_Time19.ShowUpDown = true;
            this.dtp_End_Time19.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time19.TabIndex = 263;
            this.dtp_End_Time19.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time19
            // 
            this.dtp_Begin_Time19.CustomFormat = "HH:mm";
            this.dtp_Begin_Time19.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time19.Location = new System.Drawing.Point(577, 140);
            this.dtp_Begin_Time19.Name = "dtp_Begin_Time19";
            this.dtp_Begin_Time19.ShowUpDown = true;
            this.dtp_Begin_Time19.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time19.TabIndex = 262;
            this.dtp_Begin_Time19.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel35
            // 
            this.skinLabel35.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel35.AutoSize = true;
            this.skinLabel35.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel35.BorderColor = System.Drawing.Color.White;
            this.skinLabel35.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel35.Location = new System.Drawing.Point(497, 140);
            this.skinLabel35.Name = "skinLabel35";
            this.skinLabel35.Size = new System.Drawing.Size(69, 19);
            this.skinLabel35.TabIndex = 261;
            this.skinLabel35.Text = "时段19：";
            // 
            // dtp_End_Time18
            // 
            this.dtp_End_Time18.CustomFormat = "HH:mm";
            this.dtp_End_Time18.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time18.Location = new System.Drawing.Point(777, 100);
            this.dtp_End_Time18.Name = "dtp_End_Time18";
            this.dtp_End_Time18.ShowUpDown = true;
            this.dtp_End_Time18.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time18.TabIndex = 260;
            this.dtp_End_Time18.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time18
            // 
            this.dtp_Begin_Time18.CustomFormat = "HH:mm";
            this.dtp_Begin_Time18.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time18.Location = new System.Drawing.Point(577, 100);
            this.dtp_Begin_Time18.Name = "dtp_Begin_Time18";
            this.dtp_Begin_Time18.ShowUpDown = true;
            this.dtp_Begin_Time18.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time18.TabIndex = 259;
            this.dtp_Begin_Time18.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel36
            // 
            this.skinLabel36.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel36.AutoSize = true;
            this.skinLabel36.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel36.BorderColor = System.Drawing.Color.White;
            this.skinLabel36.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel36.Location = new System.Drawing.Point(497, 100);
            this.skinLabel36.Name = "skinLabel36";
            this.skinLabel36.Size = new System.Drawing.Size(69, 19);
            this.skinLabel36.TabIndex = 258;
            this.skinLabel36.Text = "时段18：";
            // 
            // dtp_End_Time17
            // 
            this.dtp_End_Time17.CustomFormat = "HH:mm";
            this.dtp_End_Time17.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time17.Location = new System.Drawing.Point(777, 60);
            this.dtp_End_Time17.Name = "dtp_End_Time17";
            this.dtp_End_Time17.ShowUpDown = true;
            this.dtp_End_Time17.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time17.TabIndex = 257;
            this.dtp_End_Time17.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time17
            // 
            this.dtp_Begin_Time17.CustomFormat = "HH:mm";
            this.dtp_Begin_Time17.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time17.Location = new System.Drawing.Point(577, 60);
            this.dtp_Begin_Time17.Name = "dtp_Begin_Time17";
            this.dtp_Begin_Time17.ShowUpDown = true;
            this.dtp_Begin_Time17.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time17.TabIndex = 256;
            this.dtp_Begin_Time17.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel37
            // 
            this.skinLabel37.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel37.AutoSize = true;
            this.skinLabel37.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel37.BorderColor = System.Drawing.Color.White;
            this.skinLabel37.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel37.Location = new System.Drawing.Point(497, 60);
            this.skinLabel37.Name = "skinLabel37";
            this.skinLabel37.Size = new System.Drawing.Size(69, 19);
            this.skinLabel37.TabIndex = 255;
            this.skinLabel37.Text = "时段17：";
            // 
            // dtp_End_Time16
            // 
            this.dtp_End_Time16.CustomFormat = "HH:mm";
            this.dtp_End_Time16.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time16.Location = new System.Drawing.Point(777, 20);
            this.dtp_End_Time16.Name = "dtp_End_Time16";
            this.dtp_End_Time16.ShowUpDown = true;
            this.dtp_End_Time16.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time16.TabIndex = 254;
            this.dtp_End_Time16.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time16
            // 
            this.dtp_Begin_Time16.CustomFormat = "HH:mm";
            this.dtp_Begin_Time16.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time16.Location = new System.Drawing.Point(577, 20);
            this.dtp_Begin_Time16.Name = "dtp_Begin_Time16";
            this.dtp_Begin_Time16.ShowUpDown = true;
            this.dtp_Begin_Time16.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time16.TabIndex = 253;
            this.dtp_Begin_Time16.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel38
            // 
            this.skinLabel38.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel38.AutoSize = true;
            this.skinLabel38.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel38.BorderColor = System.Drawing.Color.White;
            this.skinLabel38.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel38.Location = new System.Drawing.Point(497, 20);
            this.skinLabel38.Name = "skinLabel38";
            this.skinLabel38.Size = new System.Drawing.Size(69, 19);
            this.skinLabel38.TabIndex = 252;
            this.skinLabel38.Text = "时段16：";
            // 
            // dtp_End_Time15
            // 
            this.dtp_End_Time15.CustomFormat = "HH:mm";
            this.dtp_End_Time15.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time15.Location = new System.Drawing.Point(300, 580);
            this.dtp_End_Time15.Name = "dtp_End_Time15";
            this.dtp_End_Time15.ShowUpDown = true;
            this.dtp_End_Time15.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time15.TabIndex = 251;
            this.dtp_End_Time15.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time15
            // 
            this.dtp_Begin_Time15.CustomFormat = "HH:mm";
            this.dtp_Begin_Time15.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time15.Location = new System.Drawing.Point(100, 580);
            this.dtp_Begin_Time15.Name = "dtp_Begin_Time15";
            this.dtp_Begin_Time15.ShowUpDown = true;
            this.dtp_Begin_Time15.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time15.TabIndex = 250;
            this.dtp_Begin_Time15.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time14
            // 
            this.dtp_End_Time14.CustomFormat = "HH:mm";
            this.dtp_End_Time14.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time14.Location = new System.Drawing.Point(300, 540);
            this.dtp_End_Time14.Name = "dtp_End_Time14";
            this.dtp_End_Time14.ShowUpDown = true;
            this.dtp_End_Time14.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time14.TabIndex = 249;
            this.dtp_End_Time14.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time14
            // 
            this.dtp_Begin_Time14.CustomFormat = "HH:mm";
            this.dtp_Begin_Time14.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time14.Location = new System.Drawing.Point(100, 540);
            this.dtp_Begin_Time14.Name = "dtp_Begin_Time14";
            this.dtp_Begin_Time14.ShowUpDown = true;
            this.dtp_Begin_Time14.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time14.TabIndex = 248;
            this.dtp_Begin_Time14.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time13
            // 
            this.dtp_End_Time13.CustomFormat = "HH:mm";
            this.dtp_End_Time13.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time13.Location = new System.Drawing.Point(300, 500);
            this.dtp_End_Time13.Name = "dtp_End_Time13";
            this.dtp_End_Time13.ShowUpDown = true;
            this.dtp_End_Time13.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time13.TabIndex = 247;
            this.dtp_End_Time13.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time13
            // 
            this.dtp_Begin_Time13.CustomFormat = "HH:mm";
            this.dtp_Begin_Time13.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time13.Location = new System.Drawing.Point(100, 500);
            this.dtp_Begin_Time13.Name = "dtp_Begin_Time13";
            this.dtp_Begin_Time13.ShowUpDown = true;
            this.dtp_Begin_Time13.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time13.TabIndex = 246;
            this.dtp_Begin_Time13.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time12
            // 
            this.dtp_End_Time12.CustomFormat = "HH:mm";
            this.dtp_End_Time12.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time12.Location = new System.Drawing.Point(300, 460);
            this.dtp_End_Time12.Name = "dtp_End_Time12";
            this.dtp_End_Time12.ShowUpDown = true;
            this.dtp_End_Time12.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time12.TabIndex = 245;
            this.dtp_End_Time12.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time12
            // 
            this.dtp_Begin_Time12.CustomFormat = "HH:mm";
            this.dtp_Begin_Time12.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time12.Location = new System.Drawing.Point(100, 460);
            this.dtp_Begin_Time12.Name = "dtp_Begin_Time12";
            this.dtp_Begin_Time12.ShowUpDown = true;
            this.dtp_Begin_Time12.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time12.TabIndex = 244;
            this.dtp_Begin_Time12.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_End_Time11
            // 
            this.dtp_End_Time11.CustomFormat = "HH:mm";
            this.dtp_End_Time11.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time11.Location = new System.Drawing.Point(300, 420);
            this.dtp_End_Time11.Name = "dtp_End_Time11";
            this.dtp_End_Time11.ShowUpDown = true;
            this.dtp_End_Time11.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time11.TabIndex = 243;
            this.dtp_End_Time11.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time11
            // 
            this.dtp_Begin_Time11.CustomFormat = "HH:mm";
            this.dtp_Begin_Time11.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time11.Location = new System.Drawing.Point(100, 420);
            this.dtp_Begin_Time11.Name = "dtp_Begin_Time11";
            this.dtp_Begin_Time11.ShowUpDown = true;
            this.dtp_Begin_Time11.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time11.TabIndex = 242;
            this.dtp_Begin_Time11.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel18
            // 
            this.skinLabel18.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel18.AutoSize = true;
            this.skinLabel18.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel18.BorderColor = System.Drawing.Color.White;
            this.skinLabel18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel18.Location = new System.Drawing.Point(20, 580);
            this.skinLabel18.Name = "skinLabel18";
            this.skinLabel18.Size = new System.Drawing.Size(69, 19);
            this.skinLabel18.TabIndex = 241;
            this.skinLabel18.Text = "时段15：";
            // 
            // skinLabel19
            // 
            this.skinLabel19.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel19.AutoSize = true;
            this.skinLabel19.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel19.BorderColor = System.Drawing.Color.White;
            this.skinLabel19.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel19.Location = new System.Drawing.Point(20, 540);
            this.skinLabel19.Name = "skinLabel19";
            this.skinLabel19.Size = new System.Drawing.Size(69, 19);
            this.skinLabel19.TabIndex = 240;
            this.skinLabel19.Text = "时段14：";
            // 
            // skinLabel20
            // 
            this.skinLabel20.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel20.AutoSize = true;
            this.skinLabel20.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel20.BorderColor = System.Drawing.Color.White;
            this.skinLabel20.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel20.Location = new System.Drawing.Point(20, 500);
            this.skinLabel20.Name = "skinLabel20";
            this.skinLabel20.Size = new System.Drawing.Size(69, 19);
            this.skinLabel20.TabIndex = 239;
            this.skinLabel20.Text = "时段13：";
            // 
            // skinLabel21
            // 
            this.skinLabel21.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel21.AutoSize = true;
            this.skinLabel21.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel21.BorderColor = System.Drawing.Color.White;
            this.skinLabel21.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel21.Location = new System.Drawing.Point(20, 460);
            this.skinLabel21.Name = "skinLabel21";
            this.skinLabel21.Size = new System.Drawing.Size(69, 19);
            this.skinLabel21.TabIndex = 238;
            this.skinLabel21.Text = "时段12：";
            // 
            // skinLabel22
            // 
            this.skinLabel22.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel22.AutoSize = true;
            this.skinLabel22.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel22.BorderColor = System.Drawing.Color.White;
            this.skinLabel22.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel22.Location = new System.Drawing.Point(20, 420);
            this.skinLabel22.Name = "skinLabel22";
            this.skinLabel22.Size = new System.Drawing.Size(69, 19);
            this.skinLabel22.TabIndex = 237;
            this.skinLabel22.Text = "时段11：";
            // 
            // dtp_End_Time10
            // 
            this.dtp_End_Time10.CustomFormat = "HH:mm";
            this.dtp_End_Time10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time10.Location = new System.Drawing.Point(300, 380);
            this.dtp_End_Time10.Name = "dtp_End_Time10";
            this.dtp_End_Time10.ShowUpDown = true;
            this.dtp_End_Time10.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time10.TabIndex = 236;
            this.dtp_End_Time10.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time10
            // 
            this.dtp_Begin_Time10.CustomFormat = "HH:mm";
            this.dtp_Begin_Time10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time10.Location = new System.Drawing.Point(100, 380);
            this.dtp_Begin_Time10.Name = "dtp_Begin_Time10";
            this.dtp_Begin_Time10.ShowUpDown = true;
            this.dtp_Begin_Time10.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time10.TabIndex = 235;
            this.dtp_Begin_Time10.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel10
            // 
            this.skinLabel10.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel10.BorderColor = System.Drawing.Color.White;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel10.Location = new System.Drawing.Point(20, 380);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(69, 19);
            this.skinLabel10.TabIndex = 234;
            this.skinLabel10.Text = "时段10：";
            // 
            // dtp_End_Time9
            // 
            this.dtp_End_Time9.CustomFormat = "HH:mm";
            this.dtp_End_Time9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time9.Location = new System.Drawing.Point(300, 340);
            this.dtp_End_Time9.Name = "dtp_End_Time9";
            this.dtp_End_Time9.ShowUpDown = true;
            this.dtp_End_Time9.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time9.TabIndex = 233;
            this.dtp_End_Time9.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time9
            // 
            this.dtp_Begin_Time9.CustomFormat = "HH:mm";
            this.dtp_Begin_Time9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time9.Location = new System.Drawing.Point(100, 340);
            this.dtp_Begin_Time9.Name = "dtp_Begin_Time9";
            this.dtp_Begin_Time9.ShowUpDown = true;
            this.dtp_Begin_Time9.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time9.TabIndex = 232;
            this.dtp_Begin_Time9.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel11
            // 
            this.skinLabel11.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel11.Location = new System.Drawing.Point(20, 340);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(69, 19);
            this.skinLabel11.TabIndex = 231;
            this.skinLabel11.Text = "时段09：";
            // 
            // dtp_End_Time8
            // 
            this.dtp_End_Time8.CustomFormat = "HH:mm";
            this.dtp_End_Time8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time8.Location = new System.Drawing.Point(300, 300);
            this.dtp_End_Time8.Name = "dtp_End_Time8";
            this.dtp_End_Time8.ShowUpDown = true;
            this.dtp_End_Time8.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time8.TabIndex = 230;
            this.dtp_End_Time8.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time8
            // 
            this.dtp_Begin_Time8.CustomFormat = "HH:mm";
            this.dtp_Begin_Time8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time8.Location = new System.Drawing.Point(100, 300);
            this.dtp_Begin_Time8.Name = "dtp_Begin_Time8";
            this.dtp_Begin_Time8.ShowUpDown = true;
            this.dtp_Begin_Time8.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time8.TabIndex = 229;
            this.dtp_Begin_Time8.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel12
            // 
            this.skinLabel12.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel12.BorderColor = System.Drawing.Color.White;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel12.Location = new System.Drawing.Point(20, 300);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(69, 19);
            this.skinLabel12.TabIndex = 228;
            this.skinLabel12.Text = "时段08：";
            // 
            // dtp_End_Time7
            // 
            this.dtp_End_Time7.CustomFormat = "HH:mm";
            this.dtp_End_Time7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time7.Location = new System.Drawing.Point(300, 260);
            this.dtp_End_Time7.Name = "dtp_End_Time7";
            this.dtp_End_Time7.ShowUpDown = true;
            this.dtp_End_Time7.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time7.TabIndex = 227;
            this.dtp_End_Time7.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time7
            // 
            this.dtp_Begin_Time7.CustomFormat = "HH:mm";
            this.dtp_Begin_Time7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time7.Location = new System.Drawing.Point(100, 260);
            this.dtp_Begin_Time7.Name = "dtp_Begin_Time7";
            this.dtp_Begin_Time7.ShowUpDown = true;
            this.dtp_Begin_Time7.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time7.TabIndex = 226;
            this.dtp_Begin_Time7.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel9.Location = new System.Drawing.Point(20, 260);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(69, 19);
            this.skinLabel9.TabIndex = 225;
            this.skinLabel9.Text = "时段07：";
            // 
            // dtp_End_Time6
            // 
            this.dtp_End_Time6.CustomFormat = "HH:mm";
            this.dtp_End_Time6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time6.Location = new System.Drawing.Point(300, 220);
            this.dtp_End_Time6.Name = "dtp_End_Time6";
            this.dtp_End_Time6.ShowUpDown = true;
            this.dtp_End_Time6.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time6.TabIndex = 224;
            this.dtp_End_Time6.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time6
            // 
            this.dtp_Begin_Time6.CustomFormat = "HH:mm";
            this.dtp_Begin_Time6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time6.Location = new System.Drawing.Point(100, 220);
            this.dtp_Begin_Time6.Name = "dtp_Begin_Time6";
            this.dtp_Begin_Time6.ShowUpDown = true;
            this.dtp_Begin_Time6.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time6.TabIndex = 223;
            this.dtp_Begin_Time6.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.White;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel8.Location = new System.Drawing.Point(20, 220);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(69, 19);
            this.skinLabel8.TabIndex = 222;
            this.skinLabel8.Text = "时段06：";
            // 
            // dtp_End_Time5
            // 
            this.dtp_End_Time5.CustomFormat = "HH:mm";
            this.dtp_End_Time5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time5.Location = new System.Drawing.Point(300, 180);
            this.dtp_End_Time5.Name = "dtp_End_Time5";
            this.dtp_End_Time5.ShowUpDown = true;
            this.dtp_End_Time5.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time5.TabIndex = 221;
            this.dtp_End_Time5.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time5
            // 
            this.dtp_Begin_Time5.CustomFormat = "HH:mm";
            this.dtp_Begin_Time5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time5.Location = new System.Drawing.Point(100, 180);
            this.dtp_Begin_Time5.Name = "dtp_Begin_Time5";
            this.dtp_Begin_Time5.ShowUpDown = true;
            this.dtp_Begin_Time5.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time5.TabIndex = 220;
            this.dtp_Begin_Time5.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel13
            // 
            this.skinLabel13.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel13.AutoSize = true;
            this.skinLabel13.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel13.BorderColor = System.Drawing.Color.White;
            this.skinLabel13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel13.Location = new System.Drawing.Point(20, 180);
            this.skinLabel13.Name = "skinLabel13";
            this.skinLabel13.Size = new System.Drawing.Size(69, 19);
            this.skinLabel13.TabIndex = 219;
            this.skinLabel13.Text = "时段05：";
            // 
            // dtp_End_Time4
            // 
            this.dtp_End_Time4.CustomFormat = "HH:mm";
            this.dtp_End_Time4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time4.Location = new System.Drawing.Point(300, 140);
            this.dtp_End_Time4.Name = "dtp_End_Time4";
            this.dtp_End_Time4.ShowUpDown = true;
            this.dtp_End_Time4.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time4.TabIndex = 218;
            this.dtp_End_Time4.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time4
            // 
            this.dtp_Begin_Time4.CustomFormat = "HH:mm";
            this.dtp_Begin_Time4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time4.Location = new System.Drawing.Point(100, 140);
            this.dtp_Begin_Time4.Name = "dtp_Begin_Time4";
            this.dtp_Begin_Time4.ShowUpDown = true;
            this.dtp_Begin_Time4.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time4.TabIndex = 217;
            this.dtp_Begin_Time4.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel14
            // 
            this.skinLabel14.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel14.AutoSize = true;
            this.skinLabel14.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel14.BorderColor = System.Drawing.Color.White;
            this.skinLabel14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel14.Location = new System.Drawing.Point(20, 140);
            this.skinLabel14.Name = "skinLabel14";
            this.skinLabel14.Size = new System.Drawing.Size(69, 19);
            this.skinLabel14.TabIndex = 216;
            this.skinLabel14.Text = "时段04：";
            // 
            // dtp_End_Time3
            // 
            this.dtp_End_Time3.CustomFormat = "HH:mm";
            this.dtp_End_Time3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time3.Location = new System.Drawing.Point(300, 100);
            this.dtp_End_Time3.Name = "dtp_End_Time3";
            this.dtp_End_Time3.ShowUpDown = true;
            this.dtp_End_Time3.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time3.TabIndex = 215;
            this.dtp_End_Time3.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time3
            // 
            this.dtp_Begin_Time3.CustomFormat = "HH:mm";
            this.dtp_Begin_Time3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time3.Location = new System.Drawing.Point(100, 100);
            this.dtp_Begin_Time3.Name = "dtp_Begin_Time3";
            this.dtp_Begin_Time3.ShowUpDown = true;
            this.dtp_Begin_Time3.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time3.TabIndex = 214;
            this.dtp_Begin_Time3.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel15
            // 
            this.skinLabel15.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel15.AutoSize = true;
            this.skinLabel15.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel15.BorderColor = System.Drawing.Color.White;
            this.skinLabel15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel15.Location = new System.Drawing.Point(20, 100);
            this.skinLabel15.Name = "skinLabel15";
            this.skinLabel15.Size = new System.Drawing.Size(69, 19);
            this.skinLabel15.TabIndex = 213;
            this.skinLabel15.Text = "时段03：";
            // 
            // dtp_End_Time2
            // 
            this.dtp_End_Time2.CustomFormat = "HH:mm";
            this.dtp_End_Time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time2.Location = new System.Drawing.Point(300, 60);
            this.dtp_End_Time2.Name = "dtp_End_Time2";
            this.dtp_End_Time2.ShowUpDown = true;
            this.dtp_End_Time2.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time2.TabIndex = 212;
            this.dtp_End_Time2.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time2
            // 
            this.dtp_Begin_Time2.CustomFormat = "HH:mm";
            this.dtp_Begin_Time2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time2.Location = new System.Drawing.Point(100, 60);
            this.dtp_Begin_Time2.Name = "dtp_Begin_Time2";
            this.dtp_Begin_Time2.ShowUpDown = true;
            this.dtp_Begin_Time2.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time2.TabIndex = 211;
            this.dtp_Begin_Time2.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel16
            // 
            this.skinLabel16.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel16.AutoSize = true;
            this.skinLabel16.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel16.BorderColor = System.Drawing.Color.White;
            this.skinLabel16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel16.Location = new System.Drawing.Point(20, 60);
            this.skinLabel16.Name = "skinLabel16";
            this.skinLabel16.Size = new System.Drawing.Size(69, 19);
            this.skinLabel16.TabIndex = 210;
            this.skinLabel16.Text = "时段01：";
            // 
            // dtp_End_Time1
            // 
            this.dtp_End_Time1.CustomFormat = "HH:mm";
            this.dtp_End_Time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End_Time1.Location = new System.Drawing.Point(300, 20);
            this.dtp_End_Time1.Name = "dtp_End_Time1";
            this.dtp_End_Time1.ShowUpDown = true;
            this.dtp_End_Time1.Size = new System.Drawing.Size(120, 23);
            this.dtp_End_Time1.TabIndex = 209;
            this.dtp_End_Time1.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // dtp_Begin_Time1
            // 
            this.dtp_Begin_Time1.CustomFormat = "HH:mm";
            this.dtp_Begin_Time1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Begin_Time1.Location = new System.Drawing.Point(100, 20);
            this.dtp_Begin_Time1.Name = "dtp_Begin_Time1";
            this.dtp_Begin_Time1.ShowUpDown = true;
            this.dtp_Begin_Time1.Size = new System.Drawing.Size(120, 23);
            this.dtp_Begin_Time1.TabIndex = 208;
            this.dtp_Begin_Time1.Value = new System.DateTime(2016, 4, 8, 0, 0, 0, 0);
            // 
            // skinLabel17
            // 
            this.skinLabel17.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel17.AutoSize = true;
            this.skinLabel17.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel17.BorderColor = System.Drawing.Color.White;
            this.skinLabel17.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel17.Location = new System.Drawing.Point(20, 20);
            this.skinLabel17.Name = "skinLabel17";
            this.skinLabel17.Size = new System.Drawing.Size(69, 19);
            this.skinLabel17.TabIndex = 207;
            this.skinLabel17.Text = "时段00：";
            // 
            // tb_TimeRange
            // 
            this.tb_TimeRange.BackColor = System.Drawing.Color.White;
            this.tb_TimeRange.Controls.Add(this.skinTabControl6);
            this.tb_TimeRange.Controls.Add(this.btn_Save1);
            this.tb_TimeRange.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tb_TimeRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tb_TimeRange.Location = new System.Drawing.Point(0, 30);
            this.tb_TimeRange.Name = "tb_TimeRange";
            this.tb_TimeRange.Size = new System.Drawing.Size(200, 0);
            this.tb_TimeRange.TabIndex = 5;
            this.tb_TimeRange.Text = "时区设置";
            // 
            // skinTabControl6
            // 
            animation5.AnimateOnlyDifferences = false;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 2F;
            animation5.TransparencyCoeff = 0F;
            this.skinTabControl6.Animation = animation5;
            this.skinTabControl6.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.skinTabControl6.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl6.Controls.Add(this.timezone1);
            this.skinTabControl6.Controls.Add(this.timezone2);
            this.skinTabControl6.Controls.Add(this.timezone3);
            this.skinTabControl6.Controls.Add(this.timezone4);
            this.skinTabControl6.Controls.Add(this.timezone5);
            this.skinTabControl6.Controls.Add(this.timezone6);
            this.skinTabControl6.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl6.Location = new System.Drawing.Point(3, 3);
            this.skinTabControl6.Name = "skinTabControl6";
            this.skinTabControl6.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl6.PageArrowDown")));
            this.skinTabControl6.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl6.PageArrowHover")));
            this.skinTabControl6.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl6.PageCloseHover")));
            this.skinTabControl6.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl6.PageCloseNormal")));
            this.skinTabControl6.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl6.PageDown")));
            this.skinTabControl6.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl6.PageHover")));
            this.skinTabControl6.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl6.PageNorml = null;
            this.skinTabControl6.SelectedIndex = 0;
            this.skinTabControl6.Size = new System.Drawing.Size(1018, 579);
            this.skinTabControl6.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl6.TabIndex = 0;
            // 
            // timezone1
            // 
            this.timezone1.BackColor = System.Drawing.Color.White;
            this.timezone1.Controls.Add(this.skinLabel42);
            this.timezone1.Controls.Add(this.skinLabel39);
            this.timezone1.Controls.Add(this.skinLabel40);
            this.timezone1.Controls.Add(this.skinLabel41);
            this.timezone1.Controls.Add(this.cb_TimeZone30);
            this.timezone1.Controls.Add(this.cb_TimeZone29);
            this.timezone1.Controls.Add(this.cb_TimeZone28);
            this.timezone1.Controls.Add(this.cb_TimeZone27);
            this.timezone1.Controls.Add(this.cb_TimeZone26);
            this.timezone1.Controls.Add(this.cb_TimeZone25);
            this.timezone1.Controls.Add(this.cb_TimeZone24);
            this.timezone1.Controls.Add(this.cb_TimeZone23);
            this.timezone1.Controls.Add(this.cb_TimeZone22);
            this.timezone1.Controls.Add(this.cb_TimeZone21);
            this.timezone1.Controls.Add(this.cb_TimeZone20);
            this.timezone1.Controls.Add(this.cb_TimeZone19);
            this.timezone1.Controls.Add(this.cb_TimeZone18);
            this.timezone1.Controls.Add(this.cb_TimeZone17);
            this.timezone1.Controls.Add(this.cb_TimeZone16);
            this.timezone1.Controls.Add(this.cb_TimeZone15);
            this.timezone1.Controls.Add(this.cb_TimeZone14);
            this.timezone1.Controls.Add(this.cb_TimeZone13);
            this.timezone1.Controls.Add(this.cb_TimeZone12);
            this.timezone1.Controls.Add(this.cb_TimeZone11);
            this.timezone1.Controls.Add(this.cb_TimeZone10);
            this.timezone1.Controls.Add(this.cb_TimeZone9);
            this.timezone1.Controls.Add(this.cb_TimeZone8);
            this.timezone1.Controls.Add(this.cb_TimeZone7);
            this.timezone1.Controls.Add(this.cb_TimeZone6);
            this.timezone1.Controls.Add(this.cb_TimeZone5);
            this.timezone1.Controls.Add(this.cb_TimeZone4);
            this.timezone1.Controls.Add(this.cb_TimeZone3);
            this.timezone1.Controls.Add(this.cb_TimeZone2);
            this.timezone1.Controls.Add(this.cb_TimeZone1);
            this.timezone1.Controls.Add(this.skinLabel44);
            this.timezone1.Controls.Add(this.skinLabel45);
            this.timezone1.Controls.Add(this.skinLabel46);
            this.timezone1.Controls.Add(this.skinLabel47);
            this.timezone1.Controls.Add(this.skinLabel48);
            this.timezone1.Controls.Add(this.skinLabel49);
            this.timezone1.Controls.Add(this.skinLabel50);
            this.timezone1.Controls.Add(this.skinLabel51);
            this.timezone1.Controls.Add(this.skinLabel52);
            this.timezone1.Controls.Add(this.skinLabel53);
            this.timezone1.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timezone1.Location = new System.Drawing.Point(0, 36);
            this.timezone1.Name = "timezone1";
            this.timezone1.Padding = new System.Windows.Forms.Padding(3);
            this.timezone1.Size = new System.Drawing.Size(1018, 543);
            this.timezone1.TabIndex = 0;
            this.timezone1.Text = "【01,10】";
            // 
            // skinLabel42
            // 
            this.skinLabel42.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel42.AutoSize = true;
            this.skinLabel42.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel42.BorderColor = System.Drawing.Color.White;
            this.skinLabel42.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel42.ForeColor = System.Drawing.Color.Red;
            this.skinLabel42.Location = new System.Drawing.Point(60, 20);
            this.skinLabel42.Name = "skinLabel42";
            this.skinLabel42.Size = new System.Drawing.Size(68, 16);
            this.skinLabel42.TabIndex = 352;
            this.skinLabel42.Text = "时区序号";
            // 
            // skinLabel39
            // 
            this.skinLabel39.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel39.AutoSize = true;
            this.skinLabel39.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel39.BorderColor = System.Drawing.Color.White;
            this.skinLabel39.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel39.ForeColor = System.Drawing.Color.Red;
            this.skinLabel39.Location = new System.Drawing.Point(812, 20);
            this.skinLabel39.Name = "skinLabel39";
            this.skinLabel39.Size = new System.Drawing.Size(68, 16);
            this.skinLabel39.TabIndex = 351;
            this.skinLabel39.Text = "时间段三";
            // 
            // skinLabel40
            // 
            this.skinLabel40.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel40.AutoSize = true;
            this.skinLabel40.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel40.BorderColor = System.Drawing.Color.White;
            this.skinLabel40.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel40.ForeColor = System.Drawing.Color.Red;
            this.skinLabel40.Location = new System.Drawing.Point(515, 20);
            this.skinLabel40.Name = "skinLabel40";
            this.skinLabel40.Size = new System.Drawing.Size(68, 16);
            this.skinLabel40.TabIndex = 350;
            this.skinLabel40.Text = "时间段二";
            // 
            // skinLabel41
            // 
            this.skinLabel41.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel41.AutoSize = true;
            this.skinLabel41.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel41.BorderColor = System.Drawing.Color.White;
            this.skinLabel41.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel41.ForeColor = System.Drawing.Color.Red;
            this.skinLabel41.Location = new System.Drawing.Point(250, 20);
            this.skinLabel41.Name = "skinLabel41";
            this.skinLabel41.Size = new System.Drawing.Size(68, 16);
            this.skinLabel41.TabIndex = 349;
            this.skinLabel41.Text = "时间段一";
            // 
            // cb_TimeZone30
            // 
            this.cb_TimeZone30.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone30.FormattingEnabled = true;
            this.cb_TimeZone30.Location = new System.Drawing.Point(770, 505);
            this.cb_TimeZone30.Name = "cb_TimeZone30";
            this.cb_TimeZone30.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone30.TabIndex = 348;
            // 
            // cb_TimeZone29
            // 
            this.cb_TimeZone29.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone29.FormattingEnabled = true;
            this.cb_TimeZone29.Location = new System.Drawing.Point(770, 455);
            this.cb_TimeZone29.Name = "cb_TimeZone29";
            this.cb_TimeZone29.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone29.TabIndex = 347;
            // 
            // cb_TimeZone28
            // 
            this.cb_TimeZone28.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone28.FormattingEnabled = true;
            this.cb_TimeZone28.Location = new System.Drawing.Point(770, 405);
            this.cb_TimeZone28.Name = "cb_TimeZone28";
            this.cb_TimeZone28.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone28.TabIndex = 346;
            // 
            // cb_TimeZone27
            // 
            this.cb_TimeZone27.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone27.FormattingEnabled = true;
            this.cb_TimeZone27.Location = new System.Drawing.Point(770, 355);
            this.cb_TimeZone27.Name = "cb_TimeZone27";
            this.cb_TimeZone27.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone27.TabIndex = 345;
            // 
            // cb_TimeZone26
            // 
            this.cb_TimeZone26.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone26.FormattingEnabled = true;
            this.cb_TimeZone26.Location = new System.Drawing.Point(770, 305);
            this.cb_TimeZone26.Name = "cb_TimeZone26";
            this.cb_TimeZone26.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone26.TabIndex = 344;
            // 
            // cb_TimeZone25
            // 
            this.cb_TimeZone25.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone25.FormattingEnabled = true;
            this.cb_TimeZone25.Location = new System.Drawing.Point(770, 255);
            this.cb_TimeZone25.Name = "cb_TimeZone25";
            this.cb_TimeZone25.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone25.TabIndex = 343;
            // 
            // cb_TimeZone24
            // 
            this.cb_TimeZone24.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone24.FormattingEnabled = true;
            this.cb_TimeZone24.Location = new System.Drawing.Point(770, 205);
            this.cb_TimeZone24.Name = "cb_TimeZone24";
            this.cb_TimeZone24.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone24.TabIndex = 342;
            // 
            // cb_TimeZone23
            // 
            this.cb_TimeZone23.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone23.FormattingEnabled = true;
            this.cb_TimeZone23.Location = new System.Drawing.Point(770, 155);
            this.cb_TimeZone23.Name = "cb_TimeZone23";
            this.cb_TimeZone23.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone23.TabIndex = 341;
            // 
            // cb_TimeZone22
            // 
            this.cb_TimeZone22.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone22.FormattingEnabled = true;
            this.cb_TimeZone22.Location = new System.Drawing.Point(770, 105);
            this.cb_TimeZone22.Name = "cb_TimeZone22";
            this.cb_TimeZone22.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone22.TabIndex = 340;
            // 
            // cb_TimeZone21
            // 
            this.cb_TimeZone21.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone21.FormattingEnabled = true;
            this.cb_TimeZone21.Location = new System.Drawing.Point(770, 55);
            this.cb_TimeZone21.Name = "cb_TimeZone21";
            this.cb_TimeZone21.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone21.TabIndex = 339;
            // 
            // cb_TimeZone20
            // 
            this.cb_TimeZone20.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone20.FormattingEnabled = true;
            this.cb_TimeZone20.Location = new System.Drawing.Point(480, 505);
            this.cb_TimeZone20.Name = "cb_TimeZone20";
            this.cb_TimeZone20.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone20.TabIndex = 338;
            // 
            // cb_TimeZone19
            // 
            this.cb_TimeZone19.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone19.FormattingEnabled = true;
            this.cb_TimeZone19.Location = new System.Drawing.Point(480, 455);
            this.cb_TimeZone19.Name = "cb_TimeZone19";
            this.cb_TimeZone19.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone19.TabIndex = 337;
            // 
            // cb_TimeZone18
            // 
            this.cb_TimeZone18.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone18.FormattingEnabled = true;
            this.cb_TimeZone18.Location = new System.Drawing.Point(480, 405);
            this.cb_TimeZone18.Name = "cb_TimeZone18";
            this.cb_TimeZone18.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone18.TabIndex = 336;
            // 
            // cb_TimeZone17
            // 
            this.cb_TimeZone17.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone17.FormattingEnabled = true;
            this.cb_TimeZone17.Location = new System.Drawing.Point(480, 355);
            this.cb_TimeZone17.Name = "cb_TimeZone17";
            this.cb_TimeZone17.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone17.TabIndex = 335;
            // 
            // cb_TimeZone16
            // 
            this.cb_TimeZone16.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone16.FormattingEnabled = true;
            this.cb_TimeZone16.Location = new System.Drawing.Point(480, 305);
            this.cb_TimeZone16.Name = "cb_TimeZone16";
            this.cb_TimeZone16.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone16.TabIndex = 334;
            // 
            // cb_TimeZone15
            // 
            this.cb_TimeZone15.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone15.FormattingEnabled = true;
            this.cb_TimeZone15.Location = new System.Drawing.Point(480, 255);
            this.cb_TimeZone15.Name = "cb_TimeZone15";
            this.cb_TimeZone15.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone15.TabIndex = 333;
            // 
            // cb_TimeZone14
            // 
            this.cb_TimeZone14.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone14.FormattingEnabled = true;
            this.cb_TimeZone14.Location = new System.Drawing.Point(480, 205);
            this.cb_TimeZone14.Name = "cb_TimeZone14";
            this.cb_TimeZone14.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone14.TabIndex = 332;
            // 
            // cb_TimeZone13
            // 
            this.cb_TimeZone13.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone13.FormattingEnabled = true;
            this.cb_TimeZone13.Location = new System.Drawing.Point(480, 155);
            this.cb_TimeZone13.Name = "cb_TimeZone13";
            this.cb_TimeZone13.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone13.TabIndex = 331;
            // 
            // cb_TimeZone12
            // 
            this.cb_TimeZone12.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone12.FormattingEnabled = true;
            this.cb_TimeZone12.Location = new System.Drawing.Point(480, 105);
            this.cb_TimeZone12.Name = "cb_TimeZone12";
            this.cb_TimeZone12.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone12.TabIndex = 330;
            // 
            // cb_TimeZone11
            // 
            this.cb_TimeZone11.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone11.FormattingEnabled = true;
            this.cb_TimeZone11.Location = new System.Drawing.Point(480, 55);
            this.cb_TimeZone11.Name = "cb_TimeZone11";
            this.cb_TimeZone11.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone11.TabIndex = 329;
            // 
            // cb_TimeZone10
            // 
            this.cb_TimeZone10.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone10.FormattingEnabled = true;
            this.cb_TimeZone10.Location = new System.Drawing.Point(220, 505);
            this.cb_TimeZone10.Name = "cb_TimeZone10";
            this.cb_TimeZone10.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone10.TabIndex = 328;
            // 
            // cb_TimeZone9
            // 
            this.cb_TimeZone9.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone9.FormattingEnabled = true;
            this.cb_TimeZone9.Location = new System.Drawing.Point(220, 455);
            this.cb_TimeZone9.Name = "cb_TimeZone9";
            this.cb_TimeZone9.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone9.TabIndex = 325;
            // 
            // cb_TimeZone8
            // 
            this.cb_TimeZone8.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone8.FormattingEnabled = true;
            this.cb_TimeZone8.Location = new System.Drawing.Point(220, 405);
            this.cb_TimeZone8.Name = "cb_TimeZone8";
            this.cb_TimeZone8.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone8.TabIndex = 322;
            // 
            // cb_TimeZone7
            // 
            this.cb_TimeZone7.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone7.FormattingEnabled = true;
            this.cb_TimeZone7.Location = new System.Drawing.Point(220, 355);
            this.cb_TimeZone7.Name = "cb_TimeZone7";
            this.cb_TimeZone7.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone7.TabIndex = 319;
            // 
            // cb_TimeZone6
            // 
            this.cb_TimeZone6.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone6.FormattingEnabled = true;
            this.cb_TimeZone6.Location = new System.Drawing.Point(220, 305);
            this.cb_TimeZone6.Name = "cb_TimeZone6";
            this.cb_TimeZone6.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone6.TabIndex = 316;
            // 
            // cb_TimeZone5
            // 
            this.cb_TimeZone5.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone5.FormattingEnabled = true;
            this.cb_TimeZone5.Location = new System.Drawing.Point(220, 255);
            this.cb_TimeZone5.Name = "cb_TimeZone5";
            this.cb_TimeZone5.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone5.TabIndex = 313;
            // 
            // cb_TimeZone4
            // 
            this.cb_TimeZone4.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone4.FormattingEnabled = true;
            this.cb_TimeZone4.Location = new System.Drawing.Point(220, 205);
            this.cb_TimeZone4.Name = "cb_TimeZone4";
            this.cb_TimeZone4.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone4.TabIndex = 310;
            // 
            // cb_TimeZone3
            // 
            this.cb_TimeZone3.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone3.FormattingEnabled = true;
            this.cb_TimeZone3.Location = new System.Drawing.Point(220, 155);
            this.cb_TimeZone3.Name = "cb_TimeZone3";
            this.cb_TimeZone3.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone3.TabIndex = 307;
            // 
            // cb_TimeZone2
            // 
            this.cb_TimeZone2.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone2.FormattingEnabled = true;
            this.cb_TimeZone2.Location = new System.Drawing.Point(220, 105);
            this.cb_TimeZone2.Name = "cb_TimeZone2";
            this.cb_TimeZone2.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone2.TabIndex = 304;
            // 
            // cb_TimeZone1
            // 
            this.cb_TimeZone1.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_TimeZone1.FormattingEnabled = true;
            this.cb_TimeZone1.Location = new System.Drawing.Point(220, 55);
            this.cb_TimeZone1.Name = "cb_TimeZone1";
            this.cb_TimeZone1.Size = new System.Drawing.Size(200, 21);
            this.cb_TimeZone1.TabIndex = 301;
            // 
            // skinLabel44
            // 
            this.skinLabel44.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel44.AutoSize = true;
            this.skinLabel44.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel44.BorderColor = System.Drawing.Color.White;
            this.skinLabel44.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel44.Location = new System.Drawing.Point(60, 505);
            this.skinLabel44.Name = "skinLabel44";
            this.skinLabel44.Size = new System.Drawing.Size(69, 19);
            this.skinLabel44.TabIndex = 251;
            this.skinLabel44.Text = "时区10：";
            // 
            // skinLabel45
            // 
            this.skinLabel45.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel45.AutoSize = true;
            this.skinLabel45.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel45.BorderColor = System.Drawing.Color.White;
            this.skinLabel45.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel45.Location = new System.Drawing.Point(60, 455);
            this.skinLabel45.Name = "skinLabel45";
            this.skinLabel45.Size = new System.Drawing.Size(69, 19);
            this.skinLabel45.TabIndex = 250;
            this.skinLabel45.Text = "时区09：";
            // 
            // skinLabel46
            // 
            this.skinLabel46.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel46.AutoSize = true;
            this.skinLabel46.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel46.BorderColor = System.Drawing.Color.White;
            this.skinLabel46.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel46.Location = new System.Drawing.Point(60, 405);
            this.skinLabel46.Name = "skinLabel46";
            this.skinLabel46.Size = new System.Drawing.Size(69, 19);
            this.skinLabel46.TabIndex = 249;
            this.skinLabel46.Text = "时区08：";
            // 
            // skinLabel47
            // 
            this.skinLabel47.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel47.AutoSize = true;
            this.skinLabel47.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel47.BorderColor = System.Drawing.Color.White;
            this.skinLabel47.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel47.Location = new System.Drawing.Point(60, 355);
            this.skinLabel47.Name = "skinLabel47";
            this.skinLabel47.Size = new System.Drawing.Size(69, 19);
            this.skinLabel47.TabIndex = 248;
            this.skinLabel47.Text = "时区07：";
            // 
            // skinLabel48
            // 
            this.skinLabel48.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel48.AutoSize = true;
            this.skinLabel48.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel48.BorderColor = System.Drawing.Color.White;
            this.skinLabel48.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel48.Location = new System.Drawing.Point(60, 305);
            this.skinLabel48.Name = "skinLabel48";
            this.skinLabel48.Size = new System.Drawing.Size(69, 19);
            this.skinLabel48.TabIndex = 247;
            this.skinLabel48.Text = "时区06：";
            // 
            // skinLabel49
            // 
            this.skinLabel49.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel49.AutoSize = true;
            this.skinLabel49.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel49.BorderColor = System.Drawing.Color.White;
            this.skinLabel49.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel49.Location = new System.Drawing.Point(60, 255);
            this.skinLabel49.Name = "skinLabel49";
            this.skinLabel49.Size = new System.Drawing.Size(69, 19);
            this.skinLabel49.TabIndex = 246;
            this.skinLabel49.Text = "时区05：";
            // 
            // skinLabel50
            // 
            this.skinLabel50.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel50.AutoSize = true;
            this.skinLabel50.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel50.BorderColor = System.Drawing.Color.White;
            this.skinLabel50.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel50.Location = new System.Drawing.Point(60, 205);
            this.skinLabel50.Name = "skinLabel50";
            this.skinLabel50.Size = new System.Drawing.Size(69, 19);
            this.skinLabel50.TabIndex = 245;
            this.skinLabel50.Text = "时区04：";
            // 
            // skinLabel51
            // 
            this.skinLabel51.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel51.AutoSize = true;
            this.skinLabel51.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel51.BorderColor = System.Drawing.Color.White;
            this.skinLabel51.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel51.Location = new System.Drawing.Point(60, 155);
            this.skinLabel51.Name = "skinLabel51";
            this.skinLabel51.Size = new System.Drawing.Size(69, 19);
            this.skinLabel51.TabIndex = 244;
            this.skinLabel51.Text = "时区03：";
            // 
            // skinLabel52
            // 
            this.skinLabel52.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel52.AutoSize = true;
            this.skinLabel52.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel52.BorderColor = System.Drawing.Color.White;
            this.skinLabel52.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel52.Location = new System.Drawing.Point(60, 105);
            this.skinLabel52.Name = "skinLabel52";
            this.skinLabel52.Size = new System.Drawing.Size(69, 19);
            this.skinLabel52.TabIndex = 243;
            this.skinLabel52.Text = "时区02：";
            // 
            // skinLabel53
            // 
            this.skinLabel53.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel53.AutoSize = true;
            this.skinLabel53.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel53.BorderColor = System.Drawing.Color.White;
            this.skinLabel53.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel53.Location = new System.Drawing.Point(60, 55);
            this.skinLabel53.Name = "skinLabel53";
            this.skinLabel53.Size = new System.Drawing.Size(69, 19);
            this.skinLabel53.TabIndex = 242;
            this.skinLabel53.Text = "时区01：";
            // 
            // timezone2
            // 
            this.timezone2.Controls.Add(this.skinLabel43);
            this.timezone2.Controls.Add(this.skinLabel54);
            this.timezone2.Controls.Add(this.skinLabel55);
            this.timezone2.Controls.Add(this.skinLabel56);
            this.timezone2.Controls.Add(this.cb_TimeZone60);
            this.timezone2.Controls.Add(this.cb_TimeZone59);
            this.timezone2.Controls.Add(this.cb_TimeZone58);
            this.timezone2.Controls.Add(this.cb_TimeZone57);
            this.timezone2.Controls.Add(this.cb_TimeZone56);
            this.timezone2.Controls.Add(this.cb_TimeZone55);
            this.timezone2.Controls.Add(this.cb_TimeZone54);
            this.timezone2.Controls.Add(this.cb_TimeZone53);
            this.timezone2.Controls.Add(this.cb_TimeZone52);
            this.timezone2.Controls.Add(this.cb_TimeZone51);
            this.timezone2.Controls.Add(this.cb_TimeZone50);
            this.timezone2.Controls.Add(this.cb_TimeZone49);
            this.timezone2.Controls.Add(this.cb_TimeZone48);
            this.timezone2.Controls.Add(this.cb_TimeZone47);
            this.timezone2.Controls.Add(this.cb_TimeZone46);
            this.timezone2.Controls.Add(this.cb_TimeZone45);
            this.timezone2.Controls.Add(this.cb_TimeZone44);
            this.timezone2.Controls.Add(this.cb_TimeZone43);
            this.timezone2.Controls.Add(this.cb_TimeZone42);
            this.timezone2.Controls.Add(this.cb_TimeZone41);
            this.timezone2.Controls.Add(this.cb_TimeZone40);
            this.timezone2.Controls.Add(this.cb_TimeZone39);
            this.timezone2.Controls.Add(this.cb_TimeZone38);
            this.timezone2.Controls.Add(this.cb_TimeZone37);
            this.timezone2.Controls.Add(this.cb_TimeZone36);
            this.timezone2.Controls.Add(this.cb_TimeZone35);
            this.timezone2.Controls.Add(this.cb_TimeZone34);
            this.timezone2.Controls.Add(this.cb_TimeZone33);
            this.timezone2.Controls.Add(this.cb_TimeZone32);
            this.timezone2.Controls.Add(this.cb_TimeZone31);
            this.timezone2.Controls.Add(this.skinLabel57);
            this.timezone2.Controls.Add(this.skinLabel58);
            this.timezone2.Controls.Add(this.skinLabel59);
            this.timezone2.Controls.Add(this.skinLabel60);
            this.timezone2.Controls.Add(this.skinLabel61);
            this.timezone2.Controls.Add(this.skinLabel62);
            this.timezone2.Controls.Add(this.skinLabel63);
            this.timezone2.Controls.Add(this.skinLabel64);
            this.timezone2.Controls.Add(this.skinLabel65);
            this.timezone2.Controls.Add(this.skinLabel66);
            this.timezone2.Location = new System.Drawing.Point(0, 36);
            this.timezone2.Name = "timezone2";
            this.timezone2.Padding = new System.Windows.Forms.Padding(3);
            this.timezone2.Size = new System.Drawing.Size(1018, 543);
            this.timezone2.TabIndex = 1;
            this.timezone2.Text = "【11,20】";
            this.timezone2.UseVisualStyleBackColor = true;
            // 
            // skinLabel43
            // 
            this.skinLabel43.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel43.AutoSize = true;
            this.skinLabel43.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel43.BorderColor = System.Drawing.Color.White;
            this.skinLabel43.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel43.ForeColor = System.Drawing.Color.Red;
            this.skinLabel43.Location = new System.Drawing.Point(60, 20);
            this.skinLabel43.Name = "skinLabel43";
            this.skinLabel43.Size = new System.Drawing.Size(68, 16);
            this.skinLabel43.TabIndex = 398;
            this.skinLabel43.Text = "时区序号";
            // 
            // skinLabel54
            // 
            this.skinLabel54.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel54.AutoSize = true;
            this.skinLabel54.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel54.BorderColor = System.Drawing.Color.White;
            this.skinLabel54.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel54.ForeColor = System.Drawing.Color.Red;
            this.skinLabel54.Location = new System.Drawing.Point(812, 20);
            this.skinLabel54.Name = "skinLabel54";
            this.skinLabel54.Size = new System.Drawing.Size(68, 16);
            this.skinLabel54.TabIndex = 397;
            this.skinLabel54.Text = "时间段三";
            // 
            // skinLabel55
            // 
            this.skinLabel55.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel55.AutoSize = true;
            this.skinLabel55.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel55.BorderColor = System.Drawing.Color.White;
            this.skinLabel55.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel55.ForeColor = System.Drawing.Color.Red;
            this.skinLabel55.Location = new System.Drawing.Point(515, 20);
            this.skinLabel55.Name = "skinLabel55";
            this.skinLabel55.Size = new System.Drawing.Size(68, 16);
            this.skinLabel55.TabIndex = 396;
            this.skinLabel55.Text = "时间段二";
            // 
            // skinLabel56
            // 
            this.skinLabel56.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel56.AutoSize = true;
            this.skinLabel56.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel56.BorderColor = System.Drawing.Color.White;
            this.skinLabel56.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel56.ForeColor = System.Drawing.Color.Red;
            this.skinLabel56.Location = new System.Drawing.Point(250, 20);
            this.skinLabel56.Name = "skinLabel56";
            this.skinLabel56.Size = new System.Drawing.Size(68, 16);
            this.skinLabel56.TabIndex = 395;
            this.skinLabel56.Text = "时间段一";
            // 
            // cb_TimeZone60
            // 
            this.cb_TimeZone60.FormattingEnabled = true;
            this.cb_TimeZone60.Location = new System.Drawing.Point(770, 505);
            this.cb_TimeZone60.Name = "cb_TimeZone60";
            this.cb_TimeZone60.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone60.TabIndex = 394;
            // 
            // cb_TimeZone59
            // 
            this.cb_TimeZone59.FormattingEnabled = true;
            this.cb_TimeZone59.Location = new System.Drawing.Point(770, 455);
            this.cb_TimeZone59.Name = "cb_TimeZone59";
            this.cb_TimeZone59.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone59.TabIndex = 393;
            // 
            // cb_TimeZone58
            // 
            this.cb_TimeZone58.FormattingEnabled = true;
            this.cb_TimeZone58.Location = new System.Drawing.Point(770, 405);
            this.cb_TimeZone58.Name = "cb_TimeZone58";
            this.cb_TimeZone58.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone58.TabIndex = 392;
            // 
            // cb_TimeZone57
            // 
            this.cb_TimeZone57.FormattingEnabled = true;
            this.cb_TimeZone57.Location = new System.Drawing.Point(770, 355);
            this.cb_TimeZone57.Name = "cb_TimeZone57";
            this.cb_TimeZone57.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone57.TabIndex = 391;
            // 
            // cb_TimeZone56
            // 
            this.cb_TimeZone56.FormattingEnabled = true;
            this.cb_TimeZone56.Location = new System.Drawing.Point(770, 305);
            this.cb_TimeZone56.Name = "cb_TimeZone56";
            this.cb_TimeZone56.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone56.TabIndex = 390;
            // 
            // cb_TimeZone55
            // 
            this.cb_TimeZone55.FormattingEnabled = true;
            this.cb_TimeZone55.Location = new System.Drawing.Point(770, 255);
            this.cb_TimeZone55.Name = "cb_TimeZone55";
            this.cb_TimeZone55.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone55.TabIndex = 389;
            // 
            // cb_TimeZone54
            // 
            this.cb_TimeZone54.FormattingEnabled = true;
            this.cb_TimeZone54.Location = new System.Drawing.Point(770, 205);
            this.cb_TimeZone54.Name = "cb_TimeZone54";
            this.cb_TimeZone54.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone54.TabIndex = 388;
            // 
            // cb_TimeZone53
            // 
            this.cb_TimeZone53.FormattingEnabled = true;
            this.cb_TimeZone53.Location = new System.Drawing.Point(770, 155);
            this.cb_TimeZone53.Name = "cb_TimeZone53";
            this.cb_TimeZone53.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone53.TabIndex = 387;
            // 
            // cb_TimeZone52
            // 
            this.cb_TimeZone52.FormattingEnabled = true;
            this.cb_TimeZone52.Location = new System.Drawing.Point(770, 105);
            this.cb_TimeZone52.Name = "cb_TimeZone52";
            this.cb_TimeZone52.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone52.TabIndex = 386;
            // 
            // cb_TimeZone51
            // 
            this.cb_TimeZone51.FormattingEnabled = true;
            this.cb_TimeZone51.Location = new System.Drawing.Point(770, 55);
            this.cb_TimeZone51.Name = "cb_TimeZone51";
            this.cb_TimeZone51.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone51.TabIndex = 385;
            // 
            // cb_TimeZone50
            // 
            this.cb_TimeZone50.FormattingEnabled = true;
            this.cb_TimeZone50.Location = new System.Drawing.Point(480, 505);
            this.cb_TimeZone50.Name = "cb_TimeZone50";
            this.cb_TimeZone50.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone50.TabIndex = 384;
            // 
            // cb_TimeZone49
            // 
            this.cb_TimeZone49.FormattingEnabled = true;
            this.cb_TimeZone49.Location = new System.Drawing.Point(480, 455);
            this.cb_TimeZone49.Name = "cb_TimeZone49";
            this.cb_TimeZone49.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone49.TabIndex = 383;
            // 
            // cb_TimeZone48
            // 
            this.cb_TimeZone48.FormattingEnabled = true;
            this.cb_TimeZone48.Location = new System.Drawing.Point(480, 405);
            this.cb_TimeZone48.Name = "cb_TimeZone48";
            this.cb_TimeZone48.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone48.TabIndex = 382;
            // 
            // cb_TimeZone47
            // 
            this.cb_TimeZone47.FormattingEnabled = true;
            this.cb_TimeZone47.Location = new System.Drawing.Point(480, 355);
            this.cb_TimeZone47.Name = "cb_TimeZone47";
            this.cb_TimeZone47.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone47.TabIndex = 381;
            // 
            // cb_TimeZone46
            // 
            this.cb_TimeZone46.FormattingEnabled = true;
            this.cb_TimeZone46.Location = new System.Drawing.Point(480, 305);
            this.cb_TimeZone46.Name = "cb_TimeZone46";
            this.cb_TimeZone46.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone46.TabIndex = 380;
            // 
            // cb_TimeZone45
            // 
            this.cb_TimeZone45.FormattingEnabled = true;
            this.cb_TimeZone45.Location = new System.Drawing.Point(480, 255);
            this.cb_TimeZone45.Name = "cb_TimeZone45";
            this.cb_TimeZone45.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone45.TabIndex = 379;
            // 
            // cb_TimeZone44
            // 
            this.cb_TimeZone44.FormattingEnabled = true;
            this.cb_TimeZone44.Location = new System.Drawing.Point(480, 205);
            this.cb_TimeZone44.Name = "cb_TimeZone44";
            this.cb_TimeZone44.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone44.TabIndex = 378;
            // 
            // cb_TimeZone43
            // 
            this.cb_TimeZone43.FormattingEnabled = true;
            this.cb_TimeZone43.Location = new System.Drawing.Point(480, 155);
            this.cb_TimeZone43.Name = "cb_TimeZone43";
            this.cb_TimeZone43.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone43.TabIndex = 377;
            // 
            // cb_TimeZone42
            // 
            this.cb_TimeZone42.FormattingEnabled = true;
            this.cb_TimeZone42.Location = new System.Drawing.Point(480, 105);
            this.cb_TimeZone42.Name = "cb_TimeZone42";
            this.cb_TimeZone42.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone42.TabIndex = 376;
            // 
            // cb_TimeZone41
            // 
            this.cb_TimeZone41.FormattingEnabled = true;
            this.cb_TimeZone41.Location = new System.Drawing.Point(480, 55);
            this.cb_TimeZone41.Name = "cb_TimeZone41";
            this.cb_TimeZone41.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone41.TabIndex = 375;
            // 
            // cb_TimeZone40
            // 
            this.cb_TimeZone40.FormattingEnabled = true;
            this.cb_TimeZone40.Location = new System.Drawing.Point(220, 505);
            this.cb_TimeZone40.Name = "cb_TimeZone40";
            this.cb_TimeZone40.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone40.TabIndex = 374;
            // 
            // cb_TimeZone39
            // 
            this.cb_TimeZone39.FormattingEnabled = true;
            this.cb_TimeZone39.Location = new System.Drawing.Point(220, 455);
            this.cb_TimeZone39.Name = "cb_TimeZone39";
            this.cb_TimeZone39.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone39.TabIndex = 373;
            // 
            // cb_TimeZone38
            // 
            this.cb_TimeZone38.FormattingEnabled = true;
            this.cb_TimeZone38.Location = new System.Drawing.Point(220, 405);
            this.cb_TimeZone38.Name = "cb_TimeZone38";
            this.cb_TimeZone38.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone38.TabIndex = 372;
            // 
            // cb_TimeZone37
            // 
            this.cb_TimeZone37.FormattingEnabled = true;
            this.cb_TimeZone37.Location = new System.Drawing.Point(220, 355);
            this.cb_TimeZone37.Name = "cb_TimeZone37";
            this.cb_TimeZone37.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone37.TabIndex = 371;
            // 
            // cb_TimeZone36
            // 
            this.cb_TimeZone36.FormattingEnabled = true;
            this.cb_TimeZone36.Location = new System.Drawing.Point(220, 305);
            this.cb_TimeZone36.Name = "cb_TimeZone36";
            this.cb_TimeZone36.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone36.TabIndex = 370;
            // 
            // cb_TimeZone35
            // 
            this.cb_TimeZone35.FormattingEnabled = true;
            this.cb_TimeZone35.Location = new System.Drawing.Point(220, 255);
            this.cb_TimeZone35.Name = "cb_TimeZone35";
            this.cb_TimeZone35.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone35.TabIndex = 369;
            // 
            // cb_TimeZone34
            // 
            this.cb_TimeZone34.FormattingEnabled = true;
            this.cb_TimeZone34.Location = new System.Drawing.Point(220, 205);
            this.cb_TimeZone34.Name = "cb_TimeZone34";
            this.cb_TimeZone34.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone34.TabIndex = 368;
            // 
            // cb_TimeZone33
            // 
            this.cb_TimeZone33.FormattingEnabled = true;
            this.cb_TimeZone33.Location = new System.Drawing.Point(220, 155);
            this.cb_TimeZone33.Name = "cb_TimeZone33";
            this.cb_TimeZone33.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone33.TabIndex = 367;
            // 
            // cb_TimeZone32
            // 
            this.cb_TimeZone32.FormattingEnabled = true;
            this.cb_TimeZone32.Location = new System.Drawing.Point(220, 105);
            this.cb_TimeZone32.Name = "cb_TimeZone32";
            this.cb_TimeZone32.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone32.TabIndex = 366;
            // 
            // cb_TimeZone31
            // 
            this.cb_TimeZone31.FormattingEnabled = true;
            this.cb_TimeZone31.Location = new System.Drawing.Point(220, 55);
            this.cb_TimeZone31.Name = "cb_TimeZone31";
            this.cb_TimeZone31.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone31.TabIndex = 365;
            // 
            // skinLabel57
            // 
            this.skinLabel57.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel57.AutoSize = true;
            this.skinLabel57.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel57.BorderColor = System.Drawing.Color.White;
            this.skinLabel57.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel57.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel57.Location = new System.Drawing.Point(60, 505);
            this.skinLabel57.Name = "skinLabel57";
            this.skinLabel57.Size = new System.Drawing.Size(69, 19);
            this.skinLabel57.TabIndex = 362;
            this.skinLabel57.Text = "时区20：";
            // 
            // skinLabel58
            // 
            this.skinLabel58.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel58.AutoSize = true;
            this.skinLabel58.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel58.BorderColor = System.Drawing.Color.White;
            this.skinLabel58.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel58.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel58.Location = new System.Drawing.Point(60, 455);
            this.skinLabel58.Name = "skinLabel58";
            this.skinLabel58.Size = new System.Drawing.Size(69, 19);
            this.skinLabel58.TabIndex = 361;
            this.skinLabel58.Text = "时区19：";
            // 
            // skinLabel59
            // 
            this.skinLabel59.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel59.AutoSize = true;
            this.skinLabel59.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel59.BorderColor = System.Drawing.Color.White;
            this.skinLabel59.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel59.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel59.Location = new System.Drawing.Point(60, 405);
            this.skinLabel59.Name = "skinLabel59";
            this.skinLabel59.Size = new System.Drawing.Size(69, 19);
            this.skinLabel59.TabIndex = 360;
            this.skinLabel59.Text = "时区18：";
            // 
            // skinLabel60
            // 
            this.skinLabel60.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel60.AutoSize = true;
            this.skinLabel60.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel60.BorderColor = System.Drawing.Color.White;
            this.skinLabel60.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel60.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel60.Location = new System.Drawing.Point(60, 355);
            this.skinLabel60.Name = "skinLabel60";
            this.skinLabel60.Size = new System.Drawing.Size(69, 19);
            this.skinLabel60.TabIndex = 359;
            this.skinLabel60.Text = "时区17：";
            // 
            // skinLabel61
            // 
            this.skinLabel61.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel61.AutoSize = true;
            this.skinLabel61.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel61.BorderColor = System.Drawing.Color.White;
            this.skinLabel61.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel61.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel61.Location = new System.Drawing.Point(60, 305);
            this.skinLabel61.Name = "skinLabel61";
            this.skinLabel61.Size = new System.Drawing.Size(69, 19);
            this.skinLabel61.TabIndex = 358;
            this.skinLabel61.Text = "时区16：";
            // 
            // skinLabel62
            // 
            this.skinLabel62.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel62.AutoSize = true;
            this.skinLabel62.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel62.BorderColor = System.Drawing.Color.White;
            this.skinLabel62.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel62.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel62.Location = new System.Drawing.Point(60, 255);
            this.skinLabel62.Name = "skinLabel62";
            this.skinLabel62.Size = new System.Drawing.Size(69, 19);
            this.skinLabel62.TabIndex = 357;
            this.skinLabel62.Text = "时区15：";
            // 
            // skinLabel63
            // 
            this.skinLabel63.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel63.AutoSize = true;
            this.skinLabel63.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel63.BorderColor = System.Drawing.Color.White;
            this.skinLabel63.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel63.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel63.Location = new System.Drawing.Point(60, 205);
            this.skinLabel63.Name = "skinLabel63";
            this.skinLabel63.Size = new System.Drawing.Size(69, 19);
            this.skinLabel63.TabIndex = 356;
            this.skinLabel63.Text = "时区14：";
            // 
            // skinLabel64
            // 
            this.skinLabel64.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel64.AutoSize = true;
            this.skinLabel64.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel64.BorderColor = System.Drawing.Color.White;
            this.skinLabel64.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel64.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel64.Location = new System.Drawing.Point(60, 155);
            this.skinLabel64.Name = "skinLabel64";
            this.skinLabel64.Size = new System.Drawing.Size(69, 19);
            this.skinLabel64.TabIndex = 355;
            this.skinLabel64.Text = "时区13：";
            // 
            // skinLabel65
            // 
            this.skinLabel65.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel65.AutoSize = true;
            this.skinLabel65.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel65.BorderColor = System.Drawing.Color.White;
            this.skinLabel65.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel65.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel65.Location = new System.Drawing.Point(60, 105);
            this.skinLabel65.Name = "skinLabel65";
            this.skinLabel65.Size = new System.Drawing.Size(69, 19);
            this.skinLabel65.TabIndex = 354;
            this.skinLabel65.Text = "时区12：";
            // 
            // skinLabel66
            // 
            this.skinLabel66.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel66.AutoSize = true;
            this.skinLabel66.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel66.BorderColor = System.Drawing.Color.White;
            this.skinLabel66.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel66.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel66.Location = new System.Drawing.Point(60, 55);
            this.skinLabel66.Name = "skinLabel66";
            this.skinLabel66.Size = new System.Drawing.Size(69, 19);
            this.skinLabel66.TabIndex = 353;
            this.skinLabel66.Text = "时区11：";
            // 
            // timezone3
            // 
            this.timezone3.Controls.Add(this.skinLabel67);
            this.timezone3.Controls.Add(this.skinLabel68);
            this.timezone3.Controls.Add(this.skinLabel69);
            this.timezone3.Controls.Add(this.skinLabel70);
            this.timezone3.Controls.Add(this.cb_TimeZone90);
            this.timezone3.Controls.Add(this.cb_TimeZone89);
            this.timezone3.Controls.Add(this.cb_TimeZone88);
            this.timezone3.Controls.Add(this.cb_TimeZone87);
            this.timezone3.Controls.Add(this.cb_TimeZone86);
            this.timezone3.Controls.Add(this.cb_TimeZone85);
            this.timezone3.Controls.Add(this.cb_TimeZone84);
            this.timezone3.Controls.Add(this.cb_TimeZone83);
            this.timezone3.Controls.Add(this.cb_TimeZone82);
            this.timezone3.Controls.Add(this.cb_TimeZone81);
            this.timezone3.Controls.Add(this.cb_TimeZone80);
            this.timezone3.Controls.Add(this.cb_TimeZone79);
            this.timezone3.Controls.Add(this.cb_TimeZone78);
            this.timezone3.Controls.Add(this.cb_TimeZone77);
            this.timezone3.Controls.Add(this.cb_TimeZone76);
            this.timezone3.Controls.Add(this.cb_TimeZone75);
            this.timezone3.Controls.Add(this.cb_TimeZone74);
            this.timezone3.Controls.Add(this.cb_TimeZone73);
            this.timezone3.Controls.Add(this.cb_TimeZone72);
            this.timezone3.Controls.Add(this.cb_TimeZone71);
            this.timezone3.Controls.Add(this.cb_TimeZone70);
            this.timezone3.Controls.Add(this.cb_TimeZone69);
            this.timezone3.Controls.Add(this.cb_TimeZone68);
            this.timezone3.Controls.Add(this.cb_TimeZone67);
            this.timezone3.Controls.Add(this.cb_TimeZone66);
            this.timezone3.Controls.Add(this.cb_TimeZone65);
            this.timezone3.Controls.Add(this.cb_TimeZone64);
            this.timezone3.Controls.Add(this.cb_TimeZone63);
            this.timezone3.Controls.Add(this.cb_TimeZone62);
            this.timezone3.Controls.Add(this.cb_TimeZone61);
            this.timezone3.Controls.Add(this.skinLabel71);
            this.timezone3.Controls.Add(this.skinLabel72);
            this.timezone3.Controls.Add(this.skinLabel73);
            this.timezone3.Controls.Add(this.skinLabel74);
            this.timezone3.Controls.Add(this.skinLabel75);
            this.timezone3.Controls.Add(this.skinLabel76);
            this.timezone3.Controls.Add(this.skinLabel77);
            this.timezone3.Controls.Add(this.skinLabel78);
            this.timezone3.Controls.Add(this.skinLabel79);
            this.timezone3.Controls.Add(this.skinLabel80);
            this.timezone3.Location = new System.Drawing.Point(0, 36);
            this.timezone3.Name = "timezone3";
            this.timezone3.Size = new System.Drawing.Size(1018, 543);
            this.timezone3.TabIndex = 2;
            this.timezone3.Text = "【21,30】";
            this.timezone3.UseVisualStyleBackColor = true;
            // 
            // skinLabel67
            // 
            this.skinLabel67.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel67.AutoSize = true;
            this.skinLabel67.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel67.BorderColor = System.Drawing.Color.White;
            this.skinLabel67.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel67.ForeColor = System.Drawing.Color.Red;
            this.skinLabel67.Location = new System.Drawing.Point(60, 20);
            this.skinLabel67.Name = "skinLabel67";
            this.skinLabel67.Size = new System.Drawing.Size(68, 16);
            this.skinLabel67.TabIndex = 443;
            this.skinLabel67.Text = "时区序号";
            // 
            // skinLabel68
            // 
            this.skinLabel68.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel68.AutoSize = true;
            this.skinLabel68.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel68.BorderColor = System.Drawing.Color.White;
            this.skinLabel68.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel68.ForeColor = System.Drawing.Color.Red;
            this.skinLabel68.Location = new System.Drawing.Point(812, 20);
            this.skinLabel68.Name = "skinLabel68";
            this.skinLabel68.Size = new System.Drawing.Size(68, 16);
            this.skinLabel68.TabIndex = 442;
            this.skinLabel68.Text = "时间段三";
            // 
            // skinLabel69
            // 
            this.skinLabel69.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel69.AutoSize = true;
            this.skinLabel69.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel69.BorderColor = System.Drawing.Color.White;
            this.skinLabel69.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel69.ForeColor = System.Drawing.Color.Red;
            this.skinLabel69.Location = new System.Drawing.Point(515, 20);
            this.skinLabel69.Name = "skinLabel69";
            this.skinLabel69.Size = new System.Drawing.Size(68, 16);
            this.skinLabel69.TabIndex = 441;
            this.skinLabel69.Text = "时间段二";
            // 
            // skinLabel70
            // 
            this.skinLabel70.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel70.AutoSize = true;
            this.skinLabel70.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel70.BorderColor = System.Drawing.Color.White;
            this.skinLabel70.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel70.ForeColor = System.Drawing.Color.Red;
            this.skinLabel70.Location = new System.Drawing.Point(250, 20);
            this.skinLabel70.Name = "skinLabel70";
            this.skinLabel70.Size = new System.Drawing.Size(68, 16);
            this.skinLabel70.TabIndex = 440;
            this.skinLabel70.Text = "时间段一";
            // 
            // cb_TimeZone90
            // 
            this.cb_TimeZone90.FormattingEnabled = true;
            this.cb_TimeZone90.Location = new System.Drawing.Point(770, 505);
            this.cb_TimeZone90.Name = "cb_TimeZone90";
            this.cb_TimeZone90.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone90.TabIndex = 439;
            // 
            // cb_TimeZone89
            // 
            this.cb_TimeZone89.FormattingEnabled = true;
            this.cb_TimeZone89.Location = new System.Drawing.Point(770, 455);
            this.cb_TimeZone89.Name = "cb_TimeZone89";
            this.cb_TimeZone89.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone89.TabIndex = 438;
            // 
            // cb_TimeZone88
            // 
            this.cb_TimeZone88.FormattingEnabled = true;
            this.cb_TimeZone88.Location = new System.Drawing.Point(770, 405);
            this.cb_TimeZone88.Name = "cb_TimeZone88";
            this.cb_TimeZone88.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone88.TabIndex = 437;
            // 
            // cb_TimeZone87
            // 
            this.cb_TimeZone87.FormattingEnabled = true;
            this.cb_TimeZone87.Location = new System.Drawing.Point(770, 355);
            this.cb_TimeZone87.Name = "cb_TimeZone87";
            this.cb_TimeZone87.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone87.TabIndex = 436;
            // 
            // cb_TimeZone86
            // 
            this.cb_TimeZone86.FormattingEnabled = true;
            this.cb_TimeZone86.Location = new System.Drawing.Point(770, 305);
            this.cb_TimeZone86.Name = "cb_TimeZone86";
            this.cb_TimeZone86.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone86.TabIndex = 435;
            // 
            // cb_TimeZone85
            // 
            this.cb_TimeZone85.FormattingEnabled = true;
            this.cb_TimeZone85.Location = new System.Drawing.Point(770, 255);
            this.cb_TimeZone85.Name = "cb_TimeZone85";
            this.cb_TimeZone85.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone85.TabIndex = 434;
            // 
            // cb_TimeZone84
            // 
            this.cb_TimeZone84.FormattingEnabled = true;
            this.cb_TimeZone84.Location = new System.Drawing.Point(770, 205);
            this.cb_TimeZone84.Name = "cb_TimeZone84";
            this.cb_TimeZone84.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone84.TabIndex = 433;
            // 
            // cb_TimeZone83
            // 
            this.cb_TimeZone83.FormattingEnabled = true;
            this.cb_TimeZone83.Location = new System.Drawing.Point(770, 155);
            this.cb_TimeZone83.Name = "cb_TimeZone83";
            this.cb_TimeZone83.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone83.TabIndex = 432;
            // 
            // cb_TimeZone82
            // 
            this.cb_TimeZone82.FormattingEnabled = true;
            this.cb_TimeZone82.Location = new System.Drawing.Point(770, 105);
            this.cb_TimeZone82.Name = "cb_TimeZone82";
            this.cb_TimeZone82.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone82.TabIndex = 431;
            // 
            // cb_TimeZone81
            // 
            this.cb_TimeZone81.FormattingEnabled = true;
            this.cb_TimeZone81.Location = new System.Drawing.Point(770, 55);
            this.cb_TimeZone81.Name = "cb_TimeZone81";
            this.cb_TimeZone81.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone81.TabIndex = 430;
            // 
            // cb_TimeZone80
            // 
            this.cb_TimeZone80.FormattingEnabled = true;
            this.cb_TimeZone80.Location = new System.Drawing.Point(480, 505);
            this.cb_TimeZone80.Name = "cb_TimeZone80";
            this.cb_TimeZone80.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone80.TabIndex = 429;
            // 
            // cb_TimeZone79
            // 
            this.cb_TimeZone79.FormattingEnabled = true;
            this.cb_TimeZone79.Location = new System.Drawing.Point(480, 455);
            this.cb_TimeZone79.Name = "cb_TimeZone79";
            this.cb_TimeZone79.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone79.TabIndex = 428;
            // 
            // cb_TimeZone78
            // 
            this.cb_TimeZone78.FormattingEnabled = true;
            this.cb_TimeZone78.Location = new System.Drawing.Point(480, 405);
            this.cb_TimeZone78.Name = "cb_TimeZone78";
            this.cb_TimeZone78.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone78.TabIndex = 427;
            // 
            // cb_TimeZone77
            // 
            this.cb_TimeZone77.FormattingEnabled = true;
            this.cb_TimeZone77.Location = new System.Drawing.Point(480, 355);
            this.cb_TimeZone77.Name = "cb_TimeZone77";
            this.cb_TimeZone77.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone77.TabIndex = 426;
            // 
            // cb_TimeZone76
            // 
            this.cb_TimeZone76.FormattingEnabled = true;
            this.cb_TimeZone76.Location = new System.Drawing.Point(480, 305);
            this.cb_TimeZone76.Name = "cb_TimeZone76";
            this.cb_TimeZone76.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone76.TabIndex = 425;
            // 
            // cb_TimeZone75
            // 
            this.cb_TimeZone75.FormattingEnabled = true;
            this.cb_TimeZone75.Location = new System.Drawing.Point(480, 255);
            this.cb_TimeZone75.Name = "cb_TimeZone75";
            this.cb_TimeZone75.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone75.TabIndex = 424;
            // 
            // cb_TimeZone74
            // 
            this.cb_TimeZone74.FormattingEnabled = true;
            this.cb_TimeZone74.Location = new System.Drawing.Point(480, 205);
            this.cb_TimeZone74.Name = "cb_TimeZone74";
            this.cb_TimeZone74.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone74.TabIndex = 423;
            // 
            // cb_TimeZone73
            // 
            this.cb_TimeZone73.FormattingEnabled = true;
            this.cb_TimeZone73.Location = new System.Drawing.Point(480, 155);
            this.cb_TimeZone73.Name = "cb_TimeZone73";
            this.cb_TimeZone73.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone73.TabIndex = 422;
            // 
            // cb_TimeZone72
            // 
            this.cb_TimeZone72.FormattingEnabled = true;
            this.cb_TimeZone72.Location = new System.Drawing.Point(480, 105);
            this.cb_TimeZone72.Name = "cb_TimeZone72";
            this.cb_TimeZone72.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone72.TabIndex = 421;
            // 
            // cb_TimeZone71
            // 
            this.cb_TimeZone71.FormattingEnabled = true;
            this.cb_TimeZone71.Location = new System.Drawing.Point(480, 55);
            this.cb_TimeZone71.Name = "cb_TimeZone71";
            this.cb_TimeZone71.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone71.TabIndex = 420;
            // 
            // cb_TimeZone70
            // 
            this.cb_TimeZone70.FormattingEnabled = true;
            this.cb_TimeZone70.Location = new System.Drawing.Point(220, 505);
            this.cb_TimeZone70.Name = "cb_TimeZone70";
            this.cb_TimeZone70.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone70.TabIndex = 419;
            // 
            // cb_TimeZone69
            // 
            this.cb_TimeZone69.FormattingEnabled = true;
            this.cb_TimeZone69.Location = new System.Drawing.Point(220, 455);
            this.cb_TimeZone69.Name = "cb_TimeZone69";
            this.cb_TimeZone69.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone69.TabIndex = 418;
            // 
            // cb_TimeZone68
            // 
            this.cb_TimeZone68.FormattingEnabled = true;
            this.cb_TimeZone68.Location = new System.Drawing.Point(220, 405);
            this.cb_TimeZone68.Name = "cb_TimeZone68";
            this.cb_TimeZone68.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone68.TabIndex = 417;
            // 
            // cb_TimeZone67
            // 
            this.cb_TimeZone67.FormattingEnabled = true;
            this.cb_TimeZone67.Location = new System.Drawing.Point(220, 355);
            this.cb_TimeZone67.Name = "cb_TimeZone67";
            this.cb_TimeZone67.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone67.TabIndex = 416;
            // 
            // cb_TimeZone66
            // 
            this.cb_TimeZone66.FormattingEnabled = true;
            this.cb_TimeZone66.Location = new System.Drawing.Point(220, 305);
            this.cb_TimeZone66.Name = "cb_TimeZone66";
            this.cb_TimeZone66.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone66.TabIndex = 415;
            // 
            // cb_TimeZone65
            // 
            this.cb_TimeZone65.FormattingEnabled = true;
            this.cb_TimeZone65.Location = new System.Drawing.Point(220, 255);
            this.cb_TimeZone65.Name = "cb_TimeZone65";
            this.cb_TimeZone65.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone65.TabIndex = 414;
            // 
            // cb_TimeZone64
            // 
            this.cb_TimeZone64.FormattingEnabled = true;
            this.cb_TimeZone64.Location = new System.Drawing.Point(220, 205);
            this.cb_TimeZone64.Name = "cb_TimeZone64";
            this.cb_TimeZone64.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone64.TabIndex = 413;
            // 
            // cb_TimeZone63
            // 
            this.cb_TimeZone63.FormattingEnabled = true;
            this.cb_TimeZone63.Location = new System.Drawing.Point(220, 155);
            this.cb_TimeZone63.Name = "cb_TimeZone63";
            this.cb_TimeZone63.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone63.TabIndex = 412;
            // 
            // cb_TimeZone62
            // 
            this.cb_TimeZone62.FormattingEnabled = true;
            this.cb_TimeZone62.Location = new System.Drawing.Point(220, 105);
            this.cb_TimeZone62.Name = "cb_TimeZone62";
            this.cb_TimeZone62.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone62.TabIndex = 411;
            // 
            // cb_TimeZone61
            // 
            this.cb_TimeZone61.FormattingEnabled = true;
            this.cb_TimeZone61.Location = new System.Drawing.Point(220, 55);
            this.cb_TimeZone61.Name = "cb_TimeZone61";
            this.cb_TimeZone61.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone61.TabIndex = 410;
            // 
            // skinLabel71
            // 
            this.skinLabel71.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel71.AutoSize = true;
            this.skinLabel71.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel71.BorderColor = System.Drawing.Color.White;
            this.skinLabel71.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel71.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel71.Location = new System.Drawing.Point(60, 505);
            this.skinLabel71.Name = "skinLabel71";
            this.skinLabel71.Size = new System.Drawing.Size(69, 19);
            this.skinLabel71.TabIndex = 409;
            this.skinLabel71.Text = "时区30：";
            // 
            // skinLabel72
            // 
            this.skinLabel72.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel72.AutoSize = true;
            this.skinLabel72.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel72.BorderColor = System.Drawing.Color.White;
            this.skinLabel72.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel72.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel72.Location = new System.Drawing.Point(60, 455);
            this.skinLabel72.Name = "skinLabel72";
            this.skinLabel72.Size = new System.Drawing.Size(69, 19);
            this.skinLabel72.TabIndex = 408;
            this.skinLabel72.Text = "时区29：";
            // 
            // skinLabel73
            // 
            this.skinLabel73.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel73.AutoSize = true;
            this.skinLabel73.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel73.BorderColor = System.Drawing.Color.White;
            this.skinLabel73.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel73.Location = new System.Drawing.Point(60, 405);
            this.skinLabel73.Name = "skinLabel73";
            this.skinLabel73.Size = new System.Drawing.Size(69, 19);
            this.skinLabel73.TabIndex = 407;
            this.skinLabel73.Text = "时区28：";
            // 
            // skinLabel74
            // 
            this.skinLabel74.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel74.AutoSize = true;
            this.skinLabel74.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel74.BorderColor = System.Drawing.Color.White;
            this.skinLabel74.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel74.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel74.Location = new System.Drawing.Point(60, 355);
            this.skinLabel74.Name = "skinLabel74";
            this.skinLabel74.Size = new System.Drawing.Size(69, 19);
            this.skinLabel74.TabIndex = 406;
            this.skinLabel74.Text = "时区27：";
            // 
            // skinLabel75
            // 
            this.skinLabel75.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel75.AutoSize = true;
            this.skinLabel75.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel75.BorderColor = System.Drawing.Color.White;
            this.skinLabel75.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel75.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel75.Location = new System.Drawing.Point(60, 305);
            this.skinLabel75.Name = "skinLabel75";
            this.skinLabel75.Size = new System.Drawing.Size(69, 19);
            this.skinLabel75.TabIndex = 405;
            this.skinLabel75.Text = "时区26：";
            // 
            // skinLabel76
            // 
            this.skinLabel76.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel76.AutoSize = true;
            this.skinLabel76.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel76.BorderColor = System.Drawing.Color.White;
            this.skinLabel76.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel76.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel76.Location = new System.Drawing.Point(60, 255);
            this.skinLabel76.Name = "skinLabel76";
            this.skinLabel76.Size = new System.Drawing.Size(69, 19);
            this.skinLabel76.TabIndex = 404;
            this.skinLabel76.Text = "时区25：";
            // 
            // skinLabel77
            // 
            this.skinLabel77.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel77.AutoSize = true;
            this.skinLabel77.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel77.BorderColor = System.Drawing.Color.White;
            this.skinLabel77.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel77.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel77.Location = new System.Drawing.Point(60, 205);
            this.skinLabel77.Name = "skinLabel77";
            this.skinLabel77.Size = new System.Drawing.Size(69, 19);
            this.skinLabel77.TabIndex = 403;
            this.skinLabel77.Text = "时区24：";
            // 
            // skinLabel78
            // 
            this.skinLabel78.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel78.AutoSize = true;
            this.skinLabel78.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel78.BorderColor = System.Drawing.Color.White;
            this.skinLabel78.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel78.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel78.Location = new System.Drawing.Point(60, 155);
            this.skinLabel78.Name = "skinLabel78";
            this.skinLabel78.Size = new System.Drawing.Size(69, 19);
            this.skinLabel78.TabIndex = 402;
            this.skinLabel78.Text = "时区23：";
            // 
            // skinLabel79
            // 
            this.skinLabel79.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel79.AutoSize = true;
            this.skinLabel79.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel79.BorderColor = System.Drawing.Color.White;
            this.skinLabel79.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel79.Location = new System.Drawing.Point(60, 105);
            this.skinLabel79.Name = "skinLabel79";
            this.skinLabel79.Size = new System.Drawing.Size(69, 19);
            this.skinLabel79.TabIndex = 401;
            this.skinLabel79.Text = "时区22：";
            // 
            // skinLabel80
            // 
            this.skinLabel80.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel80.AutoSize = true;
            this.skinLabel80.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel80.BorderColor = System.Drawing.Color.White;
            this.skinLabel80.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel80.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel80.Location = new System.Drawing.Point(60, 55);
            this.skinLabel80.Name = "skinLabel80";
            this.skinLabel80.Size = new System.Drawing.Size(69, 19);
            this.skinLabel80.TabIndex = 400;
            this.skinLabel80.Text = "时区21：";
            // 
            // timezone4
            // 
            this.timezone4.Controls.Add(this.skinLabel81);
            this.timezone4.Controls.Add(this.skinLabel82);
            this.timezone4.Controls.Add(this.skinLabel83);
            this.timezone4.Controls.Add(this.skinLabel84);
            this.timezone4.Controls.Add(this.cb_TimeZone120);
            this.timezone4.Controls.Add(this.cb_TimeZone119);
            this.timezone4.Controls.Add(this.cb_TimeZone118);
            this.timezone4.Controls.Add(this.cb_TimeZone117);
            this.timezone4.Controls.Add(this.cb_TimeZone116);
            this.timezone4.Controls.Add(this.cb_TimeZone115);
            this.timezone4.Controls.Add(this.cb_TimeZone114);
            this.timezone4.Controls.Add(this.cb_TimeZone113);
            this.timezone4.Controls.Add(this.cb_TimeZone112);
            this.timezone4.Controls.Add(this.cb_TimeZone111);
            this.timezone4.Controls.Add(this.cb_TimeZone110);
            this.timezone4.Controls.Add(this.cb_TimeZone109);
            this.timezone4.Controls.Add(this.cb_TimeZone108);
            this.timezone4.Controls.Add(this.cb_TimeZone107);
            this.timezone4.Controls.Add(this.cb_TimeZone106);
            this.timezone4.Controls.Add(this.cb_TimeZone105);
            this.timezone4.Controls.Add(this.cb_TimeZone104);
            this.timezone4.Controls.Add(this.cb_TimeZone103);
            this.timezone4.Controls.Add(this.cb_TimeZone102);
            this.timezone4.Controls.Add(this.cb_TimeZone101);
            this.timezone4.Controls.Add(this.cb_TimeZone100);
            this.timezone4.Controls.Add(this.cb_TimeZone99);
            this.timezone4.Controls.Add(this.cb_TimeZone98);
            this.timezone4.Controls.Add(this.cb_TimeZone97);
            this.timezone4.Controls.Add(this.cb_TimeZone96);
            this.timezone4.Controls.Add(this.cb_TimeZone95);
            this.timezone4.Controls.Add(this.cb_TimeZone94);
            this.timezone4.Controls.Add(this.cb_TimeZone93);
            this.timezone4.Controls.Add(this.cb_TimeZone92);
            this.timezone4.Controls.Add(this.cb_TimeZone91);
            this.timezone4.Controls.Add(this.skinLabel85);
            this.timezone4.Controls.Add(this.skinLabel86);
            this.timezone4.Controls.Add(this.skinLabel87);
            this.timezone4.Controls.Add(this.skinLabel88);
            this.timezone4.Controls.Add(this.skinLabel89);
            this.timezone4.Controls.Add(this.skinLabel90);
            this.timezone4.Controls.Add(this.skinLabel91);
            this.timezone4.Controls.Add(this.skinLabel92);
            this.timezone4.Controls.Add(this.skinLabel93);
            this.timezone4.Controls.Add(this.skinLabel94);
            this.timezone4.Location = new System.Drawing.Point(0, 36);
            this.timezone4.Name = "timezone4";
            this.timezone4.Size = new System.Drawing.Size(1018, 543);
            this.timezone4.TabIndex = 3;
            this.timezone4.Text = "[31,40]";
            this.timezone4.UseVisualStyleBackColor = true;
            // 
            // skinLabel81
            // 
            this.skinLabel81.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel81.AutoSize = true;
            this.skinLabel81.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel81.BorderColor = System.Drawing.Color.White;
            this.skinLabel81.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel81.ForeColor = System.Drawing.Color.Red;
            this.skinLabel81.Location = new System.Drawing.Point(60, 20);
            this.skinLabel81.Name = "skinLabel81";
            this.skinLabel81.Size = new System.Drawing.Size(68, 16);
            this.skinLabel81.TabIndex = 488;
            this.skinLabel81.Text = "时区序号";
            // 
            // skinLabel82
            // 
            this.skinLabel82.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel82.AutoSize = true;
            this.skinLabel82.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel82.BorderColor = System.Drawing.Color.White;
            this.skinLabel82.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel82.ForeColor = System.Drawing.Color.Red;
            this.skinLabel82.Location = new System.Drawing.Point(812, 20);
            this.skinLabel82.Name = "skinLabel82";
            this.skinLabel82.Size = new System.Drawing.Size(68, 16);
            this.skinLabel82.TabIndex = 487;
            this.skinLabel82.Text = "时间段三";
            // 
            // skinLabel83
            // 
            this.skinLabel83.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel83.AutoSize = true;
            this.skinLabel83.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel83.BorderColor = System.Drawing.Color.White;
            this.skinLabel83.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel83.ForeColor = System.Drawing.Color.Red;
            this.skinLabel83.Location = new System.Drawing.Point(515, 20);
            this.skinLabel83.Name = "skinLabel83";
            this.skinLabel83.Size = new System.Drawing.Size(68, 16);
            this.skinLabel83.TabIndex = 486;
            this.skinLabel83.Text = "时间段二";
            // 
            // skinLabel84
            // 
            this.skinLabel84.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel84.AutoSize = true;
            this.skinLabel84.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel84.BorderColor = System.Drawing.Color.White;
            this.skinLabel84.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel84.ForeColor = System.Drawing.Color.Red;
            this.skinLabel84.Location = new System.Drawing.Point(250, 20);
            this.skinLabel84.Name = "skinLabel84";
            this.skinLabel84.Size = new System.Drawing.Size(68, 16);
            this.skinLabel84.TabIndex = 485;
            this.skinLabel84.Text = "时间段一";
            // 
            // cb_TimeZone120
            // 
            this.cb_TimeZone120.FormattingEnabled = true;
            this.cb_TimeZone120.Location = new System.Drawing.Point(770, 505);
            this.cb_TimeZone120.Name = "cb_TimeZone120";
            this.cb_TimeZone120.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone120.TabIndex = 484;
            // 
            // cb_TimeZone119
            // 
            this.cb_TimeZone119.FormattingEnabled = true;
            this.cb_TimeZone119.Location = new System.Drawing.Point(770, 455);
            this.cb_TimeZone119.Name = "cb_TimeZone119";
            this.cb_TimeZone119.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone119.TabIndex = 483;
            // 
            // cb_TimeZone118
            // 
            this.cb_TimeZone118.FormattingEnabled = true;
            this.cb_TimeZone118.Location = new System.Drawing.Point(770, 405);
            this.cb_TimeZone118.Name = "cb_TimeZone118";
            this.cb_TimeZone118.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone118.TabIndex = 482;
            // 
            // cb_TimeZone117
            // 
            this.cb_TimeZone117.FormattingEnabled = true;
            this.cb_TimeZone117.Location = new System.Drawing.Point(770, 355);
            this.cb_TimeZone117.Name = "cb_TimeZone117";
            this.cb_TimeZone117.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone117.TabIndex = 481;
            // 
            // cb_TimeZone116
            // 
            this.cb_TimeZone116.FormattingEnabled = true;
            this.cb_TimeZone116.Location = new System.Drawing.Point(770, 305);
            this.cb_TimeZone116.Name = "cb_TimeZone116";
            this.cb_TimeZone116.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone116.TabIndex = 480;
            // 
            // cb_TimeZone115
            // 
            this.cb_TimeZone115.FormattingEnabled = true;
            this.cb_TimeZone115.Location = new System.Drawing.Point(770, 255);
            this.cb_TimeZone115.Name = "cb_TimeZone115";
            this.cb_TimeZone115.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone115.TabIndex = 479;
            // 
            // cb_TimeZone114
            // 
            this.cb_TimeZone114.FormattingEnabled = true;
            this.cb_TimeZone114.Location = new System.Drawing.Point(770, 205);
            this.cb_TimeZone114.Name = "cb_TimeZone114";
            this.cb_TimeZone114.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone114.TabIndex = 478;
            // 
            // cb_TimeZone113
            // 
            this.cb_TimeZone113.FormattingEnabled = true;
            this.cb_TimeZone113.Location = new System.Drawing.Point(770, 155);
            this.cb_TimeZone113.Name = "cb_TimeZone113";
            this.cb_TimeZone113.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone113.TabIndex = 477;
            // 
            // cb_TimeZone112
            // 
            this.cb_TimeZone112.FormattingEnabled = true;
            this.cb_TimeZone112.Location = new System.Drawing.Point(770, 105);
            this.cb_TimeZone112.Name = "cb_TimeZone112";
            this.cb_TimeZone112.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone112.TabIndex = 476;
            // 
            // cb_TimeZone111
            // 
            this.cb_TimeZone111.FormattingEnabled = true;
            this.cb_TimeZone111.Location = new System.Drawing.Point(770, 55);
            this.cb_TimeZone111.Name = "cb_TimeZone111";
            this.cb_TimeZone111.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone111.TabIndex = 475;
            // 
            // cb_TimeZone110
            // 
            this.cb_TimeZone110.FormattingEnabled = true;
            this.cb_TimeZone110.Location = new System.Drawing.Point(480, 505);
            this.cb_TimeZone110.Name = "cb_TimeZone110";
            this.cb_TimeZone110.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone110.TabIndex = 474;
            // 
            // cb_TimeZone109
            // 
            this.cb_TimeZone109.FormattingEnabled = true;
            this.cb_TimeZone109.Location = new System.Drawing.Point(480, 455);
            this.cb_TimeZone109.Name = "cb_TimeZone109";
            this.cb_TimeZone109.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone109.TabIndex = 473;
            // 
            // cb_TimeZone108
            // 
            this.cb_TimeZone108.FormattingEnabled = true;
            this.cb_TimeZone108.Location = new System.Drawing.Point(480, 405);
            this.cb_TimeZone108.Name = "cb_TimeZone108";
            this.cb_TimeZone108.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone108.TabIndex = 472;
            // 
            // cb_TimeZone107
            // 
            this.cb_TimeZone107.FormattingEnabled = true;
            this.cb_TimeZone107.Location = new System.Drawing.Point(480, 355);
            this.cb_TimeZone107.Name = "cb_TimeZone107";
            this.cb_TimeZone107.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone107.TabIndex = 471;
            // 
            // cb_TimeZone106
            // 
            this.cb_TimeZone106.FormattingEnabled = true;
            this.cb_TimeZone106.Location = new System.Drawing.Point(480, 305);
            this.cb_TimeZone106.Name = "cb_TimeZone106";
            this.cb_TimeZone106.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone106.TabIndex = 470;
            // 
            // cb_TimeZone105
            // 
            this.cb_TimeZone105.FormattingEnabled = true;
            this.cb_TimeZone105.Location = new System.Drawing.Point(480, 255);
            this.cb_TimeZone105.Name = "cb_TimeZone105";
            this.cb_TimeZone105.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone105.TabIndex = 469;
            // 
            // cb_TimeZone104
            // 
            this.cb_TimeZone104.FormattingEnabled = true;
            this.cb_TimeZone104.Location = new System.Drawing.Point(480, 205);
            this.cb_TimeZone104.Name = "cb_TimeZone104";
            this.cb_TimeZone104.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone104.TabIndex = 468;
            // 
            // cb_TimeZone103
            // 
            this.cb_TimeZone103.FormattingEnabled = true;
            this.cb_TimeZone103.Location = new System.Drawing.Point(480, 155);
            this.cb_TimeZone103.Name = "cb_TimeZone103";
            this.cb_TimeZone103.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone103.TabIndex = 467;
            // 
            // cb_TimeZone102
            // 
            this.cb_TimeZone102.FormattingEnabled = true;
            this.cb_TimeZone102.Location = new System.Drawing.Point(480, 105);
            this.cb_TimeZone102.Name = "cb_TimeZone102";
            this.cb_TimeZone102.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone102.TabIndex = 466;
            // 
            // cb_TimeZone101
            // 
            this.cb_TimeZone101.FormattingEnabled = true;
            this.cb_TimeZone101.Location = new System.Drawing.Point(480, 55);
            this.cb_TimeZone101.Name = "cb_TimeZone101";
            this.cb_TimeZone101.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone101.TabIndex = 465;
            // 
            // cb_TimeZone100
            // 
            this.cb_TimeZone100.FormattingEnabled = true;
            this.cb_TimeZone100.Location = new System.Drawing.Point(220, 505);
            this.cb_TimeZone100.Name = "cb_TimeZone100";
            this.cb_TimeZone100.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone100.TabIndex = 464;
            // 
            // cb_TimeZone99
            // 
            this.cb_TimeZone99.FormattingEnabled = true;
            this.cb_TimeZone99.Location = new System.Drawing.Point(220, 455);
            this.cb_TimeZone99.Name = "cb_TimeZone99";
            this.cb_TimeZone99.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone99.TabIndex = 463;
            // 
            // cb_TimeZone98
            // 
            this.cb_TimeZone98.FormattingEnabled = true;
            this.cb_TimeZone98.Location = new System.Drawing.Point(220, 405);
            this.cb_TimeZone98.Name = "cb_TimeZone98";
            this.cb_TimeZone98.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone98.TabIndex = 462;
            // 
            // cb_TimeZone97
            // 
            this.cb_TimeZone97.FormattingEnabled = true;
            this.cb_TimeZone97.Location = new System.Drawing.Point(220, 355);
            this.cb_TimeZone97.Name = "cb_TimeZone97";
            this.cb_TimeZone97.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone97.TabIndex = 461;
            // 
            // cb_TimeZone96
            // 
            this.cb_TimeZone96.FormattingEnabled = true;
            this.cb_TimeZone96.Location = new System.Drawing.Point(220, 305);
            this.cb_TimeZone96.Name = "cb_TimeZone96";
            this.cb_TimeZone96.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone96.TabIndex = 460;
            // 
            // cb_TimeZone95
            // 
            this.cb_TimeZone95.FormattingEnabled = true;
            this.cb_TimeZone95.Location = new System.Drawing.Point(220, 255);
            this.cb_TimeZone95.Name = "cb_TimeZone95";
            this.cb_TimeZone95.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone95.TabIndex = 459;
            // 
            // cb_TimeZone94
            // 
            this.cb_TimeZone94.FormattingEnabled = true;
            this.cb_TimeZone94.Location = new System.Drawing.Point(220, 205);
            this.cb_TimeZone94.Name = "cb_TimeZone94";
            this.cb_TimeZone94.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone94.TabIndex = 458;
            // 
            // cb_TimeZone93
            // 
            this.cb_TimeZone93.FormattingEnabled = true;
            this.cb_TimeZone93.Location = new System.Drawing.Point(220, 155);
            this.cb_TimeZone93.Name = "cb_TimeZone93";
            this.cb_TimeZone93.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone93.TabIndex = 457;
            // 
            // cb_TimeZone92
            // 
            this.cb_TimeZone92.FormattingEnabled = true;
            this.cb_TimeZone92.Location = new System.Drawing.Point(220, 105);
            this.cb_TimeZone92.Name = "cb_TimeZone92";
            this.cb_TimeZone92.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone92.TabIndex = 456;
            // 
            // cb_TimeZone91
            // 
            this.cb_TimeZone91.FormattingEnabled = true;
            this.cb_TimeZone91.Location = new System.Drawing.Point(220, 55);
            this.cb_TimeZone91.Name = "cb_TimeZone91";
            this.cb_TimeZone91.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone91.TabIndex = 455;
            // 
            // skinLabel85
            // 
            this.skinLabel85.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel85.AutoSize = true;
            this.skinLabel85.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel85.BorderColor = System.Drawing.Color.White;
            this.skinLabel85.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel85.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel85.Location = new System.Drawing.Point(60, 505);
            this.skinLabel85.Name = "skinLabel85";
            this.skinLabel85.Size = new System.Drawing.Size(69, 19);
            this.skinLabel85.TabIndex = 454;
            this.skinLabel85.Text = "时区40：";
            // 
            // skinLabel86
            // 
            this.skinLabel86.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel86.AutoSize = true;
            this.skinLabel86.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel86.BorderColor = System.Drawing.Color.White;
            this.skinLabel86.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel86.Location = new System.Drawing.Point(60, 455);
            this.skinLabel86.Name = "skinLabel86";
            this.skinLabel86.Size = new System.Drawing.Size(69, 19);
            this.skinLabel86.TabIndex = 453;
            this.skinLabel86.Text = "时区39：";
            // 
            // skinLabel87
            // 
            this.skinLabel87.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel87.AutoSize = true;
            this.skinLabel87.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel87.BorderColor = System.Drawing.Color.White;
            this.skinLabel87.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel87.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel87.Location = new System.Drawing.Point(60, 405);
            this.skinLabel87.Name = "skinLabel87";
            this.skinLabel87.Size = new System.Drawing.Size(69, 19);
            this.skinLabel87.TabIndex = 452;
            this.skinLabel87.Text = "时区38：";
            // 
            // skinLabel88
            // 
            this.skinLabel88.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel88.AutoSize = true;
            this.skinLabel88.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel88.BorderColor = System.Drawing.Color.White;
            this.skinLabel88.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel88.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel88.Location = new System.Drawing.Point(60, 355);
            this.skinLabel88.Name = "skinLabel88";
            this.skinLabel88.Size = new System.Drawing.Size(69, 19);
            this.skinLabel88.TabIndex = 451;
            this.skinLabel88.Text = "时区37：";
            // 
            // skinLabel89
            // 
            this.skinLabel89.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel89.AutoSize = true;
            this.skinLabel89.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel89.BorderColor = System.Drawing.Color.White;
            this.skinLabel89.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel89.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel89.Location = new System.Drawing.Point(60, 305);
            this.skinLabel89.Name = "skinLabel89";
            this.skinLabel89.Size = new System.Drawing.Size(69, 19);
            this.skinLabel89.TabIndex = 450;
            this.skinLabel89.Text = "时区36：";
            // 
            // skinLabel90
            // 
            this.skinLabel90.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel90.AutoSize = true;
            this.skinLabel90.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel90.BorderColor = System.Drawing.Color.White;
            this.skinLabel90.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel90.Location = new System.Drawing.Point(60, 255);
            this.skinLabel90.Name = "skinLabel90";
            this.skinLabel90.Size = new System.Drawing.Size(69, 19);
            this.skinLabel90.TabIndex = 449;
            this.skinLabel90.Text = "时区35：";
            // 
            // skinLabel91
            // 
            this.skinLabel91.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel91.AutoSize = true;
            this.skinLabel91.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel91.BorderColor = System.Drawing.Color.White;
            this.skinLabel91.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel91.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel91.Location = new System.Drawing.Point(60, 205);
            this.skinLabel91.Name = "skinLabel91";
            this.skinLabel91.Size = new System.Drawing.Size(69, 19);
            this.skinLabel91.TabIndex = 448;
            this.skinLabel91.Text = "时区34：";
            // 
            // skinLabel92
            // 
            this.skinLabel92.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel92.AutoSize = true;
            this.skinLabel92.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel92.BorderColor = System.Drawing.Color.White;
            this.skinLabel92.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel92.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel92.Location = new System.Drawing.Point(60, 155);
            this.skinLabel92.Name = "skinLabel92";
            this.skinLabel92.Size = new System.Drawing.Size(69, 19);
            this.skinLabel92.TabIndex = 447;
            this.skinLabel92.Text = "时区33：";
            // 
            // skinLabel93
            // 
            this.skinLabel93.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel93.AutoSize = true;
            this.skinLabel93.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel93.BorderColor = System.Drawing.Color.White;
            this.skinLabel93.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel93.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel93.Location = new System.Drawing.Point(60, 105);
            this.skinLabel93.Name = "skinLabel93";
            this.skinLabel93.Size = new System.Drawing.Size(69, 19);
            this.skinLabel93.TabIndex = 446;
            this.skinLabel93.Text = "时区32：";
            // 
            // skinLabel94
            // 
            this.skinLabel94.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel94.AutoSize = true;
            this.skinLabel94.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel94.BorderColor = System.Drawing.Color.White;
            this.skinLabel94.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel94.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel94.Location = new System.Drawing.Point(60, 55);
            this.skinLabel94.Name = "skinLabel94";
            this.skinLabel94.Size = new System.Drawing.Size(69, 19);
            this.skinLabel94.TabIndex = 445;
            this.skinLabel94.Text = "时区31：";
            // 
            // timezone5
            // 
            this.timezone5.Controls.Add(this.skinLabel95);
            this.timezone5.Controls.Add(this.skinLabel96);
            this.timezone5.Controls.Add(this.skinLabel97);
            this.timezone5.Controls.Add(this.skinLabel98);
            this.timezone5.Controls.Add(this.cb_TimeZone150);
            this.timezone5.Controls.Add(this.cb_TimeZone149);
            this.timezone5.Controls.Add(this.cb_TimeZone148);
            this.timezone5.Controls.Add(this.cb_TimeZone147);
            this.timezone5.Controls.Add(this.cb_TimeZone146);
            this.timezone5.Controls.Add(this.cb_TimeZone145);
            this.timezone5.Controls.Add(this.cb_TimeZone144);
            this.timezone5.Controls.Add(this.cb_TimeZone143);
            this.timezone5.Controls.Add(this.cb_TimeZone142);
            this.timezone5.Controls.Add(this.cb_TimeZone141);
            this.timezone5.Controls.Add(this.cb_TimeZone140);
            this.timezone5.Controls.Add(this.cb_TimeZone139);
            this.timezone5.Controls.Add(this.cb_TimeZone138);
            this.timezone5.Controls.Add(this.cb_TimeZone137);
            this.timezone5.Controls.Add(this.cb_TimeZone136);
            this.timezone5.Controls.Add(this.cb_TimeZone135);
            this.timezone5.Controls.Add(this.cb_TimeZone134);
            this.timezone5.Controls.Add(this.cb_TimeZone133);
            this.timezone5.Controls.Add(this.cb_TimeZone132);
            this.timezone5.Controls.Add(this.cb_TimeZone131);
            this.timezone5.Controls.Add(this.cb_TimeZone130);
            this.timezone5.Controls.Add(this.cb_TimeZone129);
            this.timezone5.Controls.Add(this.cb_TimeZone128);
            this.timezone5.Controls.Add(this.cb_TimeZone127);
            this.timezone5.Controls.Add(this.cb_TimeZone126);
            this.timezone5.Controls.Add(this.cb_TimeZone125);
            this.timezone5.Controls.Add(this.cb_TimeZone124);
            this.timezone5.Controls.Add(this.cb_TimeZone123);
            this.timezone5.Controls.Add(this.cb_TimeZone122);
            this.timezone5.Controls.Add(this.cb_TimeZone121);
            this.timezone5.Controls.Add(this.skinLabel99);
            this.timezone5.Controls.Add(this.skinLabel100);
            this.timezone5.Controls.Add(this.skinLabel101);
            this.timezone5.Controls.Add(this.skinLabel102);
            this.timezone5.Controls.Add(this.skinLabel103);
            this.timezone5.Controls.Add(this.skinLabel104);
            this.timezone5.Controls.Add(this.skinLabel105);
            this.timezone5.Controls.Add(this.skinLabel106);
            this.timezone5.Controls.Add(this.skinLabel107);
            this.timezone5.Controls.Add(this.skinLabel108);
            this.timezone5.Location = new System.Drawing.Point(0, 36);
            this.timezone5.Name = "timezone5";
            this.timezone5.Size = new System.Drawing.Size(1018, 543);
            this.timezone5.TabIndex = 4;
            this.timezone5.Text = "[41,50]";
            this.timezone5.UseVisualStyleBackColor = true;
            // 
            // skinLabel95
            // 
            this.skinLabel95.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel95.AutoSize = true;
            this.skinLabel95.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel95.BorderColor = System.Drawing.Color.White;
            this.skinLabel95.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel95.ForeColor = System.Drawing.Color.Red;
            this.skinLabel95.Location = new System.Drawing.Point(60, 20);
            this.skinLabel95.Name = "skinLabel95";
            this.skinLabel95.Size = new System.Drawing.Size(68, 16);
            this.skinLabel95.TabIndex = 488;
            this.skinLabel95.Text = "时区序号";
            // 
            // skinLabel96
            // 
            this.skinLabel96.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel96.AutoSize = true;
            this.skinLabel96.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel96.BorderColor = System.Drawing.Color.White;
            this.skinLabel96.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel96.ForeColor = System.Drawing.Color.Red;
            this.skinLabel96.Location = new System.Drawing.Point(812, 20);
            this.skinLabel96.Name = "skinLabel96";
            this.skinLabel96.Size = new System.Drawing.Size(68, 16);
            this.skinLabel96.TabIndex = 487;
            this.skinLabel96.Text = "时间段三";
            // 
            // skinLabel97
            // 
            this.skinLabel97.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel97.AutoSize = true;
            this.skinLabel97.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel97.BorderColor = System.Drawing.Color.White;
            this.skinLabel97.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel97.ForeColor = System.Drawing.Color.Red;
            this.skinLabel97.Location = new System.Drawing.Point(515, 20);
            this.skinLabel97.Name = "skinLabel97";
            this.skinLabel97.Size = new System.Drawing.Size(68, 16);
            this.skinLabel97.TabIndex = 486;
            this.skinLabel97.Text = "时间段二";
            // 
            // skinLabel98
            // 
            this.skinLabel98.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel98.AutoSize = true;
            this.skinLabel98.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel98.BorderColor = System.Drawing.Color.White;
            this.skinLabel98.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel98.ForeColor = System.Drawing.Color.Red;
            this.skinLabel98.Location = new System.Drawing.Point(250, 20);
            this.skinLabel98.Name = "skinLabel98";
            this.skinLabel98.Size = new System.Drawing.Size(68, 16);
            this.skinLabel98.TabIndex = 485;
            this.skinLabel98.Text = "时间段一";
            // 
            // cb_TimeZone150
            // 
            this.cb_TimeZone150.FormattingEnabled = true;
            this.cb_TimeZone150.Location = new System.Drawing.Point(770, 505);
            this.cb_TimeZone150.Name = "cb_TimeZone150";
            this.cb_TimeZone150.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone150.TabIndex = 484;
            // 
            // cb_TimeZone149
            // 
            this.cb_TimeZone149.FormattingEnabled = true;
            this.cb_TimeZone149.Location = new System.Drawing.Point(770, 455);
            this.cb_TimeZone149.Name = "cb_TimeZone149";
            this.cb_TimeZone149.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone149.TabIndex = 483;
            // 
            // cb_TimeZone148
            // 
            this.cb_TimeZone148.FormattingEnabled = true;
            this.cb_TimeZone148.Location = new System.Drawing.Point(770, 405);
            this.cb_TimeZone148.Name = "cb_TimeZone148";
            this.cb_TimeZone148.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone148.TabIndex = 482;
            // 
            // cb_TimeZone147
            // 
            this.cb_TimeZone147.FormattingEnabled = true;
            this.cb_TimeZone147.Location = new System.Drawing.Point(770, 355);
            this.cb_TimeZone147.Name = "cb_TimeZone147";
            this.cb_TimeZone147.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone147.TabIndex = 481;
            // 
            // cb_TimeZone146
            // 
            this.cb_TimeZone146.FormattingEnabled = true;
            this.cb_TimeZone146.Location = new System.Drawing.Point(770, 305);
            this.cb_TimeZone146.Name = "cb_TimeZone146";
            this.cb_TimeZone146.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone146.TabIndex = 480;
            // 
            // cb_TimeZone145
            // 
            this.cb_TimeZone145.FormattingEnabled = true;
            this.cb_TimeZone145.Location = new System.Drawing.Point(770, 255);
            this.cb_TimeZone145.Name = "cb_TimeZone145";
            this.cb_TimeZone145.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone145.TabIndex = 479;
            // 
            // cb_TimeZone144
            // 
            this.cb_TimeZone144.FormattingEnabled = true;
            this.cb_TimeZone144.Location = new System.Drawing.Point(770, 205);
            this.cb_TimeZone144.Name = "cb_TimeZone144";
            this.cb_TimeZone144.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone144.TabIndex = 478;
            // 
            // cb_TimeZone143
            // 
            this.cb_TimeZone143.FormattingEnabled = true;
            this.cb_TimeZone143.Location = new System.Drawing.Point(770, 155);
            this.cb_TimeZone143.Name = "cb_TimeZone143";
            this.cb_TimeZone143.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone143.TabIndex = 477;
            // 
            // cb_TimeZone142
            // 
            this.cb_TimeZone142.FormattingEnabled = true;
            this.cb_TimeZone142.Location = new System.Drawing.Point(770, 105);
            this.cb_TimeZone142.Name = "cb_TimeZone142";
            this.cb_TimeZone142.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone142.TabIndex = 476;
            // 
            // cb_TimeZone141
            // 
            this.cb_TimeZone141.FormattingEnabled = true;
            this.cb_TimeZone141.Location = new System.Drawing.Point(770, 55);
            this.cb_TimeZone141.Name = "cb_TimeZone141";
            this.cb_TimeZone141.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone141.TabIndex = 475;
            // 
            // cb_TimeZone140
            // 
            this.cb_TimeZone140.FormattingEnabled = true;
            this.cb_TimeZone140.Location = new System.Drawing.Point(480, 505);
            this.cb_TimeZone140.Name = "cb_TimeZone140";
            this.cb_TimeZone140.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone140.TabIndex = 474;
            // 
            // cb_TimeZone139
            // 
            this.cb_TimeZone139.FormattingEnabled = true;
            this.cb_TimeZone139.Location = new System.Drawing.Point(480, 455);
            this.cb_TimeZone139.Name = "cb_TimeZone139";
            this.cb_TimeZone139.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone139.TabIndex = 473;
            // 
            // cb_TimeZone138
            // 
            this.cb_TimeZone138.FormattingEnabled = true;
            this.cb_TimeZone138.Location = new System.Drawing.Point(480, 405);
            this.cb_TimeZone138.Name = "cb_TimeZone138";
            this.cb_TimeZone138.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone138.TabIndex = 472;
            // 
            // cb_TimeZone137
            // 
            this.cb_TimeZone137.FormattingEnabled = true;
            this.cb_TimeZone137.Location = new System.Drawing.Point(480, 355);
            this.cb_TimeZone137.Name = "cb_TimeZone137";
            this.cb_TimeZone137.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone137.TabIndex = 471;
            // 
            // cb_TimeZone136
            // 
            this.cb_TimeZone136.FormattingEnabled = true;
            this.cb_TimeZone136.Location = new System.Drawing.Point(480, 305);
            this.cb_TimeZone136.Name = "cb_TimeZone136";
            this.cb_TimeZone136.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone136.TabIndex = 470;
            // 
            // cb_TimeZone135
            // 
            this.cb_TimeZone135.FormattingEnabled = true;
            this.cb_TimeZone135.Location = new System.Drawing.Point(480, 255);
            this.cb_TimeZone135.Name = "cb_TimeZone135";
            this.cb_TimeZone135.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone135.TabIndex = 469;
            // 
            // cb_TimeZone134
            // 
            this.cb_TimeZone134.FormattingEnabled = true;
            this.cb_TimeZone134.Location = new System.Drawing.Point(480, 205);
            this.cb_TimeZone134.Name = "cb_TimeZone134";
            this.cb_TimeZone134.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone134.TabIndex = 468;
            // 
            // cb_TimeZone133
            // 
            this.cb_TimeZone133.FormattingEnabled = true;
            this.cb_TimeZone133.Location = new System.Drawing.Point(480, 155);
            this.cb_TimeZone133.Name = "cb_TimeZone133";
            this.cb_TimeZone133.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone133.TabIndex = 467;
            // 
            // cb_TimeZone132
            // 
            this.cb_TimeZone132.FormattingEnabled = true;
            this.cb_TimeZone132.Location = new System.Drawing.Point(480, 105);
            this.cb_TimeZone132.Name = "cb_TimeZone132";
            this.cb_TimeZone132.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone132.TabIndex = 466;
            // 
            // cb_TimeZone131
            // 
            this.cb_TimeZone131.FormattingEnabled = true;
            this.cb_TimeZone131.Location = new System.Drawing.Point(480, 55);
            this.cb_TimeZone131.Name = "cb_TimeZone131";
            this.cb_TimeZone131.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone131.TabIndex = 465;
            // 
            // cb_TimeZone130
            // 
            this.cb_TimeZone130.FormattingEnabled = true;
            this.cb_TimeZone130.Location = new System.Drawing.Point(220, 505);
            this.cb_TimeZone130.Name = "cb_TimeZone130";
            this.cb_TimeZone130.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone130.TabIndex = 464;
            // 
            // cb_TimeZone129
            // 
            this.cb_TimeZone129.FormattingEnabled = true;
            this.cb_TimeZone129.Location = new System.Drawing.Point(220, 455);
            this.cb_TimeZone129.Name = "cb_TimeZone129";
            this.cb_TimeZone129.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone129.TabIndex = 463;
            // 
            // cb_TimeZone128
            // 
            this.cb_TimeZone128.FormattingEnabled = true;
            this.cb_TimeZone128.Location = new System.Drawing.Point(220, 405);
            this.cb_TimeZone128.Name = "cb_TimeZone128";
            this.cb_TimeZone128.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone128.TabIndex = 462;
            // 
            // cb_TimeZone127
            // 
            this.cb_TimeZone127.FormattingEnabled = true;
            this.cb_TimeZone127.Location = new System.Drawing.Point(220, 355);
            this.cb_TimeZone127.Name = "cb_TimeZone127";
            this.cb_TimeZone127.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone127.TabIndex = 461;
            // 
            // cb_TimeZone126
            // 
            this.cb_TimeZone126.FormattingEnabled = true;
            this.cb_TimeZone126.Location = new System.Drawing.Point(220, 305);
            this.cb_TimeZone126.Name = "cb_TimeZone126";
            this.cb_TimeZone126.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone126.TabIndex = 460;
            // 
            // cb_TimeZone125
            // 
            this.cb_TimeZone125.FormattingEnabled = true;
            this.cb_TimeZone125.Location = new System.Drawing.Point(220, 255);
            this.cb_TimeZone125.Name = "cb_TimeZone125";
            this.cb_TimeZone125.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone125.TabIndex = 459;
            // 
            // cb_TimeZone124
            // 
            this.cb_TimeZone124.FormattingEnabled = true;
            this.cb_TimeZone124.Location = new System.Drawing.Point(220, 205);
            this.cb_TimeZone124.Name = "cb_TimeZone124";
            this.cb_TimeZone124.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone124.TabIndex = 458;
            // 
            // cb_TimeZone123
            // 
            this.cb_TimeZone123.FormattingEnabled = true;
            this.cb_TimeZone123.Location = new System.Drawing.Point(220, 155);
            this.cb_TimeZone123.Name = "cb_TimeZone123";
            this.cb_TimeZone123.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone123.TabIndex = 457;
            // 
            // cb_TimeZone122
            // 
            this.cb_TimeZone122.FormattingEnabled = true;
            this.cb_TimeZone122.Location = new System.Drawing.Point(220, 105);
            this.cb_TimeZone122.Name = "cb_TimeZone122";
            this.cb_TimeZone122.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone122.TabIndex = 456;
            // 
            // cb_TimeZone121
            // 
            this.cb_TimeZone121.FormattingEnabled = true;
            this.cb_TimeZone121.Location = new System.Drawing.Point(220, 55);
            this.cb_TimeZone121.Name = "cb_TimeZone121";
            this.cb_TimeZone121.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone121.TabIndex = 455;
            // 
            // skinLabel99
            // 
            this.skinLabel99.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel99.AutoSize = true;
            this.skinLabel99.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel99.BorderColor = System.Drawing.Color.White;
            this.skinLabel99.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel99.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel99.Location = new System.Drawing.Point(60, 505);
            this.skinLabel99.Name = "skinLabel99";
            this.skinLabel99.Size = new System.Drawing.Size(69, 19);
            this.skinLabel99.TabIndex = 454;
            this.skinLabel99.Text = "时区50：";
            // 
            // skinLabel100
            // 
            this.skinLabel100.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel100.AutoSize = true;
            this.skinLabel100.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel100.BorderColor = System.Drawing.Color.White;
            this.skinLabel100.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel100.Location = new System.Drawing.Point(60, 455);
            this.skinLabel100.Name = "skinLabel100";
            this.skinLabel100.Size = new System.Drawing.Size(69, 19);
            this.skinLabel100.TabIndex = 453;
            this.skinLabel100.Text = "时区49：";
            // 
            // skinLabel101
            // 
            this.skinLabel101.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel101.AutoSize = true;
            this.skinLabel101.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel101.BorderColor = System.Drawing.Color.White;
            this.skinLabel101.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel101.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel101.Location = new System.Drawing.Point(60, 405);
            this.skinLabel101.Name = "skinLabel101";
            this.skinLabel101.Size = new System.Drawing.Size(69, 19);
            this.skinLabel101.TabIndex = 452;
            this.skinLabel101.Text = "时区48：";
            // 
            // skinLabel102
            // 
            this.skinLabel102.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel102.AutoSize = true;
            this.skinLabel102.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel102.BorderColor = System.Drawing.Color.White;
            this.skinLabel102.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel102.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel102.Location = new System.Drawing.Point(60, 355);
            this.skinLabel102.Name = "skinLabel102";
            this.skinLabel102.Size = new System.Drawing.Size(69, 19);
            this.skinLabel102.TabIndex = 451;
            this.skinLabel102.Text = "时区47：";
            // 
            // skinLabel103
            // 
            this.skinLabel103.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel103.AutoSize = true;
            this.skinLabel103.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel103.BorderColor = System.Drawing.Color.White;
            this.skinLabel103.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel103.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel103.Location = new System.Drawing.Point(60, 305);
            this.skinLabel103.Name = "skinLabel103";
            this.skinLabel103.Size = new System.Drawing.Size(69, 19);
            this.skinLabel103.TabIndex = 450;
            this.skinLabel103.Text = "时区46：";
            // 
            // skinLabel104
            // 
            this.skinLabel104.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel104.AutoSize = true;
            this.skinLabel104.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel104.BorderColor = System.Drawing.Color.White;
            this.skinLabel104.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel104.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel104.Location = new System.Drawing.Point(60, 255);
            this.skinLabel104.Name = "skinLabel104";
            this.skinLabel104.Size = new System.Drawing.Size(69, 19);
            this.skinLabel104.TabIndex = 449;
            this.skinLabel104.Text = "时区45：";
            // 
            // skinLabel105
            // 
            this.skinLabel105.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel105.AutoSize = true;
            this.skinLabel105.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel105.BorderColor = System.Drawing.Color.White;
            this.skinLabel105.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel105.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel105.Location = new System.Drawing.Point(60, 205);
            this.skinLabel105.Name = "skinLabel105";
            this.skinLabel105.Size = new System.Drawing.Size(69, 19);
            this.skinLabel105.TabIndex = 448;
            this.skinLabel105.Text = "时区44：";
            // 
            // skinLabel106
            // 
            this.skinLabel106.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel106.AutoSize = true;
            this.skinLabel106.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel106.BorderColor = System.Drawing.Color.White;
            this.skinLabel106.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel106.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel106.Location = new System.Drawing.Point(60, 155);
            this.skinLabel106.Name = "skinLabel106";
            this.skinLabel106.Size = new System.Drawing.Size(69, 19);
            this.skinLabel106.TabIndex = 447;
            this.skinLabel106.Text = "时区43：";
            // 
            // skinLabel107
            // 
            this.skinLabel107.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel107.AutoSize = true;
            this.skinLabel107.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel107.BorderColor = System.Drawing.Color.White;
            this.skinLabel107.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel107.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel107.Location = new System.Drawing.Point(60, 105);
            this.skinLabel107.Name = "skinLabel107";
            this.skinLabel107.Size = new System.Drawing.Size(69, 19);
            this.skinLabel107.TabIndex = 446;
            this.skinLabel107.Text = "时区42：";
            // 
            // skinLabel108
            // 
            this.skinLabel108.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel108.AutoSize = true;
            this.skinLabel108.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel108.BorderColor = System.Drawing.Color.White;
            this.skinLabel108.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel108.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel108.Location = new System.Drawing.Point(60, 55);
            this.skinLabel108.Name = "skinLabel108";
            this.skinLabel108.Size = new System.Drawing.Size(69, 19);
            this.skinLabel108.TabIndex = 445;
            this.skinLabel108.Text = "时区41：";
            // 
            // timezone6
            // 
            this.timezone6.Controls.Add(this.skinLabel109);
            this.timezone6.Controls.Add(this.skinLabel110);
            this.timezone6.Controls.Add(this.skinLabel111);
            this.timezone6.Controls.Add(this.skinLabel112);
            this.timezone6.Controls.Add(this.cb_TimeZone180);
            this.timezone6.Controls.Add(this.cb_TimeZone179);
            this.timezone6.Controls.Add(this.cb_TimeZone178);
            this.timezone6.Controls.Add(this.cb_TimeZone177);
            this.timezone6.Controls.Add(this.cb_TimeZone176);
            this.timezone6.Controls.Add(this.cb_TimeZone175);
            this.timezone6.Controls.Add(this.cb_TimeZone174);
            this.timezone6.Controls.Add(this.cb_TimeZone173);
            this.timezone6.Controls.Add(this.cb_TimeZone172);
            this.timezone6.Controls.Add(this.cb_TimeZone171);
            this.timezone6.Controls.Add(this.cb_TimeZone170);
            this.timezone6.Controls.Add(this.cb_TimeZone169);
            this.timezone6.Controls.Add(this.cb_TimeZone168);
            this.timezone6.Controls.Add(this.cb_TimeZone167);
            this.timezone6.Controls.Add(this.cb_TimeZone166);
            this.timezone6.Controls.Add(this.cb_TimeZone165);
            this.timezone6.Controls.Add(this.cb_TimeZone164);
            this.timezone6.Controls.Add(this.cb_TimeZone163);
            this.timezone6.Controls.Add(this.cb_TimeZone162);
            this.timezone6.Controls.Add(this.cb_TimeZone161);
            this.timezone6.Controls.Add(this.cb_TimeZone160);
            this.timezone6.Controls.Add(this.cb_TimeZone159);
            this.timezone6.Controls.Add(this.cb_TimeZone158);
            this.timezone6.Controls.Add(this.cb_TimeZone157);
            this.timezone6.Controls.Add(this.cb_TimeZone156);
            this.timezone6.Controls.Add(this.cb_TimeZone155);
            this.timezone6.Controls.Add(this.cb_TimeZone154);
            this.timezone6.Controls.Add(this.cb_TimeZone153);
            this.timezone6.Controls.Add(this.cb_TimeZone152);
            this.timezone6.Controls.Add(this.cb_TimeZone151);
            this.timezone6.Controls.Add(this.skinLabel113);
            this.timezone6.Controls.Add(this.skinLabel114);
            this.timezone6.Controls.Add(this.skinLabel115);
            this.timezone6.Controls.Add(this.skinLabel116);
            this.timezone6.Controls.Add(this.skinLabel117);
            this.timezone6.Controls.Add(this.skinLabel118);
            this.timezone6.Controls.Add(this.skinLabel119);
            this.timezone6.Controls.Add(this.skinLabel120);
            this.timezone6.Controls.Add(this.skinLabel121);
            this.timezone6.Controls.Add(this.skinLabel122);
            this.timezone6.Location = new System.Drawing.Point(0, 36);
            this.timezone6.Name = "timezone6";
            this.timezone6.Size = new System.Drawing.Size(1018, 543);
            this.timezone6.TabIndex = 5;
            this.timezone6.Text = "[51,60]";
            this.timezone6.UseVisualStyleBackColor = true;
            // 
            // skinLabel109
            // 
            this.skinLabel109.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel109.AutoSize = true;
            this.skinLabel109.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel109.BorderColor = System.Drawing.Color.White;
            this.skinLabel109.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel109.ForeColor = System.Drawing.Color.Red;
            this.skinLabel109.Location = new System.Drawing.Point(60, 20);
            this.skinLabel109.Name = "skinLabel109";
            this.skinLabel109.Size = new System.Drawing.Size(68, 16);
            this.skinLabel109.TabIndex = 488;
            this.skinLabel109.Text = "时区序号";
            // 
            // skinLabel110
            // 
            this.skinLabel110.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel110.AutoSize = true;
            this.skinLabel110.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel110.BorderColor = System.Drawing.Color.White;
            this.skinLabel110.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinLabel110.ForeColor = System.Drawing.Color.Red;
            this.skinLabel110.Location = new System.Drawing.Point(812, 20);
            this.skinLabel110.Name = "skinLabel110";
            this.skinLabel110.Size = new System.Drawing.Size(68, 16);
            this.skinLabel110.TabIndex = 487;
            this.skinLabel110.Text = "时间段三";
            // 
            // skinLabel111
            // 
            this.skinLabel111.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel111.AutoSize = true;
            this.skinLabel111.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel111.BorderColor = System.Drawing.Color.White;
            this.skinLabel111.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel111.ForeColor = System.Drawing.Color.Red;
            this.skinLabel111.Location = new System.Drawing.Point(515, 20);
            this.skinLabel111.Name = "skinLabel111";
            this.skinLabel111.Size = new System.Drawing.Size(68, 16);
            this.skinLabel111.TabIndex = 486;
            this.skinLabel111.Text = "时间段二";
            // 
            // skinLabel112
            // 
            this.skinLabel112.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel112.AutoSize = true;
            this.skinLabel112.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel112.BorderColor = System.Drawing.Color.White;
            this.skinLabel112.Font = new System.Drawing.Font("华文楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel112.ForeColor = System.Drawing.Color.Red;
            this.skinLabel112.Location = new System.Drawing.Point(250, 20);
            this.skinLabel112.Name = "skinLabel112";
            this.skinLabel112.Size = new System.Drawing.Size(68, 16);
            this.skinLabel112.TabIndex = 485;
            this.skinLabel112.Text = "时间段一";
            // 
            // cb_TimeZone180
            // 
            this.cb_TimeZone180.FormattingEnabled = true;
            this.cb_TimeZone180.Location = new System.Drawing.Point(770, 505);
            this.cb_TimeZone180.Name = "cb_TimeZone180";
            this.cb_TimeZone180.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone180.TabIndex = 484;
            // 
            // cb_TimeZone179
            // 
            this.cb_TimeZone179.FormattingEnabled = true;
            this.cb_TimeZone179.Location = new System.Drawing.Point(770, 455);
            this.cb_TimeZone179.Name = "cb_TimeZone179";
            this.cb_TimeZone179.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone179.TabIndex = 483;
            // 
            // cb_TimeZone178
            // 
            this.cb_TimeZone178.FormattingEnabled = true;
            this.cb_TimeZone178.Location = new System.Drawing.Point(770, 405);
            this.cb_TimeZone178.Name = "cb_TimeZone178";
            this.cb_TimeZone178.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone178.TabIndex = 482;
            // 
            // cb_TimeZone177
            // 
            this.cb_TimeZone177.FormattingEnabled = true;
            this.cb_TimeZone177.Location = new System.Drawing.Point(770, 355);
            this.cb_TimeZone177.Name = "cb_TimeZone177";
            this.cb_TimeZone177.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone177.TabIndex = 481;
            // 
            // cb_TimeZone176
            // 
            this.cb_TimeZone176.FormattingEnabled = true;
            this.cb_TimeZone176.Location = new System.Drawing.Point(770, 305);
            this.cb_TimeZone176.Name = "cb_TimeZone176";
            this.cb_TimeZone176.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone176.TabIndex = 480;
            // 
            // cb_TimeZone175
            // 
            this.cb_TimeZone175.FormattingEnabled = true;
            this.cb_TimeZone175.Location = new System.Drawing.Point(770, 255);
            this.cb_TimeZone175.Name = "cb_TimeZone175";
            this.cb_TimeZone175.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone175.TabIndex = 479;
            // 
            // cb_TimeZone174
            // 
            this.cb_TimeZone174.FormattingEnabled = true;
            this.cb_TimeZone174.Location = new System.Drawing.Point(770, 205);
            this.cb_TimeZone174.Name = "cb_TimeZone174";
            this.cb_TimeZone174.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone174.TabIndex = 478;
            // 
            // cb_TimeZone173
            // 
            this.cb_TimeZone173.FormattingEnabled = true;
            this.cb_TimeZone173.Location = new System.Drawing.Point(770, 155);
            this.cb_TimeZone173.Name = "cb_TimeZone173";
            this.cb_TimeZone173.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone173.TabIndex = 477;
            // 
            // cb_TimeZone172
            // 
            this.cb_TimeZone172.FormattingEnabled = true;
            this.cb_TimeZone172.Location = new System.Drawing.Point(770, 105);
            this.cb_TimeZone172.Name = "cb_TimeZone172";
            this.cb_TimeZone172.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone172.TabIndex = 476;
            // 
            // cb_TimeZone171
            // 
            this.cb_TimeZone171.FormattingEnabled = true;
            this.cb_TimeZone171.Location = new System.Drawing.Point(770, 55);
            this.cb_TimeZone171.Name = "cb_TimeZone171";
            this.cb_TimeZone171.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone171.TabIndex = 475;
            // 
            // cb_TimeZone170
            // 
            this.cb_TimeZone170.FormattingEnabled = true;
            this.cb_TimeZone170.Location = new System.Drawing.Point(480, 505);
            this.cb_TimeZone170.Name = "cb_TimeZone170";
            this.cb_TimeZone170.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone170.TabIndex = 474;
            // 
            // cb_TimeZone169
            // 
            this.cb_TimeZone169.FormattingEnabled = true;
            this.cb_TimeZone169.Location = new System.Drawing.Point(480, 455);
            this.cb_TimeZone169.Name = "cb_TimeZone169";
            this.cb_TimeZone169.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone169.TabIndex = 473;
            // 
            // cb_TimeZone168
            // 
            this.cb_TimeZone168.FormattingEnabled = true;
            this.cb_TimeZone168.Location = new System.Drawing.Point(480, 405);
            this.cb_TimeZone168.Name = "cb_TimeZone168";
            this.cb_TimeZone168.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone168.TabIndex = 472;
            // 
            // cb_TimeZone167
            // 
            this.cb_TimeZone167.FormattingEnabled = true;
            this.cb_TimeZone167.Location = new System.Drawing.Point(480, 355);
            this.cb_TimeZone167.Name = "cb_TimeZone167";
            this.cb_TimeZone167.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone167.TabIndex = 471;
            // 
            // cb_TimeZone166
            // 
            this.cb_TimeZone166.FormattingEnabled = true;
            this.cb_TimeZone166.Location = new System.Drawing.Point(480, 305);
            this.cb_TimeZone166.Name = "cb_TimeZone166";
            this.cb_TimeZone166.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone166.TabIndex = 470;
            // 
            // cb_TimeZone165
            // 
            this.cb_TimeZone165.FormattingEnabled = true;
            this.cb_TimeZone165.Location = new System.Drawing.Point(480, 255);
            this.cb_TimeZone165.Name = "cb_TimeZone165";
            this.cb_TimeZone165.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone165.TabIndex = 469;
            // 
            // cb_TimeZone164
            // 
            this.cb_TimeZone164.FormattingEnabled = true;
            this.cb_TimeZone164.Location = new System.Drawing.Point(480, 205);
            this.cb_TimeZone164.Name = "cb_TimeZone164";
            this.cb_TimeZone164.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone164.TabIndex = 468;
            // 
            // cb_TimeZone163
            // 
            this.cb_TimeZone163.FormattingEnabled = true;
            this.cb_TimeZone163.Location = new System.Drawing.Point(480, 155);
            this.cb_TimeZone163.Name = "cb_TimeZone163";
            this.cb_TimeZone163.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone163.TabIndex = 467;
            // 
            // cb_TimeZone162
            // 
            this.cb_TimeZone162.FormattingEnabled = true;
            this.cb_TimeZone162.Location = new System.Drawing.Point(480, 105);
            this.cb_TimeZone162.Name = "cb_TimeZone162";
            this.cb_TimeZone162.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone162.TabIndex = 466;
            // 
            // cb_TimeZone161
            // 
            this.cb_TimeZone161.FormattingEnabled = true;
            this.cb_TimeZone161.Location = new System.Drawing.Point(480, 55);
            this.cb_TimeZone161.Name = "cb_TimeZone161";
            this.cb_TimeZone161.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone161.TabIndex = 465;
            // 
            // cb_TimeZone160
            // 
            this.cb_TimeZone160.FormattingEnabled = true;
            this.cb_TimeZone160.Location = new System.Drawing.Point(220, 505);
            this.cb_TimeZone160.Name = "cb_TimeZone160";
            this.cb_TimeZone160.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone160.TabIndex = 464;
            // 
            // cb_TimeZone159
            // 
            this.cb_TimeZone159.FormattingEnabled = true;
            this.cb_TimeZone159.Location = new System.Drawing.Point(220, 455);
            this.cb_TimeZone159.Name = "cb_TimeZone159";
            this.cb_TimeZone159.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone159.TabIndex = 463;
            // 
            // cb_TimeZone158
            // 
            this.cb_TimeZone158.FormattingEnabled = true;
            this.cb_TimeZone158.Location = new System.Drawing.Point(220, 405);
            this.cb_TimeZone158.Name = "cb_TimeZone158";
            this.cb_TimeZone158.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone158.TabIndex = 462;
            // 
            // cb_TimeZone157
            // 
            this.cb_TimeZone157.FormattingEnabled = true;
            this.cb_TimeZone157.Location = new System.Drawing.Point(220, 355);
            this.cb_TimeZone157.Name = "cb_TimeZone157";
            this.cb_TimeZone157.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone157.TabIndex = 461;
            // 
            // cb_TimeZone156
            // 
            this.cb_TimeZone156.FormattingEnabled = true;
            this.cb_TimeZone156.Location = new System.Drawing.Point(220, 305);
            this.cb_TimeZone156.Name = "cb_TimeZone156";
            this.cb_TimeZone156.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone156.TabIndex = 460;
            // 
            // cb_TimeZone155
            // 
            this.cb_TimeZone155.FormattingEnabled = true;
            this.cb_TimeZone155.Location = new System.Drawing.Point(220, 255);
            this.cb_TimeZone155.Name = "cb_TimeZone155";
            this.cb_TimeZone155.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone155.TabIndex = 459;
            // 
            // cb_TimeZone154
            // 
            this.cb_TimeZone154.FormattingEnabled = true;
            this.cb_TimeZone154.Location = new System.Drawing.Point(220, 205);
            this.cb_TimeZone154.Name = "cb_TimeZone154";
            this.cb_TimeZone154.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone154.TabIndex = 458;
            // 
            // cb_TimeZone153
            // 
            this.cb_TimeZone153.FormattingEnabled = true;
            this.cb_TimeZone153.Location = new System.Drawing.Point(220, 155);
            this.cb_TimeZone153.Name = "cb_TimeZone153";
            this.cb_TimeZone153.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone153.TabIndex = 457;
            // 
            // cb_TimeZone152
            // 
            this.cb_TimeZone152.FormattingEnabled = true;
            this.cb_TimeZone152.Location = new System.Drawing.Point(220, 105);
            this.cb_TimeZone152.Name = "cb_TimeZone152";
            this.cb_TimeZone152.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone152.TabIndex = 456;
            // 
            // cb_TimeZone151
            // 
            this.cb_TimeZone151.FormattingEnabled = true;
            this.cb_TimeZone151.Location = new System.Drawing.Point(220, 55);
            this.cb_TimeZone151.Name = "cb_TimeZone151";
            this.cb_TimeZone151.Size = new System.Drawing.Size(200, 25);
            this.cb_TimeZone151.TabIndex = 455;
            // 
            // skinLabel113
            // 
            this.skinLabel113.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel113.AutoSize = true;
            this.skinLabel113.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel113.BorderColor = System.Drawing.Color.White;
            this.skinLabel113.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel113.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel113.Location = new System.Drawing.Point(60, 505);
            this.skinLabel113.Name = "skinLabel113";
            this.skinLabel113.Size = new System.Drawing.Size(69, 19);
            this.skinLabel113.TabIndex = 454;
            this.skinLabel113.Text = "时区60：";
            // 
            // skinLabel114
            // 
            this.skinLabel114.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel114.AutoSize = true;
            this.skinLabel114.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel114.BorderColor = System.Drawing.Color.White;
            this.skinLabel114.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel114.Location = new System.Drawing.Point(60, 455);
            this.skinLabel114.Name = "skinLabel114";
            this.skinLabel114.Size = new System.Drawing.Size(69, 19);
            this.skinLabel114.TabIndex = 453;
            this.skinLabel114.Text = "时区59：";
            // 
            // skinLabel115
            // 
            this.skinLabel115.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel115.AutoSize = true;
            this.skinLabel115.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel115.BorderColor = System.Drawing.Color.White;
            this.skinLabel115.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel115.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel115.Location = new System.Drawing.Point(60, 405);
            this.skinLabel115.Name = "skinLabel115";
            this.skinLabel115.Size = new System.Drawing.Size(69, 19);
            this.skinLabel115.TabIndex = 452;
            this.skinLabel115.Text = "时区58：";
            // 
            // skinLabel116
            // 
            this.skinLabel116.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel116.AutoSize = true;
            this.skinLabel116.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel116.BorderColor = System.Drawing.Color.White;
            this.skinLabel116.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel116.Location = new System.Drawing.Point(60, 355);
            this.skinLabel116.Name = "skinLabel116";
            this.skinLabel116.Size = new System.Drawing.Size(69, 19);
            this.skinLabel116.TabIndex = 451;
            this.skinLabel116.Text = "时区57：";
            // 
            // skinLabel117
            // 
            this.skinLabel117.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel117.AutoSize = true;
            this.skinLabel117.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel117.BorderColor = System.Drawing.Color.White;
            this.skinLabel117.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel117.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel117.Location = new System.Drawing.Point(60, 305);
            this.skinLabel117.Name = "skinLabel117";
            this.skinLabel117.Size = new System.Drawing.Size(69, 19);
            this.skinLabel117.TabIndex = 450;
            this.skinLabel117.Text = "时区56：";
            // 
            // skinLabel118
            // 
            this.skinLabel118.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel118.AutoSize = true;
            this.skinLabel118.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel118.BorderColor = System.Drawing.Color.White;
            this.skinLabel118.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel118.Location = new System.Drawing.Point(60, 255);
            this.skinLabel118.Name = "skinLabel118";
            this.skinLabel118.Size = new System.Drawing.Size(69, 19);
            this.skinLabel118.TabIndex = 449;
            this.skinLabel118.Text = "时区55：";
            // 
            // skinLabel119
            // 
            this.skinLabel119.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel119.AutoSize = true;
            this.skinLabel119.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel119.BorderColor = System.Drawing.Color.White;
            this.skinLabel119.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel119.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel119.Location = new System.Drawing.Point(60, 205);
            this.skinLabel119.Name = "skinLabel119";
            this.skinLabel119.Size = new System.Drawing.Size(69, 19);
            this.skinLabel119.TabIndex = 448;
            this.skinLabel119.Text = "时区54：";
            // 
            // skinLabel120
            // 
            this.skinLabel120.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel120.AutoSize = true;
            this.skinLabel120.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel120.BorderColor = System.Drawing.Color.White;
            this.skinLabel120.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel120.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel120.Location = new System.Drawing.Point(60, 155);
            this.skinLabel120.Name = "skinLabel120";
            this.skinLabel120.Size = new System.Drawing.Size(69, 19);
            this.skinLabel120.TabIndex = 447;
            this.skinLabel120.Text = "时区53：";
            // 
            // skinLabel121
            // 
            this.skinLabel121.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel121.AutoSize = true;
            this.skinLabel121.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel121.BorderColor = System.Drawing.Color.White;
            this.skinLabel121.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel121.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel121.Location = new System.Drawing.Point(60, 105);
            this.skinLabel121.Name = "skinLabel121";
            this.skinLabel121.Size = new System.Drawing.Size(69, 19);
            this.skinLabel121.TabIndex = 446;
            this.skinLabel121.Text = "时区52：";
            // 
            // skinLabel122
            // 
            this.skinLabel122.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel122.AutoSize = true;
            this.skinLabel122.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel122.BorderColor = System.Drawing.Color.White;
            this.skinLabel122.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel122.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel122.Location = new System.Drawing.Point(60, 55);
            this.skinLabel122.Name = "skinLabel122";
            this.skinLabel122.Size = new System.Drawing.Size(69, 19);
            this.skinLabel122.TabIndex = 445;
            this.skinLabel122.Text = "时区51：";
            // 
            // btn_Save1
            // 
            this.btn_Save1.BackColor = System.Drawing.Color.White;
            this.btn_Save1.BaseColor = System.Drawing.Color.White;
            this.btn_Save1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Save1.DownBack = null;
            this.btn_Save1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Save1.ForeColor = System.Drawing.Color.Black;
            this.btn_Save1.Location = new System.Drawing.Point(854, 575);
            this.btn_Save1.MouseBack = null;
            this.btn_Save1.Name = "btn_Save1";
            this.btn_Save1.NormlBack = null;
            this.btn_Save1.Size = new System.Drawing.Size(159, 40);
            this.btn_Save1.TabIndex = 299;
            this.btn_Save1.Text = "保存并同步";
            this.btn_Save1.UseVisualStyleBackColor = false;
            this.btn_Save1.Click += new System.EventHandler(this.btn_Save1_Click);
            // 
            // tp_doorRange
            // 
            this.tp_doorRange.BackColor = System.Drawing.Color.White;
            this.tp_doorRange.Controls.Add(this.dgv_Door_Range_Data);
            this.tp_doorRange.Controls.Add(this.btn_Del_DoorRange);
            this.tp_doorRange.Controls.Add(this.btn_Update_DoorRange);
            this.tp_doorRange.Controls.Add(this.btn_Add_DoorRange);
            this.tp_doorRange.Controls.Add(this.txt_Search_DoorRange);
            this.tp_doorRange.Controls.Add(this.btn_Door_Range_Search);
            this.tp_doorRange.Controls.Add(this.skinLabel5);
            this.tp_doorRange.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_doorRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_doorRange.Location = new System.Drawing.Point(0, 30);
            this.tp_doorRange.Margin = new System.Windows.Forms.Padding(0);
            this.tp_doorRange.Name = "tp_doorRange";
            this.tp_doorRange.Size = new System.Drawing.Size(200, 0);
            this.tp_doorRange.TabIndex = 0;
            this.tp_doorRange.Text = "门通行计划";
            // 
            // dgv_Door_Range_Data
            // 
            this.dgv_Door_Range_Data.AllowUserToAddRows = false;
            this.dgv_Door_Range_Data.AllowUserToDeleteRows = false;
            this.dgv_Door_Range_Data.AllowUserToOrderColumns = true;
            this.dgv_Door_Range_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Door_Range_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn35});
            this.dgv_Door_Range_Data.Location = new System.Drawing.Point(6, 46);
            this.dgv_Door_Range_Data.MultiSelect = false;
            this.dgv_Door_Range_Data.Name = "dgv_Door_Range_Data";
            this.dgv_Door_Range_Data.ReadOnly = true;
            this.dgv_Door_Range_Data.RowTemplate.Height = 23;
            this.dgv_Door_Range_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Door_Range_Data.Size = new System.Drawing.Size(1007, 533);
            this.dgv_Door_Range_Data.TabIndex = 54;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn29.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 150;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "TimeRange_Name";
            this.dataGridViewTextBoxColumn30.HeaderText = "时间段名称";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 180;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn35.HeaderText = "备注";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 300;
            // 
            // btn_Del_DoorRange
            // 
            this.btn_Del_DoorRange.BackColor = System.Drawing.Color.White;
            this.btn_Del_DoorRange.BaseColor = System.Drawing.Color.White;
            this.btn_Del_DoorRange.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Del_DoorRange.DownBack = null;
            this.btn_Del_DoorRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Del_DoorRange.ForeColor = System.Drawing.Color.Black;
            this.btn_Del_DoorRange.Location = new System.Drawing.Point(909, 588);
            this.btn_Del_DoorRange.MouseBack = null;
            this.btn_Del_DoorRange.Name = "btn_Del_DoorRange";
            this.btn_Del_DoorRange.NormlBack = null;
            this.btn_Del_DoorRange.Size = new System.Drawing.Size(83, 35);
            this.btn_Del_DoorRange.TabIndex = 53;
            this.btn_Del_DoorRange.Text = "删除";
            this.btn_Del_DoorRange.UseVisualStyleBackColor = false;
            this.btn_Del_DoorRange.Click += new System.EventHandler(this.btn_Del_DoorRange_Click);
            // 
            // btn_Update_DoorRange
            // 
            this.btn_Update_DoorRange.BackColor = System.Drawing.Color.White;
            this.btn_Update_DoorRange.BaseColor = System.Drawing.Color.White;
            this.btn_Update_DoorRange.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Update_DoorRange.DownBack = null;
            this.btn_Update_DoorRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update_DoorRange.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_DoorRange.Location = new System.Drawing.Point(799, 588);
            this.btn_Update_DoorRange.MouseBack = null;
            this.btn_Update_DoorRange.Name = "btn_Update_DoorRange";
            this.btn_Update_DoorRange.NormlBack = null;
            this.btn_Update_DoorRange.Size = new System.Drawing.Size(83, 35);
            this.btn_Update_DoorRange.TabIndex = 52;
            this.btn_Update_DoorRange.Text = "修改";
            this.btn_Update_DoorRange.UseVisualStyleBackColor = false;
            this.btn_Update_DoorRange.Click += new System.EventHandler(this.btn_Update_DoorRange_Click);
            // 
            // btn_Add_DoorRange
            // 
            this.btn_Add_DoorRange.BackColor = System.Drawing.Color.White;
            this.btn_Add_DoorRange.BaseColor = System.Drawing.Color.White;
            this.btn_Add_DoorRange.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Add_DoorRange.DownBack = null;
            this.btn_Add_DoorRange.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add_DoorRange.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_DoorRange.Location = new System.Drawing.Point(669, 588);
            this.btn_Add_DoorRange.MouseBack = null;
            this.btn_Add_DoorRange.Name = "btn_Add_DoorRange";
            this.btn_Add_DoorRange.NormlBack = null;
            this.btn_Add_DoorRange.Size = new System.Drawing.Size(83, 35);
            this.btn_Add_DoorRange.TabIndex = 51;
            this.btn_Add_DoorRange.Text = "增加";
            this.btn_Add_DoorRange.UseVisualStyleBackColor = false;
            this.btn_Add_DoorRange.Click += new System.EventHandler(this.btn_Add_DoorRange_Click);
            // 
            // txt_Search_DoorRange
            // 
            this.txt_Search_DoorRange.Location = new System.Drawing.Point(103, 9);
            this.txt_Search_DoorRange.Multiline = true;
            this.txt_Search_DoorRange.Name = "txt_Search_DoorRange";
            this.txt_Search_DoorRange.Size = new System.Drawing.Size(618, 29);
            this.txt_Search_DoorRange.TabIndex = 50;
            this.txt_Search_DoorRange.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Search_DoorRange.WaterText = "";
            this.txt_Search_DoorRange.MouseEnter += new System.EventHandler(this.txt_Search_DoorRange_MouseEnter);
            this.txt_Search_DoorRange.MouseLeave += new System.EventHandler(this.txt_Search_DoorRange_MouseLeave);
            // 
            // btn_Door_Range_Search
            // 
            this.btn_Door_Range_Search.BackColor = System.Drawing.Color.White;
            this.btn_Door_Range_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Door_Range_Search.BackgroundImage")));
            this.btn_Door_Range_Search.BaseColor = System.Drawing.Color.White;
            this.btn_Door_Range_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Door_Range_Search.DownBack = null;
            this.btn_Door_Range_Search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Door_Range_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Door_Range_Search.Location = new System.Drawing.Point(754, 2);
            this.btn_Door_Range_Search.MouseBack = null;
            this.btn_Door_Range_Search.Name = "btn_Door_Range_Search";
            this.btn_Door_Range_Search.NormlBack = null;
            this.btn_Door_Range_Search.Size = new System.Drawing.Size(83, 46);
            this.btn_Door_Range_Search.TabIndex = 49;
            this.btn_Door_Range_Search.Text = "查询";
            this.btn_Door_Range_Search.UseVisualStyleBackColor = false;
            this.btn_Door_Range_Search.Click += new System.EventHandler(this.btn_Door_Range_Search_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel5.Location = new System.Drawing.Point(18, 9);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(79, 19);
            this.skinLabel5.TabIndex = 48;
            this.skinLabel5.Text = "搜索条件：";
            // 
            // tp_doorHoliday
            // 
            this.tp_doorHoliday.BackColor = System.Drawing.Color.White;
            this.tp_doorHoliday.Controls.Add(this.skinButton1);
            this.tp_doorHoliday.Controls.Add(this.dgv_holiday);
            this.tp_doorHoliday.Controls.Add(this.btn_del_holiday);
            this.tp_doorHoliday.Controls.Add(this.btn_update_holiday);
            this.tp_doorHoliday.Controls.Add(this.btn_add_holiday);
            this.tp_doorHoliday.Controls.Add(this.txt_search_holiday);
            this.tp_doorHoliday.Controls.Add(this.btn_search_holiday);
            this.tp_doorHoliday.Controls.Add(this.skinLabel3);
            this.tp_doorHoliday.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_doorHoliday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_doorHoliday.Location = new System.Drawing.Point(0, 30);
            this.tp_doorHoliday.Margin = new System.Windows.Forms.Padding(0);
            this.tp_doorHoliday.Name = "tp_doorHoliday";
            this.tp_doorHoliday.Size = new System.Drawing.Size(200, 0);
            this.tp_doorHoliday.TabIndex = 1;
            this.tp_doorHoliday.Text = "门禁节假日";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.White;
            this.skinButton1.BaseColor = System.Drawing.Color.White;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.Black;
            this.skinButton1.Location = new System.Drawing.Point(22, 587);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(189, 35);
            this.skinButton1.TabIndex = 48;
            this.skinButton1.Text = "同步假日数据到设备";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // dgv_holiday
            // 
            this.dgv_holiday.AllowUserToAddRows = false;
            this.dgv_holiday.AllowUserToDeleteRows = false;
            this.dgv_holiday.AllowUserToOrderColumns = true;
            this.dgv_holiday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_holiday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.结束日期,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn21});
            this.dgv_holiday.Location = new System.Drawing.Point(6, 43);
            this.dgv_holiday.MultiSelect = false;
            this.dgv_holiday.Name = "dgv_holiday";
            this.dgv_holiday.ReadOnly = true;
            this.dgv_holiday.RowTemplate.Height = 23;
            this.dgv_holiday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_holiday.Size = new System.Drawing.Size(1007, 538);
            this.dgv_holiday.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn13.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn14.HeaderText = "节假日名称";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 120;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "holiday_name";
            this.dataGridViewTextBoxColumn15.HeaderText = "节假日类型";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 120;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "begin_date";
            this.dataGridViewTextBoxColumn16.HeaderText = "开始日期";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 120;
            // 
            // 结束日期
            // 
            this.结束日期.DataPropertyName = "end_date";
            this.结束日期.HeaderText = "结束日期";
            this.结束日期.Name = "结束日期";
            this.结束日期.ReadOnly = true;
            this.结束日期.Width = 120;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "is_cycle";
            this.dataGridViewTextBoxColumn17.HeaderText = "是否按年循环";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn21.HeaderText = "备注";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 200;
            // 
            // btn_del_holiday
            // 
            this.btn_del_holiday.BackColor = System.Drawing.Color.White;
            this.btn_del_holiday.BaseColor = System.Drawing.Color.White;
            this.btn_del_holiday.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_del_holiday.DownBack = null;
            this.btn_del_holiday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_del_holiday.ForeColor = System.Drawing.Color.Black;
            this.btn_del_holiday.Location = new System.Drawing.Point(919, 587);
            this.btn_del_holiday.MouseBack = null;
            this.btn_del_holiday.Name = "btn_del_holiday";
            this.btn_del_holiday.NormlBack = null;
            this.btn_del_holiday.Size = new System.Drawing.Size(83, 35);
            this.btn_del_holiday.TabIndex = 46;
            this.btn_del_holiday.Text = "删除";
            this.btn_del_holiday.UseVisualStyleBackColor = false;
            this.btn_del_holiday.Click += new System.EventHandler(this.btn_del_holiday_Click);
            // 
            // btn_update_holiday
            // 
            this.btn_update_holiday.BackColor = System.Drawing.Color.White;
            this.btn_update_holiday.BaseColor = System.Drawing.Color.White;
            this.btn_update_holiday.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_update_holiday.DownBack = null;
            this.btn_update_holiday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_update_holiday.ForeColor = System.Drawing.Color.Black;
            this.btn_update_holiday.Location = new System.Drawing.Point(809, 587);
            this.btn_update_holiday.MouseBack = null;
            this.btn_update_holiday.Name = "btn_update_holiday";
            this.btn_update_holiday.NormlBack = null;
            this.btn_update_holiday.Size = new System.Drawing.Size(83, 35);
            this.btn_update_holiday.TabIndex = 45;
            this.btn_update_holiday.Text = "修改";
            this.btn_update_holiday.UseVisualStyleBackColor = false;
            this.btn_update_holiday.Click += new System.EventHandler(this.btn_update_holiday_Click);
            // 
            // btn_add_holiday
            // 
            this.btn_add_holiday.BackColor = System.Drawing.Color.White;
            this.btn_add_holiday.BaseColor = System.Drawing.Color.White;
            this.btn_add_holiday.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add_holiday.DownBack = null;
            this.btn_add_holiday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_add_holiday.ForeColor = System.Drawing.Color.Black;
            this.btn_add_holiday.Location = new System.Drawing.Point(679, 587);
            this.btn_add_holiday.MouseBack = null;
            this.btn_add_holiday.Name = "btn_add_holiday";
            this.btn_add_holiday.NormlBack = null;
            this.btn_add_holiday.Size = new System.Drawing.Size(83, 35);
            this.btn_add_holiday.TabIndex = 44;
            this.btn_add_holiday.Text = "增加";
            this.btn_add_holiday.UseVisualStyleBackColor = false;
            this.btn_add_holiday.Click += new System.EventHandler(this.btn_add_holiday_Click);
            // 
            // txt_search_holiday
            // 
            this.txt_search_holiday.Location = new System.Drawing.Point(103, 6);
            this.txt_search_holiday.Multiline = true;
            this.txt_search_holiday.Name = "txt_search_holiday";
            this.txt_search_holiday.Size = new System.Drawing.Size(618, 29);
            this.txt_search_holiday.TabIndex = 43;
            this.txt_search_holiday.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_search_holiday.WaterText = "";
            this.txt_search_holiday.MouseEnter += new System.EventHandler(this.txt_search_holiday_MouseEnter);
            this.txt_search_holiday.MouseLeave += new System.EventHandler(this.txt_search_holiday_MouseLeave);
            // 
            // btn_search_holiday
            // 
            this.btn_search_holiday.BackColor = System.Drawing.Color.White;
            this.btn_search_holiday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_holiday.BackgroundImage")));
            this.btn_search_holiday.BaseColor = System.Drawing.Color.White;
            this.btn_search_holiday.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_search_holiday.DownBack = null;
            this.btn_search_holiday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search_holiday.ForeColor = System.Drawing.Color.Black;
            this.btn_search_holiday.Location = new System.Drawing.Point(747, -1);
            this.btn_search_holiday.MouseBack = null;
            this.btn_search_holiday.Name = "btn_search_holiday";
            this.btn_search_holiday.NormlBack = null;
            this.btn_search_holiday.Size = new System.Drawing.Size(83, 46);
            this.btn_search_holiday.TabIndex = 42;
            this.btn_search_holiday.Text = "查询";
            this.btn_search_holiday.UseVisualStyleBackColor = false;
            this.btn_search_holiday.Click += new System.EventHandler(this.btn_search_holiday_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel3.Location = new System.Drawing.Point(18, 6);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(79, 19);
            this.skinLabel3.TabIndex = 41;
            this.skinLabel3.Text = "搜索条件：";
            // 
            // tp_doorInfo
            // 
            this.tp_doorInfo.BackColor = System.Drawing.Color.White;
            this.tp_doorInfo.Controls.Add(this.dgv_door_info);
            this.tp_doorInfo.Controls.Add(this.btn_Update_door);
            this.tp_doorInfo.Controls.Add(this.txt_search_doorInfo);
            this.tp_doorInfo.Controls.Add(this.btn_search_door);
            this.tp_doorInfo.Controls.Add(this.skinLabel4);
            this.tp_doorInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_doorInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_doorInfo.Location = new System.Drawing.Point(0, 30);
            this.tp_doorInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tp_doorInfo.Name = "tp_doorInfo";
            this.tp_doorInfo.Size = new System.Drawing.Size(200, 0);
            this.tp_doorInfo.TabIndex = 2;
            this.tp_doorInfo.Text = "门设置";
            // 
            // dgv_door_info
            // 
            this.dgv_door_info.AllowUserToAddRows = false;
            this.dgv_door_info.AllowUserToDeleteRows = false;
            this.dgv_door_info.AllowUserToOrderColumns = true;
            this.dgv_door_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_door_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.dgv_door_info.Location = new System.Drawing.Point(6, 46);
            this.dgv_door_info.MultiSelect = false;
            this.dgv_door_info.Name = "dgv_door_info";
            this.dgv_door_info.ReadOnly = true;
            this.dgv_door_info.RowTemplate.Height = 23;
            this.dgv_door_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_door_info.Size = new System.Drawing.Size(1007, 522);
            this.dgv_door_info.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn18.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Door_Name";
            this.dataGridViewTextBoxColumn19.HeaderText = "门名称";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 150;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Door_NO";
            this.dataGridViewTextBoxColumn20.HeaderText = "门编号";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Controller_Name";
            this.dataGridViewTextBoxColumn22.HeaderText = "控制器名称";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 150;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Is_Attendance_Record";
            this.dataGridViewTextBoxColumn24.HeaderText = "是否为考勤门";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 150;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn25.HeaderText = "备注";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 200;
            // 
            // btn_Update_door
            // 
            this.btn_Update_door.BackColor = System.Drawing.Color.White;
            this.btn_Update_door.BaseColor = System.Drawing.Color.White;
            this.btn_Update_door.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Update_door.DownBack = null;
            this.btn_Update_door.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update_door.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_door.Location = new System.Drawing.Point(875, 577);
            this.btn_Update_door.MouseBack = null;
            this.btn_Update_door.Name = "btn_Update_door";
            this.btn_Update_door.NormlBack = null;
            this.btn_Update_door.Size = new System.Drawing.Size(83, 35);
            this.btn_Update_door.TabIndex = 51;
            this.btn_Update_door.Text = "修改";
            this.btn_Update_door.UseVisualStyleBackColor = false;
            this.btn_Update_door.Click += new System.EventHandler(this.btn_Update_door_Click);
            // 
            // txt_search_doorInfo
            // 
            this.txt_search_doorInfo.Location = new System.Drawing.Point(103, 9);
            this.txt_search_doorInfo.Multiline = true;
            this.txt_search_doorInfo.Name = "txt_search_doorInfo";
            this.txt_search_doorInfo.Size = new System.Drawing.Size(750, 29);
            this.txt_search_doorInfo.TabIndex = 50;
            this.txt_search_doorInfo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_search_doorInfo.WaterText = "";
            this.txt_search_doorInfo.MouseEnter += new System.EventHandler(this.txt_search_doorInfo_MouseEnter);
            this.txt_search_doorInfo.MouseLeave += new System.EventHandler(this.txt_search_doorInfo_MouseLeave);
            // 
            // btn_search_door
            // 
            this.btn_search_door.BackColor = System.Drawing.Color.White;
            this.btn_search_door.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_door.BackgroundImage")));
            this.btn_search_door.BaseColor = System.Drawing.Color.White;
            this.btn_search_door.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_search_door.DownBack = null;
            this.btn_search_door.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search_door.ForeColor = System.Drawing.Color.Black;
            this.btn_search_door.Location = new System.Drawing.Point(875, -5);
            this.btn_search_door.MouseBack = null;
            this.btn_search_door.Name = "btn_search_door";
            this.btn_search_door.NormlBack = null;
            this.btn_search_door.Size = new System.Drawing.Size(83, 46);
            this.btn_search_door.TabIndex = 49;
            this.btn_search_door.Text = "查询";
            this.btn_search_door.UseVisualStyleBackColor = false;
            this.btn_search_door.Click += new System.EventHandler(this.btn_search_door_Click);
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel4.Location = new System.Drawing.Point(18, 9);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(79, 19);
            this.skinLabel4.TabIndex = 48;
            this.skinLabel4.Text = "搜索条件：";
            // 
            // tp_door_Right
            // 
            this.tp_door_Right.BackColor = System.Drawing.Color.White;
            this.tp_door_Right.Controls.Add(this.btn_Send_Data_DoorGroup);
            this.tp_door_Right.Controls.Add(this.dgv_Door_Right);
            this.tp_door_Right.Controls.Add(this.btn_Del_Door_Right);
            this.tp_door_Right.Controls.Add(this.btn_Update_Door_Right);
            this.tp_door_Right.Controls.Add(this.btn_Add_Door_Right);
            this.tp_door_Right.Controls.Add(this.txt_Door_Right);
            this.tp_door_Right.Controls.Add(this.btn_Door_Right_Search);
            this.tp_door_Right.Controls.Add(this.skinLabel7);
            this.tp_door_Right.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_door_Right.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_door_Right.Location = new System.Drawing.Point(0, 30);
            this.tp_door_Right.Margin = new System.Windows.Forms.Padding(0);
            this.tp_door_Right.Name = "tp_door_Right";
            this.tp_door_Right.Size = new System.Drawing.Size(200, 0);
            this.tp_door_Right.TabIndex = 3;
            this.tp_door_Right.Tag = "door_right";
            this.tp_door_Right.Text = "门禁权限组";
            // 
            // btn_Send_Data_DoorGroup
            // 
            this.btn_Send_Data_DoorGroup.BackColor = System.Drawing.Color.White;
            this.btn_Send_Data_DoorGroup.BaseColor = System.Drawing.Color.White;
            this.btn_Send_Data_DoorGroup.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Send_Data_DoorGroup.DownBack = null;
            this.btn_Send_Data_DoorGroup.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Send_Data_DoorGroup.ForeColor = System.Drawing.Color.Black;
            this.btn_Send_Data_DoorGroup.Location = new System.Drawing.Point(22, 582);
            this.btn_Send_Data_DoorGroup.MouseBack = null;
            this.btn_Send_Data_DoorGroup.Name = "btn_Send_Data_DoorGroup";
            this.btn_Send_Data_DoorGroup.NormlBack = null;
            this.btn_Send_Data_DoorGroup.Size = new System.Drawing.Size(189, 35);
            this.btn_Send_Data_DoorGroup.TabIndex = 62;
            this.btn_Send_Data_DoorGroup.Text = "同步权限组数据到设备";
            this.btn_Send_Data_DoorGroup.UseVisualStyleBackColor = false;
            this.btn_Send_Data_DoorGroup.Click += new System.EventHandler(this.btn_Send_Data_DoorGroup_Click);
            // 
            // dgv_Door_Right
            // 
            this.dgv_Door_Right.AllowUserToAddRows = false;
            this.dgv_Door_Right.AllowUserToDeleteRows = false;
            this.dgv_Door_Right.AllowUserToOrderColumns = true;
            this.dgv_Door_Right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Door_Right.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.门禁时间段,
            this.dataGridViewTextBoxColumn28,
            this.人员组合});
            this.dgv_Door_Right.Location = new System.Drawing.Point(6, 46);
            this.dgv_Door_Right.MultiSelect = false;
            this.dgv_Door_Right.Name = "dgv_Door_Right";
            this.dgv_Door_Right.ReadOnly = true;
            this.dgv_Door_Right.RowTemplate.Height = 23;
            this.dgv_Door_Right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Door_Right.Size = new System.Drawing.Size(1007, 533);
            this.dgv_Door_Right.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn26.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 140;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Group_Name";
            this.dataGridViewTextBoxColumn27.HeaderText = "权限组名称";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 150;
            // 
            // 门禁时间段
            // 
            this.门禁时间段.DataPropertyName = "TimeRange_Name";
            this.门禁时间段.HeaderText = "门禁时间段";
            this.门禁时间段.Name = "门禁时间段";
            this.门禁时间段.ReadOnly = true;
            this.门禁时间段.Width = 150;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "door_names";
            this.dataGridViewTextBoxColumn28.HeaderText = "门组合";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 280;
            // 
            // 人员组合
            // 
            this.人员组合.DataPropertyName = "Person_Names";
            this.人员组合.HeaderText = "人员组合";
            this.人员组合.Name = "人员组合";
            this.人员组合.ReadOnly = true;
            this.人员组合.Width = 280;
            // 
            // btn_Del_Door_Right
            // 
            this.btn_Del_Door_Right.BackColor = System.Drawing.Color.White;
            this.btn_Del_Door_Right.BaseColor = System.Drawing.Color.White;
            this.btn_Del_Door_Right.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Del_Door_Right.DownBack = null;
            this.btn_Del_Door_Right.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Del_Door_Right.ForeColor = System.Drawing.Color.Black;
            this.btn_Del_Door_Right.Location = new System.Drawing.Point(913, 582);
            this.btn_Del_Door_Right.MouseBack = null;
            this.btn_Del_Door_Right.Name = "btn_Del_Door_Right";
            this.btn_Del_Door_Right.NormlBack = null;
            this.btn_Del_Door_Right.Size = new System.Drawing.Size(83, 35);
            this.btn_Del_Door_Right.TabIndex = 60;
            this.btn_Del_Door_Right.Text = "删除";
            this.btn_Del_Door_Right.UseVisualStyleBackColor = false;
            this.btn_Del_Door_Right.Click += new System.EventHandler(this.btn_Del_Door_Right_Click);
            // 
            // btn_Update_Door_Right
            // 
            this.btn_Update_Door_Right.BackColor = System.Drawing.Color.White;
            this.btn_Update_Door_Right.BaseColor = System.Drawing.Color.White;
            this.btn_Update_Door_Right.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Update_Door_Right.DownBack = null;
            this.btn_Update_Door_Right.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update_Door_Right.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_Door_Right.Location = new System.Drawing.Point(803, 582);
            this.btn_Update_Door_Right.MouseBack = null;
            this.btn_Update_Door_Right.Name = "btn_Update_Door_Right";
            this.btn_Update_Door_Right.NormlBack = null;
            this.btn_Update_Door_Right.Size = new System.Drawing.Size(83, 35);
            this.btn_Update_Door_Right.TabIndex = 59;
            this.btn_Update_Door_Right.Text = "修改";
            this.btn_Update_Door_Right.UseVisualStyleBackColor = false;
            this.btn_Update_Door_Right.Click += new System.EventHandler(this.btn_Update_Door_Right_Click);
            // 
            // btn_Add_Door_Right
            // 
            this.btn_Add_Door_Right.BackColor = System.Drawing.Color.White;
            this.btn_Add_Door_Right.BaseColor = System.Drawing.Color.White;
            this.btn_Add_Door_Right.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Add_Door_Right.DownBack = null;
            this.btn_Add_Door_Right.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add_Door_Right.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Door_Right.Location = new System.Drawing.Point(673, 582);
            this.btn_Add_Door_Right.MouseBack = null;
            this.btn_Add_Door_Right.Name = "btn_Add_Door_Right";
            this.btn_Add_Door_Right.NormlBack = null;
            this.btn_Add_Door_Right.Size = new System.Drawing.Size(83, 35);
            this.btn_Add_Door_Right.TabIndex = 58;
            this.btn_Add_Door_Right.Text = "增加";
            this.btn_Add_Door_Right.UseVisualStyleBackColor = false;
            this.btn_Add_Door_Right.Click += new System.EventHandler(this.btn_Add_Door_Right_Click);
            // 
            // txt_Door_Right
            // 
            this.txt_Door_Right.Location = new System.Drawing.Point(103, 9);
            this.txt_Door_Right.Multiline = true;
            this.txt_Door_Right.Name = "txt_Door_Right";
            this.txt_Door_Right.Size = new System.Drawing.Size(694, 29);
            this.txt_Door_Right.TabIndex = 57;
            this.txt_Door_Right.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Door_Right.WaterText = "";
            this.txt_Door_Right.MouseEnter += new System.EventHandler(this.txt_Door_Right_MouseEnter);
            this.txt_Door_Right.MouseLeave += new System.EventHandler(this.txt_Door_Right_MouseLeave);
            // 
            // btn_Door_Right_Search
            // 
            this.btn_Door_Right_Search.BackColor = System.Drawing.Color.White;
            this.btn_Door_Right_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Door_Right_Search.BackgroundImage")));
            this.btn_Door_Right_Search.BaseColor = System.Drawing.Color.White;
            this.btn_Door_Right_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Door_Right_Search.DownBack = null;
            this.btn_Door_Right_Search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Door_Right_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Door_Right_Search.Location = new System.Drawing.Point(803, 0);
            this.btn_Door_Right_Search.MouseBack = null;
            this.btn_Door_Right_Search.Name = "btn_Door_Right_Search";
            this.btn_Door_Right_Search.NormlBack = null;
            this.btn_Door_Right_Search.Size = new System.Drawing.Size(83, 46);
            this.btn_Door_Right_Search.TabIndex = 56;
            this.btn_Door_Right_Search.Text = "查询";
            this.btn_Door_Right_Search.UseVisualStyleBackColor = false;
            this.btn_Door_Right_Search.Click += new System.EventHandler(this.btn_Door_Right_Search_Click);
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel7.Location = new System.Drawing.Point(18, 9);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(79, 19);
            this.skinLabel7.TabIndex = 55;
            this.skinLabel7.Text = "搜索条件：";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(-32768, 14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // tabPageEx2
            // 
            this.tabPageEx2.BackColor = System.Drawing.Color.White;
            this.tabPageEx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageEx2.Controls.Add(this.pictureBox1);
            this.tabPageEx2.Controls.Add(this.pictureBox2);
            this.tabPageEx2.Controls.Add(this.skinTabControl4);
            this.tabPageEx2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageEx2.ForeColor = System.Drawing.Color.White;
            this.tabPageEx2.ImageIndex = 1;
            this.tabPageEx2.Location = new System.Drawing.Point(0, 75);
            this.tabPageEx2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageEx2.Name = "tabPageEx2";
            this.tabPageEx2.Size = new System.Drawing.Size(1024, 665);
            this.tabPageEx2.TabIndex = 1;
            this.tabPageEx2.Text = "设备管理";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-32768, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-32768, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 118);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // skinTabControl4
            // 
            animation6.AnimateOnlyDifferences = false;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.skinTabControl4.Animation = animation6;
            this.skinTabControl4.AnimationStart = false;
            this.skinTabControl4.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.BackgroundImage")));
            this.skinTabControl4.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl4.Controls.Add(this.tp_Area);
            this.skinTabControl4.Controls.Add(this.tp_Cotroller);
            this.skinTabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl4.ItemSize = new System.Drawing.Size(109, 30);
            this.skinTabControl4.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl4.Name = "skinTabControl4";
            this.skinTabControl4.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageArrowDown")));
            this.skinTabControl4.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageArrowHover")));
            this.skinTabControl4.PageBackRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.skinTabControl4.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageCloseHover")));
            this.skinTabControl4.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageCloseNormal")));
            this.skinTabControl4.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageDown")));
            this.skinTabControl4.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageHover")));
            this.skinTabControl4.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl4.PageNorml = ((System.Drawing.Image)(resources.GetObject("skinTabControl4.PageNorml")));
            this.skinTabControl4.PagePalace = true;
            this.skinTabControl4.SelectedIndex = 0;
            this.skinTabControl4.Size = new System.Drawing.Size(1024, 665);
            this.skinTabControl4.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl4.TabIndex = 8;
            this.skinTabControl4.Selected += new System.Windows.Forms.TabControlEventHandler(this.skinTabControl4_Selected);
            // 
            // tp_Area
            // 
            this.tp_Area.BackColor = System.Drawing.Color.White;
            this.tp_Area.Controls.Add(this.btn_serach_area);
            this.tp_Area.Controls.Add(this.dgv_Area_Data);
            this.tp_Area.Controls.Add(this.btn_Del_Area);
            this.tp_Area.Controls.Add(this.btn_Update_Area);
            this.tp_Area.Controls.Add(this.btn_Add_Area);
            this.tp_Area.Controls.Add(this.txt_Area_Serach);
            this.tp_Area.Controls.Add(this.skinLabel1);
            this.tp_Area.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_Area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_Area.Location = new System.Drawing.Point(0, 30);
            this.tp_Area.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Area.Name = "tp_Area";
            this.tp_Area.Size = new System.Drawing.Size(1024, 635);
            this.tp_Area.TabIndex = 1;
            this.tp_Area.Text = "区域";
            // 
            // btn_serach_area
            // 
            this.btn_serach_area.BackColor = System.Drawing.Color.White;
            this.btn_serach_area.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_serach_area.BackgroundImage")));
            this.btn_serach_area.BaseColor = System.Drawing.Color.White;
            this.btn_serach_area.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_serach_area.DownBack = null;
            this.btn_serach_area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_serach_area.ForeColor = System.Drawing.Color.Black;
            this.btn_serach_area.Location = new System.Drawing.Point(829, -7);
            this.btn_serach_area.MouseBack = null;
            this.btn_serach_area.Name = "btn_serach_area";
            this.btn_serach_area.NormlBack = null;
            this.btn_serach_area.Size = new System.Drawing.Size(83, 46);
            this.btn_serach_area.TabIndex = 42;
            this.btn_serach_area.Text = "查询";
            this.btn_serach_area.UseVisualStyleBackColor = false;
            this.btn_serach_area.Click += new System.EventHandler(this.btn_serach_area_Click);
            // 
            // dgv_Area_Data
            // 
            this.dgv_Area_Data.AllowUserToAddRows = false;
            this.dgv_Area_Data.AllowUserToDeleteRows = false;
            this.dgv_Area_Data.AllowUserToOrderColumns = true;
            this.dgv_Area_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Area_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.流水编号1,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgv_Area_Data.Location = new System.Drawing.Point(6, 43);
            this.dgv_Area_Data.MultiSelect = false;
            this.dgv_Area_Data.Name = "dgv_Area_Data";
            this.dgv_Area_Data.ReadOnly = true;
            this.dgv_Area_Data.RowTemplate.Height = 23;
            this.dgv_Area_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Area_Data.Size = new System.Drawing.Size(1007, 532);
            this.dgv_Area_Data.TabIndex = 49;
            // 
            // 流水编号1
            // 
            this.流水编号1.DataPropertyName = "ID";
            this.流水编号1.HeaderText = "流水编号";
            this.流水编号1.Name = "流水编号1";
            this.流水编号1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "area_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "区域编号";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn10.HeaderText = "区域名称";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Father_Name";
            this.dataGridViewTextBoxColumn11.HeaderText = "上级区域";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Content";
            this.dataGridViewTextBoxColumn12.HeaderText = "备注";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 400;
            // 
            // btn_Del_Area
            // 
            this.btn_Del_Area.BackColor = System.Drawing.Color.White;
            this.btn_Del_Area.BaseColor = System.Drawing.Color.White;
            this.btn_Del_Area.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Del_Area.DownBack = null;
            this.btn_Del_Area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Del_Area.ForeColor = System.Drawing.Color.Black;
            this.btn_Del_Area.Location = new System.Drawing.Point(691, 585);
            this.btn_Del_Area.MouseBack = null;
            this.btn_Del_Area.Name = "btn_Del_Area";
            this.btn_Del_Area.NormlBack = null;
            this.btn_Del_Area.Size = new System.Drawing.Size(83, 35);
            this.btn_Del_Area.TabIndex = 46;
            this.btn_Del_Area.Text = "删除";
            this.btn_Del_Area.UseVisualStyleBackColor = false;
            this.btn_Del_Area.Click += new System.EventHandler(this.btn_Del_Area_Click);
            // 
            // btn_Update_Area
            // 
            this.btn_Update_Area.BackColor = System.Drawing.Color.White;
            this.btn_Update_Area.BaseColor = System.Drawing.Color.White;
            this.btn_Update_Area.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Update_Area.DownBack = null;
            this.btn_Update_Area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update_Area.ForeColor = System.Drawing.Color.Black;
            this.btn_Update_Area.Location = new System.Drawing.Point(581, 585);
            this.btn_Update_Area.MouseBack = null;
            this.btn_Update_Area.Name = "btn_Update_Area";
            this.btn_Update_Area.NormlBack = null;
            this.btn_Update_Area.Size = new System.Drawing.Size(83, 35);
            this.btn_Update_Area.TabIndex = 45;
            this.btn_Update_Area.Text = "修改";
            this.btn_Update_Area.UseVisualStyleBackColor = false;
            this.btn_Update_Area.Click += new System.EventHandler(this.btn_Update_Area_Click);
            // 
            // btn_Add_Area
            // 
            this.btn_Add_Area.BackColor = System.Drawing.Color.White;
            this.btn_Add_Area.BaseColor = System.Drawing.Color.White;
            this.btn_Add_Area.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Add_Area.DownBack = null;
            this.btn_Add_Area.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Add_Area.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_Area.Location = new System.Drawing.Point(451, 585);
            this.btn_Add_Area.MouseBack = null;
            this.btn_Add_Area.Name = "btn_Add_Area";
            this.btn_Add_Area.NormlBack = null;
            this.btn_Add_Area.Size = new System.Drawing.Size(83, 35);
            this.btn_Add_Area.TabIndex = 44;
            this.btn_Add_Area.Text = "增加";
            this.btn_Add_Area.UseVisualStyleBackColor = false;
            this.btn_Add_Area.Click += new System.EventHandler(this.btn_Add_Area_Click);
            // 
            // txt_Area_Serach
            // 
            this.txt_Area_Serach.Location = new System.Drawing.Point(103, 6);
            this.txt_Area_Serach.Multiline = true;
            this.txt_Area_Serach.Name = "txt_Area_Serach";
            this.txt_Area_Serach.Size = new System.Drawing.Size(618, 29);
            this.txt_Area_Serach.TabIndex = 43;
            this.txt_Area_Serach.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Area_Serach.WaterText = "";
            this.txt_Area_Serach.MouseEnter += new System.EventHandler(this.txt_Area_Serach_MouseEnter);
            this.txt_Area_Serach.MouseLeave += new System.EventHandler(this.txt_Area_Serach_MouseLeave);
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel1.Location = new System.Drawing.Point(18, 6);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(79, 19);
            this.skinLabel1.TabIndex = 41;
            this.skinLabel1.Text = "搜索条件：";
            // 
            // tp_Cotroller
            // 
            this.tp_Cotroller.BackColor = System.Drawing.Color.White;
            this.tp_Cotroller.Controls.Add(this.dgv_Operater_Data);
            this.tp_Cotroller.Controls.Add(this.btn_DelOperater);
            this.tp_Cotroller.Controls.Add(this.btn_UpdateOperater);
            this.tp_Cotroller.Controls.Add(this.btn_AddOperater);
            this.tp_Cotroller.Controls.Add(this.txt_Operater_Search);
            this.tp_Cotroller.Controls.Add(this.btn_searchOperater);
            this.tp_Cotroller.Controls.Add(this.skinLabel2);
            this.tp_Cotroller.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp_Cotroller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.tp_Cotroller.Location = new System.Drawing.Point(0, 30);
            this.tp_Cotroller.Margin = new System.Windows.Forms.Padding(0);
            this.tp_Cotroller.Name = "tp_Cotroller";
            this.tp_Cotroller.Size = new System.Drawing.Size(200, 0);
            this.tp_Cotroller.TabIndex = 0;
            this.tp_Cotroller.Text = "设备";
            // 
            // dgv_Operater_Data
            // 
            this.dgv_Operater_Data.AllowUserToAddRows = false;
            this.dgv_Operater_Data.AllowUserToDeleteRows = false;
            this.dgv_Operater_Data.AllowUserToOrderColumns = true;
            this.dgv_Operater_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Operater_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.波特率,
            this.dataGridViewTextBoxColumn8,
            this.备注});
            this.dgv_Operater_Data.Location = new System.Drawing.Point(6, 41);
            this.dgv_Operater_Data.MultiSelect = false;
            this.dgv_Operater_Data.Name = "dgv_Operater_Data";
            this.dgv_Operater_Data.ReadOnly = true;
            this.dgv_Operater_Data.RowTemplate.Height = 23;
            this.dgv_Operater_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Operater_Data.Size = new System.Drawing.Size(1007, 536);
            this.dgv_Operater_Data.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Controller_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "控制器名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Controller_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "控制器编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "area";
            this.dataGridViewTextBoxColumn7.HeaderText = "所属区域";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "door_count";
            this.dataGridViewTextBoxColumn4.HeaderText = "控制器门数";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Communication_mode";
            this.dataGridViewTextBoxColumn5.HeaderText = "通讯方式";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SerialNO";
            this.dataGridViewTextBoxColumn6.HeaderText = "串口号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // 波特率
            // 
            this.波特率.DataPropertyName = "bondRode";
            this.波特率.HeaderText = "波特率";
            this.波特率.Name = "波特率";
            this.波特率.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RS485_Adress";
            this.dataGridViewTextBoxColumn8.HeaderText = "RS485地址";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Content";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // btn_DelOperater
            // 
            this.btn_DelOperater.BackColor = System.Drawing.Color.White;
            this.btn_DelOperater.BaseColor = System.Drawing.Color.White;
            this.btn_DelOperater.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_DelOperater.DownBack = null;
            this.btn_DelOperater.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DelOperater.ForeColor = System.Drawing.Color.Black;
            this.btn_DelOperater.Location = new System.Drawing.Point(696, 583);
            this.btn_DelOperater.MouseBack = null;
            this.btn_DelOperater.Name = "btn_DelOperater";
            this.btn_DelOperater.NormlBack = null;
            this.btn_DelOperater.Size = new System.Drawing.Size(83, 35);
            this.btn_DelOperater.TabIndex = 37;
            this.btn_DelOperater.Text = "删除";
            this.btn_DelOperater.UseVisualStyleBackColor = false;
            this.btn_DelOperater.Click += new System.EventHandler(this.btn_DelOperater_Click);
            // 
            // btn_UpdateOperater
            // 
            this.btn_UpdateOperater.BackColor = System.Drawing.Color.White;
            this.btn_UpdateOperater.BaseColor = System.Drawing.Color.White;
            this.btn_UpdateOperater.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_UpdateOperater.DownBack = null;
            this.btn_UpdateOperater.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UpdateOperater.ForeColor = System.Drawing.Color.Black;
            this.btn_UpdateOperater.Location = new System.Drawing.Point(586, 583);
            this.btn_UpdateOperater.MouseBack = null;
            this.btn_UpdateOperater.Name = "btn_UpdateOperater";
            this.btn_UpdateOperater.NormlBack = null;
            this.btn_UpdateOperater.Size = new System.Drawing.Size(83, 35);
            this.btn_UpdateOperater.TabIndex = 36;
            this.btn_UpdateOperater.Text = "修改";
            this.btn_UpdateOperater.UseVisualStyleBackColor = false;
            this.btn_UpdateOperater.Click += new System.EventHandler(this.btn_UpdateOperater_Click);
            // 
            // btn_AddOperater
            // 
            this.btn_AddOperater.BackColor = System.Drawing.Color.White;
            this.btn_AddOperater.BaseColor = System.Drawing.Color.White;
            this.btn_AddOperater.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_AddOperater.DownBack = null;
            this.btn_AddOperater.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddOperater.ForeColor = System.Drawing.Color.Black;
            this.btn_AddOperater.Location = new System.Drawing.Point(456, 583);
            this.btn_AddOperater.MouseBack = null;
            this.btn_AddOperater.Name = "btn_AddOperater";
            this.btn_AddOperater.NormlBack = null;
            this.btn_AddOperater.Size = new System.Drawing.Size(83, 35);
            this.btn_AddOperater.TabIndex = 35;
            this.btn_AddOperater.Text = "增加";
            this.btn_AddOperater.UseVisualStyleBackColor = false;
            this.btn_AddOperater.Click += new System.EventHandler(this.btn_AddOperater_Click);
            // 
            // txt_Operater_Search
            // 
            this.txt_Operater_Search.Location = new System.Drawing.Point(103, 4);
            this.txt_Operater_Search.Multiline = true;
            this.txt_Operater_Search.Name = "txt_Operater_Search";
            this.txt_Operater_Search.Size = new System.Drawing.Size(618, 29);
            this.txt_Operater_Search.TabIndex = 34;
            this.txt_Operater_Search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Operater_Search.WaterText = "";
            this.txt_Operater_Search.MouseEnter += new System.EventHandler(this.txt_Operater_Search_MouseEnter);
            this.txt_Operater_Search.MouseLeave += new System.EventHandler(this.txt_Operater_Search_MouseLeave);
            // 
            // btn_searchOperater
            // 
            this.btn_searchOperater.BackColor = System.Drawing.Color.White;
            this.btn_searchOperater.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchOperater.BackgroundImage")));
            this.btn_searchOperater.BaseColor = System.Drawing.Color.White;
            this.btn_searchOperater.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_searchOperater.DownBack = null;
            this.btn_searchOperater.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_searchOperater.ForeColor = System.Drawing.Color.Black;
            this.btn_searchOperater.Location = new System.Drawing.Point(747, -3);
            this.btn_searchOperater.MouseBack = null;
            this.btn_searchOperater.Name = "btn_searchOperater";
            this.btn_searchOperater.NormlBack = null;
            this.btn_searchOperater.Size = new System.Drawing.Size(83, 46);
            this.btn_searchOperater.TabIndex = 33;
            this.btn_searchOperater.Text = "查询";
            this.btn_searchOperater.UseVisualStyleBackColor = false;
            this.btn_searchOperater.Click += new System.EventHandler(this.btn_searchOperater_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel2.Location = new System.Drawing.Point(18, 4);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(79, 19);
            this.skinLabel2.TabIndex = 32;
            this.skinLabel2.Text = "搜索条件：";
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 1F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.skinTabControl1.Animation = animation7;
            this.skinTabControl1.AnimationStart = false;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.Leaf;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tabPageEx6);
            this.skinTabControl1.Controls.Add(this.tabPageEx1);
            this.skinTabControl1.Controls.Add(this.tabPageEx2);
            this.skinTabControl1.Controls.Add(this.tabPageEx3);
            this.skinTabControl1.Controls.Add(this.tabPageEx5);
            this.skinTabControl1.Controls.Add(this.tabPageEx4);
            this.skinTabControl1.Controls.Add(this.tabPage2);
            this.skinTabControl1.Controls.Add(this.tabPage4);
            this.skinTabControl1.ImageList = this.imageList;
            this.skinTabControl1.ImgSize = new System.Drawing.Size(48, 48);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(80, 75);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 24);
            this.skinTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.Padding = new System.Drawing.Point(0, 0);
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.PageTextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(1024, 740);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 140;
            this.skinTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.skinTabControl1_Selected);
            // 
            // tabPageEx1
            // 
            this.tabPageEx1.BackColor = System.Drawing.Color.White;
            this.tabPageEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageEx1.Controls.Add(this.dgv_Person_Data);
            this.tabPageEx1.Controls.Add(this.btn_ExportPerson);
            this.tabPageEx1.Controls.Add(this.btn_InportPerson);
            this.tabPageEx1.Controls.Add(this.btn_DelPerson);
            this.tabPageEx1.Controls.Add(this.btn_UpdatePerson);
            this.tabPageEx1.Controls.Add(this.btn_AddPerson);
            this.tabPageEx1.Controls.Add(this.txt_Person_Search);
            this.tabPageEx1.Controls.Add(this.btn_searchPerson);
            this.tabPageEx1.Controls.Add(this.skinLabel27);
            this.tabPageEx1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPageEx1.ForeColor = System.Drawing.Color.White;
            this.tabPageEx1.ImageIndex = 11;
            this.tabPageEx1.Location = new System.Drawing.Point(0, 75);
            this.tabPageEx1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageEx1.Name = "tabPageEx1";
            this.tabPageEx1.Size = new System.Drawing.Size(1024, 665);
            this.tabPageEx1.TabIndex = 0;
            this.tabPageEx1.Text = "人事管理";
            // 
            // dgv_Person_Data
            // 
            this.dgv_Person_Data.AllowUserToAddRows = false;
            this.dgv_Person_Data.AllowUserToDeleteRows = false;
            this.dgv_Person_Data.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            this.dgv_Person_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Person_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Person_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Person_Data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.流水编号,
            this.用户名,
            this.联系方式,
            this.邮箱,
            this.Column2,
            this.卡片编号,
            this.卡片类型,
            this.卡片密码,
            this.是否APB检验,
            this.IACUC审阅小组,
            this.批准日期,
            this.起止日期,
            this.课题名称,
            this.PI,
            this.申请人,
            this.AP,
            this.动物种属,
            this.动物总用量,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Person_Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Person_Data.Location = new System.Drawing.Point(3, 52);
            this.dgv_Person_Data.MultiSelect = false;
            this.dgv_Person_Data.Name = "dgv_Person_Data";
            this.dgv_Person_Data.ReadOnly = true;
            this.dgv_Person_Data.RowTemplate.Height = 23;
            this.dgv_Person_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Person_Data.Size = new System.Drawing.Size(1010, 551);
            this.dgv_Person_Data.TabIndex = 13;
            // 
            // 流水编号
            // 
            this.流水编号.DataPropertyName = "id";
            this.流水编号.HeaderText = "流水编号";
            this.流水编号.Name = "流水编号";
            this.流水编号.ReadOnly = true;
            // 
            // 用户名
            // 
            this.用户名.DataPropertyName = "name";
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            // 
            // 联系方式
            // 
            this.联系方式.DataPropertyName = "Phone";
            this.联系方式.HeaderText = "联系方式";
            this.联系方式.Name = "联系方式";
            this.联系方式.ReadOnly = true;
            // 
            // 邮箱
            // 
            this.邮箱.DataPropertyName = "Email";
            this.邮箱.HeaderText = "邮箱";
            this.邮箱.Name = "邮箱";
            this.邮箱.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Identity_NO";
            this.Column2.HeaderText = "身份证号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // 卡片编号
            // 
            this.卡片编号.DataPropertyName = "CardID";
            this.卡片编号.HeaderText = "卡片编号";
            this.卡片编号.Name = "卡片编号";
            this.卡片编号.ReadOnly = true;
            // 
            // 卡片类型
            // 
            this.卡片类型.DataPropertyName = "CardType";
            this.卡片类型.HeaderText = "卡片类型";
            this.卡片类型.Name = "卡片类型";
            this.卡片类型.ReadOnly = true;
            // 
            // 卡片密码
            // 
            this.卡片密码.DataPropertyName = "PINPWD";
            this.卡片密码.HeaderText = "卡片密码";
            this.卡片密码.Name = "卡片密码";
            this.卡片密码.ReadOnly = true;
            // 
            // 是否APB检验
            // 
            this.是否APB检验.DataPropertyName = "IsAPBCheck";
            this.是否APB检验.HeaderText = "是否APB检验";
            this.是否APB检验.Name = "是否APB检验";
            this.是否APB检验.ReadOnly = true;
            // 
            // IACUC审阅小组
            // 
            this.IACUC审阅小组.DataPropertyName = "IACUC_GroupName";
            this.IACUC审阅小组.HeaderText = "IACUC审阅小组";
            this.IACUC审阅小组.Name = "IACUC审阅小组";
            this.IACUC审阅小组.ReadOnly = true;
            // 
            // 批准日期
            // 
            this.批准日期.DataPropertyName = "Approval_Date";
            this.批准日期.HeaderText = "批准日期";
            this.批准日期.Name = "批准日期";
            this.批准日期.ReadOnly = true;
            // 
            // 起止日期
            // 
            this.起止日期.DataPropertyName = "Experiment_TimeRange";
            this.起止日期.HeaderText = "起止日期";
            this.起止日期.Name = "起止日期";
            this.起止日期.ReadOnly = true;
            // 
            // 课题名称
            // 
            this.课题名称.DataPropertyName = "Topic_Name";
            this.课题名称.HeaderText = "课题名称";
            this.课题名称.Name = "课题名称";
            this.课题名称.ReadOnly = true;
            // 
            // PI
            // 
            this.PI.DataPropertyName = "PI";
            this.PI.HeaderText = "PI";
            this.PI.Name = "PI";
            this.PI.ReadOnly = true;
            // 
            // 申请人
            // 
            this.申请人.DataPropertyName = "Applicant";
            this.申请人.HeaderText = "申请人";
            this.申请人.Name = "申请人";
            this.申请人.ReadOnly = true;
            // 
            // AP
            // 
            this.AP.DataPropertyName = "AP";
            this.AP.HeaderText = "AP";
            this.AP.Name = "AP";
            this.AP.ReadOnly = true;
            // 
            // 动物种属
            // 
            this.动物种属.DataPropertyName = "Animal_Species";
            this.动物种属.HeaderText = "动物种属";
            this.动物种属.Name = "动物种属";
            this.动物种属.ReadOnly = true;
            // 
            // 动物总用量
            // 
            this.动物总用量.DataPropertyName = "Animal_Count";
            this.动物总用量.HeaderText = "动物总用量";
            this.动物总用量.Name = "动物总用量";
            this.动物总用量.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "content";
            this.Column1.HeaderText = "备注";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btn_ExportPerson
            // 
            this.btn_ExportPerson.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExportPerson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_ExportPerson.DownBack = null;
            this.btn_ExportPerson.Location = new System.Drawing.Point(0, 0);
            this.btn_ExportPerson.MouseBack = null;
            this.btn_ExportPerson.Name = "btn_ExportPerson";
            this.btn_ExportPerson.NormlBack = null;
            this.btn_ExportPerson.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportPerson.TabIndex = 14;
            this.btn_ExportPerson.UseVisualStyleBackColor = false;
            // 
            // btn_InportPerson
            // 
            this.btn_InportPerson.BackColor = System.Drawing.Color.White;
            this.btn_InportPerson.BaseColor = System.Drawing.Color.White;
            this.btn_InportPerson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_InportPerson.DownBack = null;
            this.btn_InportPerson.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_InportPerson.ForeColor = System.Drawing.Color.Black;
            this.btn_InportPerson.Location = new System.Drawing.Point(775, 609);
            this.btn_InportPerson.MouseBack = null;
            this.btn_InportPerson.Name = "btn_InportPerson";
            this.btn_InportPerson.NormlBack = null;
            this.btn_InportPerson.Size = new System.Drawing.Size(139, 35);
            this.btn_InportPerson.TabIndex = 11;
            this.btn_InportPerson.Text = "导入试验信息";
            this.btn_InportPerson.UseVisualStyleBackColor = false;
            this.btn_InportPerson.Click += new System.EventHandler(this.btn_InportPerson_Click);
            // 
            // btn_DelPerson
            // 
            this.btn_DelPerson.BackColor = System.Drawing.Color.White;
            this.btn_DelPerson.BaseColor = System.Drawing.Color.White;
            this.btn_DelPerson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_DelPerson.DownBack = null;
            this.btn_DelPerson.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_DelPerson.ForeColor = System.Drawing.Color.Black;
            this.btn_DelPerson.Location = new System.Drawing.Point(665, 609);
            this.btn_DelPerson.MouseBack = null;
            this.btn_DelPerson.Name = "btn_DelPerson";
            this.btn_DelPerson.NormlBack = null;
            this.btn_DelPerson.Size = new System.Drawing.Size(83, 35);
            this.btn_DelPerson.TabIndex = 10;
            this.btn_DelPerson.Text = "删除";
            this.btn_DelPerson.UseVisualStyleBackColor = false;
            this.btn_DelPerson.Click += new System.EventHandler(this.btn_DelPerson_Click);
            // 
            // btn_UpdatePerson
            // 
            this.btn_UpdatePerson.BackColor = System.Drawing.Color.White;
            this.btn_UpdatePerson.BaseColor = System.Drawing.Color.White;
            this.btn_UpdatePerson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_UpdatePerson.DownBack = null;
            this.btn_UpdatePerson.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_UpdatePerson.ForeColor = System.Drawing.Color.Black;
            this.btn_UpdatePerson.Location = new System.Drawing.Point(555, 609);
            this.btn_UpdatePerson.MouseBack = null;
            this.btn_UpdatePerson.Name = "btn_UpdatePerson";
            this.btn_UpdatePerson.NormlBack = null;
            this.btn_UpdatePerson.Size = new System.Drawing.Size(83, 35);
            this.btn_UpdatePerson.TabIndex = 9;
            this.btn_UpdatePerson.Text = "修改";
            this.btn_UpdatePerson.UseVisualStyleBackColor = false;
            this.btn_UpdatePerson.Click += new System.EventHandler(this.btn_UpdatePerson_Click);
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.BackColor = System.Drawing.Color.White;
            this.btn_AddPerson.BaseColor = System.Drawing.Color.White;
            this.btn_AddPerson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_AddPerson.DownBack = null;
            this.btn_AddPerson.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_AddPerson.ForeColor = System.Drawing.Color.Black;
            this.btn_AddPerson.Location = new System.Drawing.Point(425, 609);
            this.btn_AddPerson.MouseBack = null;
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.NormlBack = null;
            this.btn_AddPerson.Size = new System.Drawing.Size(83, 35);
            this.btn_AddPerson.TabIndex = 8;
            this.btn_AddPerson.Text = "增加";
            this.btn_AddPerson.UseVisualStyleBackColor = false;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // txt_Person_Search
            // 
            this.txt_Person_Search.Location = new System.Drawing.Point(100, 15);
            this.txt_Person_Search.Multiline = true;
            this.txt_Person_Search.Name = "txt_Person_Search";
            this.txt_Person_Search.Size = new System.Drawing.Size(793, 29);
            this.txt_Person_Search.TabIndex = 7;
            this.txt_Person_Search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Person_Search.WaterText = "";
            this.txt_Person_Search.MouseEnter += new System.EventHandler(this.skinWaterTextBox1_MouseEnter);
            this.txt_Person_Search.MouseLeave += new System.EventHandler(this.skinWaterTextBox1_MouseLeave);
            // 
            // btn_searchPerson
            // 
            this.btn_searchPerson.BackColor = System.Drawing.Color.White;
            this.btn_searchPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_searchPerson.BackgroundImage")));
            this.btn_searchPerson.BaseColor = System.Drawing.Color.White;
            this.btn_searchPerson.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_searchPerson.DownBack = null;
            this.btn_searchPerson.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_searchPerson.ForeColor = System.Drawing.Color.Black;
            this.btn_searchPerson.Location = new System.Drawing.Point(885, 2);
            this.btn_searchPerson.MouseBack = null;
            this.btn_searchPerson.Name = "btn_searchPerson";
            this.btn_searchPerson.NormlBack = null;
            this.btn_searchPerson.Size = new System.Drawing.Size(83, 46);
            this.btn_searchPerson.TabIndex = 6;
            this.btn_searchPerson.Text = "查询";
            this.btn_searchPerson.UseVisualStyleBackColor = false;
            this.btn_searchPerson.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // skinLabel27
            // 
            this.skinLabel27.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel27.AutoSize = true;
            this.skinLabel27.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel27.BorderColor = System.Drawing.Color.White;
            this.skinLabel27.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel27.Location = new System.Drawing.Point(15, 20);
            this.skinLabel27.Name = "skinLabel27";
            this.skinLabel27.Size = new System.Drawing.Size(79, 19);
            this.skinLabel27.TabIndex = 3;
            this.skinLabel27.Text = "搜索条件：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Watch_Full);
            this.tabPage2.Controls.Add(this.skinGroupBox9);
            this.tabPage2.Controls.Add(this.door_Group8);
            this.tabPage2.Controls.Add(this.door_Group7);
            this.tabPage2.Controls.Add(this.door_Group6);
            this.tabPage2.Controls.Add(this.door_Group5);
            this.tabPage2.Controls.Add(this.door_Group4);
            this.tabPage2.Controls.Add(this.door_Group3);
            this.tabPage2.Controls.Add(this.door_Group2);
            this.tabPage2.Controls.Add(this.door_Group1);
            this.tabPage2.ImageIndex = 3;
            this.tabPage2.Location = new System.Drawing.Point(0, 75);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1024, 665);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "实时监控";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Watch_Full
            // 
            this.btn_Watch_Full.BackColor = System.Drawing.Color.White;
            this.btn_Watch_Full.BaseColor = System.Drawing.Color.White;
            this.btn_Watch_Full.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Watch_Full.DownBack = null;
            this.btn_Watch_Full.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Watch_Full.ForeColor = System.Drawing.Color.Black;
            this.btn_Watch_Full.Location = new System.Drawing.Point(637, 612);
            this.btn_Watch_Full.MouseBack = null;
            this.btn_Watch_Full.Name = "btn_Watch_Full";
            this.btn_Watch_Full.NormlBack = null;
            this.btn_Watch_Full.Size = new System.Drawing.Size(136, 35);
            this.btn_Watch_Full.TabIndex = 111;
            this.btn_Watch_Full.Text = "全屏显示";
            this.btn_Watch_Full.UseVisualStyleBackColor = false;
            this.btn_Watch_Full.Click += new System.EventHandler(this.btn_Watch_Full_Click);
            // 
            // skinGroupBox9
            // 
            this.skinGroupBox9.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox9.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox9.Controls.Add(this.dgv_Actions);
            this.skinGroupBox9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinGroupBox9.Location = new System.Drawing.Point(471, 22);
            this.skinGroupBox9.Name = "skinGroupBox9";
            this.skinGroupBox9.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox9.Size = new System.Drawing.Size(526, 563);
            this.skinGroupBox9.TabIndex = 110;
            this.skinGroupBox9.TabStop = false;
            this.skinGroupBox9.Text = "实时进出";
            this.skinGroupBox9.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox9.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // dgv_Actions
            // 
            this.dgv_Actions.AllowUserToAddRows = false;
            this.dgv_Actions.AllowUserToDeleteRows = false;
            this.dgv_Actions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_Actions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Actions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Actions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49});
            this.dgv_Actions.Location = new System.Drawing.Point(6, 20);
            this.dgv_Actions.MultiSelect = false;
            this.dgv_Actions.Name = "dgv_Actions";
            this.dgv_Actions.ReadOnly = true;
            this.dgv_Actions.RowTemplate.Height = 23;
            this.dgv_Actions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Actions.Size = new System.Drawing.Size(514, 740);
            this.dgv_Actions.TabIndex = 104;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn44.HeaderText = "流水";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 80;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.DataPropertyName = "Action";
            this.dataGridViewTextBoxColumn45.HeaderText = "事件";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Width = 90;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.DataPropertyName = "Date_Time";
            this.dataGridViewTextBoxColumn46.HeaderText = "日期";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Width = 90;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.DataPropertyName = "Person_Name";
            this.dataGridViewTextBoxColumn47.HeaderText = "刷卡人";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Width = 70;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.DataPropertyName = "place";
            this.dataGridViewTextBoxColumn48.HeaderText = "地点";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Width = 60;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.DataPropertyName = "Controller_Name";
            this.dataGridViewTextBoxColumn49.HeaderText = "设备";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Width = 60;
            // 
            // door_Group8
            // 
            this.door_Group8.BackColor = System.Drawing.Color.Transparent;
            this.door_Group8.BorderColor = System.Drawing.Color.Red;
            this.door_Group8.Controls.Add(this.cb32);
            this.door_Group8.Controls.Add(this.door32);
            this.door_Group8.Controls.Add(this.btn_OpenDoor32);
            this.door_Group8.Controls.Add(this.cb31);
            this.door_Group8.Controls.Add(this.door31);
            this.door_Group8.Controls.Add(this.btn_OpenDoor31);
            this.door_Group8.Controls.Add(this.cb30);
            this.door_Group8.Controls.Add(this.door30);
            this.door_Group8.Controls.Add(this.btn_OpenDoor30);
            this.door_Group8.Controls.Add(this.cb29);
            this.door_Group8.Controls.Add(this.door29);
            this.door_Group8.Controls.Add(this.btn_OpenDoor29);
            this.door_Group8.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group8.ForeColor = System.Drawing.Color.Blue;
            this.door_Group8.Location = new System.Drawing.Point(238, 480);
            this.door_Group8.Name = "door_Group8";
            this.door_Group8.RectBackColor = System.Drawing.Color.White;
            this.door_Group8.Size = new System.Drawing.Size(227, 105);
            this.door_Group8.TabIndex = 109;
            this.door_Group8.TabStop = false;
            this.door_Group8.Tag = "1";
            this.door_Group8.Text = "考勤门禁";
            this.door_Group8.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group8.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb32
            // 
            this.cb32.AutoSize = true;
            this.cb32.BackColor = System.Drawing.Color.Transparent;
            this.cb32.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb32.DownBack = null;
            this.cb32.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb32.Location = new System.Drawing.Point(169, 54);
            this.cb32.MouseBack = null;
            this.cb32.Name = "cb32";
            this.cb32.NormlBack = null;
            this.cb32.SelectedDownBack = null;
            this.cb32.SelectedMouseBack = null;
            this.cb32.SelectedNormlBack = null;
            this.cb32.Size = new System.Drawing.Size(38, 14);
            this.cb32.TabIndex = 107;
            this.cb32.Tag = "1";
            this.cb32.Text = "常开";
            this.cb32.UseVisualStyleBackColor = false;
            this.cb32.Visible = false;
            // 
            // door32
            // 
            this.door32.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door32.Location = new System.Drawing.Point(173, 20);
            this.door32.Name = "door32";
            this.door32.Size = new System.Drawing.Size(20, 28);
            this.door32.TabIndex = 105;
            this.door32.UseVisualStyleBackColor = true;
            this.door32.Visible = false;
            // 
            // btn_OpenDoor32
            // 
            this.btn_OpenDoor32.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor32.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor32.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor32.Name = "btn_OpenDoor32";
            this.btn_OpenDoor32.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor32.TabIndex = 106;
            this.btn_OpenDoor32.Tag = "32";
            this.btn_OpenDoor32.Text = "开门";
            this.btn_OpenDoor32.UseVisualStyleBackColor = true;
            this.btn_OpenDoor32.Visible = false;
            this.btn_OpenDoor32.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb31
            // 
            this.cb31.AutoSize = true;
            this.cb31.BackColor = System.Drawing.Color.Transparent;
            this.cb31.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb31.DownBack = null;
            this.cb31.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb31.Location = new System.Drawing.Point(116, 54);
            this.cb31.MouseBack = null;
            this.cb31.Name = "cb31";
            this.cb31.NormlBack = null;
            this.cb31.SelectedDownBack = null;
            this.cb31.SelectedMouseBack = null;
            this.cb31.SelectedNormlBack = null;
            this.cb31.Size = new System.Drawing.Size(38, 14);
            this.cb31.TabIndex = 104;
            this.cb31.Tag = "1";
            this.cb31.Text = "常开";
            this.cb31.UseVisualStyleBackColor = false;
            this.cb31.Visible = false;
            // 
            // door31
            // 
            this.door31.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door31.Location = new System.Drawing.Point(120, 20);
            this.door31.Name = "door31";
            this.door31.Size = new System.Drawing.Size(20, 28);
            this.door31.TabIndex = 102;
            this.door31.UseVisualStyleBackColor = true;
            this.door31.Visible = false;
            // 
            // btn_OpenDoor31
            // 
            this.btn_OpenDoor31.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor31.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor31.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor31.Name = "btn_OpenDoor31";
            this.btn_OpenDoor31.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor31.TabIndex = 103;
            this.btn_OpenDoor31.Tag = "31";
            this.btn_OpenDoor31.Text = "开门";
            this.btn_OpenDoor31.UseVisualStyleBackColor = true;
            this.btn_OpenDoor31.Visible = false;
            this.btn_OpenDoor31.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb30
            // 
            this.cb30.AutoSize = true;
            this.cb30.BackColor = System.Drawing.Color.Transparent;
            this.cb30.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb30.DownBack = null;
            this.cb30.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb30.Location = new System.Drawing.Point(61, 54);
            this.cb30.MouseBack = null;
            this.cb30.Name = "cb30";
            this.cb30.NormlBack = null;
            this.cb30.SelectedDownBack = null;
            this.cb30.SelectedMouseBack = null;
            this.cb30.SelectedNormlBack = null;
            this.cb30.Size = new System.Drawing.Size(38, 14);
            this.cb30.TabIndex = 101;
            this.cb30.Tag = "1";
            this.cb30.Text = "常开";
            this.cb30.UseVisualStyleBackColor = false;
            this.cb30.Visible = false;
            // 
            // door30
            // 
            this.door30.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door30.Location = new System.Drawing.Point(65, 20);
            this.door30.Name = "door30";
            this.door30.Size = new System.Drawing.Size(20, 28);
            this.door30.TabIndex = 99;
            this.door30.UseVisualStyleBackColor = true;
            this.door30.Visible = false;
            // 
            // btn_OpenDoor30
            // 
            this.btn_OpenDoor30.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor30.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor30.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor30.Name = "btn_OpenDoor30";
            this.btn_OpenDoor30.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor30.TabIndex = 100;
            this.btn_OpenDoor30.Tag = "30";
            this.btn_OpenDoor30.Text = "开门";
            this.btn_OpenDoor30.UseVisualStyleBackColor = true;
            this.btn_OpenDoor30.Visible = false;
            this.btn_OpenDoor30.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb29
            // 
            this.cb29.AutoSize = true;
            this.cb29.BackColor = System.Drawing.Color.Transparent;
            this.cb29.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb29.DownBack = null;
            this.cb29.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb29.Location = new System.Drawing.Point(6, 54);
            this.cb29.MouseBack = null;
            this.cb29.Name = "cb29";
            this.cb29.NormlBack = null;
            this.cb29.SelectedDownBack = null;
            this.cb29.SelectedMouseBack = null;
            this.cb29.SelectedNormlBack = null;
            this.cb29.Size = new System.Drawing.Size(38, 14);
            this.cb29.TabIndex = 98;
            this.cb29.Tag = "1";
            this.cb29.Text = "常开";
            this.cb29.UseVisualStyleBackColor = false;
            this.cb29.Visible = false;
            // 
            // door29
            // 
            this.door29.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door29.Location = new System.Drawing.Point(10, 20);
            this.door29.Name = "door29";
            this.door29.Size = new System.Drawing.Size(20, 28);
            this.door29.TabIndex = 0;
            this.door29.UseVisualStyleBackColor = true;
            this.door29.Visible = false;
            // 
            // btn_OpenDoor29
            // 
            this.btn_OpenDoor29.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor29.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor29.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor29.Name = "btn_OpenDoor29";
            this.btn_OpenDoor29.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor29.TabIndex = 94;
            this.btn_OpenDoor29.Tag = "29";
            this.btn_OpenDoor29.Text = "开门";
            this.btn_OpenDoor29.UseVisualStyleBackColor = true;
            this.btn_OpenDoor29.Visible = false;
            this.btn_OpenDoor29.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group7
            // 
            this.door_Group7.BackColor = System.Drawing.Color.Transparent;
            this.door_Group7.BorderColor = System.Drawing.Color.Red;
            this.door_Group7.Controls.Add(this.cb28);
            this.door_Group7.Controls.Add(this.door28);
            this.door_Group7.Controls.Add(this.btn_OpenDoor28);
            this.door_Group7.Controls.Add(this.cb27);
            this.door_Group7.Controls.Add(this.door27);
            this.door_Group7.Controls.Add(this.btn_OpenDoor27);
            this.door_Group7.Controls.Add(this.cb26);
            this.door_Group7.Controls.Add(this.door26);
            this.door_Group7.Controls.Add(this.btn_OpenDoor26);
            this.door_Group7.Controls.Add(this.cb25);
            this.door_Group7.Controls.Add(this.door25);
            this.door_Group7.Controls.Add(this.btn_OpenDoor25);
            this.door_Group7.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group7.ForeColor = System.Drawing.Color.Blue;
            this.door_Group7.Location = new System.Drawing.Point(5, 480);
            this.door_Group7.Name = "door_Group7";
            this.door_Group7.RectBackColor = System.Drawing.Color.White;
            this.door_Group7.Size = new System.Drawing.Size(227, 105);
            this.door_Group7.TabIndex = 109;
            this.door_Group7.TabStop = false;
            this.door_Group7.Tag = "1";
            this.door_Group7.Text = "考勤门禁";
            this.door_Group7.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group7.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb28
            // 
            this.cb28.AutoSize = true;
            this.cb28.BackColor = System.Drawing.Color.Transparent;
            this.cb28.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb28.DownBack = null;
            this.cb28.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb28.Location = new System.Drawing.Point(169, 54);
            this.cb28.MouseBack = null;
            this.cb28.Name = "cb28";
            this.cb28.NormlBack = null;
            this.cb28.SelectedDownBack = null;
            this.cb28.SelectedMouseBack = null;
            this.cb28.SelectedNormlBack = null;
            this.cb28.Size = new System.Drawing.Size(38, 14);
            this.cb28.TabIndex = 107;
            this.cb28.Tag = "1";
            this.cb28.Text = "常开";
            this.cb28.UseVisualStyleBackColor = false;
            this.cb28.Visible = false;
            // 
            // door28
            // 
            this.door28.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door28.Location = new System.Drawing.Point(173, 20);
            this.door28.Name = "door28";
            this.door28.Size = new System.Drawing.Size(20, 28);
            this.door28.TabIndex = 105;
            this.door28.UseVisualStyleBackColor = true;
            this.door28.Visible = false;
            // 
            // btn_OpenDoor28
            // 
            this.btn_OpenDoor28.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor28.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor28.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor28.Name = "btn_OpenDoor28";
            this.btn_OpenDoor28.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor28.TabIndex = 106;
            this.btn_OpenDoor28.Tag = "28";
            this.btn_OpenDoor28.Text = "开门";
            this.btn_OpenDoor28.UseVisualStyleBackColor = true;
            this.btn_OpenDoor28.Visible = false;
            this.btn_OpenDoor28.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb27
            // 
            this.cb27.AutoSize = true;
            this.cb27.BackColor = System.Drawing.Color.Transparent;
            this.cb27.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb27.DownBack = null;
            this.cb27.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb27.Location = new System.Drawing.Point(116, 54);
            this.cb27.MouseBack = null;
            this.cb27.Name = "cb27";
            this.cb27.NormlBack = null;
            this.cb27.SelectedDownBack = null;
            this.cb27.SelectedMouseBack = null;
            this.cb27.SelectedNormlBack = null;
            this.cb27.Size = new System.Drawing.Size(38, 14);
            this.cb27.TabIndex = 104;
            this.cb27.Tag = "1";
            this.cb27.Text = "常开";
            this.cb27.UseVisualStyleBackColor = false;
            this.cb27.Visible = false;
            // 
            // door27
            // 
            this.door27.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door27.Location = new System.Drawing.Point(120, 20);
            this.door27.Name = "door27";
            this.door27.Size = new System.Drawing.Size(20, 28);
            this.door27.TabIndex = 102;
            this.door27.UseVisualStyleBackColor = true;
            this.door27.Visible = false;
            // 
            // btn_OpenDoor27
            // 
            this.btn_OpenDoor27.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor27.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor27.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor27.Name = "btn_OpenDoor27";
            this.btn_OpenDoor27.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor27.TabIndex = 103;
            this.btn_OpenDoor27.Tag = "27";
            this.btn_OpenDoor27.Text = "开门";
            this.btn_OpenDoor27.UseVisualStyleBackColor = true;
            this.btn_OpenDoor27.Visible = false;
            this.btn_OpenDoor27.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb26
            // 
            this.cb26.AutoSize = true;
            this.cb26.BackColor = System.Drawing.Color.Transparent;
            this.cb26.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb26.DownBack = null;
            this.cb26.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb26.Location = new System.Drawing.Point(61, 54);
            this.cb26.MouseBack = null;
            this.cb26.Name = "cb26";
            this.cb26.NormlBack = null;
            this.cb26.SelectedDownBack = null;
            this.cb26.SelectedMouseBack = null;
            this.cb26.SelectedNormlBack = null;
            this.cb26.Size = new System.Drawing.Size(38, 14);
            this.cb26.TabIndex = 101;
            this.cb26.Tag = "1";
            this.cb26.Text = "常开";
            this.cb26.UseVisualStyleBackColor = false;
            this.cb26.Visible = false;
            // 
            // door26
            // 
            this.door26.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door26.Location = new System.Drawing.Point(65, 20);
            this.door26.Name = "door26";
            this.door26.Size = new System.Drawing.Size(20, 28);
            this.door26.TabIndex = 99;
            this.door26.UseVisualStyleBackColor = true;
            this.door26.Visible = false;
            // 
            // btn_OpenDoor26
            // 
            this.btn_OpenDoor26.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor26.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor26.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor26.Name = "btn_OpenDoor26";
            this.btn_OpenDoor26.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor26.TabIndex = 100;
            this.btn_OpenDoor26.Tag = "26";
            this.btn_OpenDoor26.Text = "开门";
            this.btn_OpenDoor26.UseVisualStyleBackColor = true;
            this.btn_OpenDoor26.Visible = false;
            this.btn_OpenDoor26.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb25
            // 
            this.cb25.AutoSize = true;
            this.cb25.BackColor = System.Drawing.Color.Transparent;
            this.cb25.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb25.DownBack = null;
            this.cb25.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb25.Location = new System.Drawing.Point(6, 54);
            this.cb25.MouseBack = null;
            this.cb25.Name = "cb25";
            this.cb25.NormlBack = null;
            this.cb25.SelectedDownBack = null;
            this.cb25.SelectedMouseBack = null;
            this.cb25.SelectedNormlBack = null;
            this.cb25.Size = new System.Drawing.Size(38, 14);
            this.cb25.TabIndex = 98;
            this.cb25.Tag = "1";
            this.cb25.Text = "常开";
            this.cb25.UseVisualStyleBackColor = false;
            this.cb25.Visible = false;
            // 
            // door25
            // 
            this.door25.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door25.Location = new System.Drawing.Point(10, 20);
            this.door25.Name = "door25";
            this.door25.Size = new System.Drawing.Size(20, 28);
            this.door25.TabIndex = 0;
            this.door25.UseVisualStyleBackColor = true;
            this.door25.Visible = false;
            // 
            // btn_OpenDoor25
            // 
            this.btn_OpenDoor25.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor25.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor25.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor25.Name = "btn_OpenDoor25";
            this.btn_OpenDoor25.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor25.TabIndex = 94;
            this.btn_OpenDoor25.Tag = "25";
            this.btn_OpenDoor25.Text = "开门";
            this.btn_OpenDoor25.UseVisualStyleBackColor = true;
            this.btn_OpenDoor25.Visible = false;
            this.btn_OpenDoor25.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group6
            // 
            this.door_Group6.BackColor = System.Drawing.Color.Transparent;
            this.door_Group6.BorderColor = System.Drawing.Color.Red;
            this.door_Group6.Controls.Add(this.cb24);
            this.door_Group6.Controls.Add(this.door24);
            this.door_Group6.Controls.Add(this.btn_OpenDoor24);
            this.door_Group6.Controls.Add(this.cb23);
            this.door_Group6.Controls.Add(this.door23);
            this.door_Group6.Controls.Add(this.btn_OpenDoor23);
            this.door_Group6.Controls.Add(this.cb22);
            this.door_Group6.Controls.Add(this.door22);
            this.door_Group6.Controls.Add(this.btn_OpenDoor22);
            this.door_Group6.Controls.Add(this.cb21);
            this.door_Group6.Controls.Add(this.door21);
            this.door_Group6.Controls.Add(this.btn_OpenDoor21);
            this.door_Group6.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group6.ForeColor = System.Drawing.Color.Blue;
            this.door_Group6.Location = new System.Drawing.Point(238, 324);
            this.door_Group6.Name = "door_Group6";
            this.door_Group6.RectBackColor = System.Drawing.Color.White;
            this.door_Group6.Size = new System.Drawing.Size(227, 105);
            this.door_Group6.TabIndex = 109;
            this.door_Group6.TabStop = false;
            this.door_Group6.Tag = "1";
            this.door_Group6.Text = "考勤门禁";
            this.door_Group6.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group6.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb24
            // 
            this.cb24.AutoSize = true;
            this.cb24.BackColor = System.Drawing.Color.Transparent;
            this.cb24.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb24.DownBack = null;
            this.cb24.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb24.Location = new System.Drawing.Point(169, 54);
            this.cb24.MouseBack = null;
            this.cb24.Name = "cb24";
            this.cb24.NormlBack = null;
            this.cb24.SelectedDownBack = null;
            this.cb24.SelectedMouseBack = null;
            this.cb24.SelectedNormlBack = null;
            this.cb24.Size = new System.Drawing.Size(38, 14);
            this.cb24.TabIndex = 107;
            this.cb24.Tag = "1";
            this.cb24.Text = "常开";
            this.cb24.UseVisualStyleBackColor = false;
            this.cb24.Visible = false;
            // 
            // door24
            // 
            this.door24.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door24.Location = new System.Drawing.Point(173, 20);
            this.door24.Name = "door24";
            this.door24.Size = new System.Drawing.Size(20, 28);
            this.door24.TabIndex = 105;
            this.door24.UseVisualStyleBackColor = true;
            this.door24.Visible = false;
            // 
            // btn_OpenDoor24
            // 
            this.btn_OpenDoor24.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor24.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor24.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor24.Name = "btn_OpenDoor24";
            this.btn_OpenDoor24.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor24.TabIndex = 106;
            this.btn_OpenDoor24.Tag = "24";
            this.btn_OpenDoor24.Text = "开门";
            this.btn_OpenDoor24.UseVisualStyleBackColor = true;
            this.btn_OpenDoor24.Visible = false;
            this.btn_OpenDoor24.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb23
            // 
            this.cb23.AutoSize = true;
            this.cb23.BackColor = System.Drawing.Color.Transparent;
            this.cb23.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb23.DownBack = null;
            this.cb23.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb23.Location = new System.Drawing.Point(116, 54);
            this.cb23.MouseBack = null;
            this.cb23.Name = "cb23";
            this.cb23.NormlBack = null;
            this.cb23.SelectedDownBack = null;
            this.cb23.SelectedMouseBack = null;
            this.cb23.SelectedNormlBack = null;
            this.cb23.Size = new System.Drawing.Size(38, 14);
            this.cb23.TabIndex = 104;
            this.cb23.Tag = "1";
            this.cb23.Text = "常开";
            this.cb23.UseVisualStyleBackColor = false;
            this.cb23.Visible = false;
            // 
            // door23
            // 
            this.door23.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door23.Location = new System.Drawing.Point(120, 20);
            this.door23.Name = "door23";
            this.door23.Size = new System.Drawing.Size(20, 28);
            this.door23.TabIndex = 102;
            this.door23.UseVisualStyleBackColor = true;
            this.door23.Visible = false;
            // 
            // btn_OpenDoor23
            // 
            this.btn_OpenDoor23.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor23.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor23.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor23.Name = "btn_OpenDoor23";
            this.btn_OpenDoor23.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor23.TabIndex = 103;
            this.btn_OpenDoor23.Tag = "23";
            this.btn_OpenDoor23.Text = "开门";
            this.btn_OpenDoor23.UseVisualStyleBackColor = true;
            this.btn_OpenDoor23.Visible = false;
            this.btn_OpenDoor23.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb22
            // 
            this.cb22.AutoSize = true;
            this.cb22.BackColor = System.Drawing.Color.Transparent;
            this.cb22.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb22.DownBack = null;
            this.cb22.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb22.Location = new System.Drawing.Point(61, 54);
            this.cb22.MouseBack = null;
            this.cb22.Name = "cb22";
            this.cb22.NormlBack = null;
            this.cb22.SelectedDownBack = null;
            this.cb22.SelectedMouseBack = null;
            this.cb22.SelectedNormlBack = null;
            this.cb22.Size = new System.Drawing.Size(38, 14);
            this.cb22.TabIndex = 101;
            this.cb22.Tag = "1";
            this.cb22.Text = "常开";
            this.cb22.UseVisualStyleBackColor = false;
            this.cb22.Visible = false;
            // 
            // door22
            // 
            this.door22.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door22.Location = new System.Drawing.Point(65, 20);
            this.door22.Name = "door22";
            this.door22.Size = new System.Drawing.Size(20, 28);
            this.door22.TabIndex = 99;
            this.door22.UseVisualStyleBackColor = true;
            this.door22.Visible = false;
            // 
            // btn_OpenDoor22
            // 
            this.btn_OpenDoor22.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor22.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor22.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor22.Name = "btn_OpenDoor22";
            this.btn_OpenDoor22.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor22.TabIndex = 100;
            this.btn_OpenDoor22.Tag = "22";
            this.btn_OpenDoor22.Text = "开门";
            this.btn_OpenDoor22.UseVisualStyleBackColor = true;
            this.btn_OpenDoor22.Visible = false;
            this.btn_OpenDoor22.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb21
            // 
            this.cb21.AutoSize = true;
            this.cb21.BackColor = System.Drawing.Color.Transparent;
            this.cb21.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb21.DownBack = null;
            this.cb21.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb21.Location = new System.Drawing.Point(6, 54);
            this.cb21.MouseBack = null;
            this.cb21.Name = "cb21";
            this.cb21.NormlBack = null;
            this.cb21.SelectedDownBack = null;
            this.cb21.SelectedMouseBack = null;
            this.cb21.SelectedNormlBack = null;
            this.cb21.Size = new System.Drawing.Size(38, 14);
            this.cb21.TabIndex = 98;
            this.cb21.Tag = "1";
            this.cb21.Text = "常开";
            this.cb21.UseVisualStyleBackColor = false;
            this.cb21.Visible = false;
            // 
            // door21
            // 
            this.door21.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door21.Location = new System.Drawing.Point(10, 20);
            this.door21.Name = "door21";
            this.door21.Size = new System.Drawing.Size(20, 28);
            this.door21.TabIndex = 0;
            this.door21.UseVisualStyleBackColor = true;
            this.door21.Visible = false;
            // 
            // btn_OpenDoor21
            // 
            this.btn_OpenDoor21.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor21.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor21.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor21.Name = "btn_OpenDoor21";
            this.btn_OpenDoor21.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor21.TabIndex = 94;
            this.btn_OpenDoor21.Tag = "21";
            this.btn_OpenDoor21.Text = "开门";
            this.btn_OpenDoor21.UseVisualStyleBackColor = true;
            this.btn_OpenDoor21.Visible = false;
            this.btn_OpenDoor21.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group5
            // 
            this.door_Group5.BackColor = System.Drawing.Color.Transparent;
            this.door_Group5.BorderColor = System.Drawing.Color.Red;
            this.door_Group5.Controls.Add(this.cb20);
            this.door_Group5.Controls.Add(this.door20);
            this.door_Group5.Controls.Add(this.btn_OpenDoor20);
            this.door_Group5.Controls.Add(this.cb19);
            this.door_Group5.Controls.Add(this.door19);
            this.door_Group5.Controls.Add(this.btn_OpenDoor19);
            this.door_Group5.Controls.Add(this.cb18);
            this.door_Group5.Controls.Add(this.door18);
            this.door_Group5.Controls.Add(this.btn_OpenDoor18);
            this.door_Group5.Controls.Add(this.cb17);
            this.door_Group5.Controls.Add(this.door17);
            this.door_Group5.Controls.Add(this.btn_OpenDoor17);
            this.door_Group5.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group5.ForeColor = System.Drawing.Color.Blue;
            this.door_Group5.Location = new System.Drawing.Point(5, 324);
            this.door_Group5.Name = "door_Group5";
            this.door_Group5.RectBackColor = System.Drawing.Color.White;
            this.door_Group5.Size = new System.Drawing.Size(227, 105);
            this.door_Group5.TabIndex = 109;
            this.door_Group5.TabStop = false;
            this.door_Group5.Tag = "1";
            this.door_Group5.Text = "考勤门禁";
            this.door_Group5.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group5.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb20
            // 
            this.cb20.AutoSize = true;
            this.cb20.BackColor = System.Drawing.Color.Transparent;
            this.cb20.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb20.DownBack = null;
            this.cb20.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb20.Location = new System.Drawing.Point(169, 54);
            this.cb20.MouseBack = null;
            this.cb20.Name = "cb20";
            this.cb20.NormlBack = null;
            this.cb20.SelectedDownBack = null;
            this.cb20.SelectedMouseBack = null;
            this.cb20.SelectedNormlBack = null;
            this.cb20.Size = new System.Drawing.Size(38, 14);
            this.cb20.TabIndex = 107;
            this.cb20.Tag = "1";
            this.cb20.Text = "常开";
            this.cb20.UseVisualStyleBackColor = false;
            this.cb20.Visible = false;
            // 
            // door20
            // 
            this.door20.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door20.Location = new System.Drawing.Point(173, 20);
            this.door20.Name = "door20";
            this.door20.Size = new System.Drawing.Size(20, 28);
            this.door20.TabIndex = 105;
            this.door20.UseVisualStyleBackColor = true;
            this.door20.Visible = false;
            // 
            // btn_OpenDoor20
            // 
            this.btn_OpenDoor20.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor20.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor20.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor20.Name = "btn_OpenDoor20";
            this.btn_OpenDoor20.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor20.TabIndex = 106;
            this.btn_OpenDoor20.Tag = "20";
            this.btn_OpenDoor20.Text = "开门";
            this.btn_OpenDoor20.UseVisualStyleBackColor = true;
            this.btn_OpenDoor20.Visible = false;
            this.btn_OpenDoor20.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb19
            // 
            this.cb19.AutoSize = true;
            this.cb19.BackColor = System.Drawing.Color.Transparent;
            this.cb19.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb19.DownBack = null;
            this.cb19.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb19.Location = new System.Drawing.Point(116, 54);
            this.cb19.MouseBack = null;
            this.cb19.Name = "cb19";
            this.cb19.NormlBack = null;
            this.cb19.SelectedDownBack = null;
            this.cb19.SelectedMouseBack = null;
            this.cb19.SelectedNormlBack = null;
            this.cb19.Size = new System.Drawing.Size(38, 14);
            this.cb19.TabIndex = 104;
            this.cb19.Tag = "1";
            this.cb19.Text = "常开";
            this.cb19.UseVisualStyleBackColor = false;
            this.cb19.Visible = false;
            // 
            // door19
            // 
            this.door19.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door19.Location = new System.Drawing.Point(120, 20);
            this.door19.Name = "door19";
            this.door19.Size = new System.Drawing.Size(20, 28);
            this.door19.TabIndex = 102;
            this.door19.UseVisualStyleBackColor = true;
            this.door19.Visible = false;
            // 
            // btn_OpenDoor19
            // 
            this.btn_OpenDoor19.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor19.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor19.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor19.Name = "btn_OpenDoor19";
            this.btn_OpenDoor19.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor19.TabIndex = 103;
            this.btn_OpenDoor19.Tag = "19";
            this.btn_OpenDoor19.Text = "开门";
            this.btn_OpenDoor19.UseVisualStyleBackColor = true;
            this.btn_OpenDoor19.Visible = false;
            this.btn_OpenDoor19.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb18
            // 
            this.cb18.AutoSize = true;
            this.cb18.BackColor = System.Drawing.Color.Transparent;
            this.cb18.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb18.DownBack = null;
            this.cb18.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb18.Location = new System.Drawing.Point(61, 54);
            this.cb18.MouseBack = null;
            this.cb18.Name = "cb18";
            this.cb18.NormlBack = null;
            this.cb18.SelectedDownBack = null;
            this.cb18.SelectedMouseBack = null;
            this.cb18.SelectedNormlBack = null;
            this.cb18.Size = new System.Drawing.Size(38, 14);
            this.cb18.TabIndex = 101;
            this.cb18.Tag = "1";
            this.cb18.Text = "常开";
            this.cb18.UseVisualStyleBackColor = false;
            this.cb18.Visible = false;
            // 
            // door18
            // 
            this.door18.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door18.Location = new System.Drawing.Point(65, 20);
            this.door18.Name = "door18";
            this.door18.Size = new System.Drawing.Size(20, 28);
            this.door18.TabIndex = 99;
            this.door18.UseVisualStyleBackColor = true;
            this.door18.Visible = false;
            // 
            // btn_OpenDoor18
            // 
            this.btn_OpenDoor18.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor18.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor18.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor18.Name = "btn_OpenDoor18";
            this.btn_OpenDoor18.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor18.TabIndex = 100;
            this.btn_OpenDoor18.Tag = "18";
            this.btn_OpenDoor18.Text = "开门";
            this.btn_OpenDoor18.UseVisualStyleBackColor = true;
            this.btn_OpenDoor18.Visible = false;
            this.btn_OpenDoor18.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb17
            // 
            this.cb17.AutoSize = true;
            this.cb17.BackColor = System.Drawing.Color.Transparent;
            this.cb17.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb17.DownBack = null;
            this.cb17.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb17.Location = new System.Drawing.Point(6, 54);
            this.cb17.MouseBack = null;
            this.cb17.Name = "cb17";
            this.cb17.NormlBack = null;
            this.cb17.SelectedDownBack = null;
            this.cb17.SelectedMouseBack = null;
            this.cb17.SelectedNormlBack = null;
            this.cb17.Size = new System.Drawing.Size(38, 14);
            this.cb17.TabIndex = 98;
            this.cb17.Tag = "1";
            this.cb17.Text = "常开";
            this.cb17.UseVisualStyleBackColor = false;
            this.cb17.Visible = false;
            // 
            // door17
            // 
            this.door17.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door17.Location = new System.Drawing.Point(10, 20);
            this.door17.Name = "door17";
            this.door17.Size = new System.Drawing.Size(20, 28);
            this.door17.TabIndex = 0;
            this.door17.UseVisualStyleBackColor = true;
            this.door17.Visible = false;
            // 
            // btn_OpenDoor17
            // 
            this.btn_OpenDoor17.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor17.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor17.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor17.Name = "btn_OpenDoor17";
            this.btn_OpenDoor17.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor17.TabIndex = 94;
            this.btn_OpenDoor17.Tag = "17";
            this.btn_OpenDoor17.Text = "开门";
            this.btn_OpenDoor17.UseVisualStyleBackColor = true;
            this.btn_OpenDoor17.Visible = false;
            this.btn_OpenDoor17.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group4
            // 
            this.door_Group4.BackColor = System.Drawing.Color.Transparent;
            this.door_Group4.BorderColor = System.Drawing.Color.Red;
            this.door_Group4.Controls.Add(this.cb16);
            this.door_Group4.Controls.Add(this.door16);
            this.door_Group4.Controls.Add(this.btn_OpenDoor16);
            this.door_Group4.Controls.Add(this.cb15);
            this.door_Group4.Controls.Add(this.door15);
            this.door_Group4.Controls.Add(this.btn_OpenDoor15);
            this.door_Group4.Controls.Add(this.cb14);
            this.door_Group4.Controls.Add(this.door14);
            this.door_Group4.Controls.Add(this.btn_OpenDoor14);
            this.door_Group4.Controls.Add(this.cb13);
            this.door_Group4.Controls.Add(this.door13);
            this.door_Group4.Controls.Add(this.btn_OpenDoor13);
            this.door_Group4.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group4.ForeColor = System.Drawing.Color.Blue;
            this.door_Group4.Location = new System.Drawing.Point(238, 172);
            this.door_Group4.Name = "door_Group4";
            this.door_Group4.RectBackColor = System.Drawing.Color.White;
            this.door_Group4.Size = new System.Drawing.Size(227, 105);
            this.door_Group4.TabIndex = 108;
            this.door_Group4.TabStop = false;
            this.door_Group4.Tag = "1";
            this.door_Group4.Text = "考勤门禁";
            this.door_Group4.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group4.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb16
            // 
            this.cb16.AutoSize = true;
            this.cb16.BackColor = System.Drawing.Color.Transparent;
            this.cb16.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb16.DownBack = null;
            this.cb16.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb16.Location = new System.Drawing.Point(169, 54);
            this.cb16.MouseBack = null;
            this.cb16.Name = "cb16";
            this.cb16.NormlBack = null;
            this.cb16.SelectedDownBack = null;
            this.cb16.SelectedMouseBack = null;
            this.cb16.SelectedNormlBack = null;
            this.cb16.Size = new System.Drawing.Size(38, 14);
            this.cb16.TabIndex = 107;
            this.cb16.Tag = "1";
            this.cb16.Text = "常开";
            this.cb16.UseVisualStyleBackColor = false;
            this.cb16.Visible = false;
            // 
            // door16
            // 
            this.door16.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door16.Location = new System.Drawing.Point(173, 20);
            this.door16.Name = "door16";
            this.door16.Size = new System.Drawing.Size(20, 28);
            this.door16.TabIndex = 105;
            this.door16.UseVisualStyleBackColor = true;
            this.door16.Visible = false;
            // 
            // btn_OpenDoor16
            // 
            this.btn_OpenDoor16.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor16.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor16.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor16.Name = "btn_OpenDoor16";
            this.btn_OpenDoor16.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor16.TabIndex = 106;
            this.btn_OpenDoor16.Tag = "16";
            this.btn_OpenDoor16.Text = "开门";
            this.btn_OpenDoor16.UseVisualStyleBackColor = true;
            this.btn_OpenDoor16.Visible = false;
            this.btn_OpenDoor16.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb15
            // 
            this.cb15.AutoSize = true;
            this.cb15.BackColor = System.Drawing.Color.Transparent;
            this.cb15.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb15.DownBack = null;
            this.cb15.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb15.Location = new System.Drawing.Point(116, 54);
            this.cb15.MouseBack = null;
            this.cb15.Name = "cb15";
            this.cb15.NormlBack = null;
            this.cb15.SelectedDownBack = null;
            this.cb15.SelectedMouseBack = null;
            this.cb15.SelectedNormlBack = null;
            this.cb15.Size = new System.Drawing.Size(38, 14);
            this.cb15.TabIndex = 104;
            this.cb15.Tag = "1";
            this.cb15.Text = "常开";
            this.cb15.UseVisualStyleBackColor = false;
            this.cb15.Visible = false;
            // 
            // door15
            // 
            this.door15.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door15.Location = new System.Drawing.Point(120, 20);
            this.door15.Name = "door15";
            this.door15.Size = new System.Drawing.Size(20, 28);
            this.door15.TabIndex = 102;
            this.door15.UseVisualStyleBackColor = true;
            this.door15.Visible = false;
            // 
            // btn_OpenDoor15
            // 
            this.btn_OpenDoor15.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor15.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor15.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor15.Name = "btn_OpenDoor15";
            this.btn_OpenDoor15.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor15.TabIndex = 103;
            this.btn_OpenDoor15.Tag = "15";
            this.btn_OpenDoor15.Text = "开门";
            this.btn_OpenDoor15.UseVisualStyleBackColor = true;
            this.btn_OpenDoor15.Visible = false;
            this.btn_OpenDoor15.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb14
            // 
            this.cb14.AutoSize = true;
            this.cb14.BackColor = System.Drawing.Color.Transparent;
            this.cb14.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb14.DownBack = null;
            this.cb14.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb14.Location = new System.Drawing.Point(61, 54);
            this.cb14.MouseBack = null;
            this.cb14.Name = "cb14";
            this.cb14.NormlBack = null;
            this.cb14.SelectedDownBack = null;
            this.cb14.SelectedMouseBack = null;
            this.cb14.SelectedNormlBack = null;
            this.cb14.Size = new System.Drawing.Size(38, 14);
            this.cb14.TabIndex = 101;
            this.cb14.Tag = "1";
            this.cb14.Text = "常开";
            this.cb14.UseVisualStyleBackColor = false;
            this.cb14.Visible = false;
            // 
            // door14
            // 
            this.door14.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door14.Location = new System.Drawing.Point(65, 20);
            this.door14.Name = "door14";
            this.door14.Size = new System.Drawing.Size(20, 28);
            this.door14.TabIndex = 99;
            this.door14.UseVisualStyleBackColor = true;
            this.door14.Visible = false;
            // 
            // btn_OpenDoor14
            // 
            this.btn_OpenDoor14.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor14.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor14.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor14.Name = "btn_OpenDoor14";
            this.btn_OpenDoor14.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor14.TabIndex = 100;
            this.btn_OpenDoor14.Tag = "14";
            this.btn_OpenDoor14.Text = "开门";
            this.btn_OpenDoor14.UseVisualStyleBackColor = true;
            this.btn_OpenDoor14.Visible = false;
            this.btn_OpenDoor14.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb13
            // 
            this.cb13.AutoSize = true;
            this.cb13.BackColor = System.Drawing.Color.Transparent;
            this.cb13.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb13.DownBack = null;
            this.cb13.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb13.Location = new System.Drawing.Point(6, 54);
            this.cb13.MouseBack = null;
            this.cb13.Name = "cb13";
            this.cb13.NormlBack = null;
            this.cb13.SelectedDownBack = null;
            this.cb13.SelectedMouseBack = null;
            this.cb13.SelectedNormlBack = null;
            this.cb13.Size = new System.Drawing.Size(38, 14);
            this.cb13.TabIndex = 98;
            this.cb13.Tag = "1";
            this.cb13.Text = "常开";
            this.cb13.UseVisualStyleBackColor = false;
            this.cb13.Visible = false;
            // 
            // door13
            // 
            this.door13.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door13.Location = new System.Drawing.Point(10, 20);
            this.door13.Name = "door13";
            this.door13.Size = new System.Drawing.Size(20, 28);
            this.door13.TabIndex = 0;
            this.door13.UseVisualStyleBackColor = true;
            this.door13.Visible = false;
            // 
            // btn_OpenDoor13
            // 
            this.btn_OpenDoor13.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor13.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor13.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor13.Name = "btn_OpenDoor13";
            this.btn_OpenDoor13.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor13.TabIndex = 94;
            this.btn_OpenDoor13.Tag = "13";
            this.btn_OpenDoor13.Text = "开门";
            this.btn_OpenDoor13.UseVisualStyleBackColor = true;
            this.btn_OpenDoor13.Visible = false;
            this.btn_OpenDoor13.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group3
            // 
            this.door_Group3.BackColor = System.Drawing.Color.Transparent;
            this.door_Group3.BorderColor = System.Drawing.Color.Red;
            this.door_Group3.Controls.Add(this.cb12);
            this.door_Group3.Controls.Add(this.door12);
            this.door_Group3.Controls.Add(this.btn_OpenDoor12);
            this.door_Group3.Controls.Add(this.cb11);
            this.door_Group3.Controls.Add(this.door11);
            this.door_Group3.Controls.Add(this.btn_OpenDoor11);
            this.door_Group3.Controls.Add(this.cb10);
            this.door_Group3.Controls.Add(this.door10);
            this.door_Group3.Controls.Add(this.btn_OpenDoor10);
            this.door_Group3.Controls.Add(this.cb9);
            this.door_Group3.Controls.Add(this.door9);
            this.door_Group3.Controls.Add(this.btn_OpenDoor9);
            this.door_Group3.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group3.ForeColor = System.Drawing.Color.Blue;
            this.door_Group3.Location = new System.Drawing.Point(5, 172);
            this.door_Group3.Name = "door_Group3";
            this.door_Group3.RectBackColor = System.Drawing.Color.White;
            this.door_Group3.Size = new System.Drawing.Size(227, 105);
            this.door_Group3.TabIndex = 108;
            this.door_Group3.TabStop = false;
            this.door_Group3.Tag = "1";
            this.door_Group3.Text = "考勤门禁";
            this.door_Group3.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group3.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb12
            // 
            this.cb12.AutoSize = true;
            this.cb12.BackColor = System.Drawing.Color.Transparent;
            this.cb12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb12.DownBack = null;
            this.cb12.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb12.Location = new System.Drawing.Point(169, 54);
            this.cb12.MouseBack = null;
            this.cb12.Name = "cb12";
            this.cb12.NormlBack = null;
            this.cb12.SelectedDownBack = null;
            this.cb12.SelectedMouseBack = null;
            this.cb12.SelectedNormlBack = null;
            this.cb12.Size = new System.Drawing.Size(38, 14);
            this.cb12.TabIndex = 107;
            this.cb12.Tag = "1";
            this.cb12.Text = "常开";
            this.cb12.UseVisualStyleBackColor = false;
            this.cb12.Visible = false;
            // 
            // door12
            // 
            this.door12.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door12.Location = new System.Drawing.Point(173, 20);
            this.door12.Name = "door12";
            this.door12.Size = new System.Drawing.Size(20, 28);
            this.door12.TabIndex = 105;
            this.door12.UseVisualStyleBackColor = true;
            this.door12.Visible = false;
            // 
            // btn_OpenDoor12
            // 
            this.btn_OpenDoor12.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor12.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor12.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor12.Name = "btn_OpenDoor12";
            this.btn_OpenDoor12.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor12.TabIndex = 106;
            this.btn_OpenDoor12.Tag = "12";
            this.btn_OpenDoor12.Text = "开门";
            this.btn_OpenDoor12.UseVisualStyleBackColor = true;
            this.btn_OpenDoor12.Visible = false;
            this.btn_OpenDoor12.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb11
            // 
            this.cb11.AutoSize = true;
            this.cb11.BackColor = System.Drawing.Color.Transparent;
            this.cb11.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb11.DownBack = null;
            this.cb11.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb11.Location = new System.Drawing.Point(116, 54);
            this.cb11.MouseBack = null;
            this.cb11.Name = "cb11";
            this.cb11.NormlBack = null;
            this.cb11.SelectedDownBack = null;
            this.cb11.SelectedMouseBack = null;
            this.cb11.SelectedNormlBack = null;
            this.cb11.Size = new System.Drawing.Size(38, 14);
            this.cb11.TabIndex = 104;
            this.cb11.Tag = "1";
            this.cb11.Text = "常开";
            this.cb11.UseVisualStyleBackColor = false;
            this.cb11.Visible = false;
            // 
            // door11
            // 
            this.door11.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door11.Location = new System.Drawing.Point(120, 20);
            this.door11.Name = "door11";
            this.door11.Size = new System.Drawing.Size(20, 28);
            this.door11.TabIndex = 102;
            this.door11.UseVisualStyleBackColor = true;
            this.door11.Visible = false;
            // 
            // btn_OpenDoor11
            // 
            this.btn_OpenDoor11.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor11.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor11.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor11.Name = "btn_OpenDoor11";
            this.btn_OpenDoor11.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor11.TabIndex = 103;
            this.btn_OpenDoor11.Tag = "11";
            this.btn_OpenDoor11.Text = "开门";
            this.btn_OpenDoor11.UseVisualStyleBackColor = true;
            this.btn_OpenDoor11.Visible = false;
            this.btn_OpenDoor11.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb10
            // 
            this.cb10.AutoSize = true;
            this.cb10.BackColor = System.Drawing.Color.Transparent;
            this.cb10.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb10.DownBack = null;
            this.cb10.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb10.Location = new System.Drawing.Point(61, 54);
            this.cb10.MouseBack = null;
            this.cb10.Name = "cb10";
            this.cb10.NormlBack = null;
            this.cb10.SelectedDownBack = null;
            this.cb10.SelectedMouseBack = null;
            this.cb10.SelectedNormlBack = null;
            this.cb10.Size = new System.Drawing.Size(38, 14);
            this.cb10.TabIndex = 101;
            this.cb10.Tag = "1";
            this.cb10.Text = "常开";
            this.cb10.UseVisualStyleBackColor = false;
            this.cb10.Visible = false;
            // 
            // door10
            // 
            this.door10.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door10.Location = new System.Drawing.Point(65, 20);
            this.door10.Name = "door10";
            this.door10.Size = new System.Drawing.Size(20, 28);
            this.door10.TabIndex = 99;
            this.door10.UseVisualStyleBackColor = true;
            this.door10.Visible = false;
            // 
            // btn_OpenDoor10
            // 
            this.btn_OpenDoor10.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor10.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor10.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor10.Name = "btn_OpenDoor10";
            this.btn_OpenDoor10.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor10.TabIndex = 100;
            this.btn_OpenDoor10.Tag = "10";
            this.btn_OpenDoor10.Text = "开门";
            this.btn_OpenDoor10.UseVisualStyleBackColor = true;
            this.btn_OpenDoor10.Visible = false;
            this.btn_OpenDoor10.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb9
            // 
            this.cb9.AutoSize = true;
            this.cb9.BackColor = System.Drawing.Color.Transparent;
            this.cb9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb9.DownBack = null;
            this.cb9.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb9.Location = new System.Drawing.Point(6, 54);
            this.cb9.MouseBack = null;
            this.cb9.Name = "cb9";
            this.cb9.NormlBack = null;
            this.cb9.SelectedDownBack = null;
            this.cb9.SelectedMouseBack = null;
            this.cb9.SelectedNormlBack = null;
            this.cb9.Size = new System.Drawing.Size(38, 14);
            this.cb9.TabIndex = 98;
            this.cb9.Tag = "1";
            this.cb9.Text = "常开";
            this.cb9.UseVisualStyleBackColor = false;
            this.cb9.Visible = false;
            // 
            // door9
            // 
            this.door9.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door9.Location = new System.Drawing.Point(10, 20);
            this.door9.Name = "door9";
            this.door9.Size = new System.Drawing.Size(20, 28);
            this.door9.TabIndex = 0;
            this.door9.UseVisualStyleBackColor = true;
            this.door9.Visible = false;
            // 
            // btn_OpenDoor9
            // 
            this.btn_OpenDoor9.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor9.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor9.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor9.Name = "btn_OpenDoor9";
            this.btn_OpenDoor9.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor9.TabIndex = 94;
            this.btn_OpenDoor9.Tag = "9";
            this.btn_OpenDoor9.Text = "开门";
            this.btn_OpenDoor9.UseVisualStyleBackColor = true;
            this.btn_OpenDoor9.Visible = false;
            this.btn_OpenDoor9.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group2
            // 
            this.door_Group2.BackColor = System.Drawing.Color.Transparent;
            this.door_Group2.BorderColor = System.Drawing.Color.Red;
            this.door_Group2.Controls.Add(this.cb8);
            this.door_Group2.Controls.Add(this.door8);
            this.door_Group2.Controls.Add(this.btn_OpenDoor8);
            this.door_Group2.Controls.Add(this.cb7);
            this.door_Group2.Controls.Add(this.door7);
            this.door_Group2.Controls.Add(this.btn_OpenDoor7);
            this.door_Group2.Controls.Add(this.cb6);
            this.door_Group2.Controls.Add(this.door6);
            this.door_Group2.Controls.Add(this.btn_OpenDoor6);
            this.door_Group2.Controls.Add(this.cb5);
            this.door_Group2.Controls.Add(this.door5);
            this.door_Group2.Controls.Add(this.btn_OpenDoor5);
            this.door_Group2.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group2.ForeColor = System.Drawing.Color.Blue;
            this.door_Group2.Location = new System.Drawing.Point(240, 22);
            this.door_Group2.Name = "door_Group2";
            this.door_Group2.RectBackColor = System.Drawing.Color.White;
            this.door_Group2.Size = new System.Drawing.Size(227, 105);
            this.door_Group2.TabIndex = 108;
            this.door_Group2.TabStop = false;
            this.door_Group2.Tag = "1";
            this.door_Group2.Text = "考勤门禁";
            this.door_Group2.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group2.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb8
            // 
            this.cb8.AutoSize = true;
            this.cb8.BackColor = System.Drawing.Color.Transparent;
            this.cb8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb8.DownBack = null;
            this.cb8.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb8.Location = new System.Drawing.Point(169, 54);
            this.cb8.MouseBack = null;
            this.cb8.Name = "cb8";
            this.cb8.NormlBack = null;
            this.cb8.SelectedDownBack = null;
            this.cb8.SelectedMouseBack = null;
            this.cb8.SelectedNormlBack = null;
            this.cb8.Size = new System.Drawing.Size(38, 14);
            this.cb8.TabIndex = 107;
            this.cb8.Tag = "1";
            this.cb8.Text = "常开";
            this.cb8.UseVisualStyleBackColor = false;
            this.cb8.Visible = false;
            // 
            // door8
            // 
            this.door8.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door8.Location = new System.Drawing.Point(173, 20);
            this.door8.Name = "door8";
            this.door8.Size = new System.Drawing.Size(20, 28);
            this.door8.TabIndex = 105;
            this.door8.UseVisualStyleBackColor = true;
            this.door8.Visible = false;
            // 
            // btn_OpenDoor8
            // 
            this.btn_OpenDoor8.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor8.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor8.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor8.Name = "btn_OpenDoor8";
            this.btn_OpenDoor8.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor8.TabIndex = 106;
            this.btn_OpenDoor8.Tag = "8";
            this.btn_OpenDoor8.Text = "开门";
            this.btn_OpenDoor8.UseVisualStyleBackColor = true;
            this.btn_OpenDoor8.Visible = false;
            this.btn_OpenDoor8.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb7
            // 
            this.cb7.AutoSize = true;
            this.cb7.BackColor = System.Drawing.Color.Transparent;
            this.cb7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb7.DownBack = null;
            this.cb7.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb7.Location = new System.Drawing.Point(116, 54);
            this.cb7.MouseBack = null;
            this.cb7.Name = "cb7";
            this.cb7.NormlBack = null;
            this.cb7.SelectedDownBack = null;
            this.cb7.SelectedMouseBack = null;
            this.cb7.SelectedNormlBack = null;
            this.cb7.Size = new System.Drawing.Size(38, 14);
            this.cb7.TabIndex = 104;
            this.cb7.Tag = "1";
            this.cb7.Text = "常开";
            this.cb7.UseVisualStyleBackColor = false;
            this.cb7.Visible = false;
            // 
            // door7
            // 
            this.door7.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door7.Location = new System.Drawing.Point(120, 20);
            this.door7.Name = "door7";
            this.door7.Size = new System.Drawing.Size(20, 28);
            this.door7.TabIndex = 102;
            this.door7.UseVisualStyleBackColor = true;
            this.door7.Visible = false;
            // 
            // btn_OpenDoor7
            // 
            this.btn_OpenDoor7.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor7.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor7.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor7.Name = "btn_OpenDoor7";
            this.btn_OpenDoor7.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor7.TabIndex = 103;
            this.btn_OpenDoor7.Tag = "7";
            this.btn_OpenDoor7.Text = "开门";
            this.btn_OpenDoor7.UseVisualStyleBackColor = true;
            this.btn_OpenDoor7.Visible = false;
            this.btn_OpenDoor7.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb6
            // 
            this.cb6.AutoSize = true;
            this.cb6.BackColor = System.Drawing.Color.Transparent;
            this.cb6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb6.DownBack = null;
            this.cb6.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb6.Location = new System.Drawing.Point(61, 54);
            this.cb6.MouseBack = null;
            this.cb6.Name = "cb6";
            this.cb6.NormlBack = null;
            this.cb6.SelectedDownBack = null;
            this.cb6.SelectedMouseBack = null;
            this.cb6.SelectedNormlBack = null;
            this.cb6.Size = new System.Drawing.Size(38, 14);
            this.cb6.TabIndex = 101;
            this.cb6.Tag = "1";
            this.cb6.Text = "常开";
            this.cb6.UseVisualStyleBackColor = false;
            this.cb6.Visible = false;
            // 
            // door6
            // 
            this.door6.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door6.Location = new System.Drawing.Point(65, 20);
            this.door6.Name = "door6";
            this.door6.Size = new System.Drawing.Size(20, 28);
            this.door6.TabIndex = 99;
            this.door6.UseVisualStyleBackColor = true;
            this.door6.Visible = false;
            // 
            // btn_OpenDoor6
            // 
            this.btn_OpenDoor6.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor6.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor6.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor6.Name = "btn_OpenDoor6";
            this.btn_OpenDoor6.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor6.TabIndex = 100;
            this.btn_OpenDoor6.Tag = "6";
            this.btn_OpenDoor6.Text = "开门";
            this.btn_OpenDoor6.UseVisualStyleBackColor = true;
            this.btn_OpenDoor6.Visible = false;
            this.btn_OpenDoor6.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb5
            // 
            this.cb5.AutoSize = true;
            this.cb5.BackColor = System.Drawing.Color.Transparent;
            this.cb5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb5.DownBack = null;
            this.cb5.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb5.Location = new System.Drawing.Point(6, 54);
            this.cb5.MouseBack = null;
            this.cb5.Name = "cb5";
            this.cb5.NormlBack = null;
            this.cb5.SelectedDownBack = null;
            this.cb5.SelectedMouseBack = null;
            this.cb5.SelectedNormlBack = null;
            this.cb5.Size = new System.Drawing.Size(38, 14);
            this.cb5.TabIndex = 98;
            this.cb5.Tag = "1";
            this.cb5.Text = "常开";
            this.cb5.UseVisualStyleBackColor = false;
            this.cb5.Visible = false;
            // 
            // door5
            // 
            this.door5.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door5.Location = new System.Drawing.Point(10, 20);
            this.door5.Name = "door5";
            this.door5.Size = new System.Drawing.Size(20, 28);
            this.door5.TabIndex = 0;
            this.door5.UseVisualStyleBackColor = true;
            this.door5.Visible = false;
            // 
            // btn_OpenDoor5
            // 
            this.btn_OpenDoor5.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor5.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor5.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor5.Name = "btn_OpenDoor5";
            this.btn_OpenDoor5.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor5.TabIndex = 94;
            this.btn_OpenDoor5.Tag = "5";
            this.btn_OpenDoor5.Text = "开门";
            this.btn_OpenDoor5.UseVisualStyleBackColor = true;
            this.btn_OpenDoor5.Visible = false;
            this.btn_OpenDoor5.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // door_Group1
            // 
            this.door_Group1.BackColor = System.Drawing.Color.Transparent;
            this.door_Group1.BorderColor = System.Drawing.Color.Red;
            this.door_Group1.Controls.Add(this.cb4);
            this.door_Group1.Controls.Add(this.door4);
            this.door_Group1.Controls.Add(this.btn_OpenDoor4);
            this.door_Group1.Controls.Add(this.cb3);
            this.door_Group1.Controls.Add(this.door3);
            this.door_Group1.Controls.Add(this.btn_OpenDoor3);
            this.door_Group1.Controls.Add(this.cb2);
            this.door_Group1.Controls.Add(this.door2);
            this.door_Group1.Controls.Add(this.btn_OpenDoor2);
            this.door_Group1.Controls.Add(this.cb1);
            this.door_Group1.Controls.Add(this.door1);
            this.door_Group1.Controls.Add(this.btn_OpenDoor1);
            this.door_Group1.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.door_Group1.ForeColor = System.Drawing.Color.Blue;
            this.door_Group1.Location = new System.Drawing.Point(5, 22);
            this.door_Group1.Name = "door_Group1";
            this.door_Group1.RectBackColor = System.Drawing.Color.White;
            this.door_Group1.Size = new System.Drawing.Size(227, 105);
            this.door_Group1.TabIndex = 100;
            this.door_Group1.TabStop = false;
            this.door_Group1.Tag = "1";
            this.door_Group1.Text = "考勤门禁";
            this.door_Group1.TitleBorderColor = System.Drawing.Color.Red;
            this.door_Group1.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.BackColor = System.Drawing.Color.Transparent;
            this.cb4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb4.DownBack = null;
            this.cb4.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb4.Location = new System.Drawing.Point(169, 54);
            this.cb4.MouseBack = null;
            this.cb4.Name = "cb4";
            this.cb4.NormlBack = null;
            this.cb4.SelectedDownBack = null;
            this.cb4.SelectedMouseBack = null;
            this.cb4.SelectedNormlBack = null;
            this.cb4.Size = new System.Drawing.Size(38, 14);
            this.cb4.TabIndex = 107;
            this.cb4.Tag = "1";
            this.cb4.Text = "常开";
            this.cb4.UseVisualStyleBackColor = false;
            this.cb4.Visible = false;
            // 
            // door4
            // 
            this.door4.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door4.Location = new System.Drawing.Point(173, 20);
            this.door4.Name = "door4";
            this.door4.Size = new System.Drawing.Size(20, 28);
            this.door4.TabIndex = 105;
            this.door4.UseVisualStyleBackColor = true;
            this.door4.Visible = false;
            // 
            // btn_OpenDoor4
            // 
            this.btn_OpenDoor4.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor4.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor4.Location = new System.Drawing.Point(173, 74);
            this.btn_OpenDoor4.Name = "btn_OpenDoor4";
            this.btn_OpenDoor4.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor4.TabIndex = 106;
            this.btn_OpenDoor4.Tag = "4";
            this.btn_OpenDoor4.Text = "开门";
            this.btn_OpenDoor4.UseVisualStyleBackColor = true;
            this.btn_OpenDoor4.Visible = false;
            this.btn_OpenDoor4.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.BackColor = System.Drawing.Color.Transparent;
            this.cb3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb3.DownBack = null;
            this.cb3.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb3.Location = new System.Drawing.Point(116, 54);
            this.cb3.MouseBack = null;
            this.cb3.Name = "cb3";
            this.cb3.NormlBack = null;
            this.cb3.SelectedDownBack = null;
            this.cb3.SelectedMouseBack = null;
            this.cb3.SelectedNormlBack = null;
            this.cb3.Size = new System.Drawing.Size(38, 14);
            this.cb3.TabIndex = 104;
            this.cb3.Tag = "1";
            this.cb3.Text = "常开";
            this.cb3.UseVisualStyleBackColor = false;
            this.cb3.Visible = false;
            // 
            // door3
            // 
            this.door3.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door3.Location = new System.Drawing.Point(120, 20);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(20, 28);
            this.door3.TabIndex = 102;
            this.door3.UseVisualStyleBackColor = true;
            this.door3.Visible = false;
            // 
            // btn_OpenDoor3
            // 
            this.btn_OpenDoor3.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor3.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor3.Location = new System.Drawing.Point(120, 74);
            this.btn_OpenDoor3.Name = "btn_OpenDoor3";
            this.btn_OpenDoor3.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor3.TabIndex = 103;
            this.btn_OpenDoor3.Tag = "3";
            this.btn_OpenDoor3.Text = "开门";
            this.btn_OpenDoor3.UseVisualStyleBackColor = true;
            this.btn_OpenDoor3.Visible = false;
            this.btn_OpenDoor3.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.BackColor = System.Drawing.Color.Transparent;
            this.cb2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb2.DownBack = null;
            this.cb2.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb2.Location = new System.Drawing.Point(61, 54);
            this.cb2.MouseBack = null;
            this.cb2.Name = "cb2";
            this.cb2.NormlBack = null;
            this.cb2.SelectedDownBack = null;
            this.cb2.SelectedMouseBack = null;
            this.cb2.SelectedNormlBack = null;
            this.cb2.Size = new System.Drawing.Size(38, 14);
            this.cb2.TabIndex = 101;
            this.cb2.Tag = "1";
            this.cb2.Text = "常开";
            this.cb2.UseVisualStyleBackColor = false;
            this.cb2.Visible = false;
            // 
            // door2
            // 
            this.door2.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door2.Location = new System.Drawing.Point(65, 20);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(20, 28);
            this.door2.TabIndex = 99;
            this.door2.UseVisualStyleBackColor = true;
            this.door2.Visible = false;
            // 
            // btn_OpenDoor2
            // 
            this.btn_OpenDoor2.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor2.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor2.Location = new System.Drawing.Point(65, 74);
            this.btn_OpenDoor2.Name = "btn_OpenDoor2";
            this.btn_OpenDoor2.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor2.TabIndex = 100;
            this.btn_OpenDoor2.Tag = "2";
            this.btn_OpenDoor2.Text = "开门";
            this.btn_OpenDoor2.UseVisualStyleBackColor = true;
            this.btn_OpenDoor2.Visible = false;
            this.btn_OpenDoor2.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.BackColor = System.Drawing.Color.Transparent;
            this.cb1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cb1.DownBack = null;
            this.cb1.Font = new System.Drawing.Font("微软雅黑", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb1.Location = new System.Drawing.Point(6, 54);
            this.cb1.MouseBack = null;
            this.cb1.Name = "cb1";
            this.cb1.NormlBack = null;
            this.cb1.SelectedDownBack = null;
            this.cb1.SelectedMouseBack = null;
            this.cb1.SelectedNormlBack = null;
            this.cb1.Size = new System.Drawing.Size(38, 14);
            this.cb1.TabIndex = 98;
            this.cb1.Tag = "1";
            this.cb1.Text = "常开";
            this.cb1.UseVisualStyleBackColor = false;
            this.cb1.Visible = false;
            // 
            // door1
            // 
            this.door1.BackgroundImage = global::Demo.Properties.Resources.未标题_1;
            this.door1.Location = new System.Drawing.Point(10, 20);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(20, 28);
            this.door1.TabIndex = 0;
            this.door1.UseVisualStyleBackColor = true;
            this.door1.Visible = false;
            // 
            // btn_OpenDoor1
            // 
            this.btn_OpenDoor1.BackgroundImage = global::Demo.Properties.Resources.btn_bag;
            this.btn_OpenDoor1.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenDoor1.Location = new System.Drawing.Point(10, 74);
            this.btn_OpenDoor1.Name = "btn_OpenDoor1";
            this.btn_OpenDoor1.Size = new System.Drawing.Size(34, 21);
            this.btn_OpenDoor1.TabIndex = 94;
            this.btn_OpenDoor1.Tag = "1";
            this.btn_OpenDoor1.Text = "开门";
            this.btn_OpenDoor1.UseVisualStyleBackColor = true;
            this.btn_OpenDoor1.Visible = false;
            this.btn_OpenDoor1.Click += new System.EventHandler(this.btn_OpenDoor1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_Animal_Search);
            this.tabPage4.Controls.Add(this.dgv_Animal);
            this.tabPage4.Controls.Add(this.txt_Animal_Search);
            this.tabPage4.Controls.Add(this.skinLabel143);
            this.tabPage4.ImageIndex = 7;
            this.tabPage4.Location = new System.Drawing.Point(0, 75);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1024, 665);
            this.tabPage4.TabIndex = 7;
            this.tabPage4.Text = "动物流向";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_Animal_Search
            // 
            this.btn_Animal_Search.BackColor = System.Drawing.Color.White;
            this.btn_Animal_Search.BaseColor = System.Drawing.Color.White;
            this.btn_Animal_Search.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_Animal_Search.DownBack = null;
            this.btn_Animal_Search.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Animal_Search.ForeColor = System.Drawing.Color.Black;
            this.btn_Animal_Search.Location = new System.Drawing.Point(903, -6);
            this.btn_Animal_Search.MouseBack = null;
            this.btn_Animal_Search.Name = "btn_Animal_Search";
            this.btn_Animal_Search.NormlBack = null;
            this.btn_Animal_Search.Size = new System.Drawing.Size(83, 46);
            this.btn_Animal_Search.TabIndex = 18;
            this.btn_Animal_Search.Text = "查询";
            this.btn_Animal_Search.UseVisualStyleBackColor = false;
            this.btn_Animal_Search.Click += new System.EventHandler(this.btn_Animal_Search_Click);
            // 
            // dgv_Animal
            // 
            this.dgv_Animal.AllowUserToAddRows = false;
            this.dgv_Animal.AllowUserToDeleteRows = false;
            this.dgv_Animal.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.dgv_Animal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Animal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Animal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Animal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Animal.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Animal.Location = new System.Drawing.Point(7, 48);
            this.dgv_Animal.MultiSelect = false;
            this.dgv_Animal.Name = "dgv_Animal";
            this.dgv_Animal.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Animal.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Animal.RowTemplate.Height = 23;
            this.dgv_Animal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Animal.Size = new System.Drawing.Size(1010, 577);
            this.dgv_Animal.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn23.HeaderText = "流水编号";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn53.HeaderText = "学生姓名";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Width = 120;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.DataPropertyName = "ID_Card_Number";
            this.dataGridViewTextBoxColumn55.HeaderText = "身份证号";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Width = 120;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.DataPropertyName = "PI";
            this.dataGridViewTextBoxColumn56.HeaderText = "PI";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.DataPropertyName = "Effective_Time";
            this.dataGridViewTextBoxColumn57.HeaderText = "有效时间";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.DataPropertyName = "Animal_Species";
            this.dataGridViewTextBoxColumn58.HeaderText = "动物种类";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.DataPropertyName = "Animal_Count";
            this.dataGridViewTextBoxColumn64.HeaderText = "动物数量";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.DataPropertyName = "Laboratory";
            this.dataGridViewTextBoxColumn65.HeaderText = "实验室";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.Width = 120;
            // 
            // txt_Animal_Search
            // 
            this.txt_Animal_Search.Location = new System.Drawing.Point(104, 11);
            this.txt_Animal_Search.Multiline = true;
            this.txt_Animal_Search.Name = "txt_Animal_Search";
            this.txt_Animal_Search.Size = new System.Drawing.Size(793, 29);
            this.txt_Animal_Search.TabIndex = 16;
            this.txt_Animal_Search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txt_Animal_Search.WaterText = "";
            this.txt_Animal_Search.MouseEnter += new System.EventHandler(this.txt_Animal_Search_MouseEnter);
            this.txt_Animal_Search.MouseLeave += new System.EventHandler(this.txt_Animal_Search_MouseLeave);
            // 
            // skinLabel143
            // 
            this.skinLabel143.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel143.AutoSize = true;
            this.skinLabel143.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel143.BorderColor = System.Drawing.Color.White;
            this.skinLabel143.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel143.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.skinLabel143.Location = new System.Drawing.Point(19, 16);
            this.skinLabel143.Name = "skinLabel143";
            this.skinLabel143.Size = new System.Drawing.Size(79, 19);
            this.skinLabel143.TabIndex = 14;
            this.skinLabel143.Text = "搜索条件：";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.SendEmail);
            // 
            // timer_GetData
            // 
            this.timer_GetData.Interval = 2000;
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusInfo,
            this.toolStripProgressProc,
            this.toolStripDropDownButton1});
            this.statusStripInfo.Location = new System.Drawing.Point(4, 741);
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(1016, 23);
            this.statusStripInfo.TabIndex = 141;
            this.statusStripInfo.Text = "statusStrip1";
            // 
            // toolStripStatusInfo
            // 
            this.toolStripStatusInfo.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.toolStripStatusInfo.Name = "toolStripStatusInfo";
            this.toolStripStatusInfo.Size = new System.Drawing.Size(104, 18);
            this.toolStripStatusInfo.Text = "系统初始化已完成";
            // 
            // toolStripProgressProc
            // 
            this.toolStripProgressProc.Name = "toolStripProgressProc";
            this.toolStripProgressProc.Size = new System.Drawing.Size(180, 17);
            this.toolStripProgressProc.Value = 100;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripMenuItem3,
            this.btn_Clear,
            this.不透明ToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(57, 21);
            this.toolStripDropDownButton1.Text = "透明度";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem5.Tag = "0.6";
            this.toolStripMenuItem5.Text = "60%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem4.Tag = "0.7";
            this.toolStripMenuItem4.Text = "70%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(112, 22);
            this.toolStripMenuItem3.Tag = "0.8";
            this.toolStripMenuItem3.Text = "80%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(112, 22);
            this.btn_Clear.Tag = "0.9";
            this.btn_Clear.Text = "90%";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // 不透明ToolStripMenuItem
            // 
            this.不透明ToolStripMenuItem.Name = "不透明ToolStripMenuItem";
            this.不透明ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.不透明ToolStripMenuItem.Tag = "1";
            this.不透明ToolStripMenuItem.Text = "不透明";
            this.不透明ToolStripMenuItem.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Back = ((System.Drawing.Image)(resources.GetObject("$this.Back")));
            this.BackShade = false;
            this.CanResize = false;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CaptionHeight = 22;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.Controls.Add(this.statusStripInfo);
            this.Controls.Add(this.skinTabControl1);
            this.EffectBack = System.Drawing.Color.Black;
            this.EffectCaption = CCWin.TitleType.Title;
            this.EffectWidth = 0;
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaxDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxDownBack")));
            this.MaximizeBox = false;
            this.MaxMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxMouseBack")));
            this.MaxNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MaxNormlBack")));
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.Name = "FrmMain";
            this.Radius = 1;
            this.RestoreDownBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreDownBack")));
            this.RestoreMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreMouseBack")));
            this.RestoreNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.RestoreNormlBack")));
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.SkinOpacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(937, 0, 27, 22);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(937, 0);
            cmSysButton1.Name = "SysTool";
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(27, 22);
            cmSysButton1.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonDown")));
            cmSysButton1.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonMouse")));
            cmSysButton1.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton1.SysButtonNorml")));
            cmSysButton1.ToolTip = "主菜单";
            cmSysButton2.Bounds = new System.Drawing.Rectangle(910, 0, 27, 22);
            cmSysButton2.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton2.Location = new System.Drawing.Point(910, 0);
            cmSysButton2.Name = "SysMsg";
            cmSysButton2.OwnerForm = this;
            cmSysButton2.Size = new System.Drawing.Size(27, 22);
            cmSysButton2.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonDown")));
            cmSysButton2.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonMouse")));
            cmSysButton2.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton2.SysButtonNorml")));
            cmSysButton2.ToolTip = "反馈意见";
            cmSysButton3.Bounds = new System.Drawing.Rectangle(883, 0, 27, 22);
            cmSysButton3.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton3.Location = new System.Drawing.Point(883, 0);
            cmSysButton3.Name = "SysSkin";
            cmSysButton3.OwnerForm = this;
            cmSysButton3.Size = new System.Drawing.Size(27, 22);
            cmSysButton3.SysButtonDown = ((System.Drawing.Image)(resources.GetObject("cmSysButton3.SysButtonDown")));
            cmSysButton3.SysButtonMouse = ((System.Drawing.Image)(resources.GetObject("cmSysButton3.SysButtonMouse")));
            cmSysButton3.SysButtonNorml = ((System.Drawing.Image)(resources.GetObject("cmSysButton3.SysButtonNorml")));
            cmSysButton3.ToolTip = "换肤";
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1,
            cmSysButton2,
            cmSysButton3});
            this.Text = "实验室门禁系统 v1.0";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleOffset = new System.Drawing.Point(13, 4);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabPageEx6.ResumeLayout(false);
            this.skinTabControl7.ResumeLayout(false);
            this.tp_Dept.ResumeLayout(false);
            this.tp_Dept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Dept)).EndInit();
            this.tp_KaoQin.ResumeLayout(false);
            this.tp_KaoQin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            this.tabPageEx5.ResumeLayout(false);
            this.skinTabControl3.ResumeLayout(false);
            this.tb_Today_Action.ResumeLayout(false);
            this.tb_Today_Action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Today_Actions)).EndInit();
            this.tb_Exception_Action.ResumeLayout(false);
            this.tb_Exception_Action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Exception)).EndInit();
            this.tabPageEx4.ResumeLayout(false);
            this.skinTabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Log)).EndInit();
            this.tabPageEx3.ResumeLayout(false);
            this.skinTabControl5.ResumeLayout(false);
            this.tp_TimeInfo.ResumeLayout(false);
            this.tp_TimeInfo.PerformLayout();
            this.tb_TimeRange.ResumeLayout(false);
            this.skinTabControl6.ResumeLayout(false);
            this.timezone1.ResumeLayout(false);
            this.timezone1.PerformLayout();
            this.timezone2.ResumeLayout(false);
            this.timezone2.PerformLayout();
            this.timezone3.ResumeLayout(false);
            this.timezone3.PerformLayout();
            this.timezone4.ResumeLayout(false);
            this.timezone4.PerformLayout();
            this.timezone5.ResumeLayout(false);
            this.timezone5.PerformLayout();
            this.timezone6.ResumeLayout(false);
            this.timezone6.PerformLayout();
            this.tp_doorRange.ResumeLayout(false);
            this.tp_doorRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Door_Range_Data)).EndInit();
            this.tp_doorHoliday.ResumeLayout(false);
            this.tp_doorHoliday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_holiday)).EndInit();
            this.tp_doorInfo.ResumeLayout(false);
            this.tp_doorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_door_info)).EndInit();
            this.tp_door_Right.ResumeLayout(false);
            this.tp_door_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Door_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPageEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.skinTabControl4.ResumeLayout(false);
            this.tp_Area.ResumeLayout(false);
            this.tp_Area.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Area_Data)).EndInit();
            this.tp_Cotroller.ResumeLayout(false);
            this.tp_Cotroller.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Operater_Data)).EndInit();
            this.skinTabControl1.ResumeLayout(false);
            this.tabPageEx1.ResumeLayout(false);
            this.tabPageEx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Person_Data)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.skinGroupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Actions)).EndInit();
            this.door_Group8.ResumeLayout(false);
            this.door_Group8.PerformLayout();
            this.door_Group7.ResumeLayout(false);
            this.door_Group7.PerformLayout();
            this.door_Group6.ResumeLayout(false);
            this.door_Group6.PerformLayout();
            this.door_Group5.ResumeLayout(false);
            this.door_Group5.PerformLayout();
            this.door_Group4.ResumeLayout(false);
            this.door_Group4.PerformLayout();
            this.door_Group3.ResumeLayout(false);
            this.door_Group3.PerformLayout();
            this.door_Group2.ResumeLayout(false);
            this.door_Group2.PerformLayout();
            this.door_Group1.ResumeLayout(false);
            this.door_Group1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Animal)).EndInit();
            this.statusStripInfo.ResumeLayout(false);
            this.statusStripInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private CCWin.SkinControl.SkinTabPage tabPageEx6;
        private CCWin.SkinControl.SkinTabPage tabPageEx5;
        private CCWin.SkinControl.SkinTabControl skinTabControl3;
        private CCWin.SkinControl.SkinTabPage tb_Today_Action;
        private CCWin.SkinControl.SkinTabPage tb_Exception_Action;
        private CCWin.SkinControl.SkinTabPage tabPageEx4;
        private CCWin.SkinControl.SkinTabControl skinTabControl2;
        private CCWin.SkinControl.SkinTabPage tabPage1;
        private CCWin.SkinControl.SkinTabPage tabPage3;
        private CCWin.SkinControl.SkinTabPage tabPageEx3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CCWin.SkinControl.SkinTabPage tabPageEx2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage tabPageEx1;
        private CCWin.SkinControl.SkinLabel skinLabel27;
        private CCWin.SkinControl.SkinWaterTextBox txt_Person_Search;
        private CCWin.SkinControl.SkinButton btn_searchPerson;
        private CCWin.SkinControl.SkinButton btn_ExportPerson;
        private CCWin.SkinControl.SkinButton btn_InportPerson;
        private CCWin.SkinControl.SkinButton btn_DelPerson;
        private CCWin.SkinControl.SkinButton btn_UpdatePerson;
        private CCWin.SkinControl.SkinButton btn_AddPerson;
        private System.Windows.Forms.DataGridView dgv_Person_Data;
        private CCWin.SkinControl.SkinTabControl skinTabControl4;
        private CCWin.SkinControl.SkinTabPage tp_Area;
        private CCWin.SkinControl.SkinTabPage tp_Cotroller;
        private System.Windows.Forms.DataGridView dgv_Operater_Data;
        private CCWin.SkinControl.SkinButton btn_DelOperater;
        private CCWin.SkinControl.SkinButton btn_UpdateOperater;
        private CCWin.SkinControl.SkinButton btn_AddOperater;
        private CCWin.SkinControl.SkinWaterTextBox txt_Operater_Search;
        private CCWin.SkinControl.SkinButton btn_searchOperater;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DataGridView dgv_Area_Data;
        private CCWin.SkinControl.SkinButton btn_Del_Area;
        private CCWin.SkinControl.SkinButton btn_Update_Area;
        private CCWin.SkinControl.SkinButton btn_Add_Area;
        private CCWin.SkinControl.SkinWaterTextBox txt_Area_Serach;
        private CCWin.SkinControl.SkinButton btn_serach_area;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTabControl skinTabControl5;
        private CCWin.SkinControl.SkinTabPage tp_doorRange;
        private CCWin.SkinControl.SkinTabPage tp_doorHoliday;
        private CCWin.SkinControl.SkinTabPage tp_doorInfo;
        private CCWin.SkinControl.SkinTabPage tp_door_Right;
        private CCWin.SkinControl.SkinTabPage tp_TimeInfo;
        private System.Windows.Forms.TabPage tb_TimeRange;
        private System.Windows.Forms.DataGridView dgv_holiday;
        private CCWin.SkinControl.SkinButton btn_del_holiday;
        private CCWin.SkinControl.SkinButton btn_update_holiday;
        private CCWin.SkinControl.SkinButton btn_add_holiday;
        private CCWin.SkinControl.SkinWaterTextBox txt_search_holiday;
        private CCWin.SkinControl.SkinButton btn_search_holiday;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结束日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn 流水编号1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView dgv_door_info;
        private CCWin.SkinControl.SkinButton btn_Update_door;
        private CCWin.SkinControl.SkinWaterTextBox txt_search_doorInfo;
        private CCWin.SkinControl.SkinButton btn_search_door;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private System.Windows.Forms.DataGridView dgv_Door_Range_Data;
        private CCWin.SkinControl.SkinButton btn_Del_DoorRange;
        private CCWin.SkinControl.SkinButton btn_Update_DoorRange;
        private CCWin.SkinControl.SkinButton btn_Add_DoorRange;
        private CCWin.SkinControl.SkinWaterTextBox txt_Search_DoorRange;
        private CCWin.SkinControl.SkinButton btn_Door_Range_Search;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinWaterTextBox txt_Log;
        private CCWin.SkinControl.SkinButton btn_Log;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.DataGridView dgv_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridView dgv_Door_Right;
        private CCWin.SkinControl.SkinButton btn_Del_Door_Right;
        private CCWin.SkinControl.SkinButton btn_Update_Door_Right;
        private CCWin.SkinControl.SkinButton btn_Add_Door_Right;
        private CCWin.SkinControl.SkinWaterTextBox txt_Door_Right;
        private CCWin.SkinControl.SkinButton btn_Door_Right_Search;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn 门禁时间段;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn 人员组合;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton btn_Send_Data_DoorGroup;
        private CCWin.SkinControl.SkinButton btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_End_Time30;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time30;
        private System.Windows.Forms.DateTimePicker dtp_End_Time29;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time29;
        private System.Windows.Forms.DateTimePicker dtp_End_Time28;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time28;
        private System.Windows.Forms.DateTimePicker dtp_End_Time27;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time27;
        private System.Windows.Forms.DateTimePicker dtp_End_Time26;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time26;
        private CCWin.SkinControl.SkinLabel skinLabel23;
        private CCWin.SkinControl.SkinLabel skinLabel24;
        private CCWin.SkinControl.SkinLabel skinLabel25;
        private CCWin.SkinControl.SkinLabel skinLabel26;
        private CCWin.SkinControl.SkinLabel skinLabel28;
        private System.Windows.Forms.DateTimePicker dtp_End_Time25;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time25;
        private CCWin.SkinControl.SkinLabel skinLabel29;
        private System.Windows.Forms.DateTimePicker dtp_End_Time24;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time24;
        private CCWin.SkinControl.SkinLabel skinLabel30;
        private System.Windows.Forms.DateTimePicker dtp_End_Time23;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time23;
        private CCWin.SkinControl.SkinLabel skinLabel31;
        private System.Windows.Forms.DateTimePicker dtp_End_Time22;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time22;
        private CCWin.SkinControl.SkinLabel skinLabel32;
        private System.Windows.Forms.DateTimePicker dtp_End_Time21;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time21;
        private CCWin.SkinControl.SkinLabel skinLabel33;
        private System.Windows.Forms.DateTimePicker dtp_End_Time20;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time20;
        private CCWin.SkinControl.SkinLabel skinLabel34;
        private System.Windows.Forms.DateTimePicker dtp_End_Time19;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time19;
        private CCWin.SkinControl.SkinLabel skinLabel35;
        private System.Windows.Forms.DateTimePicker dtp_End_Time18;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time18;
        private CCWin.SkinControl.SkinLabel skinLabel36;
        private System.Windows.Forms.DateTimePicker dtp_End_Time17;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time17;
        private CCWin.SkinControl.SkinLabel skinLabel37;
        private System.Windows.Forms.DateTimePicker dtp_End_Time16;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time16;
        private CCWin.SkinControl.SkinLabel skinLabel38;
        private System.Windows.Forms.DateTimePicker dtp_End_Time15;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time15;
        private System.Windows.Forms.DateTimePicker dtp_End_Time14;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time14;
        private System.Windows.Forms.DateTimePicker dtp_End_Time13;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time13;
        private System.Windows.Forms.DateTimePicker dtp_End_Time12;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time12;
        private System.Windows.Forms.DateTimePicker dtp_End_Time11;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time11;
        private CCWin.SkinControl.SkinLabel skinLabel18;
        private CCWin.SkinControl.SkinLabel skinLabel19;
        private CCWin.SkinControl.SkinLabel skinLabel20;
        private CCWin.SkinControl.SkinLabel skinLabel21;
        private CCWin.SkinControl.SkinLabel skinLabel22;
        private System.Windows.Forms.DateTimePicker dtp_End_Time10;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time10;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private System.Windows.Forms.DateTimePicker dtp_End_Time9;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time9;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private System.Windows.Forms.DateTimePicker dtp_End_Time8;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time8;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private System.Windows.Forms.DateTimePicker dtp_End_Time7;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time7;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private System.Windows.Forms.DateTimePicker dtp_End_Time6;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time6;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private System.Windows.Forms.DateTimePicker dtp_End_Time5;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time5;
        private CCWin.SkinControl.SkinLabel skinLabel13;
        private System.Windows.Forms.DateTimePicker dtp_End_Time4;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time4;
        private CCWin.SkinControl.SkinLabel skinLabel14;
        private System.Windows.Forms.DateTimePicker dtp_End_Time3;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time3;
        private CCWin.SkinControl.SkinLabel skinLabel15;
        private System.Windows.Forms.DateTimePicker dtp_End_Time2;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time2;
        private CCWin.SkinControl.SkinLabel skinLabel16;
        private System.Windows.Forms.DateTimePicker dtp_End_Time1;
        private System.Windows.Forms.DateTimePicker dtp_Begin_Time1;
        private CCWin.SkinControl.SkinLabel skinLabel17;
        private CCWin.SkinControl.SkinTabControl skinTabControl6;
        private System.Windows.Forms.TabPage timezone1;
        private System.Windows.Forms.TabPage timezone2;
        private System.Windows.Forms.TabPage timezone3;
        private CCWin.SkinControl.SkinButton btn_Save1;
        private CCWin.SkinControl.SkinLabel skinLabel44;
        private CCWin.SkinControl.SkinLabel skinLabel45;
        private CCWin.SkinControl.SkinLabel skinLabel46;
        private CCWin.SkinControl.SkinLabel skinLabel47;
        private CCWin.SkinControl.SkinLabel skinLabel48;
        private CCWin.SkinControl.SkinLabel skinLabel49;
        private CCWin.SkinControl.SkinLabel skinLabel50;
        private CCWin.SkinControl.SkinLabel skinLabel51;
        private CCWin.SkinControl.SkinLabel skinLabel52;
        private CCWin.SkinControl.SkinLabel skinLabel53;
        private CCWin.SkinControl.SkinLabel skinLabel42;
        private CCWin.SkinControl.SkinLabel skinLabel39;
        private CCWin.SkinControl.SkinLabel skinLabel40;
        private CCWin.SkinControl.SkinLabel skinLabel41;
        private System.Windows.Forms.ComboBox cb_TimeZone30;
        private System.Windows.Forms.ComboBox cb_TimeZone29;
        private System.Windows.Forms.ComboBox cb_TimeZone28;
        private System.Windows.Forms.ComboBox cb_TimeZone27;
        private System.Windows.Forms.ComboBox cb_TimeZone26;
        private System.Windows.Forms.ComboBox cb_TimeZone25;
        private System.Windows.Forms.ComboBox cb_TimeZone24;
        private System.Windows.Forms.ComboBox cb_TimeZone23;
        private System.Windows.Forms.ComboBox cb_TimeZone22;
        private System.Windows.Forms.ComboBox cb_TimeZone21;
        private System.Windows.Forms.ComboBox cb_TimeZone20;
        private System.Windows.Forms.ComboBox cb_TimeZone19;
        private System.Windows.Forms.ComboBox cb_TimeZone18;
        private System.Windows.Forms.ComboBox cb_TimeZone17;
        private System.Windows.Forms.ComboBox cb_TimeZone16;
        private System.Windows.Forms.ComboBox cb_TimeZone15;
        private System.Windows.Forms.ComboBox cb_TimeZone14;
        private System.Windows.Forms.ComboBox cb_TimeZone13;
        private System.Windows.Forms.ComboBox cb_TimeZone12;
        private System.Windows.Forms.ComboBox cb_TimeZone11;
        private System.Windows.Forms.ComboBox cb_TimeZone10;
        private System.Windows.Forms.ComboBox cb_TimeZone9;
        private System.Windows.Forms.ComboBox cb_TimeZone8;
        private System.Windows.Forms.ComboBox cb_TimeZone7;
        private System.Windows.Forms.ComboBox cb_TimeZone6;
        private System.Windows.Forms.ComboBox cb_TimeZone5;
        private System.Windows.Forms.ComboBox cb_TimeZone4;
        private System.Windows.Forms.ComboBox cb_TimeZone3;
        private System.Windows.Forms.ComboBox cb_TimeZone2;
        private System.Windows.Forms.ComboBox cb_TimeZone1;
        private CCWin.SkinControl.SkinLabel skinLabel43;
        private CCWin.SkinControl.SkinLabel skinLabel54;
        private CCWin.SkinControl.SkinLabel skinLabel55;
        private CCWin.SkinControl.SkinLabel skinLabel56;
        private System.Windows.Forms.ComboBox cb_TimeZone60;
        private System.Windows.Forms.ComboBox cb_TimeZone59;
        private System.Windows.Forms.ComboBox cb_TimeZone58;
        private System.Windows.Forms.ComboBox cb_TimeZone57;
        private System.Windows.Forms.ComboBox cb_TimeZone56;
        private System.Windows.Forms.ComboBox cb_TimeZone55;
        private System.Windows.Forms.ComboBox cb_TimeZone54;
        private System.Windows.Forms.ComboBox cb_TimeZone53;
        private System.Windows.Forms.ComboBox cb_TimeZone52;
        private System.Windows.Forms.ComboBox cb_TimeZone51;
        private System.Windows.Forms.ComboBox cb_TimeZone50;
        private System.Windows.Forms.ComboBox cb_TimeZone49;
        private System.Windows.Forms.ComboBox cb_TimeZone48;
        private System.Windows.Forms.ComboBox cb_TimeZone47;
        private System.Windows.Forms.ComboBox cb_TimeZone46;
        private System.Windows.Forms.ComboBox cb_TimeZone45;
        private System.Windows.Forms.ComboBox cb_TimeZone44;
        private System.Windows.Forms.ComboBox cb_TimeZone43;
        private System.Windows.Forms.ComboBox cb_TimeZone42;
        private System.Windows.Forms.ComboBox cb_TimeZone41;
        private System.Windows.Forms.ComboBox cb_TimeZone40;
        private System.Windows.Forms.ComboBox cb_TimeZone39;
        private System.Windows.Forms.ComboBox cb_TimeZone38;
        private System.Windows.Forms.ComboBox cb_TimeZone37;
        private System.Windows.Forms.ComboBox cb_TimeZone36;
        private System.Windows.Forms.ComboBox cb_TimeZone35;
        private System.Windows.Forms.ComboBox cb_TimeZone34;
        private System.Windows.Forms.ComboBox cb_TimeZone33;
        private System.Windows.Forms.ComboBox cb_TimeZone32;
        private System.Windows.Forms.ComboBox cb_TimeZone31;
        private CCWin.SkinControl.SkinLabel skinLabel57;
        private CCWin.SkinControl.SkinLabel skinLabel58;
        private CCWin.SkinControl.SkinLabel skinLabel59;
        private CCWin.SkinControl.SkinLabel skinLabel60;
        private CCWin.SkinControl.SkinLabel skinLabel61;
        private CCWin.SkinControl.SkinLabel skinLabel62;
        private CCWin.SkinControl.SkinLabel skinLabel63;
        private CCWin.SkinControl.SkinLabel skinLabel64;
        private CCWin.SkinControl.SkinLabel skinLabel65;
        private CCWin.SkinControl.SkinLabel skinLabel66;
        private CCWin.SkinControl.SkinLabel skinLabel67;
        private CCWin.SkinControl.SkinLabel skinLabel68;
        private CCWin.SkinControl.SkinLabel skinLabel69;
        private CCWin.SkinControl.SkinLabel skinLabel70;
        private System.Windows.Forms.ComboBox cb_TimeZone90;
        private System.Windows.Forms.ComboBox cb_TimeZone89;
        private System.Windows.Forms.ComboBox cb_TimeZone88;
        private System.Windows.Forms.ComboBox cb_TimeZone87;
        private System.Windows.Forms.ComboBox cb_TimeZone86;
        private System.Windows.Forms.ComboBox cb_TimeZone85;
        private System.Windows.Forms.ComboBox cb_TimeZone84;
        private System.Windows.Forms.ComboBox cb_TimeZone83;
        private System.Windows.Forms.ComboBox cb_TimeZone82;
        private System.Windows.Forms.ComboBox cb_TimeZone81;
        private System.Windows.Forms.ComboBox cb_TimeZone80;
        private System.Windows.Forms.ComboBox cb_TimeZone79;
        private System.Windows.Forms.ComboBox cb_TimeZone78;
        private System.Windows.Forms.ComboBox cb_TimeZone77;
        private System.Windows.Forms.ComboBox cb_TimeZone76;
        private System.Windows.Forms.ComboBox cb_TimeZone75;
        private System.Windows.Forms.ComboBox cb_TimeZone74;
        private System.Windows.Forms.ComboBox cb_TimeZone73;
        private System.Windows.Forms.ComboBox cb_TimeZone72;
        private System.Windows.Forms.ComboBox cb_TimeZone71;
        private System.Windows.Forms.ComboBox cb_TimeZone70;
        private System.Windows.Forms.ComboBox cb_TimeZone69;
        private System.Windows.Forms.ComboBox cb_TimeZone68;
        private System.Windows.Forms.ComboBox cb_TimeZone67;
        private System.Windows.Forms.ComboBox cb_TimeZone66;
        private System.Windows.Forms.ComboBox cb_TimeZone65;
        private System.Windows.Forms.ComboBox cb_TimeZone64;
        private System.Windows.Forms.ComboBox cb_TimeZone63;
        private System.Windows.Forms.ComboBox cb_TimeZone62;
        private System.Windows.Forms.ComboBox cb_TimeZone61;
        private CCWin.SkinControl.SkinLabel skinLabel71;
        private CCWin.SkinControl.SkinLabel skinLabel72;
        private CCWin.SkinControl.SkinLabel skinLabel73;
        private CCWin.SkinControl.SkinLabel skinLabel74;
        private CCWin.SkinControl.SkinLabel skinLabel75;
        private CCWin.SkinControl.SkinLabel skinLabel76;
        private CCWin.SkinControl.SkinLabel skinLabel77;
        private CCWin.SkinControl.SkinLabel skinLabel78;
        private CCWin.SkinControl.SkinLabel skinLabel79;
        private CCWin.SkinControl.SkinLabel skinLabel80;
        private System.Windows.Forms.TabPage timezone4;
        private CCWin.SkinControl.SkinLabel skinLabel81;
        private CCWin.SkinControl.SkinLabel skinLabel82;
        private CCWin.SkinControl.SkinLabel skinLabel83;
        private CCWin.SkinControl.SkinLabel skinLabel84;
        private System.Windows.Forms.ComboBox cb_TimeZone120;
        private System.Windows.Forms.ComboBox cb_TimeZone119;
        private System.Windows.Forms.ComboBox cb_TimeZone118;
        private System.Windows.Forms.ComboBox cb_TimeZone117;
        private System.Windows.Forms.ComboBox cb_TimeZone116;
        private System.Windows.Forms.ComboBox cb_TimeZone115;
        private System.Windows.Forms.ComboBox cb_TimeZone114;
        private System.Windows.Forms.ComboBox cb_TimeZone113;
        private System.Windows.Forms.ComboBox cb_TimeZone112;
        private System.Windows.Forms.ComboBox cb_TimeZone111;
        private System.Windows.Forms.ComboBox cb_TimeZone110;
        private System.Windows.Forms.ComboBox cb_TimeZone109;
        private System.Windows.Forms.ComboBox cb_TimeZone108;
        private System.Windows.Forms.ComboBox cb_TimeZone107;
        private System.Windows.Forms.ComboBox cb_TimeZone106;
        private System.Windows.Forms.ComboBox cb_TimeZone105;
        private System.Windows.Forms.ComboBox cb_TimeZone104;
        private System.Windows.Forms.ComboBox cb_TimeZone103;
        private System.Windows.Forms.ComboBox cb_TimeZone102;
        private System.Windows.Forms.ComboBox cb_TimeZone101;
        private System.Windows.Forms.ComboBox cb_TimeZone100;
        private System.Windows.Forms.ComboBox cb_TimeZone99;
        private System.Windows.Forms.ComboBox cb_TimeZone98;
        private System.Windows.Forms.ComboBox cb_TimeZone97;
        private System.Windows.Forms.ComboBox cb_TimeZone96;
        private System.Windows.Forms.ComboBox cb_TimeZone95;
        private System.Windows.Forms.ComboBox cb_TimeZone94;
        private System.Windows.Forms.ComboBox cb_TimeZone93;
        private System.Windows.Forms.ComboBox cb_TimeZone92;
        private System.Windows.Forms.ComboBox cb_TimeZone91;
        private CCWin.SkinControl.SkinLabel skinLabel85;
        private CCWin.SkinControl.SkinLabel skinLabel86;
        private CCWin.SkinControl.SkinLabel skinLabel87;
        private CCWin.SkinControl.SkinLabel skinLabel88;
        private CCWin.SkinControl.SkinLabel skinLabel89;
        private CCWin.SkinControl.SkinLabel skinLabel90;
        private CCWin.SkinControl.SkinLabel skinLabel91;
        private CCWin.SkinControl.SkinLabel skinLabel92;
        private CCWin.SkinControl.SkinLabel skinLabel93;
        private CCWin.SkinControl.SkinLabel skinLabel94;
        private System.Windows.Forms.TabPage timezone5;
        private CCWin.SkinControl.SkinLabel skinLabel95;
        private CCWin.SkinControl.SkinLabel skinLabel96;
        private CCWin.SkinControl.SkinLabel skinLabel97;
        private CCWin.SkinControl.SkinLabel skinLabel98;
        private System.Windows.Forms.ComboBox cb_TimeZone150;
        private System.Windows.Forms.ComboBox cb_TimeZone149;
        private System.Windows.Forms.ComboBox cb_TimeZone148;
        private System.Windows.Forms.ComboBox cb_TimeZone147;
        private System.Windows.Forms.ComboBox cb_TimeZone146;
        private System.Windows.Forms.ComboBox cb_TimeZone145;
        private System.Windows.Forms.ComboBox cb_TimeZone144;
        private System.Windows.Forms.ComboBox cb_TimeZone143;
        private System.Windows.Forms.ComboBox cb_TimeZone142;
        private System.Windows.Forms.ComboBox cb_TimeZone141;
        private System.Windows.Forms.ComboBox cb_TimeZone140;
        private System.Windows.Forms.ComboBox cb_TimeZone139;
        private System.Windows.Forms.ComboBox cb_TimeZone138;
        private System.Windows.Forms.ComboBox cb_TimeZone137;
        private System.Windows.Forms.ComboBox cb_TimeZone136;
        private System.Windows.Forms.ComboBox cb_TimeZone135;
        private System.Windows.Forms.ComboBox cb_TimeZone134;
        private System.Windows.Forms.ComboBox cb_TimeZone133;
        private System.Windows.Forms.ComboBox cb_TimeZone132;
        private System.Windows.Forms.ComboBox cb_TimeZone131;
        private System.Windows.Forms.ComboBox cb_TimeZone130;
        private System.Windows.Forms.ComboBox cb_TimeZone129;
        private System.Windows.Forms.ComboBox cb_TimeZone128;
        private System.Windows.Forms.ComboBox cb_TimeZone127;
        private System.Windows.Forms.ComboBox cb_TimeZone126;
        private System.Windows.Forms.ComboBox cb_TimeZone125;
        private System.Windows.Forms.ComboBox cb_TimeZone124;
        private System.Windows.Forms.ComboBox cb_TimeZone123;
        private System.Windows.Forms.ComboBox cb_TimeZone122;
        private System.Windows.Forms.ComboBox cb_TimeZone121;
        private CCWin.SkinControl.SkinLabel skinLabel99;
        private CCWin.SkinControl.SkinLabel skinLabel100;
        private CCWin.SkinControl.SkinLabel skinLabel101;
        private CCWin.SkinControl.SkinLabel skinLabel102;
        private CCWin.SkinControl.SkinLabel skinLabel103;
        private CCWin.SkinControl.SkinLabel skinLabel104;
        private CCWin.SkinControl.SkinLabel skinLabel105;
        private CCWin.SkinControl.SkinLabel skinLabel106;
        private CCWin.SkinControl.SkinLabel skinLabel107;
        private CCWin.SkinControl.SkinLabel skinLabel108;
        private System.Windows.Forms.TabPage timezone6;
        private CCWin.SkinControl.SkinLabel skinLabel109;
        private CCWin.SkinControl.SkinLabel skinLabel110;
        private CCWin.SkinControl.SkinLabel skinLabel111;
        private CCWin.SkinControl.SkinLabel skinLabel112;
        private System.Windows.Forms.ComboBox cb_TimeZone180;
        private System.Windows.Forms.ComboBox cb_TimeZone179;
        private System.Windows.Forms.ComboBox cb_TimeZone178;
        private System.Windows.Forms.ComboBox cb_TimeZone177;
        private System.Windows.Forms.ComboBox cb_TimeZone176;
        private System.Windows.Forms.ComboBox cb_TimeZone175;
        private System.Windows.Forms.ComboBox cb_TimeZone174;
        private System.Windows.Forms.ComboBox cb_TimeZone173;
        private System.Windows.Forms.ComboBox cb_TimeZone172;
        private System.Windows.Forms.ComboBox cb_TimeZone171;
        private System.Windows.Forms.ComboBox cb_TimeZone170;
        private System.Windows.Forms.ComboBox cb_TimeZone169;
        private System.Windows.Forms.ComboBox cb_TimeZone168;
        private System.Windows.Forms.ComboBox cb_TimeZone167;
        private System.Windows.Forms.ComboBox cb_TimeZone166;
        private System.Windows.Forms.ComboBox cb_TimeZone165;
        private System.Windows.Forms.ComboBox cb_TimeZone164;
        private System.Windows.Forms.ComboBox cb_TimeZone163;
        private System.Windows.Forms.ComboBox cb_TimeZone162;
        private System.Windows.Forms.ComboBox cb_TimeZone161;
        private System.Windows.Forms.ComboBox cb_TimeZone160;
        private System.Windows.Forms.ComboBox cb_TimeZone159;
        private System.Windows.Forms.ComboBox cb_TimeZone158;
        private System.Windows.Forms.ComboBox cb_TimeZone157;
        private System.Windows.Forms.ComboBox cb_TimeZone156;
        private System.Windows.Forms.ComboBox cb_TimeZone155;
        private System.Windows.Forms.ComboBox cb_TimeZone154;
        private System.Windows.Forms.ComboBox cb_TimeZone153;
        private System.Windows.Forms.ComboBox cb_TimeZone152;
        private System.Windows.Forms.ComboBox cb_TimeZone151;
        private CCWin.SkinControl.SkinLabel skinLabel113;
        private CCWin.SkinControl.SkinLabel skinLabel114;
        private CCWin.SkinControl.SkinLabel skinLabel115;
        private CCWin.SkinControl.SkinLabel skinLabel116;
        private CCWin.SkinControl.SkinLabel skinLabel117;
        private CCWin.SkinControl.SkinLabel skinLabel118;
        private CCWin.SkinControl.SkinLabel skinLabel119;
        private CCWin.SkinControl.SkinLabel skinLabel120;
        private CCWin.SkinControl.SkinLabel skinLabel121;
        private CCWin.SkinControl.SkinLabel skinLabel122;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private CCWin.SkinControl.SkinWaterTextBox txt_Today_Actions;
        private CCWin.SkinControl.SkinButton btn_Today_Actions;
        private CCWin.SkinControl.SkinLabel skinLabel123;
        private System.Windows.Forms.DataGridView dgv_Exception;
        private CCWin.SkinControl.SkinWaterTextBox txt_Exception;
        private CCWin.SkinControl.SkinButton btn_Search_ExceptionData;
        private CCWin.SkinControl.SkinLabel skinLabel127;
        private System.Windows.Forms.DataGridView dgv_Today_Actions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事件1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 流水编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 联系方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 邮箱;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡片编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡片类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 卡片密码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否APB检验;
        private System.Windows.Forms.DataGridViewTextBoxColumn IACUC审阅小组;
        private System.Windows.Forms.DataGridViewTextBoxColumn 批准日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 起止日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 课题名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn PI;
        private System.Windows.Forms.DataGridViewTextBoxColumn 申请人;
        private System.Windows.Forms.DataGridViewTextBoxColumn AP;
        private System.Windows.Forms.DataGridViewTextBoxColumn 动物种属;
        private System.Windows.Forms.DataGridViewTextBoxColumn 动物总用量;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinGroupBox door_Group1;
        private CCWin.SkinControl.SkinCheckBox cb1;
        private System.Windows.Forms.Button door1;
        private System.Windows.Forms.Button btn_OpenDoor1;
        private CCWin.SkinControl.SkinGroupBox door_Group8;
        private CCWin.SkinControl.SkinCheckBox cb32;
        private System.Windows.Forms.Button door32;
        private System.Windows.Forms.Button btn_OpenDoor32;
        private CCWin.SkinControl.SkinCheckBox cb31;
        private System.Windows.Forms.Button door31;
        private System.Windows.Forms.Button btn_OpenDoor31;
        private CCWin.SkinControl.SkinCheckBox cb30;
        private System.Windows.Forms.Button door30;
        private System.Windows.Forms.Button btn_OpenDoor30;
        private CCWin.SkinControl.SkinCheckBox cb29;
        private System.Windows.Forms.Button door29;
        private System.Windows.Forms.Button btn_OpenDoor29;
        private CCWin.SkinControl.SkinGroupBox door_Group7;
        private CCWin.SkinControl.SkinCheckBox cb28;
        private System.Windows.Forms.Button door28;
        private System.Windows.Forms.Button btn_OpenDoor28;
        private CCWin.SkinControl.SkinCheckBox cb27;
        private System.Windows.Forms.Button door27;
        private System.Windows.Forms.Button btn_OpenDoor27;
        private CCWin.SkinControl.SkinCheckBox cb26;
        private System.Windows.Forms.Button door26;
        private System.Windows.Forms.Button btn_OpenDoor26;
        private CCWin.SkinControl.SkinCheckBox cb25;
        private System.Windows.Forms.Button door25;
        private System.Windows.Forms.Button btn_OpenDoor25;
        private CCWin.SkinControl.SkinGroupBox door_Group6;
        private CCWin.SkinControl.SkinCheckBox cb24;
        private System.Windows.Forms.Button door24;
        private System.Windows.Forms.Button btn_OpenDoor24;
        private CCWin.SkinControl.SkinCheckBox cb23;
        private System.Windows.Forms.Button door23;
        private System.Windows.Forms.Button btn_OpenDoor23;
        private CCWin.SkinControl.SkinCheckBox cb22;
        private System.Windows.Forms.Button door22;
        private System.Windows.Forms.Button btn_OpenDoor22;
        private CCWin.SkinControl.SkinCheckBox cb21;
        private System.Windows.Forms.Button door21;
        private System.Windows.Forms.Button btn_OpenDoor21;
        private CCWin.SkinControl.SkinGroupBox door_Group5;
        private CCWin.SkinControl.SkinCheckBox cb20;
        private System.Windows.Forms.Button door20;
        private System.Windows.Forms.Button btn_OpenDoor20;
        private CCWin.SkinControl.SkinCheckBox cb19;
        private System.Windows.Forms.Button door19;
        private System.Windows.Forms.Button btn_OpenDoor19;
        private CCWin.SkinControl.SkinCheckBox cb18;
        private System.Windows.Forms.Button door18;
        private System.Windows.Forms.Button btn_OpenDoor18;
        private CCWin.SkinControl.SkinCheckBox cb17;
        private System.Windows.Forms.Button door17;
        private System.Windows.Forms.Button btn_OpenDoor17;
        private CCWin.SkinControl.SkinGroupBox door_Group4;
        private CCWin.SkinControl.SkinCheckBox cb16;
        private System.Windows.Forms.Button door16;
        private System.Windows.Forms.Button btn_OpenDoor16;
        private CCWin.SkinControl.SkinCheckBox cb15;
        private System.Windows.Forms.Button door15;
        private System.Windows.Forms.Button btn_OpenDoor15;
        private CCWin.SkinControl.SkinCheckBox cb14;
        private System.Windows.Forms.Button door14;
        private System.Windows.Forms.Button btn_OpenDoor14;
        private CCWin.SkinControl.SkinCheckBox cb13;
        private System.Windows.Forms.Button door13;
        private System.Windows.Forms.Button btn_OpenDoor13;
        private CCWin.SkinControl.SkinGroupBox door_Group3;
        private CCWin.SkinControl.SkinCheckBox cb12;
        private System.Windows.Forms.Button door12;
        private System.Windows.Forms.Button btn_OpenDoor12;
        private CCWin.SkinControl.SkinCheckBox cb11;
        private System.Windows.Forms.Button door11;
        private System.Windows.Forms.Button btn_OpenDoor11;
        private CCWin.SkinControl.SkinCheckBox cb10;
        private System.Windows.Forms.Button door10;
        private System.Windows.Forms.Button btn_OpenDoor10;
        private CCWin.SkinControl.SkinCheckBox cb9;
        private System.Windows.Forms.Button door9;
        private System.Windows.Forms.Button btn_OpenDoor9;
        private CCWin.SkinControl.SkinGroupBox door_Group2;
        private CCWin.SkinControl.SkinCheckBox cb8;
        private System.Windows.Forms.Button door8;
        private System.Windows.Forms.Button btn_OpenDoor8;
        private CCWin.SkinControl.SkinCheckBox cb7;
        private System.Windows.Forms.Button door7;
        private System.Windows.Forms.Button btn_OpenDoor7;
        private CCWin.SkinControl.SkinCheckBox cb6;
        private System.Windows.Forms.Button door6;
        private System.Windows.Forms.Button btn_OpenDoor6;
        private CCWin.SkinControl.SkinCheckBox cb5;
        private System.Windows.Forms.Button door5;
        private System.Windows.Forms.Button btn_OpenDoor5;
        private CCWin.SkinControl.SkinCheckBox cb4;
        private System.Windows.Forms.Button door4;
        private System.Windows.Forms.Button btn_OpenDoor4;
        private CCWin.SkinControl.SkinCheckBox cb3;
        private System.Windows.Forms.Button door3;
        private System.Windows.Forms.Button btn_OpenDoor3;
        private CCWin.SkinControl.SkinCheckBox cb2;
        private System.Windows.Forms.Button door2;
        private System.Windows.Forms.Button btn_OpenDoor2;
        private CCWin.SkinControl.SkinButton btn_Watch_Full;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox9;
        private System.Windows.Forms.DataGridView dgv_Actions;
        private CCWin.SkinControl.SkinTabControl skinTabControl7;
        private CCWin.SkinControl.SkinTabPage tp_Dept;
        private CCWin.SkinControl.SkinButton btn_Search_Dept_Info;
        private System.Windows.Forms.DataGridView dgv_Dept;
        private CCWin.SkinControl.SkinButton btn_Del_Dept;
        private CCWin.SkinControl.SkinButton btn_Modify_Dept;
        private CCWin.SkinControl.SkinButton btn_Add_Dept;
        private CCWin.SkinControl.SkinWaterTextBox txt_Dept;
        private CCWin.SkinControl.SkinLabel skinLabel142;
        private CCWin.SkinControl.SkinTabPage tp_KaoQin;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private CCWin.SkinControl.SkinLabel skinLabel140;
        private CCWin.SkinControl.SkinLabel skinLabel141;
        private CCWin.SkinControl.SkinLabel skinLabel139;
        private System.Windows.Forms.NumericUpDown nud7;
        private CCWin.SkinControl.SkinLabel skinLabel138;
        private System.Windows.Forms.NumericUpDown nud6;
        private System.Windows.Forms.NumericUpDown nud5;
        private System.Windows.Forms.NumericUpDown nud4;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.NumericUpDown nud1;
        private CCWin.SkinControl.SkinWaterTextBox txt_Mail;
        private System.Windows.Forms.Button btn_Test_SendMail;
        private System.Windows.Forms.Button btn_Save_KaoQin;
        private CCWin.SkinControl.SkinLabel skinLabel124;
        private CCWin.SkinControl.SkinLabel skinLabel125;
        private CCWin.SkinControl.SkinLabel skinLabel126;
        private CCWin.SkinControl.SkinLabel skinLabel128;
        private CCWin.SkinControl.SkinLabel skinLabel129;
        private CCWin.SkinControl.SkinLabel skinLabel130;
        private CCWin.SkinControl.SkinLabel skinLabel131;
        private CCWin.SkinControl.SkinLabel skinLabel132;
        private CCWin.SkinControl.SkinLabel skinLabel133;
        private CCWin.SkinControl.SkinLabel skinLabel134;
        private CCWin.SkinControl.SkinLabel skinLabel135;
        private CCWin.SkinControl.SkinLabel skinLabel136;
        private CCWin.SkinControl.SkinLabel skinLabel137;
        private System.Windows.Forms.TabPage tp_Right;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.Timer timer_GetData;
        private System.Windows.Forms.StatusStrip statusStripInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusInfo;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressProc;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btn_Clear;
        private System.Windows.Forms.ToolStripMenuItem 不透明ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn 事件;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private CCWin.SkinControl.SkinButton btn_Animal_Search;
        private System.Windows.Forms.DataGridView dgv_Animal;
        private CCWin.SkinControl.SkinWaterTextBox txt_Animal_Search;
        private CCWin.SkinControl.SkinLabel skinLabel143;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn 波特率;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}

