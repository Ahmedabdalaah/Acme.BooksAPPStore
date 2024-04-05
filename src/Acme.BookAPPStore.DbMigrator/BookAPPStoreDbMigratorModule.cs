using Acme.BookAPPStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookAPPStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookAPPStoreEntityFrameworkCoreModule),
    typeof(BookAPPStoreApplicationContractsModule)
    )]
public class BookAPPStoreDbMigratorModule : AbpModule
{
}
