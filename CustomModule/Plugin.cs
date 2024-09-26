using System;
using CustomModule.Roles;
using Exiled.API.Features;
using Exiled.CustomModules.API.Features;
using Exiled.CustomModules.API.Features.CustomRoles;

namespace CustomModule
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Custom Module Ghost";
        public override Version Version { get; } = new Version(0, 1, 4);
        public override string Author { get; } = "Hanbin-GW";

        private void OnRoundStarted()
        {
            try
            {
                Map.Broadcast(5,"<size=38><color=#a503fc>👻- 라운드가 시작되었습니다 -👻</color></size>\n<size=35><color=red>Good Luck For Your Survive...</color></size>");
                Cassie.MessageTranslated(
                    message: "Attention Containment breach detected", 
                    isSubtitles: true,
                    translation: "Attention <color=red>Containment breach</color> detected",
                    isNoisy: true
                );

                var hostPlayer = Server.Host;
                if (hostPlayer == null)
                {
                    Log.Error("Server host player not found.");
                    return;
                }

                Pawn pawn = hostPlayer.Cast<Pawn>();
                if (pawn == null)
                {
                    Log.Error("Failed to cast Server.Host to Pawn.");
                    return;
                }
                
                CustomRole.Get(CustomRoleType.O5Administrtor).Spawn(Player.Get(2).Cast<Pawn>(),force:true); 
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred in OnRoundStarted: {ex.StackTrace}");
            }
        }
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
            base.OnDisabled();
        }
    }
}