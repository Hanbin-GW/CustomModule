using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.Generic;

namespace CustomModule.Item.MORS
{
    [ModuleIdentifier]
    public class MORSConfig : ModulePointer<CustomItem>
    {
        public override uint Id { get; set; } = CustomItemType.Mors;
    }
}