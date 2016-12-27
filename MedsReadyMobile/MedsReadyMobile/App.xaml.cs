using MedsReadyMobile.FreshMvvm;
using MedsReadyMobile.ViewModels;
using Xamarin.Forms;

namespace MedsReadyMobile
{
    public partial class App : Application
    {
        public App()
        {
            FreshMvvmStartup.Register();

            InitializeComponent();

            //MainPage = FreshMvvmPageHelper.GenerateSetupWizardNavigation() as Page;
            MainPage = FreshMvvmPageHelper.GeneratePrescriptionNavigation() as Page;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
