using MovieStore.DL.DB;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
    }
}
