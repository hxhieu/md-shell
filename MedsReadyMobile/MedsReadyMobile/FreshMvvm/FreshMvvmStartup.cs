using FreshMvvm;
using MedsReadyMobile.Data.Common;
using MedsReadyMobile.Data.Realm;
using MedsReadyMobile.Data.Realm.RealmObjects;
using MedsReadyMobile.Services;
using MedsReadyMobile.Services.Loggers;
using MedsReadyMobile.UserControls;
using MedsReadyMobile.ViewModels.Navigation;
using MedsReadyMobile.ViewModels.Navigation.Implementations;
using System.Reflection;

namespace MedsReadyMobile.FreshMvvm
{
    internal static class FreshMvvmStartup
    {
        private static readonly IFreshIOC _container = FreshIOC.Container;
        public static void Register()
        {
            //Custom mapper so we can resolve view models from different assembly
            FreshPageModelResolver.PageModelMapper = new CrossAssembliesModelMapper(typeof(App).GetTypeInfo().Assembly);

            RegisterDependencies();
            RegisterLogger();
            RegisterNavigationStacks();
        }

        public static void RegisterDependencies()
        {
            //Views registration, they should be transiences
            _container.Register<ITabNavigationMenu, TabNavigationMenu>().AsMultiInstance();
            _container.Register<IWizardNavigationMenu, WizardNavigationMenu>().AsMultiInstance();

            //Services registrations, they should be singletons
            _container.Register<ILog>(new ConsoleLog(), "console");
            _container.Register<ILogger, Logger>();
            _container.Register<IDialog, UserDialogsDialog>();

            //Data registrations, they should be singletons
            _container.Register<IRepository<DeviceSetting>, DeviceSettingRepository>();

            //Navigation models, they should be singletons
            _container.Register<ISetupWizardNavigationModel, SetupWizardNavigationModel>();
            _container.Register<IMainBottomNavigationModel, MainBottomNavigationModel>();
        }

        private static void RegisterLogger()
        {
            var logger = _container.Resolve<ILogger>();
            logger.AddLogMedium(_container.Resolve<ILog>("console"));
        }

        private static void RegisterNavigationStacks()
        {
            _container.Register(FreshMvvmPageHelper.GenerateSetupWizardNavigation());
            _container.Register(FreshMvvmPageHelper.GeneratePrescriptionNavigation());
            _container.Register(FreshMvvmPageHelper.GenerateScanNavigation());
            _container.Register(FreshMvvmPageHelper.GeneratePharmacyNavigation());
        }
    }
}
