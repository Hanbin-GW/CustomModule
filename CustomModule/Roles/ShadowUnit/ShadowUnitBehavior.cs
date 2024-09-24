using System.Collections.Generic;
using CustomModule.Item;
using CustomModule.Item.MORS;
using Exiled.API.Enums;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Inventory;

namespace CustomModule.Roles.ShadowUnit;

public class ShadowUnitBehavior : RoleBehaviour
{
    protected override void PostInitialize()
    {
        base.PostInitialize();
    }

    protected override InventoryManager Inventory { get; } = new InventoryManager()
    {
        Items = new List<ItemType>()
        {
            ItemType.ArmorCombat,
            ItemType.KeycardMTFOperative,
            ItemType.Medkit,
            ItemType.Radio,
            ItemType.GunCrossvec,
        },
        CustomItems = new List<object>()
        {
            new MORS(),
        },
        AmmoBox = new Dictionary<AmmoType, ushort>()
        {
            { AmmoType.Nato9 , 120},
            { AmmoType.Nato556 , 20},
        }
    };
}