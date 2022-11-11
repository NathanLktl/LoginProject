<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUsuario.aspx.cs" Inherits="Login.FrmUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="logof">
           <asp:LoginStatus ID="LoginStatus1" runat="server" LoginText="Entrar"/>
        </div>
    <h1>Cadastro de usuário</h1>
        <div>
            <fieldset>

                <legend>
                    Dados de acesso:
                </legend>

                <p>
                    <label>Login:</label>
                    <asp:TextBox runat="server" id="txtLogin" required/>
                </p>

                <p>
                    <label>Senha:</label>
                    <asp:TextBox runat="server" id="txtSenha" TextMode="Password" required/>
                </p>
                <p>
                    <asp:Button Text="Cadastrar" runat="server" id="btnCadastrar" OnClick="btnCadastrar_Click"/>
                </p>
                <p>
                    <label id="lblMensagem" runat="server"></label>
                </p>

            </fieldset>
        </div>
    </form>
</body>
</html>
