using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaEntity.Configuration;

namespace PruebaEntity.Web.Host.Startup
{
    [DependsOn(
       typeof(PruebaEntityWebCoreModule))]
    public class PruebaEntityWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PruebaEntityWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaEntityWebHostModule).GetAssembly());
        }
    }
}
