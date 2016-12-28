using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;
using System.Windows.Input;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class PharmacyDetailPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public ICommand MoreDetails { get; set; }

        public PharmacyDetailPageModel(ILogger logger) : base("Pharmacy Detail", logger)
        {
            MainText = "PharmacyDetailPageModel";
            MoreDetails = new Command(async () =>
             {
                 await CoreMethods.PushPageModel<ScanHomePageModel>();
             });
        }
    }
}
