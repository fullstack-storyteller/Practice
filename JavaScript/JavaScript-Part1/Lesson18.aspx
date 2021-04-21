<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson18.aspx.cs" Inherits="JavaScript_Part1.Lesson18" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson - 18 Error Handling</title>
    <script type ="text/javascript">

        //Exception Handling in JS works exactly the same as in C#.
        //syntax and understanding is also same
        //only difference is the e.message, e.description, e.stack properties of the exception object.
        try {
            document.write(sayHello());
            document.write("This line will never be executed.","<br/>");
                        
        }
        catch(e){
            document.write("Exception Message: ",e.message ,"<br/>");
            document.write("Exception Description: ", e.description,"<br/>");
            document.write("Exception stact trace: ",e.stack,"<br/>");
        }
        finally {
            document.write("This line is guaranteed to execute.","<br/>");
        }
        document.write("<br/>");

        function divide() {
            var numerator = Number(prompt("Please enter the numerator: ", ""));
            var denomenator = Number(prompt("Please enter the denomenator: ", ""));
            try {
                if (denomenator == 0) {
                    throw {//this is an object, ; is not allowed. 
                        //use comma to separate properties.
                        error: "Divide by zero error",
                        message: "Denominator is zero",
                        
                    }
                }
                else {
                    document.write("Result = " + (numerator / denomenator), "<br/>");
                }
            }
            catch (e) {
                document.write("Exception Message: ", e.message, "<br/>");
                document.write("Exception error: ", e.error, "<br/>"); //property defined by us
                document.write("Exception stact trace: ", e.stack, "<br/>");//we didn't define this in our custom exception. do this is coming as "undefined"
            }

            ////finally block is optional.

            //finally {
            //    document.write("This line is guaranteed to execute.", "<br/>");
            //}
        }

        divide();

        //In general, we use try/catch statement to catch error in Javascript.
        //If an error is raised by a statement and is not handled by try-catch clause,
        //the window.onerror event is fired.

        /*
         * 
         * We can assign a function to window.onerror event
         * that you want to execute when an error is raised.
         * the function that is associated as the event handler for the onerror event has three
         * parameters.
         * 
         * message
         * URL,
         * line
         * 
         * */
        //the below can be used when any javascript error are uncaught.
        window.onerror = function (message, URL, line) {
            alert("Message: " + message + "\nURL: " + URL + "\nLine: " + line);
            return true;
        }

        //the below onerror handler can be used by any html element.
        function puzzle(item ) {
            alert("Error occured at script tag by id: " + item.id);            
            return true;
        }
        testMe();

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img id="myimage" alt="not available" src="nonexistingImage.jpg" onerror="puzzle(this)"/>
            
        </div>
    </form>
</body>
</html>
