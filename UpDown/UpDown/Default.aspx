<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UpDown.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="btnEnviar" runat="server" Text="Upload" OnClick="btnEnviar_Click" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" Height="153px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="285px"></asp:ListBox>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" />
    </div>
    </form>
</body>
</html>
