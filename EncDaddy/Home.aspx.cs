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


public partial class Home : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            Response.Redirect("signin.aspx");
        }
        else

            //con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=encdady;Integrated Security=True");
              con = new SqlConnection(@"workstation id=encdaddy.mssql.somee.com;packet size=4096;user id=tanny307_SQLLogin_1;pwd=8n4tedjv57;data source=encdaddy.mssql.somee.com;persist security info=False;initial catalog=encdaddy");
       
        con.Open();  
        string str = "select * from register where email='" + Session["email"] + "'";
       SqlCommand  com = new SqlCommand(str, con);

        SqlDataAdapter da = new SqlDataAdapter(com);

        DataSet ds = new DataSet();

        da.Fill(ds);

        lbluname.Text = ds.Tables[0].Rows[0]["username"].ToString() + " (" + ds.Tables[0].Rows[0]["email"].ToString() + ")";
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("encrypt.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("decrypt.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["email"] =null;
        Response.Redirect(Request.RawUrl);
    }
}
