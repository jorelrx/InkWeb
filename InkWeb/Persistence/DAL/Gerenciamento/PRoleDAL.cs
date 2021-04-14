using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Gerenciamento;
using Persistence.Contexts;

namespace Persistence.DAL.Gerenciamento
{
    public class PRoleDAL
    {
        private EFContext context = new EFContext();

        //Listar Usuarios
        public IQueryable<MRole> ListRoles()
        {
            return context.Roles.OrderBy(u => u.ID);
        }

        public MRole ListRole(long id)
        {
            return context.Roles.Where(s => s.ID == id).First();
        }

        //Adicionar usuarios e editar dados
        public void SaveRole(MRole mRole)
        {
            if (mRole.ID == 0)
            {
                context.Roles.Add(mRole);
            }
            else
            {
                context.Entry(mRole).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public MRole DeleteRole(long id)
        {
            MRole mRole = ListRole(id);
            context.Roles.Remove(mRole);
            context.SaveChanges();
            return mRole;
        }
    }
}
