using FreshMvvm;
using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedsReadyMobile.ViewModels.Navigation
{
    public interface INavigationMenuModelBase
    {
        void SetCoreMethods(IPageModelCoreMethods coreMethods);
        int HeightRequest { get; set; }
    }

    public interface INavigationMenuModel<TItem, IIdentifier> : INavigationMenuModelBase
    {
        List<TItem> Items { get; }
        TItem CurrentItem { get; set; }
        Task Back(bool animated = false);
        Task Next(bool animated = false);
        Task Goto(IIdentifier item, bool animated = false);
    }

    public abstract class NavigationMenuModelBase<TItem, IIdentifier> : FormPageModelBase, INavigationMenuModel<TItem, IIdentifier>
    {
        public abstract List<TItem> Items { get; protected set; }
        public TItem CurrentItem { get; set; }

        public int HeightRequest { get; set; } = 45;

        public NavigationMenuModelBase(string name, ILogger logger, IDialog dialogs) : base(name, logger, dialogs) { }

        public void SetCoreMethods(IPageModelCoreMethods coreMethods)
        {
            CoreMethods = coreMethods;
        }

        public abstract Task Back(bool animated = false);

        public abstract Task Next(bool animated = false);

        public abstract Task Goto(IIdentifier item, bool animated = false);
    }
}
