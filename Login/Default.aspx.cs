using System;
using System.Web.Security;
using System.Web.UI;

namespace Login
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UsuariosOnline.InnerText = Session["acessos"].ToString();
            }

        }

        [Obsolete]
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtUsuario.Text;
            var senha = txtSenha.Text;

            Usuario user = null;

            user = UsuarioDAO.ObterUsuario(login);            

            if (user != null)
            {
                var senhaCriptografada = FormsAuthentication.HashPasswordForStoringInConfigFile(senha, "SHA1");
                
                if (user.Senha == senhaCriptografada)
                {
                    //Usuário válido
                    FormsAuthentication.SetAuthCookie(login, true);

                    LogAcesso log = new LogAcesso();
                    log.UsuarioId = user.IdUsuario;
                    log.DataHoraAcesso = DateTime.Now;

                    LogAcessoDAO.CadastrarLogAcesso(log);

                    Session["user"] = log;

                    var tipo = user.GetTipoUsuario().Descricao;

                    if (tipo == "Admin")
                    {
                        Session["User"] = user;
                        Response.Redirect("~/Adm/Home");
                    }
                    else if (tipo == "Cliente")
                    {
                        Response.Redirect("~/User");
                    }
                }
            }

            lblMensagem.InnerText =
                "Usuário e/ou senha invalidos!";
           
        }
    }
}