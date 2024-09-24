using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Generic;

namespace CustomModule.Roles.ShadowUnit;
[ModuleIdentifier]
public class ShadowUnitConfig : ModulePointer<CustomRole>
{
    public override uint Id { get; set; } = CustomRoleType.ShadowUnit;
}