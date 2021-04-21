<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson22.aspx.cs" Inherits="JavaScript_Part1.Lesson22" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 22 - Slide Show</title>
    
</head>
<body>
    <img id="currentImage" alt="Image not found!" style="height:500px; width: 900px;" src="Images/1.jpg" />
    <%--remember the client side java script doesn't have access to file system.
    Hence you can't read the slide / pics/ files from your local system.--%>
    <br />
    <input id="btnStart" type="button" value="Start Slide Show!" onclick="startSlideShow()"/>
    <input id="picDuration" type="text"  />
    <input id="btnStop" type="button" value="Stop Slide Show!"  onclick="stopSlideShow()"/>
    <div id="divTest"></div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <script type="text/javascript" src="SpecialJS/SlideShow.js">
        <%--//no need to use tild ~ sign here--%>
    </script> 
</body>
</html>
