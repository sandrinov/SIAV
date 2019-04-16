<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SIAV_WebForm.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript">
        function getCookie(NameOfCookie) {
            if (document.cookie.length > 0) {
                begin = document.cookie.indexOf(NameOfCookie + "=");
                if (begin != -1) {
                    begin += NameOfCookie.length + 1;
                    end = document.cookie.indexOf(";", begin);
                    if (end == -1) end = document.cookie.length;
                    return unescape(document.cookie.substring(begin, end));
                }
            }
            return null;
        }
    </script>

    <script type="text/javascript">

        // This code returns the cookie name.
       // alert("Getting HTTP Cookie");
        alert(getCookie("MyHttpCookie"));

        // Because the cookie is set to HttpOnly,
        // this returns null.
        alert("Getting HTTP Only Cookie");
        alert(getCookie("MyHttpOnlyCookie"));

         alert("Getting HTTP Secure Cookie");
        alert(getCookie("MyHttpSecureCookie"));

    </script>
</body>
</html>
