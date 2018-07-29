using Klir.TechChallenge.Domain.Entities;
using System.Collections.Generic;

namespace Klir.TechChallenge.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
    }
}
