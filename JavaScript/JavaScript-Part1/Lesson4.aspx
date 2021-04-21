<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson4.aspx.cs" Inherits="JavaScript_Part1.Lesson4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>JavaScript - Lesson 4</title>
    <script>
        var string1 = "Hello";
        var string2 = "World";
        var string =string1.concat(" ", string2, '!', " Welcome to Javascrip", 'tutorial.');
        alert(string1.concat(" ", string2, '!', " Welcome to Javascrip", 'tutorial.'));
        alert(string.length);
        alert("  Javascript  ".length);
        alert("after removing whitespace from both end");
        alert("  Javascript  ".trim().length); 
        alert(string.toUpperCase());
        alert(string.toLowerCase());
        //replace() method
        var initialword = "Hello, Javascript!";
        alert("Before replacing original word: " + initialword);
        var finalword = initialword.replace("Javascript", 'World');
        alert("After replacing original word: " + initialword);
        //the initial word doesn't changes, but a new string is created after the replacement.
        alert(finalword);

        //performing case-sensitive global replacement
        myString = "A Blue bottle with a blue liquid is on the blue table.";
        alert("global replacement - Before: " + myString);
        alert("global replacement - Case-sensitive - After: " + myString.replace(/blue/g, 'green')); // /some text/g means a global case-sensitive replacement
        alert("global replacement - Case-insensitive - After: " + myString.replace(/blue/gi, 'green'));
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>

        </div>
    </form>
</body>
</html>
