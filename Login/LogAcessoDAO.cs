using System;
using System.Linq;

namespace Login
{
    public class LogAcessoDAO
    {
        public static void CadastrarLogAcesso(LogAcesso log)
        {
            try
            {
                using (var ctx = new UserDBEntities())
                {
                    ctx.LogAcessoes.Add(log);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }

        }

        internal static void AtualizarLogAcesso(LogAcesso log)
        {
            using(var ctx=new UserDBEntities())
            {
                var logVelho = ctx.LogAcessoes.FirstOrDefault(x=>x.IdLogAcesso==log.IdLogAcesso);
                logVelho.DataHoraLogoff = log.DataHoraLogoff;
                ctx.SaveChanges();
            }
        }
    }
}