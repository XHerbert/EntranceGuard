using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
namespace Haley.FrameWork
{
    /**/
    /// <summary>
    /// DataAccess 的摘要说明
    /// </summary>
    public class DataAccess
    {
        protected static OleDbConnection conn = new OleDbConnection();
        protected static OleDbCommand comm = new OleDbCommand();
        public DataAccess()
        {
            //init
        }
        /**/
        /// <summary>
        /// 打开数据库
        /// </summary>
        private static void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\EntranceGuardSystemDatabase.mdb;User ID=Admin;Jet OLEDB:Database Password=88888888;";//web.config文件里设定。            
                comm.Connection = conn;
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                { throw new Exception(e.Message); }
            }
        }
        /**/
        /// <summary>
        /// 关闭数据库
        /// </summary>
        private static void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                comm.Dispose();
            }
        }
        /**/
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlstr"></param>
        public static void excuteSql(string sqlstr)
        {
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            { closeConnection(); }
        }


        /**/
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlstr"></param>
        public static int excuteSqlAndReturnValues(List<string> sqlstrs)
        {
            try
            {
                int result = 0;
                openConnection();
                comm.Transaction = conn.BeginTransaction();

                foreach (var item in sqlstrs)
                {
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = item;
                    result += comm.ExecuteNonQuery();
                }
                if (result < sqlstrs.Count)
                {
                    comm.Transaction.Rollback();
                    return -1;

                }
                else
                {
                    comm.Transaction.Commit();
                    return 1;
                }


            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            { closeConnection(); }
        }


        /**/
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlstr"></param>
        public static int excuteSqlAndReturnValues(string[] sqlstrs)
        {
            try
            {
                int result = 0;
                openConnection();
                comm.Transaction = conn.BeginTransaction();
                foreach (var item in sqlstrs)
                {
                    comm.CommandType = CommandType.Text;
                    comm.CommandText = item;
                    result += comm.ExecuteNonQuery();
                }
                if (result < sqlstrs.Length)
                {
                    comm.Transaction.Rollback();
                    return -1;

                }
                else
                {
                    comm.Transaction.Commit();
                    return 1;
                }


            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            { closeConnection(); }
        }

        public static int AccessToExcel(string filename, string sheet, ref string msg)
        {

            try
            {
                string sql = "select top 65535 *  into   [Excel 8.0;database=" + filename + "].[" + sheet + "] from " + sheet;
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                return comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return -1;
            }
            finally
            {
                closeConnection();
            }
        }

        /**/
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlstr"></param>
        public static int excuteSqlAndReturnValues(string sqlstr)
        {
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                return comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            { closeConnection(); }
        }


        /**/
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="sqlstr"></param>
        public static int ExecuteScalar(string sqlstr)
        {
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                return Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            { closeConnection(); }
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的OleDbDataReader对象，使用时请注意关闭这个对象。
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static OleDbDataReader dataReader(string sqlstr)
        {
            OleDbDataReader dr = null;
            try
            {
                openConnection();
                comm.CommandText = sqlstr;
                comm.CommandType = CommandType.Text;
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                try
                {
                    dr.Close();
                    closeConnection();
                }
                catch { }
            }
            return dr;
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的OleDbDataReader对象,使用时请注意关闭
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="dr"></param>
        public static void dataReader(string sqlstr, ref OleDbDataReader dr)
        {
            try
            {
                openConnection();
                comm.CommandText = sqlstr;
                comm.CommandType = CommandType.Text;
                dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                try
                {
                    if (dr != null && !dr.IsClosed)
                        dr.Close();
                }
                catch
                {
                }
                finally
                {
                    closeConnection();
                }
            }
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的dataset
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataSet dataSet(string sqlstr)
        {
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeConnection();
            }
            return ds;
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的dataset
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="ds"></param>
        public static void dataSet(string sqlstr, ref DataSet ds)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的datatable
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataTable dataTable(string sqlstr)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的datatable
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <param name="dt"></param>
        public static void dataTable(string sqlstr, ref DataTable dt)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        /**/
        /// <summary>
        /// 返回指定sql语句的dataview
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public static DataView dataView(string sqlstr)
        {
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataView dv = new DataView();
            DataSet ds = new DataSet();
            try
            {
                openConnection();
                comm.CommandType = CommandType.Text;
                comm.CommandText = sqlstr;
                da.SelectCommand = comm;
                da.Fill(ds);
                dv = ds.Tables[0].DefaultView;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                closeConnection();
            }
            return dv;
        }

    }
}