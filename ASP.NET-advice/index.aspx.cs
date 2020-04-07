using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {

        }

    }

    protected void btn_getBook_Click(object sender, EventArgs e)
    {
        //string id = tb_ID.Text.ToString().Trim();
      ;
    }



    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Hashtable temp = new Hashtable();
        temp.Add("add",0);
        temp.Add("delete", 1);
        temp.Add("update", 2);

        MultiView1.ActiveViewIndex = (int)temp[radBtn.SelectedValue];

        //String key = "select";
        //radBtn.Items.Add(key);
        //temp.Add(key,temp.Count+1);


        //switch (radBtn.SelectedValue)
        //{
        //    case "add": MultiView1.ActiveViewIndex = 0; break;
        //    case "delete": MultiView1.ActiveViewIndex = 1; break;
        //    case "update": MultiView1.ActiveViewIndex = 2; break;
        //}


    }

    protected void Button3_Click(object sender, EventArgs e)
    {

        //lianjian();
    }

    OleDbServerConn OleDb = new OleDbServerConn();

    public void test()
    {
        //OleDbConnection Conn = new OleDbConnection();
        //OleDbCommand Comm = new OleDbCommand();
        //OleDbDataReader dataReader = null;

        //Conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mycon"].ToString();

        //Conn.Open();

        //Comm.CommandText = "select * from tbBook";
        //Comm.Connection = Conn;
        //dataReader = Comm.ExecuteReader();

        GridView1.DataSource = OleDb.DataReaderToDataTable("select * from tbBook");
            
            //dataReader;
        GridView1.DataBind();

    

       // Response.Write(dataReader["ISBN"]);
        
    }



    protected void Button7_Click(object sender, EventArgs e)
    {
        test();
    }
}