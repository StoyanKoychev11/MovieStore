using MovieStore.Models.Responses;

namespace MovieStore.BL.Interface
{
    public interface IBlMovieService
    {
        List<FullMovieDetails> GetAllMovieDetails();
    }
}

