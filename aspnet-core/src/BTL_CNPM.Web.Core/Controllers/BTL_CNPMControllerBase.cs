using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BTL_CNPM.Controllers
{
    public abstract class BTL_CNPMControllerBase: AbpController
    {
        protected BTL_CNPMControllerBase()
        {
            LocalizationSourceName = BTL_CNPMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
