using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class CreditCustomer
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public float PercentChange { get; set; } // Faiz Oranı

        public double Valume { get; set; } // Kridi Büyüklüğü

        public string Description { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int StepPay { get; set; } // Taksit Adedi




        public bool Status { get; set; }

        public bool Delete { get; set; }




        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}