<%@ WebHandler Language="C#" Class="restSev" %>

using System;
using System.Web;

public class restSev : IHttpHandler {

    OleDbServerConnTest oleDbServerConn = new OleDbServerConnTest();


    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");

        String sql = string.Format("select * from [caipin]");
        oleDbServerConn.DataReaderToDataTable(sql);

        context.Response.Write("!!");



    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}