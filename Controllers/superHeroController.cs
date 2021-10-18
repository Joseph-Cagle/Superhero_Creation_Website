using Microsoft.AspNetCore.Mvc;
using superHero.Models;

namespace superHero.Controllers
{
    public class superHeroController : Controller
    {
        public IActionResult createAHero()
        {
            var model = new heroInfo();
            ViewBag.powers1 = model.powers1;
            ViewBag.powers2 = model.powers2;
            ViewBag.weakness = model.weakness;

            return View();
        }

        [HttpPost]
        public IActionResult createAHero(heroInfo info)
        {

            if (info.power1 == info.power2)
            {
                ModelState.AddModelError("", "Please make a unique selection for your powers");
            }



            if (ModelState.IsValid)
            {
                
                allHeros.AddHero(info);
               
                return View("thanks", info);
            }
            else
            {
               // recall order page
                var model = new heroInfo();

                ViewBag.powers1 = model.powers1;
                ViewBag.powers2 = model.powers2;
                ViewBag.weakness = model.weakness;
                //view bag passes in large items

                return View();
            }
        }

        public IActionResult showHeros()
        {
            return View(allHeros.ListOrders);
        }

        public IActionResult thanks()
        {
            return View();
        }
    }
}