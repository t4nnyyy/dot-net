using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class insuranceclaim : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Get Filename from fileupload control
       
        string deathcertificate =Path.GetFileName(uplddeathcertificate.FileName); ;
        string passbook =Path.GetFileName(upldpassbook.FileName); ;
        string aadhaar = Path.GetFileName(upldaadhaar.FileName); ;
        string pan = Path.GetFileName(upldpan.FileName); ; 
        
        //Save images into Images folder
        uplddeathcertificate.SaveAs(Server.MapPath("~/Documents/"+ deathcertificate));
        upldpassbook.SaveAs(Server.MapPath("~/Documents/"+ passbook));
        upldaadhaar.SaveAs(Server.MapPath("~/Documents/"+ aadhaar));
        upldpan.SaveAs(Server.MapPath("~/Documents/"+ pan));
        //Getting dbconnection from web.config connectionstring
       SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=life;Integrated Security=True");
        //Open the database connection
        con.Open();
        //Query to insert images path and name into database
        SqlCommand cmd = new SqlCommand("Insert into claim(policyno,deceasedname,nomineename,deathcertificate,passbook,aadhaar,pan) values(@policyno,@deceasedname,@nomineename,@deathcertificate,@passbook,@aadhaar,@pan)", con);
        //Passing parameters to query
        cmd.Parameters.AddWithValue("@policyno", txtpolicyno.Text);
        cmd.Parameters.AddWithValue("@deceasedname", txtdeceasedname.Text);
        cmd.Parameters.AddWithValue("@nomineename", txtnomineename.Text);
        cmd.Parameters.AddWithValue("@deathcertificate", "Documents/"+ deathcertificate);
        cmd.Parameters.AddWithValue("@passbook", "Documents/" + passbook);
        cmd.Parameters.AddWithValue("@aadhaar", "Documents/" + aadhaar);
        cmd.Parameters.AddWithValue("@pan", "Documents/" + pan);
        cmd.ExecuteNonQuery();
        //Close dbconnection
        con.Close();
        //Response.Redirect("~/Default.aspx");
        Response.Write("<script>alert('Insurance Claimed Successfully');</script>");
    }

    
}

       
    