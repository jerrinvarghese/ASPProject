using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASP
{
    public partial class SignUp : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ad;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
                con.Open();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var name = txtUserName.Text;
            var pswd = txtPassword.Text;
            cmd = new SqlCommand("sp_insertProject", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", name);
            cmd.Parameters.AddWithValue("@upswd", pswd);
            cmd.ExecuteNonQuery();
            Response.Redirect("LoginPage.aspx");

        }
    }
}