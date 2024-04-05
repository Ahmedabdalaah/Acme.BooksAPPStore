using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.BookAPPStore.Pages;

public class Index_Tests : BookAPPStoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
