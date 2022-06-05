using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class Package
    {
        public int Id { get; set; }

        public string NamePackage { get; set; }

        public string Description { get; set; }

        public DateTime StartPackage { get; set; }

        public DateTime EndPackage { get; set; }

        public bool Status { get; set; }
        public bool Delete { get; set; }


    }
}