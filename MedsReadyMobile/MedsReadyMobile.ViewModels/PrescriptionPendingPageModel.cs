using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class PrescriptionPendingPageModel : PageModelBase
    {
        public string MainText { get; set; }

        public PrescriptionPendingPageModel(ILogger logger) : base("Prescriptions", logger)
        {
            MainText = "PrescriptionPendingPageModel";
        }
    }
}
