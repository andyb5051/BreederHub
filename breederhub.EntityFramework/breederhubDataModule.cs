using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using breederhub.EntityFramework;

namespace breederhub
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(breederhubCoreModule))]
    public class breederhubDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<breederhubDbContext>(null);
        }
    }
}
