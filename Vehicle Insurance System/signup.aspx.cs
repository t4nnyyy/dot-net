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

         con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=client;Integrated Security=True");
         
           
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into register_user values (@name, @email, @password)", con);
            cmd.Parameters.AddWithValue("name", Nametxt.Text);
            cmd.Parameters.AddWithValue("email", Emailtxt.Text);
            cmd.Parameters.AddWithValue("password", Passwordtxt.Text);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Registeration Successful');var ask = window.confirm('Goto Login Page?');if (ask) {window.location.href = 'userlogin.aspx';}</script>");
            Nametxt.Text = "";
            Nametxt.Text = "";
            Emailtxt.Text = "";
            Passwordtxt.Text = "";
            Server.Transfer("userlogin.aspx");
            
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