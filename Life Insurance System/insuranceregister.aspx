<%@ Page Language="C#" AutoEventWireup="true" CodeFile="insuranceregister.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insurance Registration</title>
      <link rel="stylesheet" href="http://code.jquery.com/ui/1.11.0/themes/smoothness/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.10.2.js"></script>
    <script src="http://code.jquery.com/ui/1.11.0/jquery-ui.js"></script>
    <script type="text/javascript" language="javascript">
        $(function () {
            $("#<%=txtclntdob.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "mm-dd-yy",
                yearRange: '1950:2050'
            });

          

            $("#<%=txtnomineedob.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "mm-dd-yy",
                yearRange: '1950:2050'
            });

    

        });
        function aska() {
            alert('Data Saved Successfully'); var ask = window.confirm('Do You Want To Print Document?'); if (ask) { javascript: window.print(); }
                        }
            </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <center><asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Life Insurance Registration Form"></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
            <br />
            &nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label34" runat="server" Text="Logged In As: "></asp:Label>
            <asp:Label ID="lbluname" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/insuranceclaim.aspx">Insurance Claim</asp:LinkButton>
        </center>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="Client Details"></asp:Label>
        <br />
        <br />
    
        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclntname" runat="server" Width="231px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Mobile No."></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclntmob" runat="server" TabIndex="1" Width="156px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Date Of Birth"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclntdob" runat="server" Width="138px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label25" runat="server" ForeColor="#3333FF" Text="MM-DD-YYYY"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclntadd" runat="server" Height="94px" TextMode="MultiLine" Width="250px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclntcity" runat="server" Width="192px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Pin Code"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclntpincode" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="Policy Details"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Plan Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="drpplanname" runat="server">
            <asp:ListItem>HDFC Life Click2Protect Plus</asp:ListItem>
            <asp:ListItem>PNB MetLife Mera Term Plan</asp:ListItem>
            <asp:ListItem>Aegon Life iTerm Plan	</asp:ListItem>
            <asp:ListItem>LIC New Jeevan Anand	</asp:ListItem>
            <asp:ListItem>SBI Life Shubh Nivesh	</asp:ListItem>
            <asp:ListItem>SBI Life Saral Pension	</asp:ListItem>
            <asp:ListItem>LIC New Jeevan Nidhi	</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Policy No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpolicyno" runat="server" Width="184px"></asp:TextBox>
        &nbsp;
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Registration Year"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpolicyregisterationyear" runat="server" Width="90px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label26" runat="server" ForeColor="#3333FF" Text="YYYY"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Text="Opening Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpolicyamount" runat="server" Width="173px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="Nomination Details"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label35" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineename" runat="server" Width="214px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Date Of Birth"></asp:Label>
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineedob" runat="server" Width="210px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label27" runat="server" ForeColor="#3333FF" Text="MM-DD-YYYY"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" Text="Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineeaddress" runat="server" Height="100px" TextMode="MultiLine" Width="323px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label21" runat="server" Text="Bank Account No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineebankaccount" runat="server" Height="24px" Width="324px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label37" runat="server" Text="Bank Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineebankname" runat="server" Height="24px" Width="324px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label36" runat="server" Text="IFSC Code"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtnomineeifsc" runat="server" Height="24px" Width="324px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  Width="80px" style="height: 26px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
       
       
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" OnClientClick="aska()" Text="Clear" />
        <br />
    
    </div>
    </form>
</body>
</html>
