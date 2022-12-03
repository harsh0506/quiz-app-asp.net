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
    public partial class Test : System.Web.UI.Page
    {
        string test_name = "test1_science";
        string cs = ConfigurationManager.ConnectionStrings["string1"].ConnectionString;
        int testscore = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            test_name = Request.QueryString["parameter"].ToString();
            Label1.Text = test_name;
            getdata(test_name);
        }

        protected void getdata(string test_name)
        {
            
            string sql = "SELECT Question, A, B, C, D,Ans FROM " + test_name ;
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            Repeater1.DataSource = cmd.ExecuteReader();
            Repeater1.DataBind();
            conn.Close();
                     
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            foreach(RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb1 = (RadioButton)ri.FindControl("Radio1");
                Label L1 = (Label)ri.FindControl("label12");
                Label L3 = (Label)ri.FindControl("label3");
                if (rb1.Checked == true)
                {
                    if (rb1.Text.Equals(L1.Text))
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb1.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb1.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
            //seconf radio
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb2 = (RadioButton)ri.FindControl("Radio2");
                Label L1 = (Label)ri.FindControl("label12");
                Label L3 = (Label)ri.FindControl("label3");
                if (rb2.Checked == true)
                {
                    if (rb2.Text.Equals(L1.Text))
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb2.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb2.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb3 = (RadioButton)ri.FindControl("Radio3");
                Label L1 = (Label)ri.FindControl("label12");
                Label L3 = (Label)ri.FindControl("label3");
                if (rb3.Checked == true)
                {
                    if (rb3.Text.Equals(L1.Text))
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb3.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb3.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
            foreach (RepeaterItem ri in Repeater1.Items)
            {
                RadioButton rb4 = (RadioButton)ri.FindControl("Radio4");
                Label L1 = (Label)ri.FindControl("label12");
                Label L3 = (Label)ri.FindControl("label3");
                if (rb4.Checked == true)
                {
                    if (rb4.Text.Equals(L1.Text))
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb4.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb4.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }
            /*
                foreach (RepeaterItem ri in Repeater1.Items)
                {
                    RadioButton rb1 = (RadioButton)ri.FindControl("Radio1");
                    RadioButton rb2 = (RadioButton)ri.FindControl("Radio2");
                    RadioButton rb3 = (RadioButton)ri.FindControl("Radio3");
                    RadioButton rb4 = (RadioButton)ri.FindControl("Radio4");
                    Label L1 = (Label)ri.FindControl("label12");
                    Label L3 = (Label)ri.FindControl("label3");
                    
                if (rb1.Checked == true)
                    {
                        if (rb1.Text== L1.Text)
                        {
                            L3.Visible = true;
                            L1.Visible = true;
                            Label L2 = (Label)ri.FindControl("Label2");
                            L2.Visible = true;
                            L2.Text = "the selected ans is " + rb1.Text.ToString() + "<br/>";
                            L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                        }
                       else
                        {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb1.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                    }

                }
                    else if (rb2.Checked == true)
                    {
                        if (rb2.Text.Equals(L1.Text))
                        {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb2.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb2.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                    }
                    }
                    else if (rb3.Checked == true)
                    {
                        if (rb3.Text.Equals(L1.Text))
                        {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb3.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb2.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Red;
                        
                    }
                    }
                    else
                    {
                        if (rb4.Text.Equals(L1.Text))
                        {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb4.Text.ToString() + "<br/>";
                        L2.ForeColor = System.Drawing.Color.Green;
                        testscore++;
                    }
                    else
                    {
                        L3.Visible = true;
                        L1.Visible = true;
                        Label L2 = (Label)ri.FindControl("Label2");
                        L2.Visible = true;
                        L2.Text = "the selected ans is " + rb2.Text.ToString() + "<br/>";

                        L2.ForeColor = System.Drawing.Color.Red;
                    }
                    }
                
                }
              */

            Label13.Text = "the score is :" + testscore;
        }
    }
}