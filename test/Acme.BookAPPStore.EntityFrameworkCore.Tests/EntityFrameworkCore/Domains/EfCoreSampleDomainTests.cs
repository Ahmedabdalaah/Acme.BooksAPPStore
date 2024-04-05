using Acme.BookAPPStore.Samples;
using Xunit;

namespace Acme.BookAPPStore.EntityFrameworkCore.Domains;

[Collection(BookAPPStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookAPPStoreEntityFrameworkCoreTestModule>
{

}
