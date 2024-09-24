using System;
using CameraShaking;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.CustomItems.Items.Firearms;
using InventorySystem.Items.Firearms.Attachments;

namespace CustomModule.Item.RAAL_MG
{
    [ModuleIdentifier]
    public class RAAL_MG : CustomItem<RAAL_MGBehavior>
    {
        public override uint Id { get; set; } = CustomItemType.Raalmg;
        public override Type BehaviourComponent { get; } = typeof(RAAL_MGBehavior);
        public override bool IsEnabled { get; set; } = true;
        public override ItemType ItemType { get; set; } = ItemType.GunLogicer;
        public override string Name { get; set; } = "RAAL_MG";
        public override string Description { get; set; } = "소이탄 을 사용하는 경기관총";

        public override SettingsBase Settings { get; set; } = new FirearmSettings()
        {
            Attachments = new AttachmentName[]
            {
                AttachmentName.Foregrip,
                AttachmentName.AmmoSight,
                AttachmentName.MuzzleBrake,
            },
            RecoilSettings = new RecoilSettings()
            {
                ZAxis = 30,
                FovKick = 35,
                SideKick = 25
            },
            ClipSize = 75,
            AmmoType = ItemType.Ammo762x39,
            MaxAmmo = 75,
            Damage = 24.5f,
            PickedUpText = new TextDisplay("You picked up <color=red>RAAL MG</color>",10,channel: TextChannelType.Broadcast),
            SelectedText = new TextDisplay("You picked up <color=red>RAAL MG</color>",10,channel: TextChannelType.Hint)
            
        };
        public override ItemCategory ItemCategory { get; set; } = ItemCategory.Firearm;
    }
}