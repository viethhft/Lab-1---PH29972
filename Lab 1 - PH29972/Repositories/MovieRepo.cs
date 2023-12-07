using Lab_1___PH29972.Context;
using Lab_1___PH29972.IRepositories;
using Lab_1___PH29972.Models;

namespace Lab_1___PH29972.Repositories
{
    public class MovieRepo : IMovieRepo
    {
        private readonly MyDBContext _myDBContext;
        public MovieRepo(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
        }
        public bool AddMovie(Movie movie)
        {
            try
            {
                _myDBContext.Add(movie);
                _myDBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public IEnumerable<Movie> GetListMovie()
        {
            return _myDBContext.movies.ToList();
        }
    }
}
