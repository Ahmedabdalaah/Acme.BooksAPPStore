using Volo.Abp.Modularity;

namespace Acme.BookAPPStore;

[DependsOn(
    typeof(BookAPPStoreApplicationModule),
    typeof(BookAPPStoreDomainTestModule)
)]
public class BookAPPStoreApplicationTestModule : AbpModule
{

}
