<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>
<%@ Register src="WebUserControl1.ascx" tagname="WebUserControl1" tagprefix="uc1" %>
<table style="width:100%;">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
        </td>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Cognome"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>

<uc1:WebUserControl1 ID="WebUserControl11" runat="server" />


