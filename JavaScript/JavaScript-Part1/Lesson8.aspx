<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson8.aspx.cs" Inherits="JavaScript_Part1.Lesson8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 8 - Loops</title>
    <script type="text/javascript">
        function WhileLoop() {
            //while loop
            var start = Number(prompt("Please enter a starting number: ", ""));
            var end = Number(prompt("Please enter an ending number: ", ""));

            while (start <= end) {

                document.write(start + "<br/>");
                start += 1;
            }
        }

        // do while loop
        var userInput = "";
        do {
            document.clear();
            WhileLoop();
            
            do {
                userInput = prompt("Would you like to continue?", "").toUpperCase();
                if (userInput != "YES" && userInput != "NO")
                    alert("Please only enter Yes or No. Invalid input");
            } while (userInput != "YES" && userInput != "NO");
        } while (userInput == "YES");
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
