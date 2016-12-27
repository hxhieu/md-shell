using FreshMvvm;
using MedsReadyMobile.ViewModels.Base;
using MedsReadyMobile.ViewModels.Navigation.Implementations;

namespace MedsReadyMobile.MasterPages
{
    public abstract partial class MasterPageSetupWizard : MasterPageBase, IMasterPageSetupWizard
    {
        public MasterPageSetupWizard()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            FreshIOC.Container.Resolve<ISetupWizardNavigationModel>().Back();

            //TODO: Need to handle navigation bar back button, which will need custom renderer

            return true;
        }
    }
}