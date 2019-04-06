using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class signin : System.Web.UI.Page
{
    SqlConnection con=new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] != null)
        {
            Response.Redirect("home.aspx");
        }

    }
    

    protected void Button1_Click1(object sender, EventArgs e)
    {
       
             con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=life;Integrated Security=True");
            
            try{  
       
        con.Open();  
        string qry = "select * from register_user where email='" + Emailtxt.Text  + "' and password='" + Passwordtxt.Text + "'";  
        SqlCommand cmd = new SqlCommand(qry,con);  
        SqlDataReader sdr = cmd.ExecuteReader();  
        if(sdr.Read())  
        {
            
            Session["email"] = Emailtxt.Text;
            con.Close();   
            Response.RedirectPermanent("insuranceregister.aspx");
            
        }  
        else  
        {  
            Response.Write("<script>alert('Provide Valid Email And Password');</script>");
            Emailtxt.Text = "";
            Passwordtxt.Text = "";
  
        }  
            
        }  
        catch(Exception ex)  
        {  
            Response.Write(ex.Message);  
        }  
}      
    }
