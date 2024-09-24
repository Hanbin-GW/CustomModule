using System.Collections.Generic;
using CustomModule.Item;
using Exiled.API.Enums;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Inventory;

namespace CustomModule.Roles.ShadowCaptain;

public class ShadowCaptainBehavior : RoleBehaviour
{
    protected override void PostInitialize()
    {
        base.PostInitialize();
    }

    protected override InventoryManager Inventory { get; } = new InventoryManager()
    {
        Items = new List<ItemType>()
        {
            ItemType.ArmorHeavy,
            ItemType.KeycardMTFCaptain,
            ItemType.GunE11SR,
            ItemType.Adrenaline,
            ItemType.Medkit,
            ItemType.Radio,
        },
        CustomItems = new List<object>()
        {
            CustomItemType.Raalmg,
        },
        AmmoBox = new Dictionary<AmmoType, ushort>()
        {
            { AmmoType.Nato556 ,120},
            { AmmoType.Nato762 ,150},
        }
    };
}