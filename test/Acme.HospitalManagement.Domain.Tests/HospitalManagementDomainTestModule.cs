using Acme.HospitalManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.HospitalManagement;

[DependsOn(
    typeof(HospitalManagementEntityFrameworkCoreTestModule)
    )]
public class HospitalManagementDomainTestModule : AbpModule
{

}
