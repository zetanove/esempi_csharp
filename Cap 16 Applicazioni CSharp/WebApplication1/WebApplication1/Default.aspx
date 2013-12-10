<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<%@ Register assembly="WebApplication1" namespace="WebApplication1" tagprefix="cc1" %>

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


        <br />
        <p>
            Data e ora: <%= DateTime.Now.ToString() %>
        </p>

        <br />
        <p>
            <%
                for (int i = 0; i < 10; i++)
                {
                    Response.Write(i);
            %>
            
            <br />
            <%
            } 
            %>
        </p>
        <br />
        <cc1:MyControl ID="MyControl1" runat="server">
            </cc1:MyControl>
    </form>
</body>
</html>
