<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />

        <p>
            User Hostname: <%: Request.UserHostName %>
        </p>
        <br />
        <p>
            User Hostname (2): <%= Request.UserHostName %>
        </p>
    </form>
</body>
</html>
