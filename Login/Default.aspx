<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Login.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Login</h1>
    <form id="form1" runat="server">
        <div>
            <p>
                <label>Usuário:</label>
                <asp:TextBox runat="server" ID="txtUsuario"/>
            </p>

            <p>
                <label>Senha:</label>
                <asp:TextBox runat="server" ID="txtSenha" TextMode="Password"/>
            </p>
            <p>
                <asp:Button 
                    Text="Logar" 
                    runat="server" 
                    ID="btnLogin" 
                    OnClick="btnLogin_Click"/>
            </p>
            <p>
                <label id="lblMensagem" class="mensagem-erro" runat="server"></label>
            </p>
            <a href="~/Usuario" runat="server">Cadastre-se</a>
        </div>
    </form>
</body>
</html>
