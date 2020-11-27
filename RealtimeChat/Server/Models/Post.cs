using System;

namespace RealtimeChat.Server.Models
{
    public class Post : IHasDateTime
    {
        public Guid Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Room Room { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}
