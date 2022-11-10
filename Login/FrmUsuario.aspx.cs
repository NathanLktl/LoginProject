using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class FrmUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text;
                var pass = txtSenha.Text;

                if (login != "" && pass != "")
                {
                    Usuario usuario = new Usuario();
                    usuario.Login = login;

                    var senhaCriptografada =
                        FormsAuthentication.
                            HashPasswordForStoringInConfigFile(pass, "SHA1");

                    usuario.Senha = senhaCriptografada;

                    //Usuario ativo
                    var user = (Usuario)Session["user"];
                    if (user != null)
                    {
                        if (user.GetTipoUsuario().Descricao == "Admin")
                        {
                            //Pode cadastrar admin
                            //usuario.TipoUsuarioId = user.TipoUsuarioId;
                        }
                    }
                    else
                    {
                        //Usuario não logado
                        var tipo = TipoUsuarioDAO.ObterTipo("Cliente");
                        usuario.TipoUsuarioId = tipo.IdTipoUsuario;
                    }
                    UsuarioDAO.CadastrarUsuario(usuario);

                    LimparDados();
                    MostrarMensagem("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MostrarMensagem("Login e senha são obrigatórios!");
                }
            }
            catch (Exception ex)
            {
                MostrarMensagem(ex.Message);
            }
        }

        private void LimparDados()
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void MostrarMensagem(string message)
        {
            lblMensagem.InnerText = message;
        }
    }
}