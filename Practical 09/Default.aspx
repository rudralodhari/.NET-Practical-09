
<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="Practical_09.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Placement Dashboard</title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Placement Dashboard</h1>

        <h3>Placement Summary</h3>

        <table border="1" cellpadding="10">
            <tr>
                <th>Total Students</th>
                <td><asp:Label ID="lblTotal" runat="server" /></td>
            </tr>
            <tr>
                <th>Placed Students</th>
                <td><asp:Label ID="lblPlaced" runat="server" /></td>
            </tr>
            <tr>
                <th>Not Placed Students</th>
                <td><asp:Label ID="lblNotPlaced" runat="server" /></td>
            </tr>
            <tr>
                <th>Placement Percentage</th>
                <td><asp:Label ID="lblPercentage" runat="server" /></td>
            </tr>
            <tr>
                <th>Maximum LPA</th>
                <td><asp:Label ID="lblMaxLPA" runat="server" /></td>
            </tr>
        </table>

        <h3>All Student Details</h3>

        <asp:GridView ID="GridView1" runat="server"
            AutoGenerateColumns="true">
        </asp:GridView>

        <br />

        <asp:HyperLink ID="HyperLink1" runat="server"
            NavigateUrl="Company.aspx"
            Text="View Company Details" />

    </form>
</body>
</html>
