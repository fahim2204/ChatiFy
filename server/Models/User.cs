using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatiFy.Models
{
    public class User
    {
        public int userId { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public string status { get; set; }

    }
}
