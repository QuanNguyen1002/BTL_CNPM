using Abp.Application.Services;
using BTL_CNPM.MultiTenancy.Dto;

namespace BTL_CNPM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

