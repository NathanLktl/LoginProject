using System;
using System.Linq;

namespace Login
{
    public class UsuarioDAO
    {
        public static Usuario ObterUsuario(string login)
        {
            Usuario user = null;
            using (var ctx = new UserDBEntities())
            {
                user = ctx.Usuarios.FirstOrDefault(
                        x => x.Login == login
                    );
            }

            return user;
        }

        public static void CadastrarUsuario(Usuario usuario)
        {
            using (var ctx = new UserDBEntities())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }
    }
}