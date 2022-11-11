<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login.Cliente.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <h1>Página Administrativa</h1>

    <h3>Bem-vindo, 
        <asp:LoginName ID="LoginName1" runat="server" />
        !
    </h3>

    <form id="form1" runat="server">
        <div class="logof">
            <asp:LoginStatus ID="LoginStatus1" runat="server" OnLoggedOut="LoginStatus1_LoggedOut" />
        </div>
    </form>
</body>
</html>
