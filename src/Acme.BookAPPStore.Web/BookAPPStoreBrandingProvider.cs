﻿using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.BookAPPStore.Web;

[Dependency(ReplaceServices = true)]
public class BookAPPStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BookAPPStore";
}
