using System.Threading.Tasks;
using PruebaEntity.Models.TokenAuth;
using PruebaEntity.Web.Controllers;
using Shouldly;
using Xunit;

namespace PruebaEntity.Web.Tests.Controllers
{
    public class HomeController_Tests: PruebaEntityWebTestBase
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