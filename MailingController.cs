using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            List<Mailing> mailings = AddMailings();
            return View(mailings.ToList());
        }

        private List<Mailing> AddMailings()
        {
            Mailing m = new Mailing();
            m.LastName = "Brown";
            m.FirstName = "Jerry";
            m.Email = "JBrown@gmail.com";

            Mailing m1 = new Mailing();
            m1.LastName = "Taylor";
            m1.FirstName = "Sue";
            m1.Email = "STaylor@gmail.com";

            Mailing m2 = new Mailing();
            m2.LastName = "Mason";
            m2.FirstName = "Tina";
            m2.Email = "TMason@gmail.com";

            Mailing m3 = new Mailing();
            m3.LastName = "Smith";
            m3.FirstName = "Steve";
            m3.Email = "SSmith@gmail.com";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m);
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return mailings;
           
        }
    }
}
