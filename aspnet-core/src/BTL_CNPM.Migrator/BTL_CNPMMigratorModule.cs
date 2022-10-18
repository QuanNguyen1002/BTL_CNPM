using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using BTL_CNPM.Configuration;
using BTL_CNPM.EntityFrameworkCore;
using BTL_CNPM.Migrator.DependencyInjection;

namespace BTL_CNPM.Migrator
{
    [DependsOn(typeof(BTL_CNPMEntityFrameworkModule))]
    public class BTL_CNPMMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public BTL_CNPMMigratorModule(BTL_CNPMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(BTL_CNPMMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                BTL_CNPMConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(BTL_CNPMMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
