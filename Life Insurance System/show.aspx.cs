using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Text;
using System.Web.SessionState;


public partial class show : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //------------------------------------------------------------
        if (Session["email"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
        else

            con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=life;Integrated Security=True");


        con.Open();
        string str = "select * from admin_login where email='" + Session["email"] + "'";
      
        SqlCommand com = new SqlCommand(str, con);
        SqlDataAdapter da = new SqlDataAdapter(com);

        DataSet ds = new DataSet();

        da.Fill(ds);

        lbluname.Text = ds.Tables[0].Rows[0]["email"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
            // all statements
            con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=life;Integrated Security=True");
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from cust where policyno='" + txtclaimbillno.Text + "'", con);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                txtclntname.Text = (myReader["clientname"].ToString());
                txtclntmob.Text = (myReader["clientmobile"].ToString());
                txtclntdob.Text = (myReader["clientdob"].ToString());
                txtclntadd.Text = (myReader["clientaddress"].ToString());
                txtclntcity.Text = (myReader["clientcity"].ToString());
                txtclntpincode.Text = (myReader["clientpincode"].ToString());

                drpplanname.Text = (myReader["planname"].ToString());
                txtpolicyno.Text = (myReader["policyno"].ToString());
                txtpolicyregisterationyear.Text = (myReader["registerationyear"].ToString());
                txtpolicyamount.Text = (myReader["amount"].ToString());


                txtnomineename.Text = (myReader["nomineename"].ToString());
                txtnomineedob.Text = (myReader["nomineedob"].ToString());
                txtnomineeaddress.Text = (myReader["nomineeaddress"].ToString());
                txtnomineebankaccount.Text = (myReader["nomineebankaccountno"].ToString());
                txtnomineebankname.Text = (myReader["nomineebankname"].ToString());
                txtnomineeifsc.Text = (myReader["nomineeifsc"].ToString());

                

                    
                   
                
            }
            con.Close();

            Response.Write("<script>alert('No Records Found');</script>");
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["email"] = null;
        Response.Redirect(Request.RawUrl);
    }




    
}

