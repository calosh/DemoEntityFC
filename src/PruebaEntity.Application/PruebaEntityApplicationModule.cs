using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaEntity.Authorization;

namespace PruebaEntity
{
    [DependsOn(
        typeof(PruebaEntityCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PruebaEntityApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PruebaEntityAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PruebaEntityApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
