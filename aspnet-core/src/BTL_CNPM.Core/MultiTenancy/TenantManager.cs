using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using BTL_CNPM.Authorization.Users;
using BTL_CNPM.Editions;

namespace BTL_CNPM.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
