<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson23.aspx.cs" Inherits="JavaScript_Part1.Lesson23" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 23 - Event Handling In JS</title>
</head>
<body>
    <h3>Option 1</h3>
    <p>Event handling using HTML attributes</p>
    <input type="button" id="btnExample"
        onmouseover="ChangeOnMouseOver(this)"
        onmouseout="ChangeOnMouseOut(this)"
        value="Click Me!"
        onclick="return ConfirmOnSubmit(this)"/> <%--whenever you want to have a confirmation box--%>
    <br />
    <br />
    <h3>Option 2</h3>
    <p>Event handling using DOM object properties</p>
    <table>
        <tr><td>First Name:</td>
            <td><input type="text" id="txtFirstName" 
                onkeyup="ValidateRequiredField(this)" 
                onblur="ValidateRequiredField(this)"/></td>
            <%--onkeyup event occurs when we release a key inside a control--%>
            <%--onblur event occurs whenever the control loses focus. --%>
        </tr>
        <tr><td>Last Name:</td>
            <td><input type="text" id="txtLastName" 
                onkeyup="ValidateRequiredField(this)" 
                onblur="ValidateRequiredField(this)"
                /></td>
        </tr>
    </table>
    <br />
    <br />
    <form id="form1" runat="server">
        <div>
            <input type="button" id="btn" value="My Button by DOM"/>
            <br />
            <input type="button" onclick="handler1()" id="btn1" value="My Button by multiple Handler"/>

        </div>
    </form>
  <br />
    <br />
    <h3>Option 3</h3>
    <p>Event handling using special methods</p>
    <script type="text/javascript">
        /*
         * Event Handling in JS
         * 
         * An event is a signal from the browser that something has happened
         * in the browser.
         * When an event occurs we can execute the javascript code or functions
         * in response to those events. TO do this, we need to associate javascript code or functions
         * to the events. The fucntion that executes in response to an event
         * is called the event handler.
         * 
         * In javascript, there are several ways to associate an event handler
         * to the event.
         * 1. Using the attribute of an HTML tag
         * 2. Using the DOM object property
         * 3. Using special methods
         * 
         * In the below exercise, we are looking into the option 1.
         */
        function ChangeOnMouseOver(obj) {
            obj.style.background = 'Red';//background color of the element
            obj.style.color = 'Yellow'; //font color
        }
        function ChangeOnMouseOut(obj) {
            obj.style.background = 'black';
            obj.style.color = 'white';
        }

        function ConfirmOnSubmit(obj) {
            if (confirm("Are you sure?")) {
                alert("You selected OK!");
                return true;
            }
            alert("You selected CANCEL!");
            return false;

        }

        function ValidateRequiredField(obj) {
            obj.style.color = 'white';
            if (obj.value == "") {
                obj.style.background = 'red';
            }
            else {
                obj.style.background = 'green';
            }
        }

        /*
         * Note, we can use the javascript to access and modify
         * DOM objects and their properties.
         * For example, you can add, modify and remove HTML element
         * and their attributes.
         * Along the same lines, you can use the DOM objects properties to
         * assign event handlers to events.
         * 
         */

        //the below example demonstrate how we can use the 
        //dom properties like onmouseover onmouseout
        //to execute the eventhandlers
        //In the below exercise, we are looking into the option 2.

        document.getElementById("btn").onmouseover = function () {
            this.style.background = 'Red';//background color of the element
            this.style.color = 'Yellow'; //font color
        }//ChangeOnMouseOver(this); <-only give the name here without parenthesis, or write a anonymous function
        document.getElementById("btn").onmouseout = function () {
            this.style.background = 'black';
            this.style.color = 'white';
        }//ChangeOnMouseOut(this);

        function handler1() {//this will be overwritten
            alert("Handler assigned using the HTML attribute.");
        }
        function handler2() {
            alert("Handler assigned using the DOM object properties.");
        }
        //document.getElementById("btn1").onclick = handler2;
        //we can also write the above one line as 
        window.document.getElementById("btn1").onclick = handler2;
        //clearly the handler assigned by the DOM object will prevail/overwrite.

        /*
         * Discussion on Option 3.
         * Using special method for adding the event handlers
         *  *
         */
    </script>
</body>
</html>
