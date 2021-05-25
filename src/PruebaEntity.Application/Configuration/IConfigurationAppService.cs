using System.Threading.Tasks;
using PruebaEntity.Configuration.Dto;

namespace PruebaEntity.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
