using System;
using System.Web.UI;

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

                //var Caminho=MapPath("~/upload")
                ImgUser.Src = "../upload/" + user.IdUsuario + ".png";
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

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (fuImagem.HasFile)
            {
                var Arquivo = fuImagem.PostedFile;
                var Mapa = MapPath("~/");
                var Caminho = Mapa = "\\upload\\" + ((Usuario)Session["user"]).IdUsuario + ".png";
                Arquivo.SaveAs(Caminho);
            }
        }
    }
}
