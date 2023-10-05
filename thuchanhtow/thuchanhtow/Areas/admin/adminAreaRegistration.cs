using System.Web.Mvc;

namespace thuchanhtow.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { Controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}