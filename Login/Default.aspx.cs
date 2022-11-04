using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtUsuario.Text;
            var senha = txtSenha.Text;

            Usuario user = null;

            user = UsuarioDAO.ObterUsuario(login);            

            if (user != null)
            {
                var senhaCriptografada =
                    FormsAuthentication.
                        HashPasswordForStoringInConfigFile(senha, "SHA1");
                
                if (user.Senha == senhaCriptografada)
                {
                    //Usuário válido
                    FormsAuthentication.SetAuthCookie(login, true);

                    LogAcesso log = new LogAcesso();
                    log.UsuarioId = user.IdUsuario;
                    log.DataHoraAcesso = DateTime.Now;

                    LogAcessoDAO.CadastrarLogAcesso(log);

                    Response.Redirect("~/Admin/Default.aspx");
                }
            }

            lblMensagem.InnerText =
                "Usuário e/ou senha invalidos!";
           
        }
    }
}