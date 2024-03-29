﻿using System.Web.Mvc;

namespace SiparisYonetimi.MVCUI.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller="Main", action = "Index", id = UrlParameter.Optional },
                new [] {"SiparisYonetimi.MVCUI.Areas.Admin.Controllers"}
            );
        }
    }
}