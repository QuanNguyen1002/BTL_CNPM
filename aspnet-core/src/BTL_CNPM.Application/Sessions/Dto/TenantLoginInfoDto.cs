using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BTL_CNPM.MultiTenancy;

namespace BTL_CNPM.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
