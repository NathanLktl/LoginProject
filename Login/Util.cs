using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login
{
    public class Util
    {
        public static int Acessos { get; set; }

        public static void AtualizarUltimoAcesso(LogAcesso log)
        {
            if (log != null)
            {
                var ultimoAcesso = DateTime.Now;
                log.DataHoraLogoff = ultimoAcesso;
                LogAcessoDAO.AtualizarLogAcesso(log);
            }
        }
    }
}