<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceWithAjax.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmployeeWithAjax</title>
    <script type="text/javascript">
        function ValidateInput() {
            if (isNaN(document.getElementById('txtID').value) ) {
                alert('Invalid Input. Please supply a number in ID Field.');
                return;
            }
            if (document.getElementById('txtID').value == '') {
                alert('ID can not be blank.');
                return;
            }
            var id = parseInt(document.getElementById('txtID').value);
            WebServiceWithAjax.EmployeeService.GetEmployeeByID(id, CallBackFunctionForSuccess, CallbackFunctionForFailure);
        }

        function CallBackFunctionForSuccess(Results) {
            if (Boolean( Results["SuccessFlag"]))
                document.getElementById('LblMessage').innerText = 'Employee Retrieved!';
            else {
                document.getElementById('LblMessage').innerText = 'Employee is not present!';
                document.getElementById('txtName').value = '';
                document.getElementById('txtSalary').value = '';
                document.getElementById('txtAddress').value = '';

                return;
            }
            document.getElementById('txtID').value = Results["Id"];
            document.getElementById('txtName').value = Results["Name"];
            document.getElementById('txtSalary').value = Results["Salary"];
            document.getElementById('txtAddress').value = Results["Address"];
        }

        function CallbackFunctionForFailure(Errors) {
            document.getElementById('LblMessage').innerText = 'Employee not present!';
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/EmployeeService.asmx" />
            </Services>
        </asp:ScriptManager>
        <div>
            <table>
                <tr>
                    <td>ID: </td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                    <td>
                        <input id="btnGetEmp" type="button" value="Get Employee" onclick="ValidateInput()"/></td>
                </tr>
                <tr>
                    <td>Name: </td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td>Salary:</td>
                    <td>
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <asp:Label ID="LblMessage" runat="server"></asp:Label>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
