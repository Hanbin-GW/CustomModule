using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomModules.API.Enums;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomItems;
using Exiled.CustomModules.API.Features.CustomItems.Items.Firearms;
using InventorySystem.Items.Firearms.Attachments;

namespace CustomModule.Item.MORS
{
    [ModuleIdentifier]
    public class MORS : CustomItem<MORSBehaviour>
    {
        public override Type BehaviourComponent { get; } = typeof(MORSBehaviour);
        public override uint Id { get; set; } = CustomItemType.Mors;  // 커스텀 아이템의 고유 ID
        public override string Name { get; set; } = "MORS";  // 커스텀 아이템의 이름
        public override string Description { get; set; } = "Bolt action Railgun. Best in class handling.";  // 아이템 설명
        public override ItemType ItemType { get; set; } = ItemType.GunE11SR;  // 기본 아이템 유형
        public override bool IsEnabled { get; set; } = true;
        public override ItemCategory ItemCategory { get; set; } = ItemCategory.Firearm;
        public override SettingsBase Settings { get; set; } = new FirearmSettings()
        {
            Damage = 90,
            SpawnProperties = new SpawnProperties()
            {
                Limit = 1,
                DynamicSpawnPoints = new List<DynamicSpawnPoint>()
                {
                    new DynamicSpawnPoint()
                    {
                        Location = SpawnLocationType.InsideHczArmory,
                        Chance = 100,
                    }
                }
            }, 
            MaxAmmo = 1,
            ClipSize = 1,
            FiringMode = FiringMode.SemiAutomatic,
            PickedUpText = new TextDisplay($"You picked up MORS \n Bolt action Railgun. Best in class handling.",5, channel: TextChannelType.Broadcast),
            Attachments = new AttachmentName[]
            {
                AttachmentName.Foregrip,
                AttachmentName.HeavyStock,
                AttachmentName.ScopeSight,
            }
        };
    }
}