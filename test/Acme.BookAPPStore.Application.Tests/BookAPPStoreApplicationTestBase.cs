using Volo.Abp.Modularity;

namespace Acme.BookAPPStore;

public abstract class BookAPPStoreApplicationTestBase<TStartupModule> : BookAPPStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
