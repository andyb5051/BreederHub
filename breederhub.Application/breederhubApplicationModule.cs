using System.Reflection;
using Abp.Modules;

namespace breederhub
{
    [DependsOn(typeof(breederhubCoreModule))]
    public class breederhubApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
