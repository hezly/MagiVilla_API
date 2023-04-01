using MagiVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace MagiVilla_VillaAPI.Repositories.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
