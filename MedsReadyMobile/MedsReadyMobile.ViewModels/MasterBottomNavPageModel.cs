using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels
{
    public class MasterBottomNavPageModel : PageModelBase
    {
        public enum NavigationPage
        {
            Presciption = 0,
            Scan = 1,
            Pharmacy = 2
        }

        public ICommand GotoScan { get; set; }
        public ICommand GotoPresciption { get; set; }
        public ICommand GotoPharmacy { get; set; }

        public NavigationPage CurrentNavPage { get; set; }

        public MasterBottomNavPageModel(ILogger logger) : base(logger)
        {
            GotoScan = new Command(async () => await Goto(NavigationPage.Scan));
            GotoPresciption = new Command(async () => await Goto(NavigationPage.Presciption));
            GotoPharmacy = new Command(async () => await Goto(NavigationPage.Pharmacy));
        }

        private async Task Goto(NavigationPage page)
        {
            if (page == CurrentNavPage) await Task.FromResult(0);

            switch (page)
            {
                case NavigationPage.Scan:
                    await Logger.Info("SCAN");
                    break;
                case NavigationPage.Presciption:
                    await Logger.Info("PRESCRIPTION");
                    break;
                case NavigationPage.Pharmacy:
                    await Logger.Info("PHARMACY");
                    break;
            }
        }
    }
}
