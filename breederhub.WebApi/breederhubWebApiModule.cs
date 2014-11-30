using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace breederhub
{
    [DependsOn(typeof(AbpWebApiModule), typeof(breederhubApplicationModule))]
    public class breederhubWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(breederhubApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
