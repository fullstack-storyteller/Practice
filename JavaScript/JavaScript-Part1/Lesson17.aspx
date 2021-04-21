<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson17.aspx.cs" Inherits="JavaScript_Part1.Lesson17" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson - 17 Arguments in JS</title>
    <script type="text/javascript">
        //Arguments are special objects that are present only inside methods.
        //They hold all the parameters value that has been supplied to the function during its call
        //Thus, we can supply variable number of parameters to a method.

        //Note:
        //Although, we can index the arguments objects acts as an arrays, but it is not an array.
        //it does not have any array properties except length.
        //sortParameters is an example where we are converting the arguments object into an array.


        function printArguments() {
            document.write("Total arguments passed: " + arguments.length, "<br/>");

            //lets loop through each one of them
            for (var i = 0; i < arguments.length; i++) {
                document.write("Argument " + i + ": " + arguments[i], "<br/>");
            }
            document.write("<br/>")
        }

        printArguments();
        printArguments('a', 'b');
        printArguments(1, 3, 4);
        printArguments(2, 'a', 7, 'tyere');
        document.write("<br/>")

        function Add() //no argument supplied, but check out how we will do multiple additon
        {
            var sum = 0;
            document.write("Count of parameters received: " + arguments.length, "<br/>");
            for (var i = 0; i < arguments.length; i++) {
                document.write("value of parameter: " + i + "-> " + arguments[i], "<br/>");
                sum += arguments[i];
            }
            document.write("Sum of parameters received: " + sum, "<br/>");
            document.write("<br/>")
        }

        Add();
        Add(10, 40, 50);
        Add('a', 23, 45, 'b', 'p');

        function sortParameters() {
            var arrayOfArguments = Array.prototype.slice.call(arguments);
            arrayOfArguments.sort(function (x, y) { return x - y; }); //works everywhere.
            //var func = (x, y) => { return x - y; };//it seems IE11 doesn't support arrow operator.
            //arrayOfArguments.sort(func);//but it works in Chrome.
            document.write(arrayOfArguments, "<br/>");
        }
        sortParameters(1, 12, 23, 10, 2);

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
