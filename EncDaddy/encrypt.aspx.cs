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


public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    protected void Page_Load(object sender, EventArgs e)
    {


        
        if (Session["email"] == null)
        {
            Response.Redirect("signin.aspx");
        }
        else

             con = new SqlConnection(@"workstation id=encdaddy.mssql.somee.com;packet size=4096;user id=tanny307_SQLLogin_1;pwd=8n4tedjv57;data source=encdaddy.mssql.somee.com;persist security info=False;initial catalog=encdaddy");
           //con = new SqlConnection(@"Data Source=LAPTOP-TANNY;Initial Catalog=encdady;Integrated Security=True");

        con.Open();
        string str = "select * from register where email='" + Session["email"] + "'";
        SqlCommand com = new SqlCommand(str, con);

        SqlDataAdapter da = new SqlDataAdapter(com);

        DataSet ds = new DataSet();

        da.Fill(ds);

        lbluname.Text = ds.Tables[0].Rows[0]["username"].ToString() + " (" + ds.Tables[0].Rows[0]["email"].ToString() + ")";
    }


    string temp;
    static string base64String = null;
    

    protected void btnencrypt_Click(object sender, EventArgs e)
    {
        
        string ipaddress;
        ipaddress = Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

        if (ipaddress == "" || ipaddress == null)
            ipaddress = Request.ServerVariables["REMOTE_ADDR"];
        txtipadd.Text = ipaddress;

        if (imgprw.ImageUrl == "")
        {
            Response.Write("<script>alert('Please Preview Image First');</script>");
        }
        else
        {
            txtenctext.Text = ImageToBase64();
            
            
            //string str = "Data Source=LAPTOP-TANNY;Initial Catalog=encdady;Integrated Security=True";
            string str = "workstation id=encdaddy.mssql.somee.com;packet size=4096;user id=tanny307_SQLLogin_1;pwd=8n4tedjv57;data source=encdaddy.mssql.somee.com;persist security info=False;initial catalog=encdaddy";
            SqlConnection cn = new SqlConnection(str);
            cn.Open();
            string n = "insert into tblenc values('" + txtenctext.Text + "','" + txtkey.Text + "','" + txtipadd.Text + "')";
            SqlCommand cmd = new SqlCommand(n, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            txtenctext.Text = "Xd1J5QtHT86PrNH+YlZJmHNy+xl/" + txtenctext.Text;
        }
            if (txtenctext.Text != "")
        {
            Response.Write("<script>alert('Download Encrypted Text And Remember Password');</script>");
            btndwnldenctxt.Enabled = true;
         

        }
    }


    protected void btnprwimg_Click(object sender, EventArgs e)
    {
        string folderPath = Server.MapPath("~/Encrypted/");
        try
        {
            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            upldimg.SaveAs(folderPath + Path.GetFileName(upldimg.FileName));

            //Display the Picture in Image control.
            imgprw.ImageUrl = "~/Encrypted/" + Path.GetFileName(upldimg.FileName);
            txtimgprwpath.Text = folderPath + Path.GetFileName(upldimg.FileName);
        }
        catch (Exception tp) {
            temp = Convert.ToString(tp);
            Response.Write("<script>alert('Please Browse Image First');</script>");
        }
    }



    protected void btndwnldenctxt_Click1(object sender, EventArgs e)
    {
        string filenm = System.IO.Path.GetRandomFileName();
        string ipadd = txtipadd.Text;
        string sGenName = "encdaddy.sectxt";

        using (System.IO.StreamWriter SW = new System.IO.StreamWriter(Server.MapPath("TextFiles/" + filenm + ".sectxt")))
        {
            SW.Write(txtenctext.Text);
            SW.Close();
        }

        System.IO.FileStream fs = null;
        fs = System.IO.File.Open(Server.MapPath("TextFiles/" + filenm + ".sectxt"), System.IO.FileMode.Open);
        byte[] btFile = new byte[fs.Length];
        fs.Read(btFile, 0, Convert.ToInt32(fs.Length));
        fs.Close();
        Response.AddHeader("Content-disposition", "attachment; filename=" + sGenName);
        Response.ContentType = "application/octet-stream";
        Response.BinaryWrite(btFile);
        Response.End();
    }
 

  //FUNCTIONS//

    public string ImageToBase64()
    {
        string path = txtimgprwpath.Text;
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

        string imageName = ImgName + ".jpg";

        //set the image path
        string imgPath = Path.Combine(path, imageName);

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
    

