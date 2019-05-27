using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200397594_app2.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public String Index()
        {
            return "Hello from the Asp.NET lesson-1 Custom.View()";
        }

        //GET: /CUSTOM/DETAIL
        public String Browse(string param)
        {
            string message = HttpUtility.HtmlEncode("Custom.Browse, Param = " + param);
            return message;
        }
    }
}