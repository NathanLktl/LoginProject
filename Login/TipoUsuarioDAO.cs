using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login
{
    public class TipoUsuarioDAO
    {
        internal static TipoUsuario ObterTipo(int? tipoUsuarioId)
        {
            TipoUsuario tipo = null;

            using(var ctx=new UserDBEntities())
            {
                tipo = ctx.TipoUsuarios.FirstOrDefault(x=>x.IdTipoUsuario==tipoUsuarioId.Value);
            }
            return tipo;
        }

        internal static TipoUsuario ObterTipo(string v)
        {
            TipoUsuario tipo = null;

            using (var ctx = new UserDBEntities())
            {
                tipo = ctx.TipoUsuarios.FirstOrDefault(x => x.Descricao == v);
            }
            return tipo;
        }
    }
}