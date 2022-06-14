using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class Campany
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Zip { get; set; }

        public string CostomerCode { get; set; }
        public string MounthGossRevenue { get; set; }
        public string YearGrossRevenue { get; set; }
        public string SubStation { get; set; }
        public string Personel { get; set; }



        public string Job { get; set; } // Branch , meslek , What do u doing for living ? 

        public bool Status { get; set; }

        public bool Delete { get; set; }



        public List<CreditCampany> CreditCampany { get; set; }
    }
}