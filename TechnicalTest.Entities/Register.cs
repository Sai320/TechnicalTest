using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.Entities
{
   public class Register
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string  City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public bool IsActive { get; set; }
    }
}
