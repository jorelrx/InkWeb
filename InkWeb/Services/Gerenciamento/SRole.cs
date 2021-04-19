using Models.Gerenciamento;
using Persistence.DAL.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Gerenciamento
{
    public class SRole
    {
        private PRoleDAL roleDAL = new PRoleDAL();
        public IQueryable<MRole> ListRoles()
        {
            return roleDAL.ListRoles();
        }

        public MRole ListRole(long id)
        {
            return roleDAL.ListRole(id);
        }
        public void SaveRole(MRole mServico)
        {
            roleDAL.SaveRole(mServico);
        }
        public MRole DeleteRole(long id)
        {
            return roleDAL.DeleteRole(id);
        }
    }
}
