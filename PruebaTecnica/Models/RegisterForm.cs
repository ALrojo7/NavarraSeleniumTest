using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavarraTrialWithSelenium.Models
{
    public class RegisterForm
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string DNI { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
        public string VerifiedPassword { get; set; }
    }
}
