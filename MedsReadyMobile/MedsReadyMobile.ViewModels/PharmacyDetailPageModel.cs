using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class PharmacyDetailPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public PharmacyDetailPageModel(ILogger logger) : base("Pharmacy Detail", logger)
        {
            MainText = "PharmacyDetailPageModel";
        }
    }
}
