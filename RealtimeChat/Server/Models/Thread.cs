using System;
using System.Collections.Generic;

namespace RealtimeChat.Server.Models
{
    public class Thread : IHasDateTime
    {
        public Guid Id { get; set; }

        public Guid PostId { get; set; }

        public Post Post { get; set; }

        public string Text { get; set; }

        /// <summary>
        /// 書き込んだユーザーへのナビゲーション
        /// </summary>
        public ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// 書き込んだユーザーのId
        /// </summary>
        public string ApplicationUserId { get; set; }

        /// <summary>
        /// アクセス者へのナビゲーション
        /// </summary>
        public List<UserThreadAccessInfo> UserThreadAccessInfos { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}
