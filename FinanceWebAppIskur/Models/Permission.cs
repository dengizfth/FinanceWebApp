using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class Permission
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public bool Delete { get; set; }

        // Foreing Key :
        public int UserId { get; set; }
        public User user { get; set; }


    }
}