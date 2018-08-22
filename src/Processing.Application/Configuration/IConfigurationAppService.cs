using System.Threading.Tasks;
using Processing.Configuration.Dto;

namespace Processing.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
