using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Processing.Roles.Dto;
using Processing.Users.Dto;

namespace Processing.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
