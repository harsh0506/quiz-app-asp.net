using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class ChooseTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == null)
            {
                System.Diagnostics.Debug.WriteLine("choose one ");
            }
            try
            {
                Response.Redirect("Test.aspx?Parameter=" + DropDownList1.SelectedValue);
            }
            catch (Exception es)
            {
                System.Diagnostics.Debug.WriteLine("error is : " + es.Message);

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}