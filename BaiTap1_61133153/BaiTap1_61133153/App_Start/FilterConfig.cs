﻿using System.Web;
using System.Web.Mvc;

namespace BaiTap1_61133153
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}