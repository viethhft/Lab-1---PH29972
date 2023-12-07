using Lab_1___PH29972.IRepositories;
using Lab_1___PH29972.IServices;
using Lab_1___PH29972.Models;

namespace Lab_1___PH29972.Services
{
    public class MovieSer : IMovieSer
    {
        private readonly IMovieRepo _movieRepo;
        public MovieSer(IMovieRepo movieRepo)
        {
            _movieRepo= movieRepo;
        }
        public string AddMovie(Movie movie)
        {
            if (_movieRepo.AddMovie(movie))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";

        }

        public IEnumerable<Movie> GetListMovie()
        {
           return _movieRepo.GetListMovie();
        }
    }
}
