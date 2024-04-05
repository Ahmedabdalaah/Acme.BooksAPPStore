using Acme.BookAPPStore.Samples;
using Xunit;

namespace Acme.BookAPPStore.EntityFrameworkCore.Applications;

[Collection(BookAPPStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookAPPStoreEntityFrameworkCoreTestModule>
{

}
