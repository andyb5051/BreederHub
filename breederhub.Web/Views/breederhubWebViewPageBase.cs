using Abp.Web.Mvc.Views;

namespace breederhub.Web.Views
{
    public abstract class breederhubWebViewPageBase : breederhubWebViewPageBase<dynamic>
    {

    }

    public abstract class breederhubWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected breederhubWebViewPageBase()
        {
            LocalizationSourceName = breederhubConsts.LocalizationSourceName;
        }
    }
}