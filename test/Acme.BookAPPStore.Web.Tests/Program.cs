using Microsoft.AspNetCore.Builder;
using Acme.BookAPPStore;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<BookAPPStoreWebTestModule>();

public partial class Program
{
}
