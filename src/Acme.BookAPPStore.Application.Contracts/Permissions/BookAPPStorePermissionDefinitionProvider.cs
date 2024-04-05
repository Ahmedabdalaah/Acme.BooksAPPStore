using Acme.BookAPPStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookAPPStore.Permissions;

public class BookAPPStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookAPPStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookAPPStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookAPPStoreResource>(name);
    }
}
