using Acr.UserDialogs;
using MedsReadyMobile.Services;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels.Navigation.Implementations
{
    public interface ISetupWizardNavigationModel : INavigationMenuModel<WizardMenuItem, WizardStep> { }

    [ImplementPropertyChanged]
    public class SetupWizardNavigationModel : NavigationMenuModelBase<WizardMenuItem, WizardStep>, ISetupWizardNavigationModel
    {
        public override List<WizardMenuItem> Items { get; protected set; }

        public SetupWizardNavigationModel(ILogger logger, IDialog dialogs) : base("Setup Steps", logger, dialogs)
        {
            var nextCommand = new Command(async () => await Next());
            var backCommand = new Command(async () => await Back());

            Items = new List<WizardMenuItem>
            {
                new WizardMenuItem
                {
                    Id = WizardStep.Country,
                    PrimaryCommand = nextCommand,
                    SecondaryCommand = backCommand
                },
                new WizardMenuItem
                {
                    Id = WizardStep.TermsAndConditions,
                    PrimaryCommand = nextCommand,
                    SecondaryCommand = backCommand
                },
                new WizardMenuItem
                {
                    Id = WizardStep.PIN,
                    PrimaryCommand = nextCommand,
                    SecondaryCommand =  backCommand
                },
                new WizardMenuItem
                {
                    Id = WizardStep.Pharmacy,
                    PrimaryCommand = nextCommand,
                    SecondaryCommand = backCommand
                }
            };

            //Start up item
            CurrentItem = Items[0];
        }

        public override async Task Back(bool animated = false)
        {
            var currentIndex = Items.FindIndex(i => i.Id == CurrentItem.Id);

            //Exit
            if (currentIndex == 0)
            {
                Dialogs.Confirm(new ConfirmConfig
                {
                    Message = "Exit the app?",
                    Title = "Confirm",
                    OnAction = (b) =>
                    {
                        //Ugly way for testing
                        if (b) throw new Exception("App exiting...");
                    }
                });
            }
            else
            {
                //Back
                if (currentIndex > 0) currentIndex--;
                CurrentItem = Items[currentIndex];

                await CoreMethods.PopPageModel(false, animated);
            }
        }

        public override async Task Next(bool animated = false)
        {
            var currentIndex = Items.FindIndex(i => i.Id == CurrentItem.Id);

            switch (CurrentItem.Id)
            {
                case WizardStep.Country:
                    await SaveCountrySetup();
                    await CoreMethods.PushPageModel<Setup_TermsConditionsPageModel>(animated);
                    break;
                case WizardStep.TermsAndConditions:
                    await SaveTermsAndConditionsSetup();
                    await CoreMethods.PushPageModel<Setup_PINPageModel>(animated);
                    break;
                case WizardStep.PIN:
                    await SavePINSetup();
                    await CoreMethods.PushPageModel<Setup_PharmacyPageModel>(animated);
                    break;
                case WizardStep.Pharmacy:
                    await SavePharmacySetup();
                    //Switch navigation to Prescription home
                    CoreMethods.SwitchOutRootNavigation(NavigationServices.PrescriptionStack);
                    break;
            }

            //Next
            if (currentIndex < Items.Count - 1) currentIndex++;
            CurrentItem = Items[currentIndex];
        }

        public override Task Goto(WizardStep item, bool animated = false)
        {
            throw new NotImplementedException("Cannot go to specific wizard step as it is unnatural to do so.");
        }

        private async Task SaveCountrySetup()
        {
            //TODO: Save setup here
            await Task.FromResult(0);
        }

        private async Task SaveTermsAndConditionsSetup()
        {
            //TODO: Save setup here
            await Task.FromResult(0);
        }

        private async Task SavePINSetup()
        {
            //TODO: Save setup here
            await Task.FromResult(0);
        }

        private async Task SavePharmacySetup()
        {
            //TODO: Save setup here
            await Task.FromResult(0);
        }
    }
}
