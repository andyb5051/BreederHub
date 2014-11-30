using System.Reflection;
using Abp.Modules;

namespace breederhub
{
    public class breederhubCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
