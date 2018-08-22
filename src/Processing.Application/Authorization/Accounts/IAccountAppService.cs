using System.Threading.Tasks;
using Abp.Application.Services;
using Processing.Authorization.Accounts.Dto;

namespace Processing.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
