using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ClientManagement.Models;

namespace ClientManagement.DAL
{
    public class AgencyClientInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AgencyClientContext>
    {

        protected override void Seed(AgencyClientContext context)
        {
            var agencies = new List<Agency>
            {
                new Agency{ AgencyName="First Country", City="Jackson", State="NJ" },
                new Agency{ AgencyName="Second State", City="Brick", State="NJ" }

            };
            agencies.ForEach(s => context.Agencies.Add(s));
            context.SaveChanges();
            
        }
    }
}