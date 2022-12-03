using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace test
{

    public partial class Add : System.Web.UI.Page
    {
    
        string cs = ConfigurationManager.ConnectionStrings["string1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "create table " + TextBox1.Text + "([Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,[Question] TEXT NULL,[A] TEXT NULL,[B] TEXT NULL,[C] TEXT NULL,[D] TEXT NULL,[Ans] TEXT NULL)";
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                string sql2 = "insert into NameOfTest values('" + TextBox1.Text +"')";
                SqlCommand cmd2 = new SqlCommand(sql2, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                System.Diagnostics.Debug.WriteLine("created ");
                Label1.Text = "created";
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('test is created')", true);

            }
            catch (Exception es)
            {
                System.Diagnostics.Debug.WriteLine("error happend" + es.Message);
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label8.Text = DropDownList1.SelectedValue;
            System.Diagnostics.Debug.WriteLine(DropDownList1.SelectedValue);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            string Tbname = DropDownList1.SelectedValue;
            if (Tbname != "" || Tbname!= "")
            {
                //string sql = $"insert into " + Tbname + "values ( '" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "' )";
                //string sql = string.Format("insert into {0} values ({1},{2},{3},{4},{5},{6})" ,Tbname, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
                string sql =string.Format("insert into {0} values('{1}' , '{2}','{3}' , '{4}' , '{5}' , '{6}')" , Tbname,TextBox2.Text , TextBox3.Text , TextBox4.Text , TextBox5.Text , TextBox6.Text , TextBox7.Text);
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('question is added')", true);

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChooseTest.aspx");
        }
    }
}