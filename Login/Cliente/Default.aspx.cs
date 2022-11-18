using System;

namespace Login.Cliente
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
        {
            Session["user"] = null;
            var log = (LogAcesso)Session["Log"];

            Util.AtualizarUltimoAcesso(log);
        }
    }
}
