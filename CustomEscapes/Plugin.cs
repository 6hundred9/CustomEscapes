using System;
using Exiled.API.Features;

namespace CustomEscapes
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "CustomEscapes";
        public override string Author => "6hundred9";
        public override string Prefix => "CE";
        public override Version RequiredExiledVersion => new Version(8, 8, 0);
        public override bool IgnoreRequiredVersionCheck => true;
        public static Plugin Instance;
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Escaping += EventHandler.Escaping;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Escaping -= EventHandler.Escaping;
            base.OnDisabled();
        }
    }
}