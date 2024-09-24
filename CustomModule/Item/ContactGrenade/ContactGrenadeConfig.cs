using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;

namespace CustomModule.Item.ContactGrenade
{
    [ModuleIdentifier]
    public class ContactGrenadeConfig : ModulePointer
    {
        public override uint Id { get; set; } = CustomItemType.ContectGrenade;
    }
}