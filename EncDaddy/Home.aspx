<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="icon" type="image/x-icon" href="~/favicon.ico" />
    <title>Home</title>
    <style type="text/css">
        .style1
        {
            width: 568px;
        }
        .style2
        {
            width: 419px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
   
            <marquee behaviour="alternate"><asp:Panel ID="Panel1" runat="server" style="margin-bottom: 0px">
             <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" 
            Text="E" Font-Bold="True" ForeColor="#0099FF"></asp:Label>
            <asp:Label ID="Label9" runat="server" Font-Size="XX-Large" Text="N" 
                Font-Bold="True" ForeColor="Lime"></asp:Label>
            <asp:Label ID="Label10" runat="server" Font-Size="XX-Large" Text="C" 
                Font-Bold="True" ForeColor="Red"></asp:Label>
            <asp:Label ID="Label11" runat="server" Font-Size="XX-Large" Text="R" 
                Font-Bold="True" ForeColor="#3333CC"></asp:Label>
            <asp:Label ID="Label12" runat="server" Font-Size="XX-Large" Text="Y" 
                Font-Bold="True" ForeColor="#66CCFF"></asp:Label>
            <asp:Label ID="Label13" runat="server" Font-Size="XX-Large" Text="P" 
                Font-Bold="True" ForeColor="#66FF66"></asp:Label>
            <asp:Label ID="Label14" runat="server" Font-Size="XX-Large" Text="T" 
                Font-Bold="True" ForeColor="#0066FF"></asp:Label>
            <asp:Label ID="Label15" runat="server" Font-Size="XX-Large" Text="I" 
                Font-Bold="True" ForeColor="#CC33FF"></asp:Label>
            <asp:Label ID="Label16" runat="server" Font-Size="XX-Large" Text="O" 
                Font-Bold="True" ForeColor="#3399FF"></asp:Label>
            <asp:Label ID="Label17" runat="server" Font-Size="XX-Large" Text="N" 
                Font-Bold="True" ForeColor="#CC00CC"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label18" runat="server" Font-Size="XX-Large" Text="D" 
                Font-Bold="True" ForeColor="#00FF99"></asp:Label>
            <asp:Label ID="Label19" runat="server" Font-Size="XX-Large" Text="A" 
                Font-Bold="True" ForeColor="#FF66FF"></asp:Label>
            <asp:Label ID="Label20" runat="server" Font-Size="XX-Large" Text="D" 
                Font-Bold="True" ForeColor="#CC00FF"></asp:Label>
            <asp:Label ID="Label21" runat="server" Font-Size="XX-Large" Text="D" 
                Font-Bold="True" ForeColor="#FF6699"></asp:Label>
            <asp:Label ID="Label22" runat="server" Font-Size="XX-Large" Text="Y" 
                Font-Bold="True" ForeColor="#660066"></asp:Label>
        </asp:Panel></marquee>
    
           
           
       
    
    </div>
  
        
            <center><asp:Image ID="Image2" runat="server" Height="135px" 
            ImageUrl="~/data_encryption.gif" Width="584px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="Large" OnClick="LinkButton1_Click">LogOut</asp:LinkButton>
        </center>
    <p style="margin-left: 480px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label0" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="Logged In As: "></asp:Label>
        <asp:Label ID="lbluname" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red"></asp:Label>
    </p>
        <p>
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" 
            Text="Our Website Helps You To Encrypt Your Images Into a Secret Text and Provide You The Secret Key, So you Can Send That Details To Someone Whom You Want To Send That Image. So They Can Generate(Decrypt) That Image Again Through Following Text and Key."></asp:Label>
    </p>
       
    &nbsp;&nbsp;<table style="width:100%;">
        <tr>
            <td align="center" class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" 
            Text="Click Below For Encryption"></asp:Label>
                </td>
            <td align="center" class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Font-Size="XX-Large" 
            Text="Click Below For Decryption"></asp:Label>
        
            </td>
        </tr>
        <tr>
            <td align="center" class="style1">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton1" runat="server" Height="225px" 
            ImageUrl="~/tumblr_ondsmc2DYX1qaw6pxo1_1280.gif" onclick="ImageButton1_Click" 
            Width="274px" />
           
            </td>
            <td align="center" class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="ImageButton2" runat="server" Height="286px" 
            ImageUrl="~/giphy.gif" onclick="ImageButton2_Click" Width="319px" />
            </td>
        </tr>
    </table>
&nbsp;<center> <asp:Label ID="Label5" runat="server" 
        Text="© 2019  Encryption Daddy | Designed and Developed by Tanveer Ali" 
            Font-Bold="True" Font-Overline="False" Font-Strikeout="False" 
            Font-Underline="True"></asp:Label></center>
</form>
</body></html>