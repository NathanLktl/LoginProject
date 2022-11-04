using System;

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
    }
}