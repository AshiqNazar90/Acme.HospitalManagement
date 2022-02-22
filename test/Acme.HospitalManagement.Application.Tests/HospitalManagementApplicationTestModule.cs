using Volo.Abp.Modularity;

namespace Acme.HospitalManagement;

[DependsOn(
    typeof(HospitalManagementApplicationModule),
    typeof(HospitalManagementDomainTestModule)
    )]
public class HospitalManagementApplicationTestModule : AbpModule
{

}
