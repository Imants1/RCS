using AdvertsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;//MVC=models, view, controller

namespace AdvertsWebApp.Controllers
{
    public class HomeController : Controller//kontrolieris - loģika, funkcijas, kas izlemj, kāda weblapa jāatgriež lietotājam
    {//html - kods, kas nosaka kopējo lapas dizainu
     // GET: Home
        public HomeController()
        {
            adverts = new List<Advert>();

            Advert ad = new Advert();
            ad.AdvertId = 1;
            ad.Name = "BMW";
            ad.Text = "labs auto";
            ad.Price = 1234.56;
            ad.CreationTime = DateTime.Now;

            Advert homeAd = new Advert();
            homeAd.AdvertId = 2;
            homeAd.Name = "māja";
            homeAd.Text = "liela māja";
            homeAd.Price = 123456.78;
            homeAd.CreationTime = new DateTime(1999, 12, 31);

            adverts.Add(ad);
            adverts.Add(homeAd);
        }

        private List<Advert> adverts;
        public ActionResult Index() // ja izsauc lapu bez īpašiem parametriem - izsauc Index lapu
        {
            return View(adverts);//view - nodefinē, kā lapai jāizskatās
        }

        public ActionResult Advert(int advertId)
        {
            foreach (var ad in adverts)
            {
                if (ad.AdvertId == advertId)
                {
                    return View(ad);
                }
            }
            return View();

        }
    }
}