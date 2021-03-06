﻿using System.Web;
using System.Web.Mvc;

namespace Vidli
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //set authourize attr. globally
            filters.Add(new AuthorizeAttribute());

            //for ssl secure channel
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
