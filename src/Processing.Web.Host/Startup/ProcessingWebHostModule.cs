using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Processing.Configuration;

namespace Processing.Web.Host.Startup
{
    [DependsOn(
       typeof(ProcessingWebCoreModule))]
    public class ProcessingWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ProcessingWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProcessingWebHostModule).GetAssembly());
        }
    }
}
