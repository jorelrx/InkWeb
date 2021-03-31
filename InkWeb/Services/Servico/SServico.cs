using Models;
using Persistence.DAL.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Servico
{
    public class SServico
    {
        private PServiceDAL serviceDAL = new PServiceDAL();
        public IQueryable<MServico> ListServices()
        {
            return serviceDAL.ListServices();
        }

        public MServico ListService(long id)
        {
            return serviceDAL.ListService(id);
        }
        public void SaveService(MServico mServico)
        {
            serviceDAL.SaveService(mServico);
        }
        public MServico DeleteSerice(long id)
        {
            return serviceDAL.DeleteService(id);
        }
    }
}
