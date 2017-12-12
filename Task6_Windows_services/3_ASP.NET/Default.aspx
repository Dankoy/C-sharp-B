<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_3_ASP.NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:textbox ID ="TextBox1" runat="server"></asp:textbox>
            <asp:button ID="Button1" runat="server" text="Button" OnClick="OnClick" />
        </div>
    </form>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</body>
</html>

