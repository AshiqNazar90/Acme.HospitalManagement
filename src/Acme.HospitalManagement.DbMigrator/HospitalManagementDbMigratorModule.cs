using Acme.HospitalManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Acme.HospitalManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HospitalManagementEntityFrameworkCoreModule),
    typeof(HospitalManagementApplicationContractsModule)
    )]
public class HospitalManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
