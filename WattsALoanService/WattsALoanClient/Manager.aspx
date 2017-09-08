<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Manager.aspx.vb" Inherits="Manager" %>

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
    
            <h1>Manager</h1>

            <div class="newStyle1" style="width: 160px; height: 300px; top: 9px; left: 512px;">
                <asp:Button ID="btnDeleteEmp" runat="server" Text="Delete Employee" Width="120px" />
                <br />
                <asp:Label ID="Label29" runat="server" Text="User ID"></asp:Label>
                <br />
                <asp:TextBox ID="txbUserID" runat="server"></asp:TextBox>
            </div>

            <div class="newStyle1" style="width: 160px; height: 300px; top: 6px; left: -240px;">
                <asp:Button ID="btnCreateEmp" runat="server" Text="Create Employee" Width="120px" />
                <br />
                <asp:Label ID="Label15" runat="server" Text="Employee Number"></asp:Label>
                <br />
                <asp:TextBox ID="txbEmpNum" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label16" runat="server" Text="First name"></asp:Label>
                <br />
                <asp:TextBox ID="txbFName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label17" runat="server" Text="Last Name"></asp:Label>
                <br />
                <asp:TextBox ID="txbLName" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label18" runat="server" Text="Title"></asp:Label>
                <br />
                <asp:TextBox ID="txbTitle" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label19" runat="server" Text="Salary"></asp:Label>
                <br />
                <asp:TextBox ID="txbSalary" runat="server"></asp:TextBox>
                <br />
            </div>
    
        </div>

            <div class="newStyle1" style="width: 160px; height: 300px;">
                <asp:Button ID="btnCreateLoan" runat="server" Text="Create Loan" Width="120px" />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Loan Type"></asp:Label>
                <br />
                <asp:TextBox ID="txbLoanType" runat="server"></asp:TextBox>
            </div>


             <div class="newStyle1" style="width: 160px; height: 300px; top: 7px; left: -248px;">
                <asp:Button ID="btnModifyEmp" runat="server" Text="Modify Employee" Width="120px" />
                <br />
                <asp:Label ID="Label22" runat="server" Text="Employee ID"></asp:Label>
                <br />
                <asp:TextBox ID="txbEmpID" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label23" runat="server" Text="Employee Number (Modify)"></asp:Label>
                <br />
                <asp:TextBox ID="txbEmpNumMod" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label24" runat="server" Text="First Name (Modify)"></asp:Label>
                <br />
                <asp:TextBox ID="txbFNameMod" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label25" runat="server" Text="Last Name (Modify)"></asp:Label>
                <br />
                <asp:TextBox ID="txbLNameMod" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label26" runat="server" Text="Title (Modify)"></asp:Label>
                <br />
                <asp:TextBox ID="txbTitleMod" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label27" runat="server" Text="Salary (Modify)"></asp:Label>
                <br />
                <asp:TextBox ID="txbSalaryMod" runat="server"></asp:TextBox>
                <br />
            </div>   
           <div class="newStyle3" style="width: 160px; height: 150px;">
                <asp:Label ID="Label36" runat="server" Text="Response"></asp:Label>
                <br />
                <asp:TextBox ID="txbResponse" runat="server" Enabled="False"></asp:TextBox>
            </div>
                    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="newStyle2">
            </asp:TreeView>
        </form>
    </body>
    </html>