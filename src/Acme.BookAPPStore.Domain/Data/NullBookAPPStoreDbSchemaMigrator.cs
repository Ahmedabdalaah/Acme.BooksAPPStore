using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookAPPStore.Data;

/* This is used if database provider does't define
 * IBookAPPStoreDbSchemaMigrator implementation.
 */
public class NullBookAPPStoreDbSchemaMigrator : IBookAPPStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
