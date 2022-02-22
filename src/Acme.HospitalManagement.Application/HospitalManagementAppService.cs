using System;
using System.Collections.Generic;
using System.Text;
using Acme.HospitalManagement.Localization;
using Volo.Abp.Application.Services;

namespace Acme.HospitalManagement;

/* Inherit your application services from this class.
 */
public abstract class HospitalManagementAppService : ApplicationService
{
    protected HospitalManagementAppService()
    {
        LocalizationResource = typeof(HospitalManagementResource);
    }
}
