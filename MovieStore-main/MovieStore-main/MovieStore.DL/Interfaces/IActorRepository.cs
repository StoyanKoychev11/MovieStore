using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    public interface IActorRepository
    {
        List<Actor> GetAll();

        Actor? GetById(string id);
    }
}
