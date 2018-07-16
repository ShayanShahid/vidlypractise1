using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{

    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            
              var movie = new Movie() {Name ="Shayan" };

            return View(movie);
        }
        [Route("movies/Edit/id")]
        public ActionResult Edit(int id)
        {
            return Content("id is equal to" + id);
        }
        public ActionResult Index(int? PageIndex, String Sortby)
        {
            if (!PageIndex.HasValue)
                PageIndex = 1;
            if (String.IsNullOrWhiteSpace(Sortby))
                Sortby = "Name";
            return Content(String.Format("pageindex={0}&sortby={1}", PageIndex, Sortby));
        }
        [Route ("movies/ByReleaseDate/{year:regex(\\d{4})}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year +"heello"+month);
        }
            
        } 
      
    }
