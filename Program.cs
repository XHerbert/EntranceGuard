/********************************************************************
 * *
 * *
 * * 创建时间：2013-12-08
 * * 说明：Program.cs
 * *
********************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Demo.NewForm;

namespace Demo
{
    static class Program
    {
        public static string Login_User;
        public static int Login_Level;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login Log = new Login(); //使用模式对话框方法显示Log
            Log.ShowDialog();//DialogResult就是用来判断是否返回父窗体的
            if (Log.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain()); //在线程中打开主窗体
            }
            //Form1 f = new Form1();
            //Application.Run(f);
        }
    }
}
