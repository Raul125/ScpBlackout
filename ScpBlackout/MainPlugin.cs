namespace ScpBlackout
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using System;

    public class MainPlugin : Plugin<Config>
    {
        public override string Name => "ScpBlackout";
        public override string Author => "Raul125";
        public override Version Version => new(1, 0, 0);
        public override Version RequiredExiledVersion => new(6, 0, 0);
        public override PluginPriority Priority => PluginPriority.Default;

        public static EventHandlers Handlers;

        public override void OnEnabled()
        {
            Handlers = new(this);

            Exiled.Events.Handlers.Server.RoundStarted += Handlers.OnRoundStarted;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= Handlers.OnRoundStarted;

            Handlers = null;

            base.OnDisabled();
        }
    }
}
