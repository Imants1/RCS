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
            advertDb = new AdvertDb();    //izsauc konstruktoru, kas uztaisa datubāzi      
        }

        private List<Advert> adverts;
        private AdvertDb advertDb;
        public ActionResult Index() // ja izsauc lapu bez īpašiem parametriem - izsauc Index lapu
        {
            return View(advertDb.Adverts.ToList());//view - nodefinē, kā lapai jāizskatās
        }

        public ActionResult Advert(int advertId)
        {
            foreach (var ad in advertDb.Adverts)
            {
                if (ad.AdvertId == advertId)
                {
                    return View(ad);
                }
            }
            return View();

        }

        public ActionResult CreateAdvert()
        {
            return View();
        }
        // GET metode - iegūst datus no servera
        // POST metode - nosūta datus serverim. tā datus no formas var nosūtīt serverim
        [HttpPost] // automātiski uzskata GET, ja grib POST - jānorāda
        public ActionResult CreateAdvert(Advert advert)
        {
            advert.CreationTime = DateTime.Now;
            advertDb.Adverts.Add(advert);
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}