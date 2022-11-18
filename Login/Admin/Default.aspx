<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login.Admin.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Página Administrativa</h1>

    <img src="#" alt="Imagem do Usuario" id="ImgUser" runat="server" />

    <h3>Bem-vindo, 
        <asp:LoginName ID="LoginName1" runat="server" />
        !
    </h3>

    <form id="form1" runat="server">
        <div class="logof">
            <asp:LoginStatus ID="LoginStatus1" runat="server" OnLoggedOut="LoginStatus1_LoggedOut" />
        </div>
        <asp:FileUpload ID="fuImagem" runat="server"  AllowMultiple="false"/>
        <asp:Button Text="upload" runat="server" ID="btnUpload" OnClick="btnUpload_Click" />
    </form>
</body>
</html>
