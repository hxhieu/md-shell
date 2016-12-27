namespace MedsReadyMobile.ViewModels.Navigation
{
    public interface INavigationMenu
    {
        object BindingContext { get; set; }
    }

    public interface ITabNavigationMenu : INavigationMenu { }
    public interface IWizardNavigationMenu : INavigationMenu { }
}
