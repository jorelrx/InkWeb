using Models.Pessoa;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DAL
{
    public class PUsuarioDAL
    {
        private EFContext context = new EFContext();

        //Listar Usuarios
        public IQueryable<MUsuario> ListarUsuarios()
        {
            return context.Usuarios.OrderBy(u => u.Nome);
        }

        //Adicionar usuarios e editar dados
        public void SaveUsuario(MUsuario mUsuario)
        {
            if (mUsuario.Id == 0)
            {
                context.Usuarios.Add(mUsuario);
            }
            else
            {
                context.Entry(mUsuario).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
