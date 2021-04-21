<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson3.aspx.cs" Inherits="JavaScript_Part1.Lesson3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sample Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <table>
             <tr>
                 <td>First Number: </td>
                 <td>
                     <input id="txtFirstNum" type="text" onfocus="HighlightText(this.id, 'white')"/></td>
             </tr>
             <tr>
                 <td>Second Number: </td>
                 <td>
                     <input id="txtSecondNum" type="text" onfocus="HighlightText(this.id, 'white')"/></td>
             </tr>
             <tr>
                 <td>Result: </td>
                 <td>
                     <input id="txtResult" type="text" /></td>
             </tr>
             <tr>
                 <td>
                     <input id="btnAdd" type="button" value="Add" onclick="Calculate(this.id)"/></td>
                 <td>
                     <input id="btnSubtract" type="button" value="Subtract" onclick="Calculate(this.id)" /></td>
             </tr>
             <tr>
                 <td colspan ="2" >
                     <input id="btnReset" type="button" value="Reset" onclick="Calculate(this.id)" /></td>
             </tr>
         </table>
        </div>
    </form>
    <script>
        function Calculate(id) {
            //alert("this is test cominig from : " + id);
            var precision = 3;
            var FirstNumber = document.getElementById("txtFirstNum").value;
            var SecondNumber = document.getElementById("txtSecondNum").value;
            if (id == "btnReset") {
                document.getElementById("txtResult").value = "";
                document.getElementById("txtFirstNum").value = "";
                document.getElementById("txtSecondNum").value = "";
                HighlightText("txtResult", "white");
                HighlightText("txtFirstNum", "white");
                HighlightText("txtSecondNum", "white");
                return;
            }

            if (FirstNumber == "") {
                HighlightText("txtFirstNum", "red");
                alert("First Number is required.");
                return;
            }
            FirstNumber = parseFloat(FirstNumber);
            if (isNaN(FirstNumber)) {
                HighlightText("txtFirstNum", "red");
                alert("First Number is not valid.");
                return;
            }


            if (SecondNumber == "") {
                HighlightText("txtSecondNum", "red");
                alert("Second Number is required.");
                return;
            }
            SecondNumber = parseFloat(SecondNumber);
            
            if (isNaN(SecondNumber)) {
                HighlightText("txtSecondNum", "red");
                alert("Second Number is not valid.");
                return;
            }

            if (id == "btnAdd") {
                document.getElementById("txtResult").value = Rounding((FirstNumber + SecondNumber), precision);
                HighlightText("txtResult", "green");
               
                HighlightText("txtFirstNum", "white");
                HighlightText("txtSecondNum", "white");
                return;
            }
            if (id == "btnSubtract") {
                document.getElementById("txtResult").value = Rounding((FirstNumber - SecondNumber), precision);
                HighlightText("txtResult", "green");
               
                HighlightText("txtFirstNum", "white");
                HighlightText("txtSecondNum", "white");
                return;
            }
            

        }

        function Rounding(value, precision) //since JS doesn't provide a proper method
        {
            var multiplier = Math.pow(10, precision || 0);
            return Math.round(value * multiplier) / multiplier;

        }

        function HighlightText(id, color) {
            document.getElementById(id).style.backgroundColor = color;
        }
    </script>
</body>
</html>
