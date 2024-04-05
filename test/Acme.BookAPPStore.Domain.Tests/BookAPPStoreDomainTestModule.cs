using Volo.Abp.Modularity;

namespace Acme.BookAPPStore;

[DependsOn(
    typeof(BookAPPStoreDomainModule),
    typeof(BookAPPStoreTestBaseModule)
)]
public class BookAPPStoreDomainTestModule : AbpModule
{

}
