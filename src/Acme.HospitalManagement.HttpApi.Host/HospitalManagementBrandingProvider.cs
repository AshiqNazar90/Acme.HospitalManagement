using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.HospitalManagement;

[Dependency(ReplaceServices = true)]
public class HospitalManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HospitalManagement";
}
