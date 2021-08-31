using Exiled.Events.EventArgs;

namespace cuffedTK
{
    class EventHandlers
    {
        public void Hurting(HurtingEventArgs ev)
        {
            if (ev.Target.IsCuffed && !ev.Attacker.IsScp) {
                ev.IsAllowed = false;
            }
        }
    }
}
