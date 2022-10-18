using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BTL_CNPM.Configuration;

namespace BTL_CNPM.Web.Host.Startup
{
    [DependsOn(
       typeof(BTL_CNPMWebCoreModule))]
    public class BTL_CNPMWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public BTL_CNPMWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BTL_CNPMWebHostModule).GetAssembly());
        }
    }
}
