using AdvertsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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


        private AdvertDb advertDb;
        public ActionResult Index() // ja izsauc lapu bez īpašiem parametriem - izsauc Index lapu
        {
            return View(advertDb.Adverts.ToList());//view - nodefinē, kā lapai jāizskatās
        }

        public ActionResult Advert(int advertId)
        {

            Advert ad = GetAdvertFromDb(advertId);
            return View(ad);

        }

        private Advert GetAdvertFromDb(int advertId)
        {

            foreach (var ad in advertDb.Adverts)
            {
                if (ad.AdvertId == advertId)
                {
                    return ad;
                }

            }
            return null;
        }

        public ActionResult CreateAdvert()
        {
            return View();// ja šeit neko nenorāda, uzskata, ka jāatgriež skats ar nosaukumu, kā funkcijai
            //ja grib var norādīt konkrētu view, ko izvadīt
        }

        // http methods!!!
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
        public ActionResult EditAdvert(int advertId)
        {
            Advert editableAdvert = GetAdvertFromDb(advertId);
            return View(editableAdvert);

        }
        [HttpPost]
        public ActionResult EditAdvert(Advert advert)
        {
            if (!ModelState.IsValid)
            {
                View(advert);
            }
            advertDb.Entry(advert).State = EntityState.Modified;
            advertDb.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}// izdarot izmaiņas aplikācijā - Package Manager Console jāievada add-migration "kautkāds nosaukums", pēc tam update-database