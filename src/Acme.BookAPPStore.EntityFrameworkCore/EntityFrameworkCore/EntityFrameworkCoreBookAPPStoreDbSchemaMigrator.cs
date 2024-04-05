using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookAPPStore.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookAPPStore.EntityFrameworkCore;

public class EntityFrameworkCoreBookAPPStoreDbSchemaMigrator
    : IBookAPPStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookAPPStoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookAPPStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookAPPStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
