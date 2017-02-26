using INFINITY.Core.Interfaces;
using INFINITY.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INFINITY.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMessageProvider _messageProvider;
        public HomeController(IMessageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        public HomeController():this(new MessageProvider())
        {

        }
        public ActionResult Index()
        {
            string message = _messageProvider.GetMessage();
            ViewData.Add("message", message);
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}