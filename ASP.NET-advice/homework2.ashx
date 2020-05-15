<%@ WebHandler Language="C#" Class="homework2" %>

using System;
using System.Web;
using System.Data;
using System.Data.OleDb;

public class homework2 : IHttpHandler {

    public void ProcessRequest (HttpContext context) {

        //客户端取值 到 服务端：Request 
        string city = context.Request["city"];
        string province = context.Request["province"];
        //连接表  打开连接
        var conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\GithubProject\ASP.NET-advice\ASP.NET-advice\DB\cities.mdb");
        conn.Open();
          
        //执行sql语句，反馈信息       
        string sql = string.Format("select cNote from cities where pName='{0}' and cName='{1}'",province,city);
    
        var reader = new OleDbCommand(sql, conn).ExecuteReader();

       // 通过context.Response向客户端输出结果
        while (reader.Read())
        {
            context.Response.Write(reader["cNote"]);
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}