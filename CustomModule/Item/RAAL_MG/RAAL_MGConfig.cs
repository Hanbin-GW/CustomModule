using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;

namespace CustomModule.Item.RAAL_MG
{
    [ModuleIdentifier]
    public class RAAL_MGConfig : ModulePointer
    {
        public override uint Id { get; set; } = CustomItemType.Raalmg;
    }
}