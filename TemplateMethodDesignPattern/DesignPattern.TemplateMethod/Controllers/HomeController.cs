using DesignPattern.TemplateMethod.Models;
using DesignPattern.TemplateMethod.TemplateMethod;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class HomeController : Controller
    {       
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlans();
            ViewBag.planType = netflixPlans.PlanType("Temel Plan");
            ViewBag.price = netflixPlans.Price(75);
            ViewBag.personCount = netflixPlans.PersonCount(1);
            ViewBag.content = netflixPlans.Content("Film-Dizi");
            ViewBag.resolution = netflixPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandardPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlans();
            ViewBag.planType = netflixPlans.PlanType("Standart Plan");
            ViewBag.price = netflixPlans.Price(100);
            ViewBag.personCount = netflixPlans.PersonCount(2);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Belgesel");
            ViewBag.resolution = netflixPlans.Resolution("720px");
            return View();
        }
        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlans();
            ViewBag.planType = netflixPlans.PlanType("Ultra Plan");
            ViewBag.price = netflixPlans.Price(150);
            ViewBag.personCount = netflixPlans.PersonCount(5);
            ViewBag.content = netflixPlans.Content("Film-Dizi-Belgesel-Animasyon");
            ViewBag.resolution = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
