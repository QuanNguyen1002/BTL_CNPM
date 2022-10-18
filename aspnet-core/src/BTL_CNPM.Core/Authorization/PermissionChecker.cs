using Abp.Authorization;
using BTL_CNPM.Authorization.Roles;
using BTL_CNPM.Authorization.Users;

namespace BTL_CNPM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
