using System;

namespace RealtimeChat.Shared
{
    public class Message
    {
        public Guid RoomId { get; init; }

        public Guid ThreadId { get; init; }

        public Guid UserId { get; init; }

        public string UserName { get; init; }

        public string Text { get; init; }
    }
}
