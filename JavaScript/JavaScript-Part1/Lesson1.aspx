<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson1.aspx.cs" Inherits="JavaScript_Part1.Lesson1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson - 1</title>
    <script>
        alert("Welcome to javascript from head");
    </script>
</head>
<body>

    <script>
        //Alert("Welcome to javascript from body");
        //javascript is case sensitive.
        alert("Welcome to javascript from body");
        var message = 10;
        alert("variale value is " + message.toString());
        message = "Manish";
        alert("variale value is " + message.toString());

    </script>


    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
</body>
</html>
