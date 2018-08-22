using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Processing.MultiTenancy.Dto;

namespace Processing.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
