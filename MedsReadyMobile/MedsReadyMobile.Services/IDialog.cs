using System;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Splat;

namespace MedsReadyMobile.Services
{
    /// <summary>
    /// Use this interface to decouple 3rd party UserDialogs
    /// </summary>
    public interface IDialog
    {
        IDisposable ActionSheet(ActionSheetConfig config);
        Task<string> ActionSheetAsync(string title, string cancel, string destructive, CancellationToken? cancelToken = default(CancellationToken?), params string[] buttons);
        IDisposable Alert(AlertConfig config);
        IDisposable Alert(string message, string title = null, string okText = null);
        Task AlertAsync(AlertConfig config, CancellationToken? cancelToken = default(CancellationToken?));
        Task AlertAsync(string message, string title = null, string okText = null, CancellationToken? cancelToken = default(CancellationToken?));
        IDisposable Confirm(ConfirmConfig config);
        Task<bool> ConfirmAsync(ConfirmConfig config, CancellationToken? cancelToken = default(CancellationToken?));
        Task<bool> ConfirmAsync(string message, string title = null, string okText = null, string cancelText = null, CancellationToken? cancelToken = default(CancellationToken?));
        IDisposable DatePrompt(DatePromptConfig config);
        Task<DatePromptResult> DatePromptAsync(DatePromptConfig config, CancellationToken? cancelToken = default(CancellationToken?));
        Task<DatePromptResult> DatePromptAsync(string title = null, DateTime? selectedDate = default(DateTime?), CancellationToken? cancelToken = default(CancellationToken?));
        void HideLoading();
        IProgressDialog Loading(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = default(MaskType?));
        IDisposable Login(LoginConfig config);
        Task<LoginResult> LoginAsync(LoginConfig config, CancellationToken? cancelToken = default(CancellationToken?));
        Task<LoginResult> LoginAsync(string title = null, string message = null, CancellationToken? cancelToken = default(CancellationToken?));
        IProgressDialog Progress(ProgressDialogConfig config);
        IProgressDialog Progress(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = default(MaskType?));
        IDisposable Prompt(PromptConfig config);
        Task<PromptResult> PromptAsync(PromptConfig config, CancellationToken? cancelToken = default(CancellationToken?));
        Task<PromptResult> PromptAsync(string message, string title = null, string okText = null, string cancelText = null, string placeholder = "", InputType inputType = InputType.Default, CancellationToken? cancelToken = default(CancellationToken?));
        void ShowError(string message, int timeoutMillis = 2000);
        void ShowImage(IBitmap image, string message, int timeoutMillis = 2000);
        void ShowLoading(string title = null, MaskType? maskType = default(MaskType?));
        void ShowSuccess(string message, int timeoutMillis = 2000);
        IDisposable TimePrompt(TimePromptConfig config);
        Task<TimePromptResult> TimePromptAsync(TimePromptConfig config, CancellationToken? cancelToken = default(CancellationToken?));
        Task<TimePromptResult> TimePromptAsync(string title = null, TimeSpan? selectedTime = default(TimeSpan?), CancellationToken? cancelToken = default(CancellationToken?));
        IDisposable Toast(ToastConfig cfg);
        IDisposable Toast(string title, TimeSpan? dismissTimer = default(TimeSpan?));
    }

    public class UserDialogsDialog : IDialog
    {
        private IUserDialogs Dialog
        {
            get { return UserDialogs.Instance; }
        }
        public IDisposable ActionSheet(ActionSheetConfig config)
        {
            throw new NotImplementedException();
        }

        public Task<string> ActionSheetAsync(string title, string cancel, string destructive, CancellationToken? cancelToken = default(CancellationToken?), params string[] buttons)
        {
            throw new NotImplementedException();
        }

        public IDisposable Alert(AlertConfig config)
        {
            return Dialog.Alert(config);
        }

        public IDisposable Alert(string message, string title = null, string okText = null)
        {
            return Dialog.Alert(message, title, okText);
        }

        public Task AlertAsync(AlertConfig config, CancellationToken? cancelToken = default(CancellationToken?))
        {
            return Dialog.AlertAsync(config, cancelToken);
        }

        public Task AlertAsync(string message, string title = null, string okText = null, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public IDisposable Confirm(ConfirmConfig config)
        {
            return Dialog.Confirm(config);
        }

        public Task<bool> ConfirmAsync(ConfirmConfig config, CancellationToken? cancelToken = default(CancellationToken?))
        {
            return Dialog.ConfirmAsync(config, cancelToken);
        }

        public Task<bool> ConfirmAsync(string message, string title = null, string okText = null, string cancelText = null, CancellationToken? cancelToken = default(CancellationToken?))
        {
            return Dialog.ConfirmAsync(message, title, okText, cancelText, cancelToken);
        }

        public IDisposable DatePrompt(DatePromptConfig config)
        {
            throw new NotImplementedException();
        }

        public Task<DatePromptResult> DatePromptAsync(DatePromptConfig config, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public Task<DatePromptResult> DatePromptAsync(string title = null, DateTime? selectedDate = default(DateTime?), CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public void HideLoading()
        {
            throw new NotImplementedException();
        }

        public IProgressDialog Loading(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = default(MaskType?))
        {
            throw new NotImplementedException();
        }

        public IDisposable Login(LoginConfig config)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResult> LoginAsync(LoginConfig config, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public Task<LoginResult> LoginAsync(string title = null, string message = null, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public IProgressDialog Progress(ProgressDialogConfig config)
        {
            throw new NotImplementedException();
        }

        public IProgressDialog Progress(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = default(MaskType?))
        {
            throw new NotImplementedException();
        }

        public IDisposable Prompt(PromptConfig config)
        {
            throw new NotImplementedException();
        }

        public Task<PromptResult> PromptAsync(PromptConfig config, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public Task<PromptResult> PromptAsync(string message, string title = null, string okText = null, string cancelText = null, string placeholder = "", InputType inputType = InputType.Default, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public void ShowError(string message, int timeoutMillis = 2000)
        {
            throw new NotImplementedException();
        }

        public void ShowImage(IBitmap image, string message, int timeoutMillis = 2000)
        {
            throw new NotImplementedException();
        }

        public void ShowLoading(string title = null, MaskType? maskType = default(MaskType?))
        {
            throw new NotImplementedException();
        }

        public void ShowSuccess(string message, int timeoutMillis = 2000)
        {
            throw new NotImplementedException();
        }

        public IDisposable TimePrompt(TimePromptConfig config)
        {
            throw new NotImplementedException();
        }

        public Task<TimePromptResult> TimePromptAsync(TimePromptConfig config, CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public Task<TimePromptResult> TimePromptAsync(string title = null, TimeSpan? selectedTime = default(TimeSpan?), CancellationToken? cancelToken = default(CancellationToken?))
        {
            throw new NotImplementedException();
        }

        public IDisposable Toast(ToastConfig cfg)
        {
            throw new NotImplementedException();
        }

        public IDisposable Toast(string title, TimeSpan? dismissTimer = default(TimeSpan?))
        {
            throw new NotImplementedException();
        }
    }
}
