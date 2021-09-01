using JqueryTutorials.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryTutorials.Controllers
{
    public class HomeController : Controller
    {
        List<Sehir> sehirler = new List<Sehir> {
            new Sehir{ID=1,Name="İstanbul",UlkeID=1 },
            new Sehir{ID=2,Name="Ankara",UlkeID=1 },
            new Sehir{ID=3,Name="New Jersey",UlkeID=2 },
            new Sehir{ID=4,Name="Newyork",UlkeID=2 },
            new Sehir{ID=5,Name="Berlin",UlkeID=4 },
            new Sehir{ID=6,Name="Moskova",UlkeID=5 },
            new Sehir{ID=7,Name="Konya",UlkeID=1 },
            new Sehir{ID=8,Name="Antalya",UlkeID=1 },
            new Sehir{ID=9,Name="İzmir",UlkeID=1 },
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UlkeVer()
        {
            
            List<Ulke> ulkeler = new List<Ulke> { 
                new Ulke{ID=1,Code="U1",Name="Türkye" },
                new Ulke{ID=2,Code="U2",Name="ABD" },
                new Ulke{ID=3,Code="U3",Name="Çin" },
                new Ulke{ID=4,Code="U4",Name="Almanya" },
                new Ulke{ID=5,Code="U5",Name="Rusya" },
            };

            return Json(ulkeler);
        }

        public IActionResult SehirVer(int uID)
        {
            return Json(sehirler.Where(x=>x.UlkeID== uID));
        }
    }
}
