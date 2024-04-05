using System.Threading.Tasks;

namespace Acme.BookAPPStore.Data;

public interface IBookAPPStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
