using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using Maticsoft.Common;
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

        // 表驱动法
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

        tbBook book = new tbBook()
        {
            ISBN1 = tb_num.Text.ToString().Trim(),
            BookName1 = tb_name.Text.ToString().Trim(),
            Price1 = 0,
            PublicDate1 = DateTime.Now
        };

        if (new tbBookManager().addBook(book))
            MessageBox.Show(this, "添加成功");
        else
            MessageBox.Show(this, "添加失败");


    }

   // OleDbServerConn OleDb = new OleDbServerConn();

    public void test()
    {
        
       // GridView1.DataSource = OleDb.DataReaderToDataTable("select * from tbBook");
               
       // GridView1.DataBind();
      
    }



    protected void Button7_Click(object sender, EventArgs e)
    {
        test();
    }
}