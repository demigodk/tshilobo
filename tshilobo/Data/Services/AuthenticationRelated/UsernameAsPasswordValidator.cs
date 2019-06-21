using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace tshilobo.Areas.Identity.Services.AuthenticationRelated
{
    public class UsernameAsPasswordValidator<TUSer> : IPasswordValidator<TUSer> where TUSer : IdentityUser
    {
        public Task<IdentityResult> ValidateAsync(UserManager<TUSer> manager, TUSer user, string password)
        {
            if (string.Equals(user.UserName, password, StringComparison.OrdinalIgnoreCase))
            {
                return Task.FromResult(IdentityResult.Failed(new IdentityError
                {
                    Code = "UsernameAsPassword",
                    Description = "You cannot use your username as your password"
                }));                
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }    
}
