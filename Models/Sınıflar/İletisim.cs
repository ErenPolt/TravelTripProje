using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class İletisim
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string Mail { get; set; }
        public  string Subject { get; set; }
        public string Message { get; set; }
    }
}