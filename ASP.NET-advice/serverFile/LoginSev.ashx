<%@ WebHandler Language="C#" Class="LoginSev" %>

using System;
using System.Web;

public class LoginSev : IHttpHandler {

    private UserDao userDao =  new UserDao();

    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        //context.Response.Write("Hello World");
        string name = context.Request.QueryString["name"];
        string pwd = context.Request.QueryString["pwd"];
        string msg = "";
        userDao.loginConfirm(name,pwd,out msg);

        context.Response.Write(msg);



    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}