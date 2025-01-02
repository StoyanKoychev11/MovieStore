using MovieStore.Models.DTO;

namespace MovieStoreB.DL.Interfaces
{
    public interface IActorRepository
    {
        Actor? GetById(string id);
    }
}
