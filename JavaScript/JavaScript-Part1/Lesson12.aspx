<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson12.aspx.cs" Inherits="JavaScript_Part1.Lesson12" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 12 - Array Filter

    </title>
    <script type="text/javascript">
        var myArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

        //lets define first a callback method which will run on each element of the array

        //a callback function contains three parameters
        function isEven(value, index, array ) {
            if (value % 2 == 0)
                return true;
            else
                return false;

            //return value % 2 == 0;
        }
        document.write(myArray, "<br/>");
        var arr = myArray.filter(isEven); //this filter method creates a new array.
        document.write(arr, "<br/>");

        //another way is to use the annonyms=ous function

        document.write(myArray, "<br/>");
        var arr = myArray.filter(function (value, index, array) { return value % 2 == 0; });
        document.write(arr, "<br/>");

        document.write("<br/>");


        var array = ["Sam", "Manish", "Archana", "Akila", "Jasbir", "Medha", "Sam", "Jasbir"];
        document.write(array, "<br/>");
        var unique_array = array.filter(function (value, index, aarray) { return array.indexOf(value) == index; });
        document.write(unique_array, "<br/>");

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
