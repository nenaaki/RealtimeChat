using System;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RealtimeChat.Server.Models;

namespace RealtimeChat.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Thread> Thread { get; set; }

        public DbSet<UserRoomAccessInfo> UserRoomAccessInfos { get; set; }

        public DbSet<UserThreadAccessInfo> UserThreadAccessInfos { get; set; }

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Room>().HasData(
                new Room[]
                {
                    new Room{ Id = Guid.NewGuid(), Name = "Random" }

                });
        }
    }
}
