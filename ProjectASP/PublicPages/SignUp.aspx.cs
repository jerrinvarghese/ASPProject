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
            //Initializing the connection at page load itself
            try
            {
                con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
                con.Open();
            }
            catch (Exception ex)
            {
                lblSignUpException.Text = ex.Message;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //clearing the value in textbox on clicking the cancel button
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Registering new user. Same users cannot register more than once.
            try
            {
                var status = "F";
                var name = txtUserName.Text;
                var pswd = txtPassword.Text;

                SqlCommand cmdCheckUser = new SqlCommand("select * from ASPProjecttbl where UserName='" + name + "' and UserPassword='" + pswd + "'", con);
                SqlDataReader rd = cmdCheckUser.ExecuteReader();
                if (rd.Read())
                {
                    Response.Write("<script>alert('Already registered')</script>");
                    // Response.Write("Already registered");
                }
                else
                {
                    rd.Close();
                    cmd = new SqlCommand("sp_insertProject", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", name);
                    cmd.Parameters.AddWithValue("@upswd", pswd);
                    cmd.Parameters.AddWithValue("@sts", status);
                    cmd.ExecuteNonQuery();

                    Response.Redirect("~/LoginPage.aspx");
                    Response.Write("<script>alert('Successfully Registered')</script>");
                }

            }

            catch (Exception ex)
            {
                lblSignUpException.Text = ex.Message;
            }
        }
    }
}