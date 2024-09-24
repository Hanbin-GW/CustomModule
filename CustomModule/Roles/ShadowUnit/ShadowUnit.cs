using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using PlayerRoles;

namespace CustomModule.Roles.ShadowUnit;
[ModuleIdentifier]
public class ShadowUnit : CustomRole<ShadowUnitBehavior>
{
    public override uint Id { get; set; } = CustomRoleType.ShadowUnit;
    public override Type BehaviourComponent { get; } = typeof(ShadowUnitBehavior);
    public override ModulePointer Config { get; set; } = new ShadowUnitConfig();
    public override bool IsEnabled { get; set; } = true;
    public override RoleTypeId RequiredRoleToSpawn { get; set; } = RoleTypeId.NtfPrivate;
    public override string Name { get; set; } = "Shadow Unit";
    public override string Description { get; set; } = "Shadow Company PMC 의 용병입니다.";
    public override bool IsScp { get; set; } = false;
    public override int MaxInstances { get; set; } = 10;
    public override int Probability { get; set; } = 100;
    public override PlayerRoles.Team[] TeamsOwnership { get; set; } = new[] { PlayerRoles.Team.FoundationForces };

    public override RoleSettings Settings { get; set; } = new RoleSettings()
    {
        MaxHealth = 100,
        Health = 100,
        MaxArtificialHealth = 0,
        CustomInfo = "Chief Scientist",
        UseDefaultRoleOnly = true,
        UniqueRole = RoleTypeId.Scientist,
        SpawnedText = new TextDisplay("당신은 Shadow Company PMC 의 용병입니다.", 10,
            channel: TextChannelType.Broadcast),
        PreservePosition = false,
        PreserveInventory = false,
        CanActivateWarhead = true,
        CanBypassCheckpoints = false,
        CanActivateGenerators = true,
        CanPlaceBlood = true,
        CanBeHurtByScps = true,
        CanHurtScps = true,
        CanBeHandcuffed = true,
        DoesLookingAffectScp096 = true,
        DoesLookingAffectScp173 = true,
        SpawnProperties = new SpawnProperties()
        {
            RoleSpawnPoints = new List<RoleSpawnPoint>()
            {
                new RoleSpawnPoint()
                {
                    Role = RoleTypeId.Scientist,
                    Chance = 100,
                }
            }
        },
    };
}