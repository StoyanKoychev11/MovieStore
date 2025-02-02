using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories.MongoDb
{
    internal class ActorRepository : IActorRepository
    {
        public List<Actor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Actor? GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
