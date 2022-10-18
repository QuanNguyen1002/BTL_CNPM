using System.Threading.Tasks;
using BTL_CNPM.Models.TokenAuth;
using BTL_CNPM.Web.Controllers;
using Shouldly;
using Xunit;

namespace BTL_CNPM.Web.Tests.Controllers
{
    public class HomeController_Tests: BTL_CNPMWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}