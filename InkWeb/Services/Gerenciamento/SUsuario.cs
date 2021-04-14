using Models.Gerenciamento;
using Persistence.DAL.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Gerenciamento
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

        public MUsuario ValidarUsuario(string login, string senha)
        {
            return usuarioDAL.ValidarUsuario(login, senha);
        }
    }
}
