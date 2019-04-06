using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

public partial class login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

         //con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=encdady;Integrated Security=True");
           con = new SqlConnection(@"workstation id=encdaddy.mssql.somee.com;packet size=4096;user id=tanny307_SQLLogin_1;pwd=8n4tedjv57;data source=encdaddy.mssql.somee.com;persist security info=False;initial catalog=encdaddy");
           
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into register values (@username, @email, @password)", con);
            cmd.Parameters.AddWithValue("username", Nametxt.Text);
            cmd.Parameters.AddWithValue("email", Emailtxt.Text);
            cmd.Parameters.AddWithValue("password", Passwordtxt.Text);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Registeration Successful');var ask = window.confirm('Goto Login Page?');if (ask) {window.location.href = 'signin.aspx';}</script>");
            Nametxt.Text = "";
            Nametxt.Text = "";
            Emailtxt.Text = "";
            Passwordtxt.Text = "";
            Server.Transfer("signin.aspx");
            
        }
        catch(Exception ex)
        {
            Response.Write("<script>alert('"+ex+"');</script>");
            Nametxt.Text = "";
            Nametxt.Text = "";
            Emailtxt.Text = "";
            Passwordtxt.Text = "";
            
        }
    }
   
}