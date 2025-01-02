using MovieStore.Models.DTO;

namespace MovieStore.BL.Interface
{
    public interface IMovieService
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(string id);

        Movie? GetMoviesById(string id);
    }
}
