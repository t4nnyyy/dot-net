<%@ Page Language="C#" AutoEventWireup="true" CodeFile="decrypt.aspx.cs" Inherits="decrypt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="shortcut icon" type="image/x-icon" href="~/favicon.ico" />
    <title>Decrypt</title>
    </head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    <div align="center">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:HyperLink ID="linkhome" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink ID="linkencrypt" runat="server" NavigateUrl="~/encrypt.aspx">Encrypt</asp:HyperLink>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="Large" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>
&nbsp;&nbsp;
            
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Logged In As: "></asp:Label>
&nbsp;<asp:Label ID="lbluname" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
        <br />
    
        <br />
        <br />
    
        <asp:TextBox ID="txtdec" runat="server" Height="28px" TextMode="MultiLine" 
            Width="210px" Visible="False" style="margin-bottom: 0px"></asp:TextBox>
                    &nbsp;<asp:Label ID="lblheading" runat="server" Font-Size="XX-Large" 
            Text="Decryption"></asp:Label><br />
                    &nbsp;
                    <br />
        <asp:Label ID="lblenctxtfile" runat="server" Text="Browse Encrypted Text File"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="upldenctxt" runat="server" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Status:&nbsp;<asp:Label 
            ID="lblupldstatus1" runat="server" Font-Bold="True" ForeColor="Lime"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnupldsectxt" runat="server" onclick="btnupldsectext_Click" 
            Text="Upload Secret Text File" Width="162px" style="height: 26px" />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    Enter Your Security Password:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtkey" runat="server" Width="182px" Font-Bold="True" Height="22px" MaxLength="10" TextMode="Password"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="btndec" runat="server" onclick="btndec_Click" 
            Text="Click To Decrypt" style="height: 26px" />
                <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="imgprw" runat="server" Height="200px" Width="200px" BorderColor="Black" 
                        BorderStyle="Outset" BorderWidth="2px" />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnsavepic" runat="server" onclick="btnsavepic_Click" 
            Text="Save This Pic" Width="102px" Enabled="False" />
                <br />
        <br />
        <br />
                    <asp:TextBox ID="txtrndimgname" runat="server" Visible="False" 
            Width="16px"></asp:TextBox>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp; Follow Us On:&nbsp;
                    <asp:HyperLink ID="linkinsta" runat="server" 
                        NavigateUrl="https://instagram.com/codeonlinux" BackColor="White" 
                        ForeColor="Lime">Instagram</asp:HyperLink>
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
                        NavigateUrl="https://codeonlinux.blogspot.com/" 
            ForeColor="Lime">Our Blog</asp:HyperLink>
                    <br />
                    <br />
&nbsp;<asp:Image ID="imglogo" runat="server" Height="187px" ImageUrl="~/codeonlinux.png" 
                        Width="232px" />
       
    
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
