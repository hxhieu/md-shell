using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class Setup_PINPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public Setup_PINPageModel(ILogger logger): base("MedsReady", logger)
        {
            MainText = "Setup_PINPageModel";
        }
    }
}

