using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASP
{
    public partial class Project : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label masterLabel = (Label)this.Page.Master.FindControl("lbluser");
            masterLabel.Text = (string)Session["user"];
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
           
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }
    }
}