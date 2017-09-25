using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectASP
{
    public partial class QuestionPage : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter ad;
        string firsttext = "";
        string firstvalue = "";
        string secondtext = "";
        string secondvalue = "";
        string thirdtext = "";
        string thirdvalue = "";
        string fourthtext = "";
        string fourthvalue = "";
        List<ListItem> item1 = new List<ListItem>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            var userNAME= Session["user"];
            //var userID = Session["uid"];
            DataTable dt = new DataTable();
            con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
            con.Open();
            MultiView1.ActiveViewIndex = 0;
            cmd = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 1 + "'", con);
            ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {

                var questionNo = dt.Rows[0]["Question"];
                var A = dt.Rows[0]["OptionA"].ToString();
                var AValue = dt.Rows[0]["OptionAValue"].ToString();
                var B = dt.Rows[0]["OptionB"].ToString();
                var BValue = dt.Rows[0]["OptionBValue"].ToString();
                var C = dt.Rows[0]["OptionC"].ToString();
                var CValue = dt.Rows[0]["OptionCValue"].ToString();
                var D = dt.Rows[0]["OptionD"].ToString();
                var DValue = dt.Rows[0]["OptionDValue"].ToString();

                 item1.Add(new ListItem(A, AValue));
                item1.Add(new ListItem(B, BValue));
                item1.Add(new ListItem(C, CValue));
                item1.Add(new ListItem(D, DValue));
                rdbtnQn1.DataSource = item1;
                rdbtnQn1.DataBind();


            }
        }

        protected List<ListItem> GetRadioBtnList(int QnNo)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd3 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + QnNo + "'", con);
            ad = new SqlDataAdapter(cmd3);
            ad.Fill(dt);

            var questionNo = dt.Rows[0]["Question"];
            firsttext = dt.Rows[0]["OptionA"].ToString();
            firstvalue = dt.Rows[0]["OptionAValue"].ToString();
            secondtext = dt.Rows[0]["OptionB"].ToString();
            secondvalue = dt.Rows[0]["OptionBValue"].ToString();
            thirdtext = dt.Rows[0]["OptionC"].ToString();
            thirdvalue = dt.Rows[0]["OptionCValue"].ToString();
            fourthtext = dt.Rows[0]["OptionD"].ToString();
            fourthvalue = dt.Rows[0]["OptionDValue"].ToString();

            List<ListItem> item1 = new List<ListItem>();
            item1.Add(new ListItem(firsttext, firstvalue));
            item1.Add(new ListItem(secondtext, secondvalue));
            item1.Add(new ListItem(thirdtext, thirdvalue));
            item1.Add(new ListItem(fourthtext, fourthvalue));
            return item1;
        }
        protected void btnNextQn1_Click(object sender, EventArgs e)
        {
            var QnSelected1 = rdbtnQn1.SelectedItem.Value;
            //var QuestionNo = 1;
            //var Ans1 = rdbtnQn1.SelectedItem.Value;
            //var correctAns = "";
            //SqlCommand cmd3 = new SqlCommand("select CorrectAnswerValue from QnTable where Question='" + QuestionNo + "'", con);
            //SqlDataReader rd = cmd3.ExecuteReader();
            //while(rd.Read())
            //{
            //   correctAns = rd["CorrectAnswerValue"].ToString();
            //}
            //rd.Close();
            //if(Ans1==correctAns)
            //{

            //}
            //SqlCommand cmd4 = new SqlCommand("insert into ResultTable values('" + Session["uid"] + "','" + QuestionNo + "','" + Ans1 + "')", con);
            //cmd4.ExecuteNonQuery();
            MultiView1.SetActiveView(Qn2);
            rdbtnQn2.DataSource = GetRadioBtnList(2);
            rdbtnQn2.DataBind();
                    

        }

        protected void btnNextQn2_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn3);
            rdbtnQn3.DataSource = GetRadioBtnList(3);
            rdbtnQn3.DataBind();
        }

        protected void btnNextQn3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn4);
            rdbtnQn4.DataSource = GetRadioBtnList(4);
            rdbtnQn4.DataBind();
        }

        protected void btnNextQn4_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn5);
            rdbtnQn5.DataSource = GetRadioBtnList(5);
            rdbtnQn5.DataBind();
        }

        protected void btnNextQn5_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn6);
            rdbtnQn6.DataSource = GetRadioBtnList(6);
            rdbtnQn6.DataBind();
        }

        protected void btnNextQn6_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn7);
            rdbtnQn7.DataSource = GetRadioBtnList(7);
            rdbtnQn7.DataBind();
        }

        protected void btnNextQn7_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn8);
            rdbtnQn8.DataSource = GetRadioBtnList(8);
            rdbtnQn8.DataBind();
        }

        protected void btnNextQn8_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn9);
            rdbtnQn9.DataSource = GetRadioBtnList(9);
            rdbtnQn9.DataBind();
        }

        protected void btnNextQn9_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn10);
            rdbtnQn10.DataSource = GetRadioBtnList(10);
            rdbtnQn10.DataBind();
        }

        protected void btnNextQn10_Click(object sender, EventArgs e)
        {
            
            var QnSelected1 = rdbtnQn1.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 1, QnSelected1);
            
            var QnSelected2 = rdbtnQn2.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 2, QnSelected2);
            
            var QnSelected3 = rdbtnQn3.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 3, QnSelected3);
            
            var QnSelected4 = rdbtnQn4.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 4, QnSelected4);
            
            var QnSelected5 = rdbtnQn5.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 5, QnSelected5);

            var QnSelected6 = rdbtnQn6.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 6, QnSelected6);

            var QnSelected7 = rdbtnQn7.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 7, QnSelected7);

            var QnSelected8 = rdbtnQn8.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 8, QnSelected8);

            var QnSelected9 = rdbtnQn9.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 9, QnSelected9);

            var QnSelected10 = rdbtnQn10.SelectedItem.Value;
            InsertResult(Convert.ToInt16(Session["uid"]), 10, QnSelected10);




        }

        protected void InsertResult(int uid,int QuestionNo,string selectedAns)
        {
            var rslt = "";
            var val = "";
            SqlCommand cmdResult = new SqlCommand("select CorrectAnswerValue from QnTable where Question='" + QuestionNo + "'", con);
            SqlDataReader rdResult = cmdResult.ExecuteReader();
            while(rdResult.Read())
            {
                rslt = rdResult["CorrectAnswerValue"].ToString();
            }
            if(selectedAns== rslt)
            {
                val = "T";
            }
            else
            {
                val = "F";
            }
            rdResult.Close();
            SqlCommand cmdInsertResult = new SqlCommand("insert into ResultTbl values('" + uid + "','" + QuestionNo + "','" + selectedAns + "','" + val + "')", con);
            cmdInsertResult.ExecuteNonQuery();
        }
    }

        
    
}