using MedsReadyMobile.Services;
using MedsReadyMobile.ViewModels.Base;
using PropertyChanged;
using System.Windows.Input;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels
{
    [ImplementPropertyChanged]
    public class PharmacyHomePageModel : FormPageModelBase
    {
        public string MainText { get; set; }

        public ICommand GotoDetails { get; set; }

        public PharmacyHomePageModel(ILogger logger, IDialog dialogs) : base("Pharmacy", logger, dialogs)
        {
            MainText = "PharmacyHomePageModel";
            GotoDetails = new Command(async () =>
            {
                await CoreMethods.PushPageModel<PharmacyDetailPageModel>();
            });
        }
    }
}
