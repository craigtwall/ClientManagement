using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientManagement.Models
{
    public class Agency
    {
        public int ID { get; set; }
        public string AgencyName { get; set; }
        public string City { get; set; }
        public string State { get; set; }


        public virtual ICollection<Client> Clients { get; set; } 
    }
}