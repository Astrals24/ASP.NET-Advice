using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// User 的摘要说明
/// </summary>
public class User
{
	public User()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public User(String userId, String userName, String password, int power)
    {
        this.userId = userId;
        this.userName = userName;
        this.password = password;
        this.power = power;
    }

    String userId;

    public String UserId
    {
        get { return userId; }
        set { userId = value; }
    }
    String userName;

    public String UserName
    {
        get { return userName; }
        set { userName = value; }
    }
    String password;

    public String Password
    {
        get { return password; }
        set { password = value; }
    }
    int power;

    public int Power
    {
        get { return power; }
        set { power = value; }
    }
}