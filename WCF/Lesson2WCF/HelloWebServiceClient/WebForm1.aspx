<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWebServiceClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td>
                    <asp:Button ID="Button1" runat="server" Text="Get Message" OnClick="Button1_Click" /></td></tr>
            <tr><td colspan="2">
                <asp:Label ID="Label1" runat="server" ></asp:Label>
                </td></tr>
        </table>
    </form>
</body>
</html>
