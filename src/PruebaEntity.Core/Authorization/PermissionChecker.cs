using Abp.Authorization;
using PruebaEntity.Authorization.Roles;
using PruebaEntity.Authorization.Users;

namespace PruebaEntity.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
