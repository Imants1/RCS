using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvertsWebApp.Models
{// veidojam datu bāzi
    public class AdvertDb : DbContext// tā aplikācija zina, ka šī ir datu bāze
    {
        public DbSet<Advert> Adverts { get; set; }
    }
}