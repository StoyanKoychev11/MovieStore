using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();

        Movie? GetById(string id);

        void Add(Movie movie);

        void Update(Movie movie);
    }
}
