````c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Store.Index";
        }
        public string Browse(string g)
        {
            string msg = "g = " + g;
            return msg;
        }
        public string Details()
        {
            return "Hello from Store.Details";
        }
    }
}
