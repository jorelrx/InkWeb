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

        public MUsuario ListUsuario(long id)
        {
            return usuarioDAL.ListUsuario(id);
        }

        public void SaveUsuario(MUsuario mUsuario)
        {
            usuarioDAL.SaveUsuario(mUsuario);
        }

        public MUsuario ValidarUsuario(string login, string senha)
        {
            return usuarioDAL.ValidarUsuario(login, senha);
        }
        public MUsuario ListServicesP(long id)
        {
            return usuarioDAL.ListServicesP(id);
        }

        public IQueryable ListServices()
        {
            return usuarioDAL.ListServices();
        }
    }
}
