using Blazored.Toast.Services;

namespace ToastMessage.Helper
{
    public class ToastHelper
    {
        private readonly IToastService _toastService;
        public ToastHelper(IToastService toastService) 
        {
            _toastService = toastService;
        }
        public void SuccessToast(string message)
        {
            _toastService.ShowSuccess(message);
        }
        public void ErrorToast(string message)
        {
            _toastService.ShowError(message);
        }
    }
}
