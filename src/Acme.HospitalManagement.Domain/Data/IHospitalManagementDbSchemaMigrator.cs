using System.Threading.Tasks;

namespace Acme.HospitalManagement.Data;

public interface IHospitalManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
