using Acme.BookAPPStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookAPPStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookAPPStoreController : AbpControllerBase
{
    protected BookAPPStoreController()
    {
        LocalizationResource = typeof(BookAPPStoreResource);
    }
}
