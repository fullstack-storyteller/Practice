<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lesson7.aspx.cs" Inherits="JavaScript_Part1.lesson7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 7 - Ternary operator</title>
    <script type="text/javascript">
        var userInput = Number(prompt("Please enter a number", ""));
        var message = userInput + (userInput % 2 == 0 ? " is even" : " is odd");
        alert(message);

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
