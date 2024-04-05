using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookAPPStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookAPPStore;

/* Inherit your application services from this class.
 */
public abstract class BookAPPStoreAppService : ApplicationService
{
    protected BookAPPStoreAppService()
    {
        LocalizationResource = typeof(BookAPPStoreResource);
    }
}
