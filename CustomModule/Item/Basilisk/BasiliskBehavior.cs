using Exiled.CustomModules.API.Features.CustomItems.Items;
using Exiled.Events.EventArgs.Player;

namespace CustomModule.Item.Basilisk;

public class BasiliskBehavior : ItemBehaviour
{
    protected override void PostInitialize()
    {
        base.PostInitialize();
    }
    protected override void OnPickingUp(PickingUpItemEventArgs ev)
    {
        base.OnPickingUp(ev);
        //Log.ErrorWithContext("Test Item is being picked up.");
    }

    /// <inheritdoc/>
    protected override void OnAcquired(bool displayMessage = true)
    {
        base.OnAcquired(displayMessage);
        //Log.ErrorWithContext("Test Item is was picked up.");
    }

    /// <inheritdoc/>
    protected override void OnDropping(DroppingItemEventArgs ev)
    {
        base.OnDropping(ev);
        //Log.ErrorWithContext("Test Item is being dropped.");
    }
}