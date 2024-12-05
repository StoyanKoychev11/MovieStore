using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface MovieService
    {
        List<Movie> GetMovies();
        void AddMovie(Movie movie);
        void DeleteMovie(int id);
        Movie? GetMoviesById(int id);
    }
}
