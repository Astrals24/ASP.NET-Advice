using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web.Configuration;


    public class OleDbServerConn
    {
        // string connstr = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        private static readonly string connstr = WebConfigurationManager.ConnectionStrings["mycon"].ToString();

        /// <summary>
        /// 输入SQL语句 返回影响行数
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public int Excu(string strSql)
        {
            int num = -1;
            using (OleDbConnection OleDbConn = new OleDbConnection(connstr))
            {
                OleDbCommand OleDbComm = new OleDbCommand(strSql, OleDbConn);

                OleDbConn.Open();

                num = OleDbComm.ExecuteNonQuery();
            }
            return num;
        }


        /// <summary>   
        /// SqlDataReader转成DataTable实现方法   
        /// </summary>   
        /// <param name="strSql"></param>   
        /// <returns></returns>   
        public DataTable DataReaderToDataTable(string strSql)
        {
            //string connstr = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
            OleDbConnection OleDbConn = new OleDbConnection(connstr);
            OleDbCommand OleDbComm = new OleDbCommand(strSql, OleDbConn); 
            OleDbDataReader dataReader = null;
            DataTable dtReturn = null;
            object[] value = null;
            try
            {
                OleDbComm.Connection.Open();
                dataReader = OleDbComm.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dtReturn = CreateTableBySchemaTable(dataReader.GetSchemaTable());
                    value = new object[dataReader.FieldCount];
                    while (dataReader.Read())
                    {
                        dataReader.GetValues(value);
                        dtReturn.LoadDataRow(value, true);
                    }
                    value = null;
                }

            }
            catch (Exception err)
            { }
            finally
            {
                dataReader.Close();
                OleDbComm.Connection.Close();
                OleDbComm.Dispose();
            }
            return dtReturn;
        }
        /// <summary>
        /// 创建表结构
        /// </summary>
        /// <param name="pSchemaTable"></param>
        /// <returns></returns>
        protected DataTable CreateTableBySchemaTable(DataTable pSchemaTable)
        {
            DataTable dtReturn = new DataTable();
            DataColumn dc = null;
            DataRow dr = null;
            for (int i = 0; i < pSchemaTable.Rows.Count; i++)
            {
                dr = pSchemaTable.Rows[i];
                dc = new DataColumn(dr["ColumnName"].ToString(), dr["DataType"] as Type);
                dtReturn.Columns.Add(dc);
            }
            dr = null;
            dc = null;
            return dtReturn;
        }


   

    }
