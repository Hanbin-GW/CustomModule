using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.CustomItems.Items.Explosives;
using UnityEngine;

namespace CustomModule.Item.ContactGrenade
{
    [ModuleIdentifier]
    public class ContactGrenade : CustomItem<ContactGrenadeBehavior>
    {
        public override uint Id { get; set; } = CustomItemType.ContectGrenade;
        public override string Name { get; set; } = "Contact Grenade";
        public override string Description { get; set; } = "접촉시 폭발";  // 아이템 설명
        public override Type BehaviourComponent { get; } = typeof(ContactGrenadeBehavior);
        public override bool IsEnabled { get; set; } = false;
        public override ItemType ItemType { get; set; } = ItemType.GrenadeHE;
        public override SettingsBase Settings { get; set; } = new GrenadeSettings()
        {
            ExplodeOnCollision = true,
            FuseTime = 4,
            Weight = 3f,
            Scale = Vector3.one,
            PickedUpText = new TextDisplay($"당신은 Contact Grenade 를 획득하였습니다.\n대기시간은 4초이며 접촉시 폭벌합니다.",5,channel: TextChannelType.Broadcast)
        };
    }
}