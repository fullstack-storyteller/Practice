<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson20.aspx.cs" Inherits="JavaScript_Part1.Lesson20" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson - 20: Timing Event in JS</title>

</head>
<body>
    <h2>SetInterval Method</h2>
    <p>This program mainly focuses on making the timer and clock using the setInterval method.</p>
    <div id="Container">
        <div id="divClock" class="header"></div>
        <div id="leftPanCLock" class="left">
            <input id="btnStopClock" type="button" value="STOP CLOCK" onclick="stopClock()" />
        </div>
        <div id="rightPanClock" class="right">
            <input id="btnStartClock" type="button" onclick="startClock()" value="START CLOCK" />
        </div>
        <div id="Header" class="main">
            <input id="txtConsole" type="text" />
        </div>
        <div id="leftPan" class="left">
            <input id="btnStop" type="button" value="STOP TIMER" onclick="stopTimer()" />
        </div>
        <div id="rightPan" class="right">
            <input id="btnStart" type="button" onclick="startTimer()" value="START TIMER" />
        </div>
        <div class="footer"></div>
    </div>



    <script type="text/javascript">
        //open in IE.
        //always call the javascript below closing the body tag
        //var date = new Date();

        //-----------------------This is for CLOCK---------------------------------------
        document.getElementById('divClock').innerHTML = new Date();
        var IntervalForCLock;
        function startClock() {
            //the setInterval will return a interval ID.

            IntervalForCLock = setInterval(function () {
                document.getElementById('divClock').innerHTML = new Date();
            }, 1000);
        }

        function stopClock() {
            clearInterval(IntervalForCLock);
        }





        //-----------------------This is for CLOCK---------------------------------------


        //-----------------------This is for Timer---------------------------------------
        var IntervalForTImer;
        var seconds;
        function startTimer() {
            if (isNaN(document.getElementById('txtConsole').value)||document.getElementById('txtConsole').value == "" || document.getElementById('txtConsole').value == "Time up!!!") {
                alert("Invalid Input!");
                return;
            }
            seconds = parseInt( document.getElementById('txtConsole').value);
            IntervalForTImer = setInterval(tick, 1000);
            function tick() {

                if (seconds == 0) {
                    //clearInterval(interval);

                    stopTimer();

                }
                else {
                    document.getElementById('txtConsole').value = --seconds;
                }
            }

        }

        function stopTimer() {
            clearInterval(IntervalForTImer);
            if (seconds == 0) {
                document.getElementById('txtConsole').value = "Time up!!!";
            }

        }
        //-----------------------This is for Timer---------------------------------------
    </script>
    <style type="text/css">
        #Container {
            position: absolute;
            display: grid;
            /*grid-template-areas:
                'header header header header'
                'left main main right'
                'footer footer footer footer';*/
            grid-gap: 15px;
            grid-column-gap: 10px;
            grid-row-gap: 10px;
            background-color: #2196F3;
        }

            #Container > div {
                /*outline:dashed thin;*/
                position: relative;
                display: inline-grid;
                background-color: rgba(255, 255, 255, 0.8);
                text-align: center;
                padding: 5px;
                font-size: 15px;
                font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            }

        .footer {
            grid-area: footer;
        }

        .main {
            grid-area: main;
        }

        .right {
            grid-area: right;
        }

        .left {
            grid-area: left;
        }

        .header {
            /*position: absolute;*/
            grid-area: header;
        }
        /*#divClock {
            text-align: center;
             ;
        }*/
    </style>
</body>
</html>
