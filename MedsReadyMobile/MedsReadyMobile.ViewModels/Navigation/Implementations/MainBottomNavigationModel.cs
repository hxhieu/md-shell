using MedsReadyMobile.Services;
using PropertyChanged;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels.Navigation.Implementations
{
    public interface IMainBottomNavigationModel : INavigationMenuModel<TabMenuItem, NavigationTab> { }

    [ImplementPropertyChanged]
    public class MainBottomNavigationModel : NavigationMenuModelBase<TabMenuItem, NavigationTab>, IMainBottomNavigationModel
    {
        public override List<TabMenuItem> Items { get; protected set; }

        public MainBottomNavigationModel(ILogger logger, IDialog dialogs) : base("Main Navigation", logger, dialogs)
        {
            Items = new List<TabMenuItem>
            {
                new TabMenuItem
                {
                    Id = NavigationTab.Scan,
                    PrimaryCommand = new Command(() =>
                    {
                        CurrentItem = Items.Single(i => i.Id == NavigationTab.Scan);
                        CoreMethods.SwitchOutRootNavigation(NavigationServices.ScanStack);
                    }),
                    Display = new MenuItemDisplay
                    {
                        Text = "Scan"
                    }
                },
                new TabMenuItem
                {
                    Id = NavigationTab.Presciption,
                    PrimaryCommand = new Command(() =>
                    {
                        CurrentItem = Items.Single(i => i.Id == NavigationTab.Presciption);
                        CoreMethods.SwitchOutRootNavigation(NavigationServices.PrescriptionStack);
                    }),
                    Display = new MenuItemDisplay
                    {
                        Text = "Presciption"
                    }
                },
                new TabMenuItem
                {
                    Id = NavigationTab.Pharmacy,
                    PrimaryCommand = new Command(() =>
                    {
                        CurrentItem = Items.Single(i => i.Id == NavigationTab.Pharmacy);
                        CoreMethods.SwitchOutRootNavigation(NavigationServices.PharmacyStack);
                    }),
                    Display = new MenuItemDisplay
                    {
                        Text = "Pharmacy"
                    }
                }
            };

            //Start up item
            CurrentItem = Items[1];
        }

        public override async Task Back(bool animated = false)
        {
            await Task.FromResult(0);
        }

        public override async Task Next(bool animated = false)
        {
            await Task.FromResult(0);
        }

        public override async Task Goto(NavigationTab item, bool animated = false)
        {
            await Task.FromResult(0);
        }
    }
}
