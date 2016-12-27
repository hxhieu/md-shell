using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class Setup_TermsConditionsPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public Setup_TermsConditionsPageModel(ILogger logger): base("MedsReady", logger)
        {
            MainText = "Setup_TermsConditionsPageModel";
        }
    }
}
