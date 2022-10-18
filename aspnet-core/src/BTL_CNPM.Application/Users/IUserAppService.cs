using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BTL_CNPM.Roles.Dto;
using BTL_CNPM.Users.Dto;

namespace BTL_CNPM.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
