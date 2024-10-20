using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Yorumlar
    {
        [Key]
        public int Id { get; set; }
        public string userName { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}