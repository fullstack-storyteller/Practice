<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>First Number: </td>
                    <td>
                        <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>Second Number: </td>
                    <td>
                        <asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Result: </td>
                    <td>
                        <asp:Label ID="lblResult" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnCalculate" Text="Calculate Result" runat="server" OnClick="btnCalculate_Click"/></td>
                </tr>
            </table>
        </div>

        <div>
            <table>
                <tr>
                    <td>First Number: </td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td>Second Number: </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Third Number: </td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Result: </td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnAdd3Number" Text="Calculate Result" runat="server" OnClick="btnAdd3Number_Click"/></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
