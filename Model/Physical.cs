using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Physical 的摘要说明
/// </summary>
public class Physical
{
	public Physical()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    public Physical(String studentId, float height, float weight,
            int lungVolume, String run50, float standJump, float sitReach,
            String run800, String run1000, int sitUp, int pullUp,
            float leftVision, float rightVision)
    {
        this.studentId = studentId;
        this.height = height;
        this.weight = weight;
        this.lungVolume = lungVolume;
        this.run50 = run50;
        this.standJump = standJump;
        this.sitReach = sitReach;
        this.run800 = run800;
        this.run1000 = run1000;
        this.sitUp = sitUp;
        this.pullUp = pullUp;
        this.leftVision = leftVision;
        this.rightVision = rightVision;
    }

    private String studentId;

    public String StudentId
    {
        get { return studentId; }
        set { studentId = value; }
    }
    private float height;

    public float Height
    {
        get { return height; }
        set { height = value; }
    }
    private float weight;

    public float Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    private int lungVolume;

    public int LungVolume
    {
        get { return lungVolume; }
        set { lungVolume = value; }
    }
    private String run50;

    public String Run50
    {
        get { return run50; }
        set { run50 = value; }
    }
    private float standJump;

    public float StandJump
    {
        get { return standJump; }
        set { standJump = value; }
    }
    private float sitReach;

    public float SitReach
    {
        get { return sitReach; }
        set { sitReach = value; }
    }
    private String run800;

    public String Run800
    {
        get { return run800; }
        set { run800 = value; }
    }
    private String run1000;

    public String Run1000
    {
        get { return run1000; }
        set { run1000 = value; }
    }
    private int sitUp;

    public int SitUp
    {
        get { return sitUp; }
        set { sitUp = value; }
    }
    private int pullUp;

    public int PullUp
    {
        get { return pullUp; }
        set { pullUp = value; }
    }
    private float leftVision;

    public float LeftVision
    {
        get { return leftVision; }
        set { leftVision = value; }
    }
    private float rightVision;

    public float RightVision
    {
        get { return rightVision; }
        set { rightVision = value; }
    }
}