using MedsReadyMobile.Services;

namespace MedsReadyMobile.ViewModels.Base
{
    public abstract class FormPageModelBase : PageModelBase
    {
        protected IDialog Dialogs { get; private set; }

        public FormPageModelBase(string title, ILogger logger, IDialog dialogs) : base(title, logger)
        {
            Dialogs = dialogs;
        }
    }
}
