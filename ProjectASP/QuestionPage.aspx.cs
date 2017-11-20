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
        //static List<ListItem> item1 = new List<ListItem>();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Initializing the connection at page load itself
            try
            {
                con = new SqlConnection("Data Source=SUYPC070;Initial Catalog=ASPProject;User Id=sa;Password=Suyati123");
                con.Open();
                if (!IsPostBack)
                {
                    //btnPreviousQn1.Enabled = false;
                    var userNAME = Session["user"];
                    var userID = Session["uid"];
                    //DataTable dt = new DataTable();

                    //Filling first question

                    DataTable dt1 = new DataTable();
                    SqlCommand cmd1 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 1 + "'", con);
                    ad = new SqlDataAdapter(cmd1);
                    ad.Fill(dt1);

                    var questionNo = dt1.Rows[0]["Question"];
                    firsttext = dt1.Rows[0]["OptionA"].ToString();
                    firstvalue = dt1.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt1.Rows[0]["OptionB"].ToString();
                    secondvalue = dt1.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt1.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt1.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt1.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt1.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn1.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn1.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn1.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn1.Items.Add(new ListItem(fourthtext, fourthvalue));


                    //Filling second question

                    DataTable dt2 = new DataTable();
                    SqlCommand cmd2 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 2 + "'", con);
                    SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
                    ad2.Fill(dt2);

                    var questionNo2 = dt2.Rows[0]["Question"];
                    firsttext = dt2.Rows[0]["OptionA"].ToString();
                    firstvalue = dt2.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt2.Rows[0]["OptionB"].ToString();
                    secondvalue = dt2.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt2.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt2.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt2.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt2.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn2.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn2.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn2.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn2.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling third question

                    DataTable dt3 = new DataTable();
                    SqlCommand cmd3 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 3 + "'", con);
                    SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);
                    ad3.Fill(dt3);

                    var questionNo3 = dt3.Rows[0]["Question"];
                    firsttext = dt3.Rows[0]["OptionA"].ToString();
                    firstvalue = dt3.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt3.Rows[0]["OptionB"].ToString();
                    secondvalue = dt3.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt3.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt3.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt3.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt3.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn3.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn3.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn3.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn3.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling fourth question

                    DataTable dt4 = new DataTable();
                    SqlCommand cmd4 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 4 + "'", con);
                    SqlDataAdapter ad4 = new SqlDataAdapter(cmd4);
                    ad4.Fill(dt4);

                    var questionNo4 = dt4.Rows[0]["Question"];
                    firsttext = dt4.Rows[0]["OptionA"].ToString();
                    firstvalue = dt4.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt4.Rows[0]["OptionB"].ToString();
                    secondvalue = dt4.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt4.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt4.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt4.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt4.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn4.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn4.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn4.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn4.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling fifth question

                    DataTable dt5 = new DataTable();
                    SqlCommand cmd5 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 5 + "'", con);
                    SqlDataAdapter ad5 = new SqlDataAdapter(cmd5);
                    ad5.Fill(dt5);

                    var questionNo5 = dt5.Rows[0]["Question"];
                    firsttext = dt5.Rows[0]["OptionA"].ToString();
                    firstvalue = dt5.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt5.Rows[0]["OptionB"].ToString();
                    secondvalue = dt5.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt5.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt5.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt5.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt5.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn5.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn5.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn5.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn5.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling sixth question

                    DataTable dt6 = new DataTable();
                    SqlCommand cmd6 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 6 + "'", con);
                    SqlDataAdapter ad6 = new SqlDataAdapter(cmd6);
                    ad6.Fill(dt6);

                    var questionNo6 = dt6.Rows[0]["Question"];
                    firsttext = dt6.Rows[0]["OptionA"].ToString();
                    firstvalue = dt6.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt6.Rows[0]["OptionB"].ToString();
                    secondvalue = dt6.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt6.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt6.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt6.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt6.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn6.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn6.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn6.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn6.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling seventh question

                    DataTable dt7 = new DataTable();
                    SqlCommand cmd7 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 7 + "'", con);
                    SqlDataAdapter ad7 = new SqlDataAdapter(cmd7);
                    ad7.Fill(dt7);

                    var questionNo7 = dt7.Rows[0]["Question"];
                    firsttext = dt7.Rows[0]["OptionA"].ToString();
                    firstvalue = dt7.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt7.Rows[0]["OptionB"].ToString();
                    secondvalue = dt7.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt7.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt7.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt7.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt7.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn7.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn7.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn7.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn7.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling eighth question

                    DataTable dt8 = new DataTable();
                    SqlCommand cmd8 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 8 + "'", con);
                    SqlDataAdapter ad8 = new SqlDataAdapter(cmd8);
                    ad8.Fill(dt8);

                    var questionNo8 = dt8.Rows[0]["Question"];
                    firsttext = dt8.Rows[0]["OptionA"].ToString();
                    firstvalue = dt8.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt8.Rows[0]["OptionB"].ToString();
                    secondvalue = dt8.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt8.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt8.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt8.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt8.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn8.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn8.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn8.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn8.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling ninth question

                    DataTable dt9 = new DataTable();
                    SqlCommand cmd9 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 9 + "'", con);
                    SqlDataAdapter ad9 = new SqlDataAdapter(cmd9);
                    ad9.Fill(dt9);

                    var questionNo9 = dt9.Rows[0]["Question"];
                    firsttext = dt9.Rows[0]["OptionA"].ToString();
                    firstvalue = dt9.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt9.Rows[0]["OptionB"].ToString();
                    secondvalue = dt9.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt9.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt9.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt9.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt9.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn9.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn9.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn9.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn9.Items.Add(new ListItem(fourthtext, fourthvalue));

                    //Filling tenth question

                    DataTable dt10 = new DataTable();
                    SqlCommand cmd10 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + 10 + "'", con);
                    SqlDataAdapter ad10 = new SqlDataAdapter(cmd10);
                    ad10.Fill(dt10);

                    var questionNo10 = dt10.Rows[0]["Question"];
                    firsttext = dt10.Rows[0]["OptionA"].ToString();
                    firstvalue = dt10.Rows[0]["OptionAValue"].ToString();
                    secondtext = dt10.Rows[0]["OptionB"].ToString();
                    secondvalue = dt10.Rows[0]["OptionBValue"].ToString();
                    thirdtext = dt10.Rows[0]["OptionC"].ToString();
                    thirdvalue = dt10.Rows[0]["OptionCValue"].ToString();
                    fourthtext = dt10.Rows[0]["OptionD"].ToString();
                    fourthvalue = dt10.Rows[0]["OptionDValue"].ToString();

                    rdbtnQn10.Items.Add(new ListItem(firsttext, firstvalue));
                    rdbtnQn10.Items.Add(new ListItem(secondtext, secondvalue));
                    rdbtnQn10.Items.Add(new ListItem(thirdtext, thirdvalue));
                    rdbtnQn10.Items.Add(new ListItem(fourthtext, fourthvalue));
                }
            }
            catch (Exception ex)
            {
                lblQnException.Text = ex.Message;
            }
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            MultiView1.SetActiveView(Qn1);

            
        }

        //protected void GetRadioBtnList(int QnNo, out string firsttext, out string firstvalue, out string secondtext, out string secondvalue, out string thirdtext, out string thirdvalue, out string fourthtext, out string fourthvalue)
        //{
        //    DataTable dt = new DataTable();
        //    SqlCommand cmd3 = new SqlCommand("select Question,OptionA,OptionAValue,OptionB,OptionBValue,OptionC,OptionCValue,OptionD,OptionDValue,CorrectAnswerValue from QnTable where Question='" + QnNo + "'", con);
        //    ad = new SqlDataAdapter(cmd3);
        //    ad.Fill(dt);

        //    var questionNo = dt.Rows[0]["Question"];
        //    firsttext = dt.Rows[0]["OptionA"].ToString();
        //    firstvalue = dt.Rows[0]["OptionAValue"].ToString();
        //    secondtext = dt.Rows[0]["OptionB"].ToString();
        //    secondvalue = dt.Rows[0]["OptionBValue"].ToString();
        //    thirdtext = dt.Rows[0]["OptionC"].ToString();
        //    thirdvalue = dt.Rows[0]["OptionCValue"].ToString();
        //    fourthtext = dt.Rows[0]["OptionD"].ToString();
        //    fourthvalue = dt.Rows[0]["OptionDValue"].ToString();


        //    //item1.Add(new ListItem(firsttext, firstvalue));
        //    //item1.Add(new ListItem(secondtext, secondvalue));
        //    //item1.Add(new ListItem(thirdtext, thirdvalue));
        //    //item1.Add(new ListItem(fourthtext, fourthvalue));
        //    //return item1;
        //}
        protected void btnNextQn1_Click(object sender, EventArgs e)
        {
             MultiView1.SetActiveView(Qn2);
        }

        protected void btnNextQn2_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn3);
        }

        protected void btnNextQn3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn4);
        }

        protected void btnNextQn4_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn5);

        }

        protected void btnNextQn5_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn6);

        }

        protected void btnNextQn6_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn7);

        }

        protected void btnNextQn7_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn8);

        }

        protected void btnNextQn8_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn9);

        }

        protected void btnNextQn9_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn10);

        }

        protected void btnNextQn10_Click(object sender, EventArgs e)
        {
            //submitting the values to the database
            try
            {
                var usts = "T";
                var QnSelected1 = rdbtnQn1.SelectedValue;
                if (QnSelected1 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 1, QnSelected1);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 1, "NA");
                }

                var QnSelected2 = rdbtnQn2.SelectedValue;
                if (QnSelected2 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 2, QnSelected2);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 2, "NA");
                }

                var QnSelected3 = rdbtnQn3.SelectedValue;
                if (QnSelected3 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 3, QnSelected3);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 3, "NA");
                }

                var QnSelected4 = rdbtnQn4.SelectedValue;
                if (QnSelected4 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 4, QnSelected4);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 4, "NA");
                }

                var QnSelected5 = rdbtnQn5.SelectedValue;
                if (QnSelected5 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 5, QnSelected5);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 5, "NA");
                }

                var QnSelected6 = rdbtnQn6.SelectedValue;
                if (QnSelected6 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 6, QnSelected6);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 6, "NA");
                }

                var QnSelected7 = rdbtnQn7.SelectedValue;
                if (QnSelected7 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 7, QnSelected7);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 7, "NA");
                }

                var QnSelected8 = rdbtnQn8.SelectedValue;
                if (QnSelected8 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 8, QnSelected8);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 8, "NA");
                }

                var QnSelected9 = rdbtnQn9.SelectedValue;
                if (QnSelected9 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 9, QnSelected9);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 9, "NA");
                }

                var QnSelected10 = rdbtnQn10.SelectedValue;
                if (QnSelected10 != "")
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 10, QnSelected10);
                }
                else
                {
                    InsertResult(Convert.ToInt16(Session["uid"]), 10, "NA");
                }
                SqlCommand cmdUpdateResult = new SqlCommand("update ASPProjecttbl set userstatus='" + usts + "' where UserId='" + Session["uid"] + "'", con);
                cmdUpdateResult.ExecuteNonQuery();
                Response.Redirect("ResultPage.aspx");

            }
            catch(Exception ex)
            {
                lblQnException.Text = ex.Message+ " " + ex.StackTrace;
            }


        }

        protected void InsertResult(int uid, int QuestionNo, string selectedAns)
        {
            try
            {
                var rslt = "";
                var val = "";
                SqlCommand cmdResult = new SqlCommand("select CorrectAnswerValue from QnTable where Question='" + QuestionNo + "'", con);
                SqlDataReader rdResult = cmdResult.ExecuteReader();
                while (rdResult.Read())
                {
                    rslt = rdResult["CorrectAnswerValue"].ToString();
                }
                if (selectedAns == rslt)
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
            catch(Exception ex)
            {
                lblQnException.Text = ex.Message;
            }
        }

        protected void btnPreviousQn1_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn1);
        }

        protected void btnPreviousQn2_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn1);
        }

        protected void btnPreviousQn3_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn2);
        }

        protected void btnPreviousQn4_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn3);
        }

        protected void btnPreviousQn5_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn4);
        }

        protected void btnPreviousQn6_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn5);
        }

        protected void btnPreviousQn7_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn6);
        }

        protected void btnPreviousQn8_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn7);
        }

        protected void btnPreviousQn9_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn8);
        }

        protected void btnPreviousQn10_Click(object sender, EventArgs e)
        {
            MultiView1.SetActiveView(Qn9);
        }

        
    }



}