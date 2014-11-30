using Abp.Application.Services;

namespace breederhub
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class breederhubAppServiceBase : ApplicationService
    {
        protected breederhubAppServiceBase()
        {
            LocalizationSourceName = breederhubConsts.LocalizationSourceName;
        }
    }
}