using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.HospitalManagement.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.HospitalManagement.EntityFrameworkCore;

public class EntityFrameworkCoreHospitalManagementDbSchemaMigrator
    : IHospitalManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHospitalManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HospitalManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HospitalManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
