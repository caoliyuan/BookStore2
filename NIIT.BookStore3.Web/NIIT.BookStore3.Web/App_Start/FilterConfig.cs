﻿using System.Web;
using System.Web.Mvc;

namespace NIIT.BookStore3.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
