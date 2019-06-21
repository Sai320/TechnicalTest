using System.Web.Mvc;

namespace TechnicalTest.Web.Areas.Register
{
    public class RegisterAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Register";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Register_default",
                "Register/{controller}/{action}/{id}",
                new {controller="Register",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}