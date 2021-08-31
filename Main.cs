using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace cuffedTK
{
    public class Main : Plugin<Config>
    {
        EventHandlers EventHandler;

        public override void OnEnabled()
        {
            base.OnEnabled();
            EventHandler = new EventHandlers();
            Player.Hurting += EventHandler.Hurting;

        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventHandler = null;
            Player.Hurting -= EventHandler.Hurting;
        }
    }
}
