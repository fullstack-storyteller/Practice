<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    First Number:
                </td>
                <td>
                    <asp:TextBox ID="txtFirstNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Second Number:
                </td>
                <td>
                    <asp:TextBox ID="txtSecondNum" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Result:
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnAdd" runat="server" Text="Click to Add" OnClick="btnAdd_Click" />
                </td>
            </tr>
        </table>
        <hr />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>

    </form>
</body>
</html>
