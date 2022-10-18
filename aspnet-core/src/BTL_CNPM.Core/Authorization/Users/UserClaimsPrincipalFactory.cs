using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using BTL_CNPM.Authorization.Roles;
using Abp.Domain.Uow;

namespace BTL_CNPM.Authorization.Users
{
    public class UserClaimsPrincipalFactory : AbpUserClaimsPrincipalFactory<User, Role>
    {
        public UserClaimsPrincipalFactory(
            UserManager userManager,
            RoleManager roleManager,
            IOptions<IdentityOptions> optionsAccessor,
            IUnitOfWorkManager unitOfWorkManager)
            : base(
                  userManager,
                  roleManager,
                  optionsAccessor,
                  unitOfWorkManager)
        {
        }
    }
}
