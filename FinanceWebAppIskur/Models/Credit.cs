using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class Credit
    {
        public int Id { get; set; }

        public string CreditName { get; set; }

        public string Amount { get; set; }

        public string Interest { get; set; }

        public int TotalMonth { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public bool Status { get; set; }

        public bool Delete { get; set; }


    }
}