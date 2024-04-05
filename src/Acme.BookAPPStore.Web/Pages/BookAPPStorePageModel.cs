using Acme.BookAPPStore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.BookAPPStore.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookAPPStorePageModel : AbpPageModel
{
    protected BookAPPStorePageModel()
    {
        LocalizationResourceType = typeof(BookAPPStoreResource);
    }
}
