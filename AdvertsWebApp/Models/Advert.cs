using System;
using System.Web;

namespace AdvertsWebApp.Models
{
    public class Advert
    {
        public int AdvertId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public double Price { get; set; }
        public DateTime CreationTime { get; set; }

    }
}
