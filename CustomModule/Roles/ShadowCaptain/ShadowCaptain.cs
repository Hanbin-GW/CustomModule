using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using PlayerRoles;

namespace CustomModule.Roles.ShadowCaptain;
[ModuleIdentifier]
public class ShadowCaptain : CustomRole<ShadowCaptainBehavior>
{
    public override uint Id { get; set; } = CustomRoleType.ShadowCaptain;
    public override string Name { get; set; } = "Shadow Company Captain";
    public override string Description { get; set; } = "당신은 쇄도우 컴패니 용병의 대장입니다.";
    public override Type BehaviourComponent { get; } = typeof(ShadowCaptainBehavior);
    public override ModulePointer Config { get; set; } = new ShadowCaptainConfig();
    public override int MaxInstances { get; set; } = 1;
    public override PlayerRoles.Team[] TeamsOwnership { get; set; } = new[] { PlayerRoles.Team.FoundationForces };
    public override RoleTypeId Role { get; set; } = RoleTypeId.NtfCaptain;
    public override int Probability { get; set; } = 100;
    public override bool IsEnabled { get; set; } = true;

    public override RoleSettings Settings { get; set; } = new RoleSettings()
    {
        MaxHealth = 120,
        Health = 120,
        MaxArtificialHealth = 0,
        CustomInfo = "Shadow Company Captain",
        UniqueRole = RoleTypeId.NtfCaptain,
        SpawnedText = new TextDisplay("당신은 쇄도우 컴패니 용병의 대장입니다.", 10, channel: TextChannelType.Broadcast),
        PreservePosition = true,
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
                    Role = RoleTypeId.NtfCaptain,
                    Chance = 100,
                }
            }
        },
    };

}