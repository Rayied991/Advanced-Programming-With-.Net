﻿using System.Web;
using System.Web.Mvc;

namespace View_Controller_Create
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
