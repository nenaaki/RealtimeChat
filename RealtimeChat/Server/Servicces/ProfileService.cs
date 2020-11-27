using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace RealtimeChat.Server.Servicces
{
    /// <summary>
    /// Blazor WebAssembly に全てのClaimを送信するための<see cref="I"/>
    /// </summary>
    public class ProfileService : IProfileService
    {
        public ProfileService()
        {
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            context.IssuedClaims.AddRange(context.Subject.Claims);
            return Task.CompletedTask;
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            return Task.CompletedTask;
        }
    }
}
