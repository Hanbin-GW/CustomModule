using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;

namespace CustomModule.Item.A7Pistol
{
    [ModuleIdentifier]
    public class A7PistolConfig : ModulePointer
    {
        public override uint Id { get; set; } = CustomItemType.A7Pistol;
    }
}