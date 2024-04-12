using System.Collections.Generic;
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using Respawning;

namespace CustomEscapes
{
    public class EventHandler
    {
        public static void Escaping(EscapingEventArgs ev)
        {
            if (ev.Player.Role.Side == Side.ChaosInsurgency && ev.Player.IsCuffed)
            {
                ev.IsAllowed = true;
                ev.EscapeScenario = EscapeScenario.CuffedClassD;
                ev.RespawnTickets = new KeyValuePair<SpawnableTeamType, float>(SpawnableTeamType.NineTailedFox, 5);
                ev.NewRole = RoleTypeId.NtfSpecialist;
            } else if (ev.Player.Role.Side == Side.Mtf && ev.Player.IsCuffed)
            {
                ev.IsAllowed = true;
                ev.EscapeScenario = EscapeScenario.CuffedScientist;
                ev.RespawnTickets = new KeyValuePair<SpawnableTeamType, float>(SpawnableTeamType.ChaosInsurgency, 5);
                ev.NewRole = RoleTypeId.ChaosConscript;
            }
        }
    }
}