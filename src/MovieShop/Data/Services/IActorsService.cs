using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieShop.Models;

namespace MovieShop.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAll(); 
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor actor);
        void Delete(int id);
    }
}