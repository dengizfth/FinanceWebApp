using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class User
    {

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string Address { get; set; }

        public string Password { get; set; }

        public string Departman { get; set; }

        public bool Status { get; set; }

        public bool Delete { get; set; }




        // Lists

        public List<Job> Job { get; set; }
        public List<SocialAccount> SocialAccount { get; set; }
        public List<Permission> Permission { get; set; }




    }
}