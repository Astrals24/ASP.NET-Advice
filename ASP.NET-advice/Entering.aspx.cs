using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Maticsoft.Common;

public partial class Entering : System.Web.UI.Page
{

    SqlServerConnTest conn = new SqlServerConnTest();


    void init()
    {
        

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //添加获取班级

    //添加【确定】按钮的事件函数，查询学生的信息

    //自定义函数——绑定Table数据
    public void tableBind()
    {
        string ID = selectClass.SelectedValue;

        //MessageBox.Show(this, ID.ToString());
        string sql = string.Format("SELECT * FROM tb_student st,tb_physical ph WHERE st.StudentID = ph.studentId AND ClassId = '{0}'",ID);
        physicalTable.DataSource = conn.DataReaderToDataTable(sql);
        physicalTable.DataBind();

    }



    protected void submitSelect_Click(object sender, EventArgs e)
    {
        if (ddl_class.SelectedValue == "0")
        {
            MessageBox.Show(this, "请选择年级");
            return;
        }
        if (selectClass.SelectedValue == "0")
        {
            MessageBox.Show(this, "请选择班级");
            return;
        }

        ClassName.Text = ddl_class.SelectedItem.ToString()+selectClass.SelectedItem.ToString()+"体育测评录入";


        tableBind();

    }

    protected void ddl_class_SelectedIndexChanged(object sender, EventArgs e)
    {

        selectClass.Items.Clear();
        selectClass.Items.Add("--请选择--");
        string ID = ddl_class.SelectedValue;      
        string sql = string.Format("SELECT * FROM tb_class WHERE GradeId='{0}'",ID);
        selectClass.DataSource = conn.DataReaderToDataTable(sql);
        selectClass.DataTextField = "ClassName";
        selectClass.DataValueField = "ClassID";
        selectClass.DataBind();

    }

    protected void ddl_class_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void physicalTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        physicalTable.PageIndex = e.NewPageIndex;
        tableBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var button = sender as Button;
        GridViewRow gvr = button.Parent.Parent as GridViewRow;

        string Height = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("Height")).Text.ToString().Trim();
        string Weight = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("Weight")).Text.ToString().Trim();
        string LungVolume = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("LungVolume")).Text.ToString().Trim();
        string Run50 = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("Run50")).Text.ToString().Trim();
        string StandJump = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("StandJump")).Text.ToString().Trim();
        string SitReach = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("SitReach")).Text.ToString().Trim();
        string Run800 = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("Run800")).Text.ToString().Trim();
        string Run1000 = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("Run1000")).Text.ToString().Trim();
        string SitUp = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("SitUp")).Text.ToString().Trim();
        string PullUp = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("PullUp")).Text.ToString().Trim();
        string LeftVision = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("LeftVision")).Text.ToString().Trim();
        string RightVision = ((TextBox)physicalTable.Rows[gvr.RowIndex].FindControl("RightVision")).Text.ToString().Trim();

        string StudentId = physicalTable.Rows[gvr.RowIndex].Cells[0].Text.ToString().Trim();

        float height = (Height == "") ? 0 : float.Parse(Height);
        float weight = (Weight == "") ? 0 : float.Parse(Weight);
        float standJump = (StandJump == "") ? 0 : float.Parse(StandJump);
        float sitReach = (SitReach == "") ? 0 : float.Parse(SitReach);
        float leftVision = (LeftVision == "") ? 0 : float.Parse(LeftVision);
        float rightVision = (RightVision == "") ? 0 : float.Parse(RightVision);
        int lungVolume = (LungVolume == "") ? 0 : int.Parse(LungVolume);
        int sitUp = (SitUp == "") ? 0 : int.Parse(SitUp);
        int pullUp = (PullUp == "") ? 0 : int.Parse(PullUp);
        Run50 = Run50.Replace('\'', ':');
        Run50 = Run50.Replace('’', ':');
        Run800 = Run800.Replace('\'', ':');
        Run800 = Run800.Replace('’', ':');
        Run1000 = Run1000.Replace('\'', ':');
        Run1000 = Run1000.Replace('’', ':');
        string run50 = null, run800 = null, run1000 = null;
        if (Run50 != "" & Run50 != "00:00:00")
        {
            run50 = "00:00:" + Run50;
        }
        if (Run800 != "" & Run800 != "00:00:00")
        {
            run800 = "0:" + Run800;
        }
        if (Run1000 != "" & Run1000 != "00:00:00")
        {
            run1000 = "0:" + Run1000;
        }

        // 可以进一步优化 拼接字符串过于麻烦
        string sql = "update tb_physical set Height='" + Height + "',Weight= '" + Weight + "',LungVolume= '" + LungVolume
            + "',run50= '" + Run50 + "',StandJump= '" + StandJump + "',SitReach= '" + SitReach + "',Run800= '" + Run800
            + "',Run1000= '" + Run1000 + "',SitUp= '" + SitUp + "',PullUp= '" + PullUp + "',LeftVision= '" + LeftVision
            + "',RightVision= '" + RightVision + "'WHERE StudentId='"+StudentId+"'";

        

        if (conn.Excu(sql) > 0)
            MessageBox.Show(this,"录入成功");


    }

    protected void physicalTable_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if(e.Row.RowType == DataControlRowType.DataRow)
        {
            if (((Label)e.Row.FindControl("StudentSex")).Text.ToString().Trim().Equals("1"))
            {
                ((TextBox)e.Row.FindControl("Run800")).Enabled = false;
                ((TextBox)e.Row.FindControl("SitUp")).Enabled = false;
            }
            else
            {
                ((TextBox)e.Row.FindControl("Run1000")).Enabled = false;
                ((TextBox)e.Row.FindControl("PullUp")).Enabled = false;
            }

            string[] arr = {"Height","Weight","LungVolume",  "Run50","StandJump" ,"SitReach","Run800Run1000" ,"SitUp" ,"PullUp" ,"LeftVision","RightVision" };

            foreach(string name in arr)
            {
                if (!((TextBox)e.Row.FindControl(name.ToString())).Text.ToString().Trim().Equals(""))
                {
                    ((TextBox)e.Row.FindControl(name.ToString())).Enabled = false;
                }
            }
        }
    }
}