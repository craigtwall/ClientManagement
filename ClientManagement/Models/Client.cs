using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientManagement.Models
{
    public class Client
    {
        public int ID { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        // Can specify how the name should be shown on-screen
        public string Alias { get; set; }
        public int AgencyID { get; set; }

        // Holds the info relating to the agency this client is part of
        public virtual Agency Agency { get; set; }
    }
}