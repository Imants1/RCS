namespace AdvertsWebApp.Migrations
{
    using AdvertsWebApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdvertsWebApp.Models.AdvertDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdvertsWebApp.Models.AdvertDb context)
        {
            Advert ad = new Advert();
            ad.AdvertId = 1;
            ad.Name = "BMW";
            ad.Text = "labs auto";
            ad.Price = 1234.56;
            ad.CreationTime = DateTime.Now;

            Advert homeAd = new Advert();
            homeAd.AdvertId = 2;
            homeAd.Name = "mâja";
            homeAd.Text = "liela mâja";
            homeAd.Price = 123456.78;
            homeAd.CreationTime = new DateTime(1999, 12, 31);

            context.Adverts.AddOrUpdate(ad);
            context.Adverts.AddOrUpdate(homeAd);// te liek to Adverts, ko modeïu failâ izveidojâm
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
