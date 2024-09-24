using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using PlayerRoles;

namespace CustomModule.Roles.SerpentsHand;
[ModuleIdentifier]
public class SerpentsHand : CustomRole<SerpentsHandBehavior>
{
    public override string Name { get; set; } = "SerpentsHand";
    public override Type BehaviourComponent { get; } = typeof(SerpentsHandBehavior);
    public override uint Id { get; set; } = CustomRoleType.SerpentsHand;
    public override bool IsEnabled { get; set; } = true;
    public override RoleTypeId Role { get; set; } = RoleTypeId.Tutorial;
    public override ModulePointer Config { get; set; } = new SerpentsHandConfig();
    public override int Probability { get; set; } = 100;
    public override int MaxInstances { get; set; } = 8;
    public override PlayerRoles.Team[] TeamsOwnership { get; set; } = new[] { PlayerRoles.Team.SCPs };

    public override RoleSettings Settings { get; set; } = new RoleSettings()
    {
        CustomInfo = "Serpents Hand",
        MaxHealth = 130,
        Health = 130,
        MaxArtificialHealth = 30,
        UniqueRole = RoleTypeId.Tutorial,
        SpawnedText = new TextDisplay("당신은 뱀의손 요원입니다!.", 10, channel: TextChannelType.Broadcast),
        PreservePosition = true,
        PreserveInventory = false,
        CanActivateWarhead = true,
        CanBypassCheckpoints = false,
        CanActivateGenerators = true,
        CanPlaceBlood = true,
        CanBeHurtByScps = false,
        CanHurtScps = false,
        CanBeHandcuffed = true,
        DoesLookingAffectScp096 = false,
        DoesLookingAffectScp173 = false,
        SpawnProperties = new SpawnProperties()
        {
            DynamicSpawnPoints = new List<DynamicSpawnPoint>()
            {
                new DynamicSpawnPoint()
                {
                    Location = SpawnLocationType.InsideEscapePrimary ,
                    Chance = 100,
                }
            }
        }
    };


}