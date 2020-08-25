using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeVee.Models;
using TreeVee.Services;

namespace TreeVee.WebMVC.Controllers
{
    [Authorize]
    public class ChannelController : Controller
    {
        // GET: Channel
        public ActionResult Index(string genreType)
        {
            var service = new ChannelService();
            var model = service.GetChannels();

            //ViewBag.FoodType = "beverages";

            if (genreType != null)
            {
                ViewBag.GenreType = genreType;
            }
            else
            {
                ViewBag.GenreType = "all";
            }

            switch (ViewBag.GenreType)
            {
                case "comedy":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Comedy);
                    break;
                case "food":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Food);
                    break;
                case "lifestyle":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Lifestyle);
                    break;
                case "movies":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Movies);
                    break;
                case "music":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Music);
                    break;
                case "nature":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Nature);
                    break;
                case "news":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.News);
                    break;
                case "sports":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Sports);
                    break;
                case "tech":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.Tech);
                    break;
                case "tv":
                    model = model.Where(e => e.ChannelGenre == TreeVee.Data.Genre.TV);
                    break;
                default:
                    break;
            }

            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChannelCreate model)
        {
            if (ModelState.IsValid)
            {
                var service = new ChannelService();
                service.CreateChannel(model);

                return RedirectToAction("Create");
            }

            return View(model);
        }

    }
}