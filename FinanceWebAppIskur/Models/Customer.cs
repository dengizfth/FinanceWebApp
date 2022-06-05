using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }
        
        public string Zip { get; set; }
        
        public string CostomerCode { get; set; }



        public bool Status { get; set; }

        public bool Delete { get; set; }





        // List
        public List<Job> Job { get; set; }
    }
}