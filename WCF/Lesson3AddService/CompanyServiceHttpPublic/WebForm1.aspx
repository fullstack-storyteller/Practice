<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CompanyServiceHttpPublic.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Company Public Info: <asp:Label ID="Label1" runat="server" ></asp:Label>
            <hr />
            <asp:Button ID="Button1" runat="server" Text="Get Public Info" OnClick="Button1_Click" />
            <hr />
            Company Private Info: <asp:Label ID="Label2" runat="server" ></asp:Label>
            <hr />
            <asp:Button ID="Button2" runat="server" Text="Get Private Info" OnClick="Button2_Click" />
            <hr />
        </div>
    </form>
</body>
</html>
