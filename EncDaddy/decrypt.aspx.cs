using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Net;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Data.Sql;

public partial class decrypt : System.Web.UI.Page
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
        SqlCommand com = new SqlCommand(str, con);

        SqlDataAdapter da = new SqlDataAdapter(com);

        DataSet ds = new DataSet();

        da.Fill(ds);

        lbluname.Text = ds.Tables[0].Rows[0]["username"].ToString() + " (" + ds.Tables[0].Rows[0]["email"].ToString() + ")";
    }


     string rndimgname = Path.GetRandomFileName();
     static string base64String = null;


    protected void btndec_Click(object sender, EventArgs e)
    {
        
        string txt4 = txtdec.Text;
        if (txtkey.Text == "")
        {
            Response.Write("<script>alert('Please Enter Your Security Password');</script>");
        }

        if (txtdec.Text == "" && txtkey.Text == "")
        {
            Response.Write("<script>alert('Please Browse Encrypted Text And Secret Key File Above');</script>");
        }
        else
       
            txtdec.Text = txt4.Substring(28, txt4.Length - 28);
            //con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=encdady;Integrated Security=True");
              con = new SqlConnection(@"workstation id=encdaddy.mssql.somee.com;packet size=4096;user id=tanny307_SQLLogin_1;pwd=8n4tedjv57;data source=encdaddy.mssql.somee.com;persist security info=False;initial catalog=encdaddy");
            SqlCommand cmd = new SqlCommand("select * from tblenc where sec_text='" + txtdec.Text + "' and sec_key='" + txtkey.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
        
         if (dt.Rows.Count > 0)
        {
            Response.Write("<script>alert('Image Decryption Successfull');</script>");
            this.SaveImage(txtdec.Text, rndimgname);
            txtrndimgname.Text = rndimgname + ".jpg";
            imgprw.ImageUrl = "~/Decrypted/" + txtrndimgname.Text;
            txtdec.Text = "";
            txtkey.Text = "";
            btnsavepic.Enabled = true;
        }
        else
        {
            Response.Write("<script>alert('Error, Lol');</script>");
            txtdec.Text = "";
            txtkey.Text = "";
        }  
    }


    protected void btnsavepic_Click(object sender, EventArgs e)
    {
        if (imgprw.ImageUrl == "")
        {
            Response.Write("<script>alert('First Click On Decrypt Button');</script>");
        }
        string imgname = Path.GetRandomFileName();
        Response.ContentType = "image/jpeg";
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + imgname + ".jpg");
        Response.TransmitFile(imgprw.ImageUrl);
        Response.End();
    }


    protected void btnupldsectext_Click(object sender, EventArgs e)
    {
        if (upldenctxt.FileName == "")
        {
            Response.Write("<script>alert('Please Browse Encrypted File');</script>");
            lblupldstatus1.Text = "ERROR";
            lblupldstatus1.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            TextReader tr = new StreamReader(upldenctxt.FileContent);
            txtdec.Text = tr.ReadToEnd();
            tr.Close();
            lblupldstatus1.Text = "OK";
            lblupldstatus1.ForeColor = System.Drawing.Color.Lime;
        }
    }


   




    //FUNCTIONS//

    public string ImageToBase64()
    {
        string path = Server.MapPath("~/Encrypted/");
        using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
    }

    public System.Drawing.Image Base64ToImage()
    {
        byte[] imageBytes = Convert.FromBase64String(base64String);
        MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
        ms.Write(imageBytes, 0, imageBytes.Length);
        System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
        return image;
    }



    public bool SaveImage(string ImgStr, string ImgName)
    {
        String path = HttpContext.Current.Server.MapPath("~/Decrypted"); //Path

        //Check if directory exist
        if (!System.IO.Directory.Exists(path))
        {
            System.IO.Directory.CreateDirectory(path); //Create directory if it doesn't exist
        }

        string fullimageName = ImgName + ".jpg";

        //set the image path
        string imgPath = Path.Combine(path, fullimageName);

        byte[] imageBytes = Convert.FromBase64String(ImgStr);

        File.WriteAllBytes(imgPath, imageBytes);
        return true;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["email"] = null;
        Response.Redirect(Request.RawUrl);
        
    }
}