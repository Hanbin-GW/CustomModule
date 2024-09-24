using System.Collections.Generic;
using CustomModule.Roles;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.CustomModules.API.Features.CustomRoles;
using PlayerRoles;
using Respawning;

namespace CustomModule.Team.Team;

[ModuleIdentifier]
public class ShadowCompany : CustomTeam
{
    public override string Name { get; set; } = "Shadow Company";
    public override uint Id { get; set; } = CustomTeamType.Shadow;
    public override string DisplayColor { get; set; } = "#b3b3b3";
    public override string DisplayName { get; set; } = "Shadow Company";
    public override bool IsEnabled { get; set; } = true;
    public override int Size { get; set; } = 15;
    public override IEnumerable<uint> Units { get; set; } = new uint[] { CustomRoleType.ShadowCaptain, CustomRoleType.ShadowUnit };
    public override int Probability { get; set; } = 60;
    public override SpawnableTeamType[] SpawnableFromTeams { get; set; } = { SpawnableTeamType.NineTailedFox };
    public override bool UseTickets { get; set; } = true;
    public override uint Tickets { get; set; } = 3;
    public override RoleTypeId RequiredRoleToSpawn { get; set; } = RoleTypeId.NtfSergeant;
    public override PlayerRoles.Team[] TeamsOwnership { get; set; } = { PlayerRoles.Team.FoundationForces };
}