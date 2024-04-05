using Volo.Abp.Modularity;

namespace Acme.BookAPPStore;

/* Inherit from this class for your domain layer tests. */
public abstract class BookAPPStoreDomainTestBase<TStartupModule> : BookAPPStoreTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
