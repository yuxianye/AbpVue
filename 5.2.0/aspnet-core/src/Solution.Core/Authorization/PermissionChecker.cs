using Abp.Authorization;
using Solution.Authorization.Roles;
using Solution.Authorization.Users;

namespace Solution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
