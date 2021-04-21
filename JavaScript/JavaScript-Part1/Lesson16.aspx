<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson16.aspx.cs" Inherits="JavaScript_Part1.Lesson16" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson - 16 Closure</title>
    <script type="text/javascript">

        //A closure is an inner function that has
        //access to the outer function's variable
        //in addition to its own variables adn global
        //variables.

        //The inner function not only has access to the
        //outer function's variables, but also to its parameters.

        //You can create a closure by adding a function
        //inside another function.

        function addNumber(x, y) {

            var returnMessage = "The result is: ";
            function add() {
                return returnMessage + (x + y);
            }
            //return add(); //this is simply return the value
            return add; //this will return inner method definition.

        };
        var result = addNumber(4, 5);
        document.write(result, "<br/>");

        var result1 = addNumber(40, 50); //removing the set of prenthesis from inner function call.
        var functResult = result1(); //use parenthesis with closure to execute them
        document.write(functResult, "<br/>");

        var myresult = addNumber(30, 40)(); //we can execute like this too.
        document.write(myresult, "<br/>");

        //-------------------------------
        //auto increment example using closures
        var counter = 0;
        function Increamenter() {
            document.getElementById("txtIncrement").value = ++counter;
        }
        //but the counter variable is a global variable right now.
        //a global variable can be updated by any script.

        //hence let's try this using the closure.


        var incrementerFucntion = (
            function IncreamenterClosure() {
                var counterClosure = 0;
                function innerCounter() {
                    document.getElementById("txtIncrementClosure").value = ++counterClosure;
                }
                return innerCounter; //there should be no parenthesis, as we returning a method.
            }
        )();
        //remember the outer method enclosing a closure gets executed only once.
        //remeber if the last () is not there in named variable during defnition then, the inner method definition will be returned.
        //remeber if the last () is there in named variable during defnition then, the inner method will be executed.
            //but make sure in both the cases above, we should make the call by using () with the named variable incrementerFucntion
            // i.e. like onclick="incrementerFucntion()"


        document.write("<br/>", innerCounter, "<br/>");

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="btnIncrementer" value="Click me!" onclick="Increamenter()" type="button" />
            <input id="txtIncrement" type="text" />
        </div>

        <div>
            <input id="btnIncrementerClosure" value="Click me!" onclick="incrementerFucntion()" type="button" />
            <input id="txtIncrementClosure" type="text" />
        </div>
    </form>
</body>
</html>
