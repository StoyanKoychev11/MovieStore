using MovieStoreB.Models.DTO;

namespace MovieStoreB.BL.Interface
{
    public interface IMovieService
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(string id);

        Movie? GetMoviesById(string id);
    }
}
