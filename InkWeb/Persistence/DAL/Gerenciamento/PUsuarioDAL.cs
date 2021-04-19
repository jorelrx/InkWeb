using Models.Gerenciamento;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DAL.Gerenciamento
{
    public class PUsuarioDAL
    {
        private EFContext context = new EFContext();

        //Listar Usuarios
        public IQueryable<MUsuario> ListarUsuarios()
        {
            return context.Usuarios.OrderBy(u => u.Nome);
        }

        public MUsuario ListUsuario(long id)
        {
            return context.Usuarios.Where(u => u.ID == id).First();
        }

        //Adicionar usuarios e editar dados
        public void SaveUsuario(MUsuario mUsuario)
        {
            if (mUsuario.ID == 0)
            {
                context.Usuarios.Add(mUsuario);
            }
            else
            {
                context.Entry(mUsuario).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public MUsuario ValidarUsuario(string login, string senha)
        {
            foreach (var item in ListarUsuarios())
            {
                if (item.Username == login && item.Senha == senha)
                {
                    return item;
                }
            }
            return null;
        }
        public MUsuario ListServicesP(long id)
        {
            return context.Usuarios.Where(u => u.ID == id).Include("Servicos.MUsuario").First();
        }

        public IQueryable ListServices()
        {
            return context.Usuarios.Include("Servicos.MUsuario");
        }
    }
}
