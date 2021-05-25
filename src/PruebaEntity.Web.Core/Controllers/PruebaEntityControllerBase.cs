using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PruebaEntity.Controllers
{
    public abstract class PruebaEntityControllerBase: AbpController
    {
        protected PruebaEntityControllerBase()
        {
            LocalizationSourceName = PruebaEntityConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
