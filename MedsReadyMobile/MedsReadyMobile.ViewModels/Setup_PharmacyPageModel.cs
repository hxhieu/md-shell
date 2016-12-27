using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class Setup_PharmacyPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public Setup_PharmacyPageModel(ILogger logger): base("MedsReady", logger)
        {
            MainText = "Setup_PharmacyPageModel";
        }
    }
}
