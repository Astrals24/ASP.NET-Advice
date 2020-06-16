using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// restMod 的摘要说明
/// </summary>
public class restMod
{
    private string cid;
    private string name;
    private string price;
    private string type;
    private string info;
    private string img;

    public override string ToString()
    {
        return base.ToString();
    }

    public string Cid
    {
        get
        {
            return cid;
        }

        set
        {
            cid = value;
        }
    }

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

    public string Price
    {
        get
        {
            return price;
        }

        set
        {
            price = value;
        }
    }

    public string Type
    {
        get
        {
            return type;
        }

        set
        {
            type = value;
        }
    }

    public string Info
    {
        get
        {
            return info;
        }

        set
        {
            info = value;
        }
    }

    public string Img
    {
        get
        {
            return img;
        }

        set
        {
            img = value;
        }
    }
}