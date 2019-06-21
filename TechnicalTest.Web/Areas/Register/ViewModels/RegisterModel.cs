using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnicalTest.Web.Areas.Register.ViewModels
{
    public class RegisterModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmedPassword { get; set; }
        public bool IsActive { get; set; }
    }
}