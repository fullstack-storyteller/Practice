<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson19.aspx.cs" Inherits="JavaScript_Part1.Lesson19" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 19: Working with dates</title>
    <script type="text/javascript">

        //a date can be created using the new Date()
        var d = new Date();
        document.write(d, "<br/>");

        //or it can be created by using a string
        var myDOB = new Date("December 1, 1992");
        document.write(myDOB, "<br/>");

        //or it can be created by using a the below syntax
        // new Date(year, month, day, hours, minutes, seconds, milliseconds);
        //just replace the literal with numeric values
        //note: month starts with 0, 1, ...., 11 in Javascript
        var newDate = new Date(1992, 11, 1, 5, 30, 45, 34);
        document.write(newDate, "<br/>");
        document.write(newDate.getMonth(), " - ", getMonthNames(newDate.getMonth()), "<br/>");
        document.write(newDate.getDay(), " - ", getDayNames(newDate.getDay()), "<br/>");

        function getMonthNames(monthNum) {
            var monthNames = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
            return monthNames[monthNum];
        }
        function getDayNames(dayNum) {
            var dayNames = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday',];
            return dayNames[dayNum];
        }

        /*
         * getFullYear() - Returns the full year(all four digits.)*
         * getMonth() - Returns the month number (0-11)
         * getDate() - Returns the date of the month (1-31)
         * getDay() - Returns the day number of the month from (0 - 6)
         * getHours() - Returns the hours (0-23)
         * getMinutes() - Returns the minutes (0-59)
         * getSeconds() - Returns the seconds (0-59)
         * getMilliseconds() - Returns the milliseconds (0-999)
         */

        function getMyDate() {
            var date = new Date();
            document.getElementById("Text1").value =
                (date.getDate() < 10 ? '0' + date.getDate() : date.getDate()) + "/"
                +
            ((date.getMonth() + 1) < 10 ? '0' + (date.getMonth() + 1) : (date.getMonth() + 1)) + "/"
                +
                date.getFullYear();
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="Button1" type="button" value="Click to know today's date" onclick="getMyDate()" />
            <input id="Text1" type="text"  />
        </div>
    </form>
</body>
</html>
