using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BTL_CNPM.Authorization;

namespace BTL_CNPM
{
    [DependsOn(
        typeof(BTL_CNPMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class BTL_CNPMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<BTL_CNPMAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(BTL_CNPMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
