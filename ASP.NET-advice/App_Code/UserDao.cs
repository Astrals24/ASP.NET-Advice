using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

/// <summary>
/// UserDao 的摘要说明
/// </summary>
public class UserDao
{
    private OleDbServerConn conn = new OleDbServerConn();

    public DataTable DataTable { get; private set; }

    //
    // TODO: 在此处添加构造函数逻辑
    //     
    public void loginConfirm(string name, string pwd, out string msg)
    {

        msg = "";
        //where Uname = '{0}' and Upassword = '{1}
        //String sql = string.Format("select * from xixi.user");

        //var conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\GithubProject\ASP.NET-advice\ASP.NET-advice\DB\xixi.mdb");
        //conn.Open();

        //执行sql语句，反馈信息       
        string sql = string.Format("select * from xixi.user where Uname = '{0}' and Upassword = '{1}'", name, pwd);

        DataTable table= conn.DataReaderToDataTable(sql);
        

        if (table != null)
        {
            msg = table.Rows[0]["ID"].ToString();

        }
        else
        {
            msg = "用户名或密码错误!";
        }
        //var reader = new OleDbCommand(sql, conn).ExecuteReader();

        //通过context.Response向客户端输出结果
        //while (reader.Read())
        //{
        //    if (reader["Uname"].ToString() == name)
        //        msg = reader["Uname"].ToString() + "-登录成功!";
        //    else
        //        msg = "用户名或密码错误!";
        //}







    }


}