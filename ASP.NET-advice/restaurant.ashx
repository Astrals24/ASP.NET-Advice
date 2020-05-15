<%@ WebHandler Language="C#" Class="restaurant" %>

using System;
using System.Web;
using System.Data.OleDb;
public class restaurant : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");


        var conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\GithubProject\ASP.NET-advice\ASP.NET-advice\DB\HotelDb.mdb");
        conn.Open();

        string feng = context.Request["taste"];
        string sql = string.Format("select [餐谱编号],[名称] from [餐谱] where [风味]='{0}'",feng);

        var reader = new OleDbCommand(sql, conn).ExecuteReader();
        var str = "{";
        while (reader.Read())
        {
            str += reader["餐谱编号"] + ":'" + reader["名称"] + "',";
        }
        str += "}";

        context.Response.Clear();
        context.Response.Write(str);
        context.Response.Flush();

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}