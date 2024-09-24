using System;
using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Spawn;
using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using PlayerRoles;

namespace CustomModule.Roles.ChiefScientist
{
    [ModuleIdentifier]
    public class ChiefScientist : CustomRole<ChiefScientistBehavior>
    {
        public override ModulePointer Config { get; set; } = new ChiefScientistConfig();
        public override Type BehaviourComponent { get; } = typeof(ChiefScientistBehavior);
        public override string Name { get; set; } = "Chief-Scientist";
        public override string Description { get; set; } = "당신은 SCP제단의 연구팀 대장입니다.";
        public override uint Id { get; set; } = CustomRoleType.O5Administrtor;
        public override int MaxInstances { get; set; } = 1;
        public override PlayerRoles.Team[] TeamsOwnership { get; set; } = new[] { PlayerRoles.Team.Scientists };
        public override RoleTypeId Role { get; set; } = RoleTypeId.Scientist;
        public override int Probability { get; set; } = 100;
        public override bool IsEnabled { get; set; } = true;
        public override RoleSettings Settings { get; set; } = new RoleSettings()
        {
            MaxHealth = 100,
            Health = 100,
            MaxArtificialHealth = 0,
            CustomInfo = "Chief Scientist",
            UseDefaultRoleOnly = true,
            UniqueRole = RoleTypeId.Scientist,
            SpawnedText = new TextDisplay("당신은 SCP제단의 <color=#42f2f5>연구팀 대장</color>입니다.\n검문소를 카드 없이 열수있습니다.", 10, channel: TextChannelType.Broadcast),
            PreservePosition = false,
            PreserveInventory = false,
            CanActivateWarhead = true,
            CanBypassCheckpoints = true,
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
}