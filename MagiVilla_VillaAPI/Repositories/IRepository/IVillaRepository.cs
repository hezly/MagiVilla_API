using MagiVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagiVilla_VillaAPI.Repositories.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
