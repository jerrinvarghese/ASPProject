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
    public partial class ResultPage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            var uid = Session["uid"];
            con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select QnNo,SelectedOption as SelectedAnswer,CorrectAnswerValue as RightAnswer from ResultTbl R inner join QnTable Q on R.QnNo=Q.Question where UserId='"+ uid + "'", con);
            ad.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}