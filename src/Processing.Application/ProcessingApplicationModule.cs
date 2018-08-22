using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Processing.Authorization;

namespace Processing
{
    [DependsOn(
        typeof(ProcessingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ProcessingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ProcessingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ProcessingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
