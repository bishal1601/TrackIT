using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace TrackIT.Data;

public class TrackITDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public TrackITDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        
        /* We intentionally resolving the TrackITDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TrackITDbContext>()
            .Database
            .MigrateAsync();

    }
}
