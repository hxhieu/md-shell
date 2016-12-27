using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class PharmacyHomePageModel : FormPageModelBase
    {
        public string MainText { get; set; }

        public PharmacyHomePageModel(ILogger logger, IDialog dialogs) : base("Pharmacy", logger, dialogs)
        {
            MainText = "PharmacyHomePageModel";
        }
    }
}
