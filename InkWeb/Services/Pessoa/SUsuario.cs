using Models.Pessoa;
using Persistence.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Pessoa
{
    public class SUsuario
    {
        private PUsuarioDAL usuarioDAL = new PUsuarioDAL();
        public IQueryable<MUsuario> ListarUsuarios()
        {
            return usuarioDAL.ListarUsuarios();
        }
        public void SaveUsuario(MUsuario mUsuario)
        {
            usuarioDAL.SaveUsuario(mUsuario);
        }
    }
}
