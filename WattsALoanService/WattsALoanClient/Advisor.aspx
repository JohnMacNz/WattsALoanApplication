<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Advisor.aspx.vb" Inherits="Advisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 520px;
        }
        .newStyle1 {
            float: left;
            border: solid 1px;
            margin: 20px;
            padding: 20px;
        }
        .newStyle3 {
            float: left;
            margin: 20px;
            padding: 20px;
        }
        .newStyle2 {
            clear: left;
        }
    </style>
</head>
<body style="height: 517px">
    <form id="form1" runat="server">
    <div>
    
        <h1>Financial Advisor</h1>




        <div class="newStyle1" style="width: 160px; height: 360px; top: 9px; left: 512px;">
            <asp:Button ID="btnModCust" runat="server" Text="Modify Customer" Width="120px" />
            <br /><br />
            <asp:Label ID="Label29" runat="server" Text="User ID"></asp:Label>
            <br />
            <asp:TextBox ID="txbUserID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label30" runat="server" Text="Date Created"></asp:Label>
            <br />
            <asp:TextBox ID="txbDateCreatedMod" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label31" runat="server" Text="Full Name"></asp:Label>
            <br />
            <asp:TextBox ID="txbFullNameMod" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label32" runat="server" Text="Billing Address"></asp:Label>
            <br />
            <asp:TextBox ID="txbAddressMod" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label33" runat="server" Text="Billing City"></asp:Label>
            <br />
            <asp:TextBox ID="txbCityMod" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label34" runat="server" Text="Billing State"></asp:Label>
            <br />
            <asp:TextBox ID="txbStateMod" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label35" runat="server" Text="Billing ZIP Code"></asp:Label>
            <br />
            <asp:TextBox ID="txbZIPMod" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Email Address"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmailMod" runat="server"></asp:TextBox>
            <br />

        </div>
    


        <div class="newStyle1" style="width: 160px; height: 360px; top: 6px; left: -240px;">
            <asp:Button ID="btnAlloLoan" runat="server" Text="Allocate Loan" Width="120px" />
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" Text="Date Prepared"></asp:Label>
            <br />
            <asp:TextBox ID="txbDatePrepared" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label16" runat="server" Text="Employee ID"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmpIDAlo" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label17" runat="server" Text="Customer ID"></asp:Label>
            <br />
            <asp:TextBox ID="txbCustID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label18" runat="server" Text="Account Number"></asp:Label>
            <br />
            <asp:TextBox ID="txbAccNum" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label19" runat="server" Text="Loan Type ID"></asp:Label>
            <br />
            <asp:TextBox ID="txbLoanTypeID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label20" runat="server" Text="Loan Amount"></asp:Label>
            <br />
            <asp:TextBox ID="txbLoanAmount" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label21" runat="server" Text="Periods"></asp:Label>
            <br />
            <asp:TextBox ID="txbPeriods" runat="server"></asp:TextBox>
            <br />
        </div>
    
    </div>

        <div class="newStyle1" style="width: 160px; height: 360px;">
            <asp:Button ID="btnRecPmt" runat="server" Text="Record Payment" Width="120px" />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="Payment Date"></asp:Label>
            <br />
            <asp:TextBox ID="txbPaymentDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Employee ID"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmpIDRec" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Loan Allocation ID"></asp:Label>
            <br />
            <asp:TextBox ID="txbLoanAloID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label11" runat="server" Text="Payment Amount"></asp:Label>
            <br />
            <asp:TextBox ID="txbPmtAmt" runat="server"></asp:TextBox>
            <br />
        </div>


         <div class="newStyle1" style="width: 160px; height: 360px; top: 7px; left: -248px;">
            <asp:Button ID="btnCreateCust" runat="server" Text="Create Customer" Width="120px" />
            <br />
            <br />
            <asp:Label ID="Label22" runat="server" Text="Date Created"></asp:Label>
            <br />
            <asp:TextBox ID="txbDateCreated" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label23" runat="server" Text="Full Name"></asp:Label>
            <br />
            <asp:TextBox ID="txbFullName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label24" runat="server" Text="Billing Address"></asp:Label>
            <br />
            <asp:TextBox ID="txbAddress" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label25" runat="server" Text="Billing City"></asp:Label>
            <br />
            <asp:TextBox ID="txbCity" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label26" runat="server" Text="Billing State"></asp:Label>
            <br />
            <asp:TextBox ID="txbState" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label27" runat="server" Text="Biling Zip Code"></asp:Label>
            <br />
            <asp:TextBox ID="txbZIP" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label28" runat="server" Text="Email Address"></asp:Label>
            <br />
            <asp:TextBox ID="txbEmail" runat="server"></asp:TextBox>
            <br />


        </div>   
       <div class="newStyle3" style="width: 160px; height: 100px;">
            <asp:Label ID="Label36" runat="server" Text="Result"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox36" runat="server" Enabled="False"></asp:TextBox>
        </div>
                <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="newStyle2">
        </asp:TreeView>
    </form>
</body>
</html>
