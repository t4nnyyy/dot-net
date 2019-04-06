<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insuranceclaim.aspx.cs" Inherits="insuranceclaim" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insurance Claim</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <center><asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Life Insurance Claim Form"></asp:Label></center>
    
    </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/insuranceregister.aspx">Insurance Register</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
        </p>
        <div>
        <asp:Label ID="Label14" runat="server" Text="Policy No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpolicyno" runat="server" Width="184px"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="Label15" runat="server" Text="Name Of Deceased"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtdeceasedname" runat="server" Width="184px"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="Label17" runat="server" Text="Nominee Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineename" runat="server" Width="184px"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="Label16" runat="server" Text="Death Certificate"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="uplddeathcertificate" runat="server" />
            <br />
            <br />
        <asp:Label ID="Label18" runat="server" Text="Nominee Bank Passbook"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="upldpassbook" runat="server" />
            <br />
            <br />
        <asp:Label ID="Label19" runat="server" Text="Nominee Aadhaar Card"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="upldaadhaar" runat="server" />
            <br />
            <br />
        <asp:Label ID="Label20" runat="server" Text="Nominee PAN Card"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:FileUpload ID="upldpan" runat="server" />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Claim" Width="100px" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
