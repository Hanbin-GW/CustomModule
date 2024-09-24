using CustomPlayerEffects;
using Exiled.CustomModules.API.Features.CustomItems.Items;
using Exiled.Events.EventArgs.Player;

namespace CustomModule.Item.RAAL_MG
{
    public class RAAL_MGBehavior : ItemBehaviour
    {
        private void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Attacker != null && ev.Player != null && ev.Attacker != ev.Player)
            {
                if (Check(ev.Attacker.CurrentItem))
                {
                    ev.Player.EnableEffect<Burned>(intensity:2,duration:5);
                }
            }
        }
        protected override void SubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Hurting += OnHurting;
            base.SubscribeEvents();
        }

        protected override void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Player.Hurting -= OnHurting;
            base.UnsubscribeEvents();
        }
    }
}