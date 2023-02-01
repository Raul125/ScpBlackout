namespace ScpBlackout
{
    using Exiled.API.Features;

    public class EventHandlers
    {
        private readonly MainPlugin plugin;
        public EventHandlers(MainPlugin plugin) 
        {
            this.plugin = plugin;
        }

        public void OnRoundStarted()
        {
            foreach (var roomType in plugin.Config.RoomsToBlackout)
            {
                var room = Room.Get(roomType);
                if (room is null)
                    continue;

                room.AreLightsOff = true;
            }
        }
    }
}
