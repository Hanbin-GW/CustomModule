using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Generic;

namespace CustomModule.Roles.SerpentsHand;
[ModuleIdentifier]
public class SerpentsHandConfig : ModulePointer<CustomRole>
{
    public override uint Id { get; set; } = CustomRoleType.SerpentsHand;
}