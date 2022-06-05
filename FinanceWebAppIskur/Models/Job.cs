using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class Job
    {

        public int Id { get; set; }

        public string UserJob { get; set; }

        public string WorkGroup { get; set; }

        public string WorkDepartmant { get; set; }

        public string PayMounth { get; set; }

        public string PayYears { get; set; }

        public bool Status { get; set; }

        public bool Delete { get; set; }




        // Foreing Key :

        public int UserId { get; set; }
        public User user { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}