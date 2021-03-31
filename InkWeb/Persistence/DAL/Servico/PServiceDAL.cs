using Models;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DAL.Servico
{
    public class PServiceDAL
    {
        private EFContext context = new EFContext();

        //Listar Usuarios
        public IQueryable<MServico> ListServices()
        {
            return context.Servicos.OrderBy(u => u.ID);
        }

        public MServico ListService(long id)
        {
            return context.Servicos.Where(s => s.ID == id).First();
        }

        //Adicionar usuarios e editar dados
        public void SaveService(MServico mServico)
        {
            if (mServico.ID == 0)
            {
                context.Servicos.Add(mServico);
            }
            else
            {
                context.Entry(mServico).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public MServico DeleteService(long id)
        {
            MServico mServico = ListService(id);
            context.Servicos.Remove(mServico);
            context.SaveChanges();
            return mServico;
        }
    }
}
