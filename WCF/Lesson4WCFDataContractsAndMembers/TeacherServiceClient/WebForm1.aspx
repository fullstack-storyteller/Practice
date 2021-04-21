<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TeacherServiceClient.WebForm1" %>

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
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="txtID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Qualification</td>
                    <td>
                        <asp:TextBox ID="txtQual" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Gender</td>
                    <td>
                        <asp:DropDownList ID="ddlGender" runat="server">
                            <asp:ListItem Text="Select Gender" Value ="-1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Male" Value ="1" ></asp:ListItem>
                            <asp:ListItem Text="Female" Value ="2"></asp:ListItem>
                            <asp:ListItem Text="Other" Value ="3"></asp:ListItem>

                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Employee Type</td>
                    <td>
                        <asp:DropDownList ID="ddlEmpType" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEmpType_SelectedIndexChanged">
                            <asp:ListItem Text="Select Employee Type" Value ="-1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Full Time Employee" Value ="1" ></asp:ListItem>
                            <asp:ListItem Text="Part Time Employee" Value ="2"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                <tr id="trannualsal" runat="server">
                    <td>Annual Salary</td>
                    <td>
                        <asp:TextBox ID="txtAnnualSal" runat="server"></asp:TextBox></td>
                </tr>
                <tr id="trhpay" runat="server">
                    <td>Hourly Pay</td>
                    <td>
                        <asp:TextBox ID="txtHourlyPay" runat="server"></asp:TextBox></td>
                </tr>
                <tr id="trhw" runat="server">
                    <td>Hours Worked</td>
                    <td>
                        <asp:TextBox ID="txtHoursWorked" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Department</td>
                    <td>
                        <asp:DropDownList ID="ddlDepartment" runat="server">
                            <%--<asp:ListItem Selected="True" Text="Select Department" Value="-1"></asp:ListItem>--%>
                        </asp:DropDownList>    
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnFetchTeacher" runat="server" Text="Get Teacher" OnClick="btnFetchTeacher_Click" /></td>
                    <td>
                        <asp:Button ID="btnInsertTeacher" runat="server" Text="Insert Teacher" OnClick="btnInsertTeacher_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Label ID="LblMessage" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
