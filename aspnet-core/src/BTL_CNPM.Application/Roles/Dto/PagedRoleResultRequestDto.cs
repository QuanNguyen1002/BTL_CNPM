using Abp.Application.Services.Dto;

namespace BTL_CNPM.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

