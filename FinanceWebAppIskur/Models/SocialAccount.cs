using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceWebAppIskur.Models
{
    public class SocialAccount
    {



        public int Id { get; set; }

        public string Username { get; set; }

        public string Url { get; set; }

        public string WebSiteName { get; set; }

        public string Icon { get; set; }       


        public bool Status { get; set; }
        public bool Delete { get; set; }




        // Foreing Key :

        public int UserId { get; set; }
        public User user { get; set; }

    }
}