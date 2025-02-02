using MovieStore.Models.DTO;

namespace MovieStore.BL.Interface
{
    public interface IMovieService
    {
         List<Movie> GetAll();

        Movie? GetById(string id);

        void Add(Movie movie);

        void AddActorToMovie(string movieId, string actor);
    }
}
