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
    }
}
