using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InkWeb.Models;

namespace InkWeb.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Ink_Web") {
            Database.SetInitializer<EFContext>(new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Cliente> Cliente { get; set; }
    }
}