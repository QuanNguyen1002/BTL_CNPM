using Abp.AutoMapper;
using BTL_CNPM.Authentication.External;

namespace BTL_CNPM.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
