using Abp.Application.Navigation;
using Abp.Localization;

namespace breederhub.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See Views/Layout/_TopMenu.cshtml file to know how to render menu.
    /// </summary>
    public class breederhubNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "Home",
                        new LocalizableString("HomePage", breederhubConsts.LocalizationSourceName),
                        url: "/",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "About",
                        new LocalizableString("About", breederhubConsts.LocalizationSourceName),
                        url: "/About",
                        icon: "fa fa-info"
                        )
                 ).AddItem(
                    new MenuItemDefinition(
                        "Sign up",
                        new LocalizableString("SignUp", breederhubConsts.LocalizationSourceName),
                        url: "/SignUp",
                        icon: "fa fa-info"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "Contact",
                        new LocalizableString("Contact", breederhubConsts.LocalizationSourceName),
                        url: "/Contact",
                        icon: "fa fa-info"
                        )
                );
        }
    }
}
