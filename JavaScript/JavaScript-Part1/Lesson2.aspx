<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson2.aspx.cs" Inherits="JavaScript_Part1.Lesson2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <script>
        var a = 20;
        var b = 30;
        var c = a + b;
        alert(c);
        //number + number  = number i.e. addition: 50

        a = "20";
        c = a + b;
        alert(c);
        //number enclosed in string + number = string concatinaion: 2030

        a = 20;
        b = "30";
        c = a + b;
        alert(c);
        //number + number enclosed in string = string concatinaion: 2030

        a = 20;
        b = " manish ji";
        c = a + b;
        alert(c);
        //number + pure string = string concatinaion: 20 manish ji

        b = 20;
        a = "manish ji ";
        c = a + b;
        alert(c);
        //pure string + number = string concatinaion: manish ji 20

        a = 20;
        b = 30;
        c = a - b;
        alert(c);
        //number - number = number substraction: -10

        a = 20;
        b = "30";
        c = a - b;
        alert(c);
        //number - number enclosed in string = number substraction: -10

        a = "20";
        b = 30;
        c = a - b;
        alert(c);
        //number enclosed in string - number = number substraction: -10

        a = 20;
        b = " manish ji";
        c = a - b;
        alert(c);
        //number - pure string = string result - NaN

        b = 20;
        a = "manish ji ";
        c = a - b;
        alert(c);
        //pure string - number = string concatinaion: result - NaN
        
    </script>
</body>
</html>
