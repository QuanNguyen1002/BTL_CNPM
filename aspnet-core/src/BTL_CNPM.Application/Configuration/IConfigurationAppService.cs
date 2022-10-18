using System.Threading.Tasks;
using BTL_CNPM.Configuration.Dto;

namespace BTL_CNPM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
