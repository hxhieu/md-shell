using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class PrescriptionRecentPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public PrescriptionRecentPageModel(ILogger logger) : base("Prescriptions", logger)
        {
            MainText = "PrescriptionRecentPageModel";
        }
    }
}
