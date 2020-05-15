<%@ WebHandler Language="C#" Class="city_service" %>


using System;
using System.Web;
using System.Data.OleDb;
using System.Configuration;
public class city_service : IHttpHandler {

    public void ProcessRequest (HttpContext context) {
        //context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        //string p = context.Request.Form["province"];
        //string c = context.Request.Form["city"];

        //OleDbServerConnTest conn = new OleDbServerConnTest();


        //HttpPostedFile file = context.Request.Files[0];
        //int len = (int)file.ContentLength;
        //byte[] buf = new byte[len];
        //file.InputStream.Read(buf, 0, len);

        //string sql = string.Format("update cities set cImage='{0}' where pName='{1}' and cName='{2}'",buf,p,c);

        //if(conn.Excu(sql) > 0)
        //{
        //    context.Response.Write("111!");
        //}


        string province = context.Request.Form["province"];
        string city = context.Request.Form["city"];

        string s = ConfigurationManager.ConnectionStrings["mycon"].ConnectionString;
        OleDbConnection con = new OleDbConnection(s);
        con.Open();

        OleDbCommand com = new OleDbCommand();
        com.Connection = con;

        HttpPostedFile fobj = context.Request.Files[0];
        int len = (int)fobj.ContentLength;
        byte[] buf = new byte[len];
        fobj.InputStream.Read(buf, 0, len);

        string sql = "update cities set cImage=? where pName='"+province+"' and cName='"+city+"'";
        OleDbParameter pm = new OleDbParameter("cImage", OleDbType.LongVarBinary);
        pm.Value = buf;
        com.Parameters.Add(pm);
        com.CommandText = sql;

        if (com.ExecuteNonQuery() > 0)
        {
            context.Response.Write("更新图像成功");
            context.Response.Clear();
            context.Response.ContentType = "image/jpeg";
            context.Response.BinaryWrite(buf);
            context.Response.Flush();
        }
        else
        {
            context.Response.Write("更新失败");
        }

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}