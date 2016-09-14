using Haley.FrameWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public static class LogHelper
    {
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="info">日志信息</param>
        public static void WriteLog(this string OperateType, string OperateContent, int Is_succeed, string Fail_renson, string Operater, string Operate_Date)
        {
            try
            {
                string sql = "select max(sl.id) from sys_log sl ";
                int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1;
                string T_sql = "insert into sys_log values(" + New_ID + ",'" + OperateType + "','" + OperateContent + "'," + Is_succeed + ",'" + Fail_renson + "','" + Operater + "','" + Operate_Date + "');";
                DataAccess.excuteSqlAndReturnValues(T_sql);
            }
            catch (Exception )
            {
                throw;
            }

        }

    }
}
