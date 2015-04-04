using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientManagement.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClientManagement.DAL
{
    public class AgencyClientContext : DbContext
    {

        public AgencyClientContext()
            : base("AgencyClientContext")
        { 
        }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}