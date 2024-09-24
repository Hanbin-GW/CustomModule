using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomModules.API.Enums;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.CustomItems.Items.Firearms;

namespace CustomModule.Item.A7Pistol
{
    [ModuleIdentifier]
    public class A7Pistol : CustomItem<A7PistolBehavior>
    {
        public override Type BehaviourComponent { get; } = typeof(A7PistolBehavior);
        public override uint Id { get; set; } = CustomItemType.A7Pistol;
        public override string Name { get; set; } = "A7-pistol";
        public override string Description { get; set; } = "A7 개조형 권총입니다 파쇠탄을 사용합니다.";
        public override ItemType ItemType { get; set; } = ItemType.GunA7;
        public override bool IsEnabled { get; set; } = true;
        public override ItemCategory ItemCategory { get; set; } = ItemCategory.Firearm;

        public override SettingsBase Settings { get; set; } = new FirearmSettings()
        {
            PickedUpText = new TextDisplay( "you picked up A7 pistol\n<color=green>A7 개조형 권총입니다 파쇠탄을 사용합니다.</color>",5,channel: TextChannelType.Broadcast,canBeDisplayed:true),
            MaxAmmo = 7,
            ClipSize = 7,
            FiringMode = FiringMode.SemiAutomatic,
            Damage = 65,
            SelectedText = new TextDisplay( "you picked up A7 pistol\n<color=green>A7 개조형 권총입니다 파쇠탄을 사용합니다.</color>",5,channel: TextChannelType.Hint,canBeDisplayed:true),
        };
    }
}