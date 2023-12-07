using Lab_1___PH29972.Models;

namespace Lab_1___PH29972.IRepositories
{
    public interface IMovieRepo
    {
        public IEnumerable<Movie> GetListMovie();

        public bool AddMovie(Movie movie);
    }
}
