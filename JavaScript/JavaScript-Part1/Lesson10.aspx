<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson10.aspx.cs" Inherits="JavaScript_Part1.Lesson10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 10 - Arrays</title>
    <script type="text/javascript">
        var emptyArr = []; //this is one way of creating an array.
        document.write("EmptyArray Length  = ", emptyArr.length); //length of an array
        //this is similar to print method in python, we can write element separating them with commas to concatenate them.

        var myArray = new Array(10);
        //note: if we pass more than 1  element in the 'new' array creation syntax,
        //will cause array to think that they are the elements.

        document.write("<br/>", "MyArray size is: ", myArray.length, "<br/>");
        myArray = [0, 2, 3, 4, 5];
        document.write(myArray, "<br/>");
        document.write("<br/>", "MyArray size is reduce to : ", myArray.length, "<br/>");
        var myArray1 = [2, 4, 67, 12];
        document.write("<br/>", "First element is: ", myArray1[0]); 
        document.write("<br/>", "First element is: ", myArray1[myArray1.length - 1]);

        document.write("<br/>");

        //for (var i of myArray1) {
        //    document.write(i + "<br/>");
        //}

        for (var i = 0; i < myArray1.length; i++) {
            document.write(myArray1[ i] + " | ");
        }

        alert(myArray1);

        for (var i = 0; i < 10; i++) {
            emptyArr[i] = i * i;
        }
        document.write("<br/>", "EmptyArr upto ", emptyArr.length, "<br/>");
        for (var i = 0; i < 10; i++) {
            document.write(emptyArr[i] + "<br/>");
        }
        document.write("EmptyArray Length  = ", emptyArr.length , "<br/>");


        for (var i = 0; i < 10; i++) {
            document.write(emptyArr.pop()+ "<br/>"); //pop() removes an element from array and displays. Array length shortens by one
        }
        document.write("EmptyArray Length  = ", emptyArr.length, "<br/>");

        for (var i = 0; i < 11; i++) {
            document.write(emptyArr.push(i*i*i) + "<br/>"); //push() adds an element to array at the end. Array length increases by one
        }
        document.write("EmptyArray Length  = ", emptyArr.length, "<br/>");
        for (var i = 0; i < 11; i++) {
            document.write(emptyArr[i] + "<br/>");
        }


        for (var i = 11; i < 15; i++) {
            document.write(emptyArr.unshift(i * i * i) + "<br/>"); //unshift() adds an element to array at the beginning. Array length increases by one
        }
        document.write("EmptyArray Length  = ", emptyArr.length, "<br/>");
        for (var i = 0; i < 15; i++) {
            document.write(emptyArr[i] + "<br/>");
        }

        for (var i = 11; i < 15; i++) {
            document.write(emptyArr.shift() + "<br/>"); //unshift() removes an element from array at the beginning. Array length shortens by one
        }
        document.write("EmptyArray Length  = ", emptyArr.length, "<br/>");
        for (var i = 0; i < 11; i++) {
            document.write(emptyArr[i] + "<br/>");
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
