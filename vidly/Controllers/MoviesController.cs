using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new List<Movie>()
            {
                new Movie() { Name = "movie1", Id = 1},
                new Movie() { Name = "movie2", Id = 1}
            };
            // return Content("hello wrlod");
            //  return HttpNotFound();
            // return RedirectToAction("Index", "Home", new {page = "1", sortBy = "name"});
            var customers = new List<Customer>
            {
                new Customer { Name = "customer1"},
                new Customer() { Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            
            //return View(movie);
            return View(viewModel);
        }
        [Route("movies/Details/{name}/{id}")]
        public ActionResult Details(string customer)
        {
            return Content(customer);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={1}&sortBy={0}", pageIndex, sortBy));
        }

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleasedDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        
    }


}