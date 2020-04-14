using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Solution.Controllers
{
    public abstract class SolutionControllerBase: AbpController
    {
        protected SolutionControllerBase()
        {
            LocalizationSourceName = SolutionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
