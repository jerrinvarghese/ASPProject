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
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter ad;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
            con.Open();
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var uname = txtUserName.Text;
            var pwd = txtPswd.Text;
            cmd = new SqlCommand("sp_loginProject", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", uname);
            cmd.Parameters.AddWithValue("@pswd", pwd);
            ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                var userid = Convert.ToInt16(dr["UserId"]);
                var name = dr["UserName"].ToString();
                var password = dr["UserPassword"].ToString();
                
                Session["user"] = name;
                Session["uid"] = userid;


                
                Response.Redirect("QuestionPage.aspx");
            }
                




        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPswd.Text = "";
        }

        
    }
}