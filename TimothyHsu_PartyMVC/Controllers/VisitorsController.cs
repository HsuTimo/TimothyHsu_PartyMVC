using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimothyHsu_PartyMVC.Models;

namespace TimothyHsu_PartyMVC.Controllers
{
    public class VisitorsController : Controller
    {
        public IActionResult Index()
        {
            TempData["ListLength"] = 0;
            var list = new List<Visitor>();
            TempData["List"] = JsonConvert.SerializeObject(list);
            return View("Input");
        }
        [HttpGet]
        public IActionResult Input()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Input(Visitor visitor)
        {
            var list = JsonConvert.DeserializeObject<List<Visitor>>((string)TempData.Peek("List"));
            list.Add(visitor);
            TempData["ListLength"] = list.Count;
            TempData["List"] = JsonConvert.SerializeObject(list);
            return View();
        }
        public IActionResult Summary()
        {
            var list = JsonConvert.DeserializeObject<List<Visitor>>((string)TempData.Peek("List"));
            TempData["TotalGuests"] = list.Count;
            TempData["TotalFamily"] = list.Where(x => x.IsFamily).ToList().Count;
            int youngestAge = list[0].Age;
            foreach (var item in list)
            {
                if (item.Age<youngestAge)
                {
                    youngestAge = item.Age;
                }
            }
            int oldestAge = list[0].Age;
            foreach (var item in list)
            {
                if (item.Age > oldestAge)
                {
                    oldestAge = item.Age;
                }
            }
            TempData["YoungestAge"] = youngestAge;
            TempData["OldestAge"] = oldestAge;
            return View();
        }
    }
}
