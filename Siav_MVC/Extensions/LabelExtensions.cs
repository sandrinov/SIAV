using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Siav_MVC.Extensions
{
    public static class MyExtensions
    {
        public static MvcHtmlString MyMethod(this HtmlHelper helper, string target, string text)
        {
            string s = String.Format("<label for='{0}'>{1}</label>", target, text);
            return new MvcHtmlString(s);
        }
    }
}