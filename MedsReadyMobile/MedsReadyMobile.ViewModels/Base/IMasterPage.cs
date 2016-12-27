using Xamarin.Forms;

namespace MedsReadyMobile.ViewModels.Base
{
    public interface IMasterPageCommon
    {
        void AppendChildren(params View[] children);
    }

    public interface IMasterPageBottomMenu : IMasterPageCommon { }
    public interface IMasterPageSetupWizard : IMasterPageCommon { }
}
