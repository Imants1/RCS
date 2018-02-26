using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace AdvertsWebApp.Models
{
    public class Advert
    {
        public int AdvertId { get; set; }
        //ar DisplayName nosakām kā lauks jānosauc, to izmantos arī labelfor un validationfor funkcijas no html
        [DisplayName("Sludinājuma nosaukums")]// atribūts, kas raksturo lauku
        [StringLength(100, MinimumLength = 3 )]
        [Required(ErrorMessage = "Lauks {0} ir vajadzīgs")]
        public string Name { get; set; }

        [DisplayName("Sludinājuma teksts")]
        public string Text { get; set; }

        [DisplayName("Sludinājuma cena")]
        [Required]// noteikts, ka laukam jābūt obligāti
        public double Price { get; set; }

        public DateTime CreationTime { get; set; }

    }
}
