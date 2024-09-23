using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.CustomModules.API.Features.CustomRoles;
using Exiled.CustomModules.API.Features.Inventory;

namespace CustomModule.Roles.ChiefScientist
{
    public class ChiefScientistBehavior : RoleBehaviour
    {
        protected override void PostInitialize()
        {
            base.PostInitialize();
        }

        protected override InventoryManager Inventory { get; } = new InventoryManager()
        {
            Items = new List<ItemType>
            {
                ItemType.KeycardFacilityManager,
                ItemType.Medkit,
                ItemType.GunRevolver,
            },
            AmmoBox = new Dictionary<AmmoType, ushort>()
            {
                { AmmoType.Ammo44Cal ,6},
            }
        };
    }
}