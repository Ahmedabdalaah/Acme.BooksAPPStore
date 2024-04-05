using Volo.Abp.Settings;

namespace Acme.BookAPPStore.Settings;

public class BookAPPStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BookAPPStoreSettings.MySetting1));
    }
}
