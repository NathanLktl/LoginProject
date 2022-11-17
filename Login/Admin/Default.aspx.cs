using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Usuario user =(Usuario)Session["User"];
                ValidarTipoUsuario(user);
            }
        }

        private void ValidarTipoUsuario(Usuario user)
        {
            //Verificar se não é nulo
            //Verificar tipo de usuario, se não admin, redirecionar para area cliente
            if (user != null)
            {
                if (user.GetTipoUsuario().Descricao!="Admin")
                {
                    Response.Redirect("~/User");
                }
            }
            else
            {
                Response.Redirect("~/Login");
            }
        }

        protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
        {
            AtualizarUltimoAcesso();
        }

        public void AtualizarUltimoAcesso()
        {
            Session["user"] = null;
            var log = (LogAcesso)Session["Log"];
            Util.AtualizarUltimoAcesso(log);
        }
    }
}
