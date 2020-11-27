using System;
using System.Collections.Generic;

namespace RealtimeChat.Server.Models
{
    public class Room : IHasDateTime
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public List<Post> Posts { get; set; }

        public List<UserRoomAccessInfo> UserRoomAccessInfos { get; set; }
    }
}
