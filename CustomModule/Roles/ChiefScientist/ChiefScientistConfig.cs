using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Generic;

namespace CustomModule.Roles.ChiefScientist
{
    [ModuleIdentifier]
    public class ChiefScientistConfig : ModulePointer<CustomRole>
    {
        public override uint Id { get; set; } = CustomRoleType.O5Administrtor;
    }
}