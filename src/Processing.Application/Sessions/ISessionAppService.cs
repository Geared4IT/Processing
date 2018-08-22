using System.Threading.Tasks;
using Abp.Application.Services;
using Processing.Sessions.Dto;

namespace Processing.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
