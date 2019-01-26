using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
	public class MoviesController : Controller
	{
		// GET: Movies
		public ActionResult Index()
		{
			return View(GetMovies());
		}

		public List<Movie> GetMovies()
		{
			List<Movie> movies = new List<Movie>
			{
				new Movie {Id = 1, Name = "Grinch"},
				new Movie {Id = 2, Name = "Ralph breakes the internet"}
			};

			return movies;
		}
	}
}