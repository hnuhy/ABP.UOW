using ABP.UOW.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABP.UOW.Permissions;

public class UOWPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(UOWPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(UOWPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<UOWResource>(name);
    }
}
