using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// restDataStructure 的摘要说明
/// </summary>
public class restDataStructure
{
    public restDataStructure()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }



}

public class restDataStruct_Menu
{
    public enum index
    {
        cid,
        name,
        price,
        type,
        info,
        img
    }
    private string cid;
    private string name;
    private string price;
    private string type;
    private string info;
    private string img;

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

    public string Type_
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

    public restDataStruct_Menu()
    {

    }
    public restDataStruct_Menu(string cid, string name, string price, string type, string info, string img)
    {
        this.Cid = cid;
        this.Name = name;
        this.Price = price;
        this.Type_ = type;
        this.Info = info;
        this.Img = img;
    }
    public string[] ToStrings()
    {
        List<string> strs = new List<string>();
        strs.Add(this.Cid);
        strs.Add(this.Name);
        strs.Add(this.Price);
        strs.Add(this.Type_);
        strs.Add(this.Info);
        strs.Add(this.Img);
        return strs.ToArray();
    }

    public string[] ToStrings_()
    {
        List<string> strs = new List<string>();
        strs.Add(this.Name);
        strs.Add(this.Price);
        strs.Add(this.Type_);
        strs.Add(this.Info);
        strs.Add(this.Img);
        return strs.ToArray();
    }

}// restDataStruct_Menu类结束
