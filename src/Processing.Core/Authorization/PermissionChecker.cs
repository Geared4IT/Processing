using Abp.Authorization;
using Processing.Authorization.Roles;
using Processing.Authorization.Users;

namespace Processing.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
