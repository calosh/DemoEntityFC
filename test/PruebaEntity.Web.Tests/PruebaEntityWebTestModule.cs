using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PruebaEntity.EntityFrameworkCore;
using PruebaEntity.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PruebaEntity.Web.Tests
{
    [DependsOn(
        typeof(PruebaEntityWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PruebaEntityWebTestModule : AbpModule
    {
        public PruebaEntityWebTestModule(PruebaEntityEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PruebaEntityWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PruebaEntityWebMvcModule).Assembly);
        }
    }
}