<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson5.aspx.cs" Inherits="JavaScript_Part1.Lesson5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 5: Sub String</title>
    <script>
        var str = "Javascript Tutorials";
        alert("Original String: " + str);
        // substring() method has start (mandatory) and end (optional) parameters
        alert("Substring from 5: " + str.substring(5));
        // end parameter is optional, if not supplied, it will take everything from start
        alert("Substring from 0 to 10: " + str.substring(0, 10));
        alert("Substring from 10 to 0: " + str.substring(10, 0));
        //this method will reverse the start end index point if end<start
        //the substring will not include the end charater in result.

        //substr() method has start (mandatory) and lenght or count (optional) parameters
        alert("Substring from 5: " + str.substr(5));
        // end parameter is optional, if not supplied, it will take everything from start
        alert("Substring from 0 to 10: " + str.substr(0, 10));
        alert("Substring from 10 to 0: " + str.substr(10, 0));
        //this method will return an empty string if the count is zero or negative

        //Slice() - it is similar to substring() but it will not swap the parameters when end value is smaller than start value.
        alert("Slicing from 0 to 10: " + str.substr(0, 10));
        alert("Slicing from 10 to 0: " + str.substr(10, 0)); //return empty string

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    
</body>
</html>
