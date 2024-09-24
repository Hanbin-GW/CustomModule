using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Generic;

namespace CustomModule.Roles.ShadowCaptain;

public class ShadowCaptainConfig : ModulePointer<CustomRole>
{
    public override uint Id { get; set; } = CustomRoleType.ShadowCaptain;
}