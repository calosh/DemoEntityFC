using Abp.Application.Services;
using PruebaEntity.MultiTenancy.Dto;

namespace PruebaEntity.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

