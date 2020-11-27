using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RealtimeChat.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// ハンドル名
        /// </summary>
        public string HandleName { get; set; }
    }
}
