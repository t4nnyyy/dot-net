<%@ Page Language="C#" AutoEventWireup="true" CodeFile="encrypt.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="shortcut icon" type="image/x-icon" href="~/favicon.ico" />
    <title>Encrypt</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
                    <asp:HyperLink ID="linkhome" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="linkdecrypt" runat="server" NavigateUrl="~/decrypt.aspx">Decrypt</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="Large" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>
            
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
                    <asp:Label ID="lblheading" runat="server" Font-Size="XX-Large" 
            Text="Encryption"></asp:Label>
    
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Logged In As: "></asp:Label>
                    <asp:Label ID="lbluname" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
        
     
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:FileUpload 
                        ID="upldimg" runat="server" Width="353px" />
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:Label ID="lblimgprw" runat="server" Text="Image Preview" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="imgprw" runat="server" Height="200px" Width="200px" BorderColor="Black" 
                        BorderStyle="Outset" BorderWidth="2px" />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnprwimg" runat="server" onclick="btnprwimg_Click" 
            Text="Click To Preview Image" Font-Bold="True" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    &nbsp;&nbsp;<br />
                    &nbsp;&nbsp;
                    <br />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:TextBox ID="txtenctext" runat="server" Height="16px" TextMode="MultiLine" 
            Width="187px" ReadOnly="True" Visible="False"></asp:TextBox>
                    <br />
                    Enter Your Security Password:&nbsp;
                    <asp:TextBox ID="txtkey" runat="server" Height="16px" 
                        Width="201px" TextMode="Password" Font-Bold="True" MaxLength="10"></asp:TextBox>
                    &nbsp;
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button 
                        ID="btnencrypt" runat="server" onclick="btnencrypt_Click" 
            Text="Click To Encrypt" Font-Bold="True" style="height: 26px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <br />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btndwnldenctxt" runat="server" onclick="btndwnldenctxt_Click1" 
                        Text="Download Encrypted Text" Width="172px" Enabled="False" />
                    &nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    &nbsp;
                    &nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtipadd" runat="server" Width="204px" Visible="False"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtimgprwpath" runat="server" Visible="False" Width="16px"></asp:TextBox>
                    <br />
                    &nbsp;&nbsp;&nbsp; Follow Us On:&nbsp;
                    <asp:HyperLink ID="linkinsta" runat="server" 
                        NavigateUrl="https://instagram.com/codeonlinuxx" ForeColor="Lime">Instagram</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="linktele" runat="server" 
                        NavigateUrl="https://t.me/codeonlinuxx" ForeColor="Lime">Telegram</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="linkyoutube" runat="server" 
                        NavigateUrl="https://www.youtube.com/channel/UCOKP4IzyDjdmPiS13caupRQ" 
                        ForeColor="Lime">Youtube</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="linkgithub" runat="server" 
                        NavigateUrl="https://github.com/codeonlinux" ForeColor="Lime">Github</asp:HyperLink>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="linkblog" runat="server" 
                        NavigateUrl="https://codeonlinux.blogspot.com/" ForeColor="Lime">Our Blog</asp:HyperLink>
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Image ID="imglogo" runat="server" Height="187px" ImageUrl="~/codeonlinux.png" 
                        Width="232px" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
    
                    <br />
                    <br />
                    <asp:Label ID="lblabout" runat="server" 
        Text="© 2019  Encryption Daddy | Designed and Developed by Tanveer Ali" 
            Font-Bold="True" Font-Overline="False" Font-Strikeout="False" 
            Font-Underline="True"></asp:Label>
       
    
    </div>
    </form>
</body>
</html>
