using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FootballMarkets.Models;

namespace FootballMarkets.Controllers
{
    public class HomeController : Controller
    {
        private readonly MarketDbContext context;
        
        public HomeController(MarketDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var games = this.context.Games.ToList();
            return View(games);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }


        [HttpGet]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Game game)
        {
            this.context.Games.Add(game);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("winner/{id}")]
        public IActionResult Winner(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("winner/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult Winner(int id, Winner winner)
        {
            winner.GameId = id;
            this.context.Winners.Add(winner);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("exactScore/{id}")]
        public IActionResult ExactScore(int id)
        {
            return View();
        }

        [HttpPost]
        [Route("exactScore/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult ExactScore(int id, ExactScore exactScore)
        {
            this.context.ExactScores.Add(exactScore);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
