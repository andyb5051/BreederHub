using Abp.Web.Mvc.Controllers;

namespace breederhub.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class breederhubControllerBase : AbpController
    {
        protected breederhubControllerBase()
        {
            LocalizationSourceName = breederhubConsts.LocalizationSourceName;
        }
    }
}