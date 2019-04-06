<%@ Page Language="C#" AutoEventWireup="true" CodeFile="clientform.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vehicle Insurance</title>
      <link rel="stylesheet" href="http://code.jquery.com/ui/1.11.0/themes/smoothness/jquery-ui.css"/>
    <script src="http://code.jquery.com/jquery-1.10.2.js"></script>
    <script src="http://code.jquery.com/ui/1.11.0/jquery-ui.js"></script>
    <script type="text/javascript" language="javascript">
        $(function () {
            $("#<%=txtpolicydate.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "mm-dd-yy",
                yearRange: '1950:2050'
            });

            $("#<%=txtfirdate.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "mm-dd-yy",
                yearRange: '1950:2050'
            });

            $("#<%=txtincidentdate.ClientID %>").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: "mm-dd-yy",
                yearRange: '1950:2050'
            });

            $("#<%=txtclaimdate.ClientID %>").datepicker({
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
    
        <center><asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Insurance Claim Form"></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
            <br />
            <br />
            <asp:Label ID="Label34" runat="server" Text="Logged In As: "></asp:Label>
            <asp:Label ID="lbluname" runat="server"></asp:Label>
        </center>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="1. Client Detail"></asp:Label>
        <br />
        <br />
    
        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtname" runat="server" Width="231px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Policy No."></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtpolicyno" runat="server" TabIndex="1" Width="156px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Policy Expiry Date"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="txtpolicydate" runat="server" Width="138px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label25" runat="server" ForeColor="#3333FF" Text="MM-DD-YYYY"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtaddress" runat="server" Height="94px" TextMode="MultiLine" Width="250px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="City"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcity" runat="server" Width="192px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Pin Code"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpincode" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Mobile No."></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtmbno" runat="server" Width="184px"></asp:TextBox>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="2. Vehicle Detail"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Company Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcomname" runat="server" Width="246px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label14" runat="server" Text="Model No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtmodel" runat="server" Width="245px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label15" runat="server" Text="Serial No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtserial" runat="server" Width="188px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Year Of Purchase"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtyearofpur" runat="server" Width="90px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label26" runat="server" ForeColor="#3333FF" Text="YYYY"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label17" runat="server" Text="Purchase From"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpurfrom" runat="server" Width="248px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label18" runat="server" Text="Purchase Bill No."></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtbillno" runat="server" Width="161px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="3. Incident Detail"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Date Of Incident"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtincidentdate" runat="server" Width="168px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label27" runat="server" ForeColor="#3333FF" Text="MM-DD-YYYY"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label20" runat="server" Text="Incident Address"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtincidentaddress" runat="server" Height="100px" TextMode="MultiLine" Width="323px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label21" runat="server" Text="Incident Info"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtincidentinfo" runat="server" Height="91px" TextMode="MultiLine" Width="324px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label22" runat="server" Text="Date Of F.I.R"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtfirdate" runat="server" Width="157px"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label28" runat="server" ForeColor="#3333FF" Text="MM-DD-YYYY"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label23" runat="server" Text="Name Of Police Station"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtpolicysta" runat="server" Width="260px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label24" runat="server" Text="F.I.R/Crime Diary No."></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtfirno" runat="server" Width="139px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="True" Text="4. Claim Detail"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label29" runat="server" Text="Claim Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclaimdate" runat="server"></asp:TextBox>
        &nbsp;
        <asp:Label ID="Label33" runat="server" ForeColor="#3333FF" Text="MM-DD-YYYY"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label30" runat="server" Text="Claim By"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclaimby" runat="server" Width="176px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label31" runat="server" Text="Claim Bill No."></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtclaimbillno" runat="server" Width="164px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label32" runat="server" Text="Claim Amount"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox12" runat="server" BorderColor="White" BorderStyle="None" Enabled="False" Font-Bold="True" Width="16px">₹</asp:TextBox>
        <asp:TextBox ID="txtclaimamount" runat="server" Width="154px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"  Width="80px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;
       
       
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" OnClientClick="aska()" Text="Clear" />
        <br />
    
    </div>
    </form>
</body>
</html>
