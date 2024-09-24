using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.Generic;

namespace CustomModule.Item.Basilisk;
[ModuleIdentifier]
public class BasiliskConfig : ModulePointer<CustomItem>
{
    public override uint Id { get; set; } = CustomItemType.Basilisk;
}