using System;

namespace RealtimeChat.Server.Models
{
    public interface IHasDateTime
    {
        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }

    public static class HasDateTimeExtensions
    {
        public static void OnCreated(this IHasDateTime source)
        {
            source.UpdatedDateTime = source.CreatedDateTime = DateTime.Now;
        }

        public static void OnUpdated(this IHasDateTime source)
        {
            source.UpdatedDateTime = DateTime.Now;
        }
    }

}
