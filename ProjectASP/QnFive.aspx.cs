using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASP
{
    public partial class QnFive : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
            con.Open();
        }

        protected void btnQn4_Click(object sender, EventArgs e)
        {
            var Result = 0;
            var uname = Session["user"];
            var id = Session["uid"];
            var QnNo = 5;
            var Ans = rdbtnQn5.SelectedItem.Value;
            var CorrectAns = "D";
            if (Ans == CorrectAns)
            {
                Result = 1;
            }
            else
            {
                Result = 0;
            }
            cmd = new SqlCommand("insert into Answertbl values('" + id + "','" + uname + "','" + QnNo + "','" + Ans + "','" + CorrectAns + "','" + Result + "')", con);
            cmd.ExecuteNonQuery();
            Response.Redirect("Result.aspx");
        }
    }
}