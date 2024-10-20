using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string imageUrl { get; set;}
        public string Description { get; set;}
    }
}