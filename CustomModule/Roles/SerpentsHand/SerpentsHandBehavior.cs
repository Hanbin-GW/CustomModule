using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Inventory;

namespace CustomModule.Roles.SerpentsHand;

public class SerpentsHandBehavior : RoleBehaviour
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
            ItemType.KeycardChaosInsurgency,
            ItemType.Radio,
            ItemType.GunCrossvec,
            ItemType.Jailbird,
            ItemType.Painkillers
        },
        AmmoBox = new Dictionary<AmmoType, ushort>()
        {
            { AmmoType.Nato9 ,120},
        }
    };
}