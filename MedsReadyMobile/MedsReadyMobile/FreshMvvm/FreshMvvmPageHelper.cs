using FreshMvvm;
using MedsReadyMobile.ViewModels;
using MedsReadyMobile.ViewModels.Navigation;
using System;

namespace MedsReadyMobile.FreshMvvm
{
    internal static class FreshMvvmPageHelper
    {
        internal class PageGenerationConfigurationException : Exception
        {
            public PageGenerationConfigurationException() : base("Tabs configuration must be set and the configuration count must match the number of tabs.") { }
        }

        internal class PageConfig
        {
            public string Title { get; set; }
            public string Icon { get; set; }
            public object InitData { get; set; }
        }

        private static IFreshNavigationService GenerateNavigationPage<T>(string name) where T : FreshBasePageModel
        {
            var page = FreshPageModelResolver.ResolvePageModel<T>();
            return new FreshNavigationContainer(page, name);
        }

        private static IFreshNavigationService GenerateTabbedPage<T1, T2>(PageConfig[] configs, string name)
            where T1 : FreshBasePageModel
            where T2 : FreshBasePageModel
        {
            if (configs == null || configs.Length < 2) throw new PageGenerationConfigurationException();

            var tabbed = new FreshTabbedNavigationContainer(name);

            tabbed.AddTab<T1>(configs[0].Title, configs[0].Icon, configs[0].InitData);
            tabbed.AddTab<T2>(configs[1].Title, configs[1].Icon, configs[1].InitData);

            return tabbed;
        }

        private static IFreshNavigationService GenerateTabbedPage<T1, T2, T3>(PageConfig[] configs, string name)
            where T1 : FreshBasePageModel
            where T2 : FreshBasePageModel
            where T3 : FreshBasePageModel
        {
            if (configs == null || configs.Length < 3) throw new PageGenerationConfigurationException();

            var tabbed = new FreshTabbedNavigationContainer(name);

            tabbed.AddTab<T1>(configs[0].Title, configs[0].Icon, configs[0].InitData);
            tabbed.AddTab<T2>(configs[1].Title, configs[1].Icon, configs[1].InitData);
            tabbed.AddTab<T3>(configs[2].Title, configs[2].Icon, configs[2].InitData);

            return tabbed;
        }

        public static IFreshNavigationService GeneratePrescriptionNavigation()
        {
            return GenerateTabbedPage<PrescriptionPendingPageModel, PrescriptionRecentPageModel>(
                new PageConfig[]
                {
                    new PageConfig
                    {
                        Title = "Pending"
                    },
                    new PageConfig
                    {
                        Title = "Recent"
                    }
                },
                NavigationServices.PrescriptionStack
            );
        }

        public static IFreshNavigationService GenerateScanNavigation()
        {
            return GenerateNavigationPage<ScanHomePageModel>(NavigationServices.ScanStack);
        }

        public static IFreshNavigationService GeneratePharmacyNavigation()
        {
            return GenerateNavigationPage<PharmacyHomePageModel>(NavigationServices.PharmacyStack);
        }

        public static IFreshNavigationService GenerateSetupWizardNavigation()
        {
            return GenerateNavigationPage<Setup_CountryPageModel>(NavigationServices.SetupWizardStack);
        }
    }
}
