using Models.Tattoo;
using Persistence.DAL.Tattoo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Tattoo
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
        public MServico DeleteService(long id)
        {
            return serviceDAL.DeleteService(id);
        }
    }
}
