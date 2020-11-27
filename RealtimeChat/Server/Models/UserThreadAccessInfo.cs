using System;

namespace RealtimeChat.Server.Models
{
    public class UserThreadAccessInfo
    {
        public Guid Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public Thread Thread { get; set; }

        public DateTime LastAcessDateTime { get; set; }
    }
}
