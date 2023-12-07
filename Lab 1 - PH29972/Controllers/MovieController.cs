using Lab_1___PH29972.IServices;
using Lab_1___PH29972.Models;
using Lab_1___PH29972.Services;
using Lab_1___PH29972.ViewModel;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1___PH29972.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieSer _movieSer;
        public MovieController(IMovieSer movieSer)
        {
            _movieSer = movieSer;
        }
        public IActionResult Index()
        {
            List<MovieDetail> list = new List<MovieDetail>();
            foreach (var item in _movieSer.GetListMovie())
            {
                list.Add(new MovieDetail()
                {
                    movie = item,
                    Status = item.Rating < 3 ? "Bad" : item.Rating >= 3 && item.Rating <= 4 ? "Avarage" : "Good"
                });
            }
            return View(list);
        }
        public IActionResult Add()
        {
            return View("AddMovie");
        }

        [HttpPost]
        public IActionResult AddMovie(string Name, string Description, string Rating)
        {
            try
            {
                Movie movie = new Movie() { Name = Name, Description = Description, Rating = Convert.ToInt32(Rating) };
                _movieSer.AddMovie(movie);
                return RedirectToAction("Index", "Movie");
            }
            catch (Exception)
            {
                return View("AddMovie");
            }
        }
    }
}
