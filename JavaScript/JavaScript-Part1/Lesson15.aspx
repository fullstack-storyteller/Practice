<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson15.aspx.cs" Inherits="JavaScript_Part1.Lesson15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>lession 15 - Local and Global variable</title>
    <script type="text/javascript">
        var greeter = "Manish"
        function helloWorld() {
            var greeting = "Hello"; //this is a local variable

            willbeglobavariable = "this variable will be global, even when it is not declared globaly."
            // since the variable is not declared in helloWorld method, it will become global variable

            greeting = greeting + "Javascript";
            alert(greeting);
        }
        helloWorld();

        //if we try to access the variable 'greeting' here,
        // it will not be accessible

        //document.write(greeting, "<br/>"); //undefined here

        alert(greeter); //this is a global variable.
        alert(willbeglobavariable);

        var test = "this is a globally declared 'test' variable";
        function mytest() {
            var test = "this is a locally declared 'test' variable";
            test += "??? modified in local";
            document.write(test, "<br/>");
        }
        mytest();
        test += "??? modified in global scope";
        document.write(test, "<br/>");

        //hence the glocal and local scopes are 
        //exclusive of each other.


        document.write("<br/>","Check out this interesting case of issue.", "<br/>");
        // Sometimes, variable hoisting and local & global variables
        // with the same name can cause unexpected
        // behaviour.
        // if you have a global variable and a local variable by the same name
        // as global variable, then global varible will not have any meaning.
        // say, global varible 'globe'
        var globe = "Declared globally.";
        function disturbingMethod1() {
            
            document.write(globe, "-> this is coming from globe from global variable", "<br/>");    
            var globe = "globe -> Declared locally 1";
            document.write(globe, "<br/>");
        }
        function disturbingMethod2() {
            var globe;
            document.write(globe, "<br/>");
            globe = "globe -> declared locally 2";
            document.write(globe, "<br/>");
        }
        disturbingMethod1();
        disturbingMethod2();
        document.write(globe, " -> coming from global", "<br/>");

        document.write("Bottom line is global variables have no meaning in JS if the same variable is defined with a local scope.", "<br/>");
        document.write("<br/>");


        //Braces do not create scope in Javascript;
        //In the following example otherNumber is a global variable
        //though it is defined inside braces.
        //in many languages like C# and Java, braces create scope, but not in
        // Javascript.

        var number = 100;
        if (number > 10) {
            var otherNumber = number
        }
        document.write(otherNumber);
        document.write("<br/>");
        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
