using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// RegisteMod 的摘要说明
/// </summary>
public class RegisteMod
{
    public RegisteMod()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    private string name;
    private string pwd;
    private string phone;
    private string adress;
    private string sex;

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public string Pwd
    {
        get
        {
            return pwd;
        }

        set
        {
            pwd = value;
        }
    }

    public string Phone
    {
        get
        {
            return phone;
        }

        set
        {
            phone = value;
        }
    }

    public string Adress
    {
        get
        {
            return adress;
        }

        set
        {
            adress = value;
        }
    }

    public string Sex
    {
        get
        {
            return sex;
        }

        set
        {
            sex = value;
        }
    }
}