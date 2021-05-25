using System.Threading.Tasks;
using Abp.Application.Services;
using PruebaEntity.Authorization.Accounts.Dto;

namespace PruebaEntity.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
