using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Data.Models
{
    public class UserService
    {
        private UserManager<IdentityUser> userManager; 
        private AuthenticationStateProvider authenticationStateProvider;
        
        public UserService(UserManager<IdentityUser> userManager, AuthenticationStateProvider authenticationStateProvider)
        {
            this.userManager = userManager; 
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<IdentityUser> GetUser()
        {
            var authenticationState = await authenticationStateProvider.GetAuthenticationStateAsync();
            return  await userManager.GetUserAsync(authenticationState.User);
        }
    }
}
