using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjekatPSA.Models;

namespace ProjekatPSA.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            Obuca obuca = new Obuca
            {
                Naziv = "Patike",
                Fotografija = "patike.jpg",
                Cena = 79.99,
                Popust = 15.0,
                Proizvodjac = "Nike",
                Rate = "4 stars",
                Opis = "Udobne patike za svaki dan",
                Ime = "Air Max 95",
                Velicina = "38",
                Materijal = "Koža",
                Boja = "Roze",
                Stil = "Sportski"
            };

            Odeca odeca = new Odeca
            {
                Naziv = "Majica",
                Fotografija = "majica.jpg",
                Cena = 19.99,
                Popust = 5.0,
                Proizvodjac = "Fashion Friends",
                Rate = "4.5 stars",
                Opis = "Pamucna majica za svaku priliku",
                Brend = "ZARA",
                Velicina = "M",
                Materijal = "Pamuk"
            };
           
            ViewBag.Obuca = obuca;
            ViewBag.Odeca = odeca;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

      



    }
    }