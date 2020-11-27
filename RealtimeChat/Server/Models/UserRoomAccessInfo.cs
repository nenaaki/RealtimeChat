using System;

namespace RealtimeChat.Server.Models
{
    public class UserRoomAccessInfo
    {
        public Guid Id { get; set; }

        public ApplicationUser User { get; set; }

        public Room Room { get; set; }

        public DateTime LastAccessTime { get; set; }
    }
}
