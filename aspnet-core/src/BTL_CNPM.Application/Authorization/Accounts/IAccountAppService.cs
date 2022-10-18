using System.Threading.Tasks;
using Abp.Application.Services;
using BTL_CNPM.Authorization.Accounts.Dto;

namespace BTL_CNPM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
