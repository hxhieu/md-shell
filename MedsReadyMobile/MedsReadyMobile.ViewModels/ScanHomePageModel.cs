using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class ScanHomePageModel : PageModelBase
    {
        public string MainText { get; set; }

        public ScanHomePageModel(ILogger logger) : base("Scan", logger)
        {
            MainText = "ScanHomePageModel";
        }
    }
}
