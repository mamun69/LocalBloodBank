using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalBloodBank.Controllers
{
    public class DonationController : Controller
    {
        //
        // GET: /Donation/
        public ActionResult DonerList()
        {
            return View();
        }

        public ActionResult CreateDoner()
        {
            return View();
        }

        public ActionResult UpdateDoner()
        {
            return View();
        }

        public ActionResult DeleteDoner()
        {
            return View();
        }
	}
}