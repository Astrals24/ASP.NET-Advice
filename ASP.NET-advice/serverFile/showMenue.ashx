<%@ WebHandler Language="C#" Class="showMenue" %>

using System;
using System.Web;
using System.Text;
using System.Collections.Generic;
public class showMenue : IHttpHandler {

    OleDbServerConnTest conn = new OleDbServerConnTest();


    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        string id = context.Request.QueryString["lei"];


        string lei = context.Request.QueryString["lei"];
        UserDao member = new UserDao();
        List<restDataStruct_Menu> menu;
        member.lookMenu(out menu, lei);
        StringBuilder sb = new StringBuilder();
        sb.Append("{\"data\":[");
        if (menu.Count > 0)
            sb.Append("{" + string.Format("\"cid\":\"{0}\",\"name\":\"{1}\",\"price\":\"{2}\",\"type\":\"{3}\",\"info\":\"{4}\",\"img\":\"{5}\"", menu[0].ToStrings()) + "}");
        for (int i = 1; i < menu.Count; i++)
        {
            sb.Append(",{" + string.Format("\"cid\":\"{0}\",\"name\":\"{1}\",\"price\":\"{2}\",\"type\":\"{3}\",\"info\":\"{4}\",\"img\":\"{5}\"", menu[i].ToStrings()) + "}");
        }
        sb.Append("]}");
        context.Response.Write(sb.ToString());

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}