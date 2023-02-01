namespace ScpBlackout
{
    using Exiled.API.Enums;
    using Exiled.API.Interfaces;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config : IConfig
    {
        [Description("Whether or not to enable the plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not to enable plugin debug logs.")]
        public bool Debug { get; set; } = false;

        [Description("Delay after round start. https://discord.com/channels/656673194693885975/668962626780397569/1067899930859032706 to check roomtypes")]
        public List<RoomType> RoomsToBlackout { get; set; } = new()
        {
            RoomType.Lcz173,
            RoomType.Hcz049,
            RoomType.Hcz079,
            RoomType.Hcz939,
            RoomType.Hcz096,
            RoomType.Hcz106,
        };
    }
}
