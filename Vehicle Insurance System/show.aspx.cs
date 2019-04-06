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

            con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=client;Integrated Security=True");


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
            con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=client;Integrated Security=True");
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand myCommand = new SqlCommand("select * from client where claimbillno='" + txtclaimbillno.Text + "'", con);

            myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                txtpolicyno.Text = (myReader["policyno"].ToString());
                txtpolicydate.Text = (myReader["policyexdte"].ToString());
                txtname.Text = (myReader["name"].ToString());
                txtaddress.Text = (myReader["address"].ToString());
                txtcity.Text = (myReader["city"].ToString());
                txtpincode.Text = (myReader["pincode"].ToString());
                txtmbno.Text = (myReader["mobile"].ToString());


                txtcomname.Text = (myReader["comname"].ToString());
                txtmodel.Text = (myReader["model"].ToString());
                txtserial.Text = (myReader["serialno"].ToString());
                txtyearofpur.Text = (myReader["yearofpur"].ToString());
                txtpurfrom.Text = (myReader["purchasefrom"].ToString());
                txtbillno.Text = (myReader["purchasebillno"].ToString());


                txtincidentdate.Text = (myReader["incidentdate"].ToString());
                txtincidentaddress.Text = (myReader["incidentaddress"].ToString());
                txtincidentinfo.Text = (myReader["incidentinfo"].ToString());
                txtfirdate.Text = (myReader["firdate"].ToString());
                txtpolicysta.Text = (myReader["policesta"].ToString());
                txtfirno.Text = (myReader["firno"].ToString());


                txtclaimdate.Text = (myReader["claimdate"].ToString());
                txtclaimby.Text = (myReader["claimby"].ToString());
                txtclaimbillno0.Text = (myReader["claimbillno"].ToString());
                txtclaimamount.Text = (myReader["claimamount"].ToString());

            }
            con.Close();
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["email"] = null;
        Response.Redirect(Request.RawUrl);
    }




    
}

