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
        //执行sql语句，反馈信息       
        string sql = string.Format("select * from [user] where Uname = '{0}' and Upassword = '{1}'", name, pwd);

        DataTable table= conn.DataReaderToDataTable(sql);
        

        if (table != null)
        {
            msg = table.Rows[0]["ID"].ToString();

        }
        else
        {
            msg = "用户名或密码错误!";
        }
    }


    public void RegisterConfirm(RegisteMod registe,out string msg)
    {
        msg = "";
        string sql = string.Format("insert into [user](Uname,Upassword,Uemail,Usex,Uaddress,lei) values('{0}','{1}','{2}','{3}','{4}','{5}')",registe.Name,registe.Pwd,registe.Phone,registe.Sex,registe.Adress,1);

        if (conn.Excu(sql) > 0)
        {
            msg = "注册成功";
        }
        else
            msg = "注册失败";
    }

    public bool lookMenu(out List<restDataStruct_Menu> me,string lei) {

        List<restDataStruct_Menu> m = new List<restDataStruct_Menu>();
        //m.Clear();
        OleDbServerConnTest conn = new OleDbServerConnTest();
        string sql = string.Format("select Cid,Cname,Cjia,Cpin,Cimg from [caipin] where Clei='{0}'",lei);
        DataTable table = conn.DataReaderToDataTable(sql);

        for (int i = 0; i < table.Rows.Count; ++i)
        {
            restDataStruct_Menu _Menu = new restDataStruct_Menu()
            {
                Cid = table.Rows[i]["Cid"].ToString(),
                Name = table.Rows[i]["Cname"].ToString(),
                Price = table.Rows[i]["Cjia"].ToString(),
                Info = table.Rows[i]["Cpin"].ToString(),
                Img = table.Rows[i]["Cimg"].ToString(),
                Type_ = lei
            };
            m.Add(_Menu);

        }
        me = m;

        if (me.Count > 0)
            return true;

        return true;
    }


}