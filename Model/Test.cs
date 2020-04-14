using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Test 的摘要说明
/// </summary>
public class Test
{
	public Test()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public Test(int testClass, int testName, String testTime,
            String testTeacher, String testSite, String testKit, int testPattern)
    {
        this.testClass = testClass;
        this.testName = testName;
        this.testTime = testTime;
        this.testTeacher = testTeacher;
        this.testSite = testSite;
        this.testKit = testKit;
        this.testPattern = testPattern;
    }

    private int testClass;

    public int TestClass
    {
        get { return testClass; }
        set { testClass = value; }
    }
    private int testName;

    public int TestName
    {
        get { return testName; }
        set { testName = value; }
    }
    private String testTime;

    public String TestTime
    {
        get { return testTime; }
        set { testTime = value; }
    }
    private String testTeacher;

    public String TestTeacher
    {
        get { return testTeacher; }
        set { testTeacher = value; }
    }
    private String testSite;

    public String TestSite
    {
        get { return testSite; }
        set { testSite = value; }
    }
    private String testKit;

    public String TestKit
    {
        get { return testKit; }
        set { testKit = value; }
    }
    private int testPattern;

    public int TestPattern
    {
        get { return testPattern; }
        set { testPattern = value; }
    }
}