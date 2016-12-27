using PropertyChanged;
using System.Windows.Input;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels.Navigation
{
    public enum MenuItemState
    {
        Normal,
        Active,
        Hover,
        Disabled
    }

    public interface INavigationMenuItemModel<TIdentifier>
    {
        TIdentifier Id { get; set; }
        ICommand PrimaryCommand { get; set; }
        ICommand SecondaryCommand { get; set; }
        MenuItemDisplay Display { get; set; }
    }

    [ImplementPropertyChanged]
    public class MenuItemDisplay
    {
        public MenuItemState State { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public Style Style { get; set; }
    }

    public abstract class NavigationMenuItemModelBase<TIdentifier> : INavigationMenuItemModel<TIdentifier>
    {
        public TIdentifier Id { get; set; }
        public ICommand PrimaryCommand { get; set; }
        public ICommand SecondaryCommand { get; set; }

        public MenuItemDisplay Display { get; set; }
    }

    [ImplementPropertyChanged]
    public class WizardMenuItem : NavigationMenuItemModelBase<WizardStep> { }

    [ImplementPropertyChanged]
    public class TabMenuItem : NavigationMenuItemModelBase<NavigationTab> { }
}
