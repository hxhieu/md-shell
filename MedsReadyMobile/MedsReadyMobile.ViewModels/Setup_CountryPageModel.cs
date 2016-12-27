using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class Setup_CountryPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public Setup_CountryPageModel(ILogger logger): base("MedsReady", logger)
        {
            MainText = "Setup_CountryPageModel";
        }
    }
}
