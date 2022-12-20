using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisYonetimi.MVCUI.Models
{
    public class HomePageViewModel
    {
        public List<Slide> Slides { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }
    }
}