<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lesson6.aspx.cs" Inherits="JavaScript_Part1.Lesson6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lesson 6</title>
    <script>
        function getEmailAndDomain() {
            var email = document.getElementById("txtEmail").value;
            document.getElementById("txtEmailID").value = email.substring(0, email.indexOf("@"));
            document.getElementById("txtDomain").value = email.substring(email.indexOf("@") + 1);
            //javascript is case-sensitive

        }

        function getTopDomain() {
            var url = document.getElementById("txtURL").value;
            document.getElementById("txtTopLevelDomain").value = url.substring(url.lastIndexOf("."));
        }
    </script>
</head>
<body>
    <ul >

        <li style="display:inline-block">
            <div >
                <table>
                    <tr>
                        <td>Enter your email ID: </td>
                        <td>
                            <input id="txtEmail" type="text" /></td>

                    </tr>
                    <tr>
                        <td>Email is: </td>
                        <td>
                            <input id="txtEmailID" type="text" /></td>

                    </tr>
                    <tr>
                        <td>Domain is: </td>
                        <td>
                            <input id="txtDomain" type="text" /></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <input id="btnGetEmailAndDomain" onclick="getEmailAndDomain()" type="button" value="Get Email and Domain" /></td>
                    </tr>
                </table>
            </div>
        </li><li style="display:inline-block"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; </li>
        <li style="display:inline-block">
            <div>
                <table>
                    <tr>
                        <td>Enter your url</td>
                        <td>
                            <input id="txtURL" type="text" /></td>

                    </tr>
                    <tr>
                        <td>Top Level Domain is: </td>
                        <td>
                            <input id="txtTopLevelDomain" type="text" /></td>

                    </tr>
                    <tr>

                        <td colspan="2">
                            <input id="btnTopLevelDomain" type="button" value="Get Top level Domain" onclick="getTopDomain()" /></td>

                    </tr>
                </table>
            </div>
        </li>
    </ul>
</body>
</html>
