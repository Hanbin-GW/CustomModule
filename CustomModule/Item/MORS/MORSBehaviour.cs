using Exiled.CustomModules.API.Features.CustomItems.Items;
using Exiled.API.Features;
using Exiled.CustomModules.API.Features.Attributes;
using Exiled.Events.EventArgs.Player;
using PlayerStatsSystem;

namespace CustomModule.Item.MORS
{
    public class MORSBehaviour : ItemBehaviour
    {
        private float DamageMultiplier { get; set; } = 7.5f;

        private void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Attacker != ev.Player && ev.DamageHandler.Base is FirearmDamageHandler firearmDamageHandler && firearmDamageHandler.WeaponType == ev.Attacker.CurrentItem.Type)
                if(Check(ev.Attacker.CurrentItem))
                    ev.Amount *= DamageMultiplier;
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

        protected override void OnPickingUp(PickingUpItemEventArgs ev)
        {
            base.OnPickingUp(ev);

            Log.ErrorWithContext("Test Item is being picked up.");
        }

        /// <inheritdoc/>
        protected override void OnAcquired(bool displayMessage = true)
        {
            base.OnAcquired(displayMessage);
            Log.ErrorWithContext("Test Item is was picked up.");
        }

        /// <inheritdoc/>
        protected override void OnDropping(DroppingItemEventArgs ev)
        {
            base.OnDropping(ev);
            Log.ErrorWithContext("Test Item is being dropped.");
        }
    }
}