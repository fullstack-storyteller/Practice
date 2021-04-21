<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson9.aspx.cs" Inherits="JavaScript_Part1.Lesson9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 9 - For Loops</title>
    <script type="text/javascript">
        var input = Number(prompt("Enter Number: ", ""));
        document.clear();
        for (var i = 0; i <= input; i += 1) {
            if(i%2==0)
                document.write(i + "<br/>");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
