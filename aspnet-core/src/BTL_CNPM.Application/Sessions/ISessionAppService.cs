using System.Threading.Tasks;
using Abp.Application.Services;
using BTL_CNPM.Sessions.Dto;

namespace BTL_CNPM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
