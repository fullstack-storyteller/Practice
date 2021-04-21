<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson11.aspx.cs" Inherits="JavaScript_Part1.Lesson11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 11 - More on array</title>
    <script type="text/javascript">

        //sorting an array in Javascript
        var arr = ["Ram", "Laxmi", "Shyam", "Kasturi"];
        document.write(arr, "<br/>");
        arr.sort(); //by default sort will treat all the elements as strings
        document.write(arr, "<br/>");
        document.write( "<br/>");
        arr = [23, 34, 1, 23, 10, 2, 67, 53];
        document.write(arr, "<br/>");
        arr.sort(function (a, b) {
            return a - b;
        })
        document.write(arr, "<br/>");

        //lets reverse it.
        arr.sort(function (a, b) {
            return b - a;
        })
        document.write("reversed using function parameter: ", arr, "<br/>");

        arr.sort().reverse();
        document.write("reversed using reverse method: ", arr, "<br/>");

        //splice method in Javascript.
        //it is used for adding or removing elements
        document.write(arr, "<br/>");
        arr.splice(2, 0, 85, 91, 65); //arr.splice( start index, count i.e. number of items to be deleted, optional parameter for the new items to be added to the array)
        document.write(arr, "<br/>");

        arr.splice(2, 3 );
        document.write(arr, "<br/>");
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
