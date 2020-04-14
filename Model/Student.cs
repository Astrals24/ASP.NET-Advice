using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Student 的摘要说明
/// </summary>
public class Student
{
	public Student()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public Student(String studentId, int classId, int nationId,
            String studentName, int studentSex, String studentDate,
            int studentOrigin, String idCard, String studentAddress)
    {
        this.studentId = studentId;
        this.classId = classId;
        this.nationId = nationId;
        this.studentName = studentName;
        this.studentSex = studentSex;
        this.studentDate = studentDate;
        this.studentOrigin = studentOrigin;
        this.idCard = idCard;
        this.studentAddress = studentAddress;
    }

    private String studentId;

    public String StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }

    private int classId;

    public int ClassId
    {
        get { return classId; }
        set { classId = value; }
    }

    private int nationId;

    public int NationId
    {
        get { return nationId; }
        set { nationId = value; }
    }

    private String studentName;

    public String StudentName
    {
        get { return studentName; }
        set { studentName = value; }
    }

    private int studentSex;

    public int StudentSex
    {
        get { return studentSex; }
        set { studentSex = value; }
    }

    private String studentDate;

    public String StudentDate
    {
        get { return studentDate; }
        set { studentDate = value; }
    }

    private int studentOrigin;

    public int StudentOrigin
    {
        get { return studentOrigin; }
        set { studentOrigin = value; }
    }

    private String idCard;

    public String IdCard
    {
        get { return idCard; }
        set { idCard = value; }
    }

    private String studentAddress;

    public String StudentAddress
    {
        get { return studentAddress; }
        set { studentAddress = value; }
    }
}