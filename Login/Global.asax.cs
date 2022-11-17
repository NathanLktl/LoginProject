using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Login
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            // Util.Acessos++;
            //  AnaliseTemp(sender, e);
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            AnaliseTemp(sender, e);
            int Acessos;
            if (Session["acessos"] != null)
            {
                Acessos = (int)Session["acessos"];
                Acessos++;
                Session["acessos"] = Acessos;
            }
            else
            {
                Session["acessos"] = 1;

            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            AnaliseTemp(sender, e);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            AnaliseTemp(sender, e);
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            AnaliseTemp(sender, e);
        }

        protected void Session_End(object sender, EventArgs e)
        {
            AnaliseTemp(sender, e);
        }

        protected void Application_End(object sender, EventArgs e)
        {
            AnaliseTemp(sender, e);

            Session["user"] = null;
            var log = (LogAcesso)Session["Log"];

            Util.AtualizarUltimoAcesso(log);
        }

        private void AnaliseTemp(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }
    }
}