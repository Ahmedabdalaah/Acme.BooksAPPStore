using Xunit;

namespace Acme.BookAPPStore.EntityFrameworkCore;

[CollectionDefinition(BookAPPStoreTestConsts.CollectionDefinitionName)]
public class BookAPPStoreEntityFrameworkCoreCollection : ICollectionFixture<BookAPPStoreEntityFrameworkCoreFixture>
{

}
