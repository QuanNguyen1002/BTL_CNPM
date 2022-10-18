using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BTL_CNPM.EntityFrameworkCore;
using BTL_CNPM.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BTL_CNPM.Web.Tests
{
    [DependsOn(
        typeof(BTL_CNPMWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class BTL_CNPMWebTestModule : AbpModule
    {
        public BTL_CNPMWebTestModule(BTL_CNPMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BTL_CNPMWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(BTL_CNPMWebMvcModule).Assembly);
        }
    }
}