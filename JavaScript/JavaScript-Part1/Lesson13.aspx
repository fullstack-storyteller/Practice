<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson13.aspx.cs" Inherits="JavaScript_Part1.Lesson13" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 13 - 2D Arrays</title>
    <script type ="text/javascript">
        
        var rows = Number(prompt("Please enter the number of rows: ", ""));
        var cols = Number(prompt("Please enter the number of cols: ", ""));
        var flag = prompt("Please enter the increment flag", "j");
        var filler = 1;
        function displayArray(array) {
            document.write("<br/>");
            for (var i = 0; i < rows; i++) {
                for (var j = 0; j < cols; j++) {
                    document.write(array[i][j],"&emsp;");
                }
                document.write("<br/>");
            }
            document.write("<br/>");
        }

        function fillArray(array, filler, flag) {
            for (var i = 0; i < rows; i++) {
                for (var j = 0; j < cols; j++) {
                    array[i][j] = filler;
                    filler= filler + (flag == 'i'? 1: -1 );
                }
            }
            return filler;
        }

        function addArrays(a, a1, a2) {
            
            for (var i = 0; i < rows; i++) {
                for (var j = 0; j < cols; j++) {
                    a[i][j] = a1[i][j] + a2[i][j];
                }
                
            }
            
        }

        //get your 2D array of "rows" rows and "cols" columns
        var array1 = new Array(rows);
        for (var i = 0; i < rows; i++) {
            array1[i] = new Array(cols);
        }
        filler = fillArray(array1, filler, flag)-1;
        displayArray(array1);

        
        document.write("+", "<br/>");

        //2nd 2D array
        var array2 = new Array(rows);
        for (var i = 0; i < rows; i++) {
            array2[i] = new Array(cols);
        }
        flag = prompt("Please enter the increment flag", "j");
        filler = fillArray(array2, filler, flag);
        displayArray(array2);

        
        document.write("=", "<br/>");

        var array3 = new Array(rows);
        for (var i = 0; i < rows; i++) {
            array3[i] = new Array(cols);
        }
        addArrays(array3, array1, array2);
        displayArray(array3);

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
