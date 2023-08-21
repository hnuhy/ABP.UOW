using Volo.Abp.Settings;

namespace ABP.UOW.Settings;

public class UOWSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(UOWSettings.MySetting1));
    }
}
