using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// TheClass 的摘要说明
/// </summary>
public class TheClass
{
	public TheClass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public TheClass(int classID, int gradeId, String className)
    {
        this.classID = classID;
        this.gradeId = gradeId;
        this.className = className;
    }

    private int classID;

    public int ClassID
    {
        get { return classID; }
        set { classID = value; }
    }

    private int gradeId;

    public int GradeId
    {
        get { return gradeId; }
        set { gradeId = value; }
    }

    private String className;

    public String ClassName
    {
        get { return className; }
        set { className = value; }
    }
}