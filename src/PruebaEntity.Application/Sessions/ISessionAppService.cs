using System.Threading.Tasks;
using Abp.Application.Services;
using PruebaEntity.Sessions.Dto;

namespace PruebaEntity.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
