using System;

namespace RealtimeChat.Shared
{
    public record Room
    {
        public Guid Id { get; init; }

        public string Name { get; init; }
    }
}
