<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Users.aspx.vb" Inherits="Users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Users</h1>
        <form id="form1" runat="server">
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
            <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" CssClass="newStyle3">
            </asp:TreeView>
        </form>
</body>
</html>
