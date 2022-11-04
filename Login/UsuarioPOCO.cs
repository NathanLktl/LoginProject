using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login
{
    public partial class Usuario
    {
        public TipoUsuario GetTipoUsuario()
        {
            TipoUsuario tipo = TipoUsuarioDAO.ObterTipo(this.TipoUsuarioId);
            return tipo;
        }
    }
}