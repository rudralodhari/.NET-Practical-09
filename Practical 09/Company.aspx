
<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Company.aspx.cs"
    Inherits="Practical_09.Company" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Company Details</title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Company Details</h1>

        <h3>Placements Table</h3>

        <asp:Repeater ID="rptCompanyTable" runat="server">
            <HeaderTemplate>
                <table border="1" cellpadding="10">
                    <tr>
                        <th>Placement ID</th>
                        <th>Student ID</th>
                        <th>Company Name</th>
                        <th>Package (LPA)</th>
                    </tr>
            </HeaderTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("PlacementId") %></td>
                    <td><%# Eval("StudentId") %></td>
                    <td><%# Eval("CompanyName") %></td>
                    <td><%# Eval("PackageLPA") %></td>
                </tr>
            </ItemTemplate>

            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>

        <h3>Placement Details</h3>

        <asp:Repeater ID="rptCompanyDetails" runat="server">
            <ItemTemplate>
                Placement ID:
                <%# Eval("PlacementId") %>
                <br />

                Student ID:
                <%# Eval("StudentId") %>
                <br />

                Company Name:
                <%# Eval("CompanyName") %>
                <br />

                Package:
                <%# Eval("PackageLPA") %> LPA

                <hr />
            </ItemTemplate>
        </asp:Repeater>

        <br />

        <asp:HyperLink ID="lnkDashboard" runat="server"
            NavigateUrl="Default.aspx"
            Text="Back to Dashboard" />

    </form>
</body>
</html>
