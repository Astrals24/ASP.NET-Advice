<%@ WebHandler Language="C#" Class="RegisterSev" %>

using System;
using System.Web;

public class RegisterSev : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        var name = context.Request.QueryString["uname"];
        var pwd = context.Request.QueryString["upwd"];
        var sex = context.Request.QueryString["usex"];
        var adress = context.Request.QueryString["uadress"];
        var phone = context.Request.QueryString["uphone"];

        RegisteMod registe = new RegisteMod()
        {
            Name = name,
            Pwd = pwd,
            Adress = adress,
            Sex = sex,
            Phone = phone
        };
        string msg = "";
        new UserDao().RegisterConfirm(registe, out msg);
        context.Response.Write(msg);

    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}