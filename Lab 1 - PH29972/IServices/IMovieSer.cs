using Lab_1___PH29972.Models;

namespace Lab_1___PH29972.IServices
{
    public interface IMovieSer
    {
        public IEnumerable<Movie> GetListMovie();

        public string AddMovie(Movie movie);
    }
}
