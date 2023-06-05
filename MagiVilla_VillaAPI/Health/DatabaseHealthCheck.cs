using MagiVilla_VillaAPI.Repositories.IRepository;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MagiVilla_VillaAPI.Health
{
    public class DatabaseHealthCheck : IHealthCheck
    {
        private readonly IVillaRepository _dbVilla;
        private readonly IVillaNumberRepository _dbVillaNumber;

        public DatabaseHealthCheck(IVillaRepository dbVilla, IVillaNumberRepository dbVillaNumber)
        {
            _dbVilla = dbVilla;
            _dbVillaNumber = dbVillaNumber;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var villaList = await _dbVilla.GetAsync();
                var villa = await _dbVillaNumber.GetAsync();
                return HealthCheckResult.Healthy();
            }
            catch (Exception e)
            {
                return HealthCheckResult.Unhealthy(exception: e);
            }
        }
    }
}
