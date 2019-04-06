using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            Response.Redirect("userlogin.aspx");
        }
        else

            con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=life;Integrated Security=True");
            

        con.Open();
        string str = "select * from register_user where email='" + Session["email"] + "'";
        SqlCommand com = new SqlCommand(str, con);

        SqlDataAdapter da = new SqlDataAdapter(com);

        DataSet ds = new DataSet();

        da.Fill(ds);

        lbluname.Text = ds.Tables[0].Rows[0]["name"].ToString() + " (" + ds.Tables[0].Rows[0]["email"].ToString() + ")";
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Label3.Text = "Your Birth Date is " + DateTime.ParseExact(txtpolicydate.Text, "dd-MM-yyyy", null).ToString("dd/MMM/yyyy");
        SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=life;Integrated Security=True");
        cnn.Open();
        String qry = "insert into cust values('" + txtclntname.Text + "'," + txtclntmob.Text + ",'" + txtclntdob.Text + "','" + txtclntadd.Text + "','" + txtclntcity.Text + "'," + txtclntpincode.Text + ",'" + drpplanname.SelectedItem+ "','" + txtpolicyno.Text + "','" + txtpolicyregisterationyear.Text + "'," + txtpolicyamount.Text + ",'" + txtnomineename.Text + "','" + txtnomineedob.Text + "','" + txtnomineeaddress.Text + "','" + txtnomineebankaccount.Text + "','" + txtnomineebankname.Text + "','" + txtnomineeifsc.Text + "')";
        SqlCommand cmd = new SqlCommand(qry, cnn);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Data Saved Successfully');var ask = window.confirm('Do You Want To Print The Form?');if (ask) {javascript:window.print();}</script>");
        cnn.Close();
        

    } 

    public void clear()
    {
        txtclntname.Text="";
        txtclntmob.Text="";
        txtclntdob.Text="";
        txtclntadd.Text="";
        txtclntcity.Text="";
        txtclntpincode.Text="";
        drpplanname.Text="";
        txtpolicyno.Text="";
        txtpolicyregisterationyear.Text="";
        txtpolicyamount.Text="";
        txtpolicyregisterationyear.Text="";
        txtpolicyamount.Text="";
        txtnomineename.Text="";
        txtnomineedob.Text="";
        txtnomineeaddress.Text="";
        txtnomineebankaccount.Text="";
        txtnomineebankname.Text="";
        txtnomineeifsc.Text = "";
        
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        clear();
    }

    public EventArgs args { get; set; }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["email"] = null;
        Response.Redirect(Request.RawUrl);
    }
   
  
}