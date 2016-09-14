
/***************************************************************
 * 文件名: DataExtraction
 * 类名: ExcelRender
 * 
 * 开发者: 孙业宝
 * 开发日期: 2014-5-28
 * 
 * 修改者: 
 * 修改日期: 
 * 修改内容: 
 * 
 * 
 ***************************************************************/


using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;
using NPOI.SS.UserModel;
using NPOI.HSSF.UserModel;
using Haley.FrameWork;

namespace RST_ReadSDData
{
    /// <summary>
    /// 自定义Excel操作类
    /// </summary>
    public class ExcelRender
    {


        #region  私有变量


        public delegate int DBAction(string sql, params IDataParameter[] parameters);

        #endregion


        #region  保存Excel文档流到文件

        /// <summary>
        /// 保存Excel文档流到文件
        /// </summary>
        /// <param name="ms">Excel文档流</param>
        /// <param name="fileName">文件名</param>
        private static void SaveToFile(MemoryStream ms, string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ms.ToArray();

                fs.Write(data, 0, data.Length);
                fs.Flush();

                data = null;
            }
        }


        #endregion


        #region   DataTable转换成Excel文档流，并保存到文件


        /// <summary>
        /// DataTable转换成Excel文档流，并保存到文件
        /// </summary>
        /// <param name="table"></param>
        /// <param name="fileName">保存的路径</param>
        public static void RenderToExcel(DataTable table, string fileName)
        {
            using (MemoryStream ms = RenderToExcel(table))
            {
                SaveToFile(ms, fileName);
            }
        }


        #endregion


        #region    DataTable转换成Excel文档流

        /// <summary>
        /// DataTable转换成Excel文档流
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static MemoryStream RenderToExcel(DataTable table)
        {
            MemoryStream ms = new MemoryStream();

            using (table)
            {
                IWorkbook workbook = new HSSFWorkbook();
                ISheet sheet = workbook.CreateSheet();
                IRow headerRow = sheet.CreateRow(0);
                foreach (DataColumn column in table.Columns)
                    headerRow.CreateCell(column.Ordinal).SetCellValue(column.Caption);//If Caption not set, returns the ColumnName value

                // handling value.
                int rowIndex = 1;

                foreach (DataRow row in table.Rows)
                {
                    IRow dataRow = sheet.CreateRow(rowIndex);

                    foreach (DataColumn column in table.Columns)
                    {
                        dataRow.CreateCell(column.Ordinal).SetCellValue(row[column].ToString());
                    }

                    rowIndex++;
                }
                AutoSizeColumns(sheet);

                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;


            }
            return ms;
        }


        #endregion


        #region   自动设置Excel列宽


        /// <summary>
        /// 自动设置Excel列宽
        /// </summary>
        /// <param name="sheet">Excel表</param>
        private static void AutoSizeColumns(ISheet sheet)
        {
            if (sheet.PhysicalNumberOfRows > 0)
            {
                IRow headerRow = sheet.GetRow(0);

                for (int i = 0, l = headerRow.LastCellNum; i < l; i++)
                {
                    sheet.AutoSizeColumn(i);
                }
            }
        }


        #endregion


        #region 检测Excel文档流是否有数据


        /// <summary>
        /// Excel文档流是否有数据
        /// </summary>
        /// <param name="excelFileStream">Excel文档流</param>
        /// <returns></returns>
        public static bool HasData(Stream excelFileStream)
        {
            return HasData(excelFileStream, 0);
        }



        /// <summary>
        /// Excel文档流是否有数据
        /// </summary>
        /// <param name="excelFileStream">Excel文档流</param>
        /// <param name="sheetIndex">表索引号，如第一个表为0</param>
        /// <returns></returns>
        public static bool HasData(Stream excelFileStream, int sheetIndex)
        {
            using (excelFileStream)
            {
                IWorkbook workbook = new HSSFWorkbook(excelFileStream);

                if (workbook.NumberOfSheets > 0)
                {
                    if (sheetIndex < workbook.NumberOfSheets)
                    {
                        ISheet sheet = workbook.GetSheetAt(sheetIndex);

                        return sheet.PhysicalNumberOfRows > 0;

                    }
                }

            }
            return false;
        }




        #endregion


        #region  Excel文档导入到数据库

        /// <summary>
        /// Excel文档导入到数据库
        /// 默认取Excel的第一个表
        /// 第一行必须为标题行
        /// </summary>
        /// <param name="excelFileStream">Excel文档流</param>
        /// <param name="insertSql">插入语句</param>
        /// <param name="dbAction">更新到数据库的方法</param>
        /// <returns></returns>
        public static bool RenderToDb(Stream excelFileStream, DBAction dbAction, List<string> listT_SQL)
        {
            return RenderToDb(excelFileStream, dbAction, 0, listT_SQL);
        }

        /// <summary>
        /// Excel文档导入到数据库
        /// </summary>
        /// <param name="excelFileStream">Excel文档流</param>
        /// <param name="dbAction">现在没有用，是执行sql的委托对象</param>
        /// <param name="headerRowIndex">Excel中表头对应列名</param>
        /// <param name="listT_SQL">有关要操作表的信息：0.数据库中表名称。1.表头对应的列名。2主键名。3.要插入到数据库中的列名。4.各列对应的数据格式。5.Excele 名称</param>
        /// <returns></returns>
        public static bool RenderToDb(Stream excelFileStream, DBAction dbAction, int headerRowIndex, List<string> listT_SQL)
        {
            bool isOK = false;
            List<string> List_TQL = new List<string>();
            int rowCount = 0;
            
            try
            {
                using (excelFileStream)
                {
                    IWorkbook workbook = new HSSFWorkbook(excelFileStream);
                    for (int indexOfSheet = 0; indexOfSheet < workbook.NumberOfSheets; indexOfSheet++)
                    {
                        ISheet sheet = workbook.GetSheetAt(indexOfSheet);
                        StringBuilder builder = new StringBuilder();
                        IRow headerRow = sheet.GetRow(headerRowIndex);
                        int cellCount = headerRow.LastCellNum;
                        rowCount += sheet.LastRowNum;
                        for (int i = (sheet.FirstRowNum + 1); i <= rowCount; i++)
                        {
                            IRow row = sheet.GetRow(i);
                            StringBuilder sbOfValue = new StringBuilder();
                            if (row != null)
                            {
                                    string Identity_NO = GetCellValue(row.GetCell(3));
                                    string IACUC_GroupName = GetCellValue(row.GetCell(4));
                                    string Approval_Date = GetCellValue(row.GetCell(5));
                                    string Experiment_TimeRange = GetCellValue(row.GetCell(6));
                                    string Topic_Name = GetCellValue(row.GetCell(7));
                                    string PI = GetCellValue(row.GetCell(8));
                                    string Applicant = GetCellValue(row.GetCell(9));
                                    string phone = GetCellValue(row.GetCell(10));
                                    string AP = GetCellValue(row.GetCell(11));
                                    string Animal_Species = GetCellValue(row.GetCell(12));
                                    string Animal_Count = GetCellValue(row.GetCell(13));
                                    Approval_Date =Convert.ToDateTime(Approval_Date.ToString()).ToString();

                                    string sql = "select max(ti.id) from test_info ti ";
                                    int New_ID = Convert.ToInt32(DataAccess.ExecuteScalar(sql)) + 1 + i;
                                    string SQLOfInsert = @"insert into Test_Info values(" + New_ID + ",'" + Identity_NO + "','" + IACUC_GroupName + "','" + Approval_Date + "','" + Experiment_TimeRange + "','" + Topic_Name + "','" + PI +
                                        "','" + Applicant + "','"+phone+"','" + AP + "','" + Animal_Species + "','" + Animal_Count+ "');";
                                    List_TQL.Add(SQLOfInsert);
                            }
                        }
                    }
                    if (DataAccess.excuteSqlAndReturnValues(List_TQL) > 0) isOK = true;
                }
            }
            catch (Exception ex)
            {
                isOK = false;
            }
            return isOK;
        }


        #endregion


        #region  根据Excel列类型获取列的值

        /// <summary>
        /// 根据Excel列类型获取列的值
        /// </summary>
        /// <param name="cell">Excel列</param>
        /// <returns></returns>
        private static string GetCellValue(ICell cell)
        {
            if (cell == null)
                return string.Empty;
            switch (cell.CellType)
            {
                case CellType.BLANK:
                    return string.Empty;
                case CellType.BOOLEAN:
                    return cell.BooleanCellValue.ToString();
                case CellType.ERROR:
                    return cell.ErrorCellValue.ToString();
                case CellType.NUMERIC:
                case CellType.Unknown:
                default:
                    return cell.ToString();//This is a trick to get the correct value of the cell. NumericCellValue will return a numeric value no matter the cell value is a date or a number
                case CellType.STRING:
                    return cell.StringCellValue;
                case CellType.FORMULA:
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
            }
        }


        #endregion



    }
}
