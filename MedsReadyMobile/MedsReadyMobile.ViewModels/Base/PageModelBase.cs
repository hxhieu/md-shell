using FreshMvvm;
using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Navigation;
using MedsReadyMobile.ViewModels.Navigation.Implementations;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels.Base
{
    public class PageModelBase : FreshBasePageModel
    {
        protected ILogger Logger { get; private set; }

        public string PageTitle { get; set; }

        public PageModelBase(string title, ILogger logger)
        {
            Logger = logger;
            PageTitle = title;
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            IFreshIOC container = FreshIOC.Container;
            IMasterPageCommon page = null;

            //Check Setup master page
            page = CurrentPage as IMasterPageSetupWizard;
            if (page != null)
            {
                AppendNavigation(page, container.Resolve<IWizardNavigationMenu>(), container.Resolve<ISetupWizardNavigationModel>());
                return;
            }

            //Check Bottom nav main master page
            page = CurrentPage as IMasterPageBottomMenu;
            if (page != null)
            {
                AppendNavigation(page, container.Resolve<ITabNavigationMenu>(), container.Resolve<IMainBottomNavigationModel>());
                return;
            }
        }

        private void AppendNavigation(IMasterPageCommon page, INavigationMenu nav, INavigationMenuModelBase model)
        {
            model.SetCoreMethods(CoreMethods);
            nav.BindingContext = model;
            page.AppendChildren(nav as View);
        }
    }
}